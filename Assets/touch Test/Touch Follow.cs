using UnityEngine;
using UnityEngine.InputSystem;

public class TouchFollow : MonoBehaviour
{
    [SerializeField] Transform obj;
    [SerializeField] Camera mainCamera;
    private Vector3 currenPosition;

    private void Start()
    {
        mainCamera = Camera.main;
        currenPosition = obj.position;
    }

    private void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed)
        {
            if (obj.position != currenPosition)
            {
                obj.position = currenPosition;
            }
            return;
        }

        Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();

        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(touchPosition);

        worldPosition.z = 0f;

        obj.position = worldPosition;

    }

}
