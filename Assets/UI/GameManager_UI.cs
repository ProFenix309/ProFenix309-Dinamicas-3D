using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager_UI : MonoBehaviour
{
    [SerializeField] GameObject mainManuPanel;
    [SerializeField] GameObject resgisterPanel;
    [SerializeField] GameObject messagePanel;

    [SerializeField] TextMeshProUGUI messagetext;

    private string _nameUser;
    private string _passUser;
    private string _emailUser;

    public string NameUser { get => _nameUser; set => _nameUser = value; }
    public string PassUser { get => _passUser; set => _passUser = value; }
    public string EmailUser { get => _emailUser; set => _emailUser = value; }

    private void Start()
    {
        MainMenu();
    }

    public void MainMenu()
    {
        mainManuPanel.SetActive(true);
        resgisterPanel.SetActive(false);
        messagePanel.SetActive(false);
    }
    public void Resgister()
    {
        mainManuPanel.SetActive(false);
        resgisterPanel.SetActive(true);
        messagePanel.SetActive(false);
    }
    public void Message()
    {
        if (NameUser != "" && PassUser != "" && EmailUser != "")
        {
            mainManuPanel.SetActive(false);
            resgisterPanel.SetActive(false);
            messagePanel.SetActive(true);

            messagetext.text = "Hola " + NameUser + " Te has resgistrado con el correo " + EmailUser;
        }


    }

}
