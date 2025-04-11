using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControladorTactil : MonoBehaviour
{

    private TouchHandle touchHandle;
    private Camera cam;

    private void Awake()
    {
        cam = Camera.main;
        touchHandle = new TouchHandle();
        touchHandle.Tactil.Toque.started += context => StartTouch(context);
        touchHandle.Tactil.Toque.canceled += context => TouchEnd(context);
    }

    private void OnEnable()
    {
        touchHandle.Enable();
    }
    private void OnDisable()
    {
        touchHandle.Disable();
    }


    void StartTouch(InputAction.CallbackContext context)
    {
        StartCoroutine(EsperarElPrimerToque(context));
    }

    public IEnumerator EsperarElPrimerToque(InputAction.CallbackContext context)
    {
        yield return new WaitForEndOfFrame();
        Vector2 touchPosition = touchHandle.Tactil.TapPosition.ReadValue<Vector2>();

        if (touchPosition == new Vector2(0,0))
        {
            yield return null;
        }

        Vector3 worldPosition = cam.ScreenToWorldPoint(touchPosition);

        worldPosition.z = 0f;

        Debug.Log("Posicion al Iniciar = " + worldPosition);
        Debug.Log("Tiempo al Iniciar = " + context.time);

        
    }

    void TouchEnd(InputAction.CallbackContext context)
    {

        Vector2 touchPosition = touchHandle.Tactil.TapPosition.ReadValue<Vector2>();

        Vector3 worldPosition = cam.ScreenToWorldPoint(touchPosition);

        worldPosition.z = 0f;

        Debug.Log("Posicion al terminer = " + worldPosition);
        Debug.Log("Tiempo al terminer = " + context.time);

        
    }
}
