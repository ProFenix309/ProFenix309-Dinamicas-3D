using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RegisterHandle : MonoBehaviour
{
    private GameManager_UI gameManager;

    [SerializeField] TMP_InputField nameInputField;
    [SerializeField] TMP_InputField passwordInputField;
    [SerializeField] TMP_InputField emailInputField;

    public string nameUser;
    public string passwordUser;
    public string emailUser;

    private void Awake()
    {
        gameManager = FindFirstObjectByType<GameManager_UI>();
    }

    public void SaveUserData()
    {
        nameUser = nameInputField.text;
        passwordUser = passwordInputField.text;
        emailUser = emailInputField.text;

        gameManager.NameUser = nameUser;
        gameManager.PassUser = passwordUser;
        gameManager.EmailUser = emailUser;
    }
}
