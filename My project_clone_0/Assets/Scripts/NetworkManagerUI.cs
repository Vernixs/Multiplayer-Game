using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using TMPro;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button ServerBtn;
    [SerializeField] private Button HostBtn;
    [SerializeField] private Button ClientBtn;
    [SerializeField] private TextMeshProUGUI playersInGameText;

    private void Awake()
    {
        Cursor.visible = true;
        
    }

    private void Update()
    {
       
    }

    private void Start()
    {
        HostBtn.onClick.AddListener(() =>
            {
                if(NetworkManager.Singleton.StartHost())
                {
                    
                }
                else
                {

                }
            });
        ServerBtn.onClick.AddListener(() =>
        {
            if (NetworkManager.Singleton.StartServer())
            {

            }
            else
            {

            }
        });
        ClientBtn.onClick.AddListener(() =>
        {
            if (NetworkManager.Singleton.StartClient())
            {

            }
            else
            {

            }
        });
    }
}
