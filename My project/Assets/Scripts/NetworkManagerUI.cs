using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkManagerUI : NetworkBehaviour
{
    [SerializeField] private Button ServerBtn;
    [SerializeField] private Button HostBtn;
    [SerializeField] private Button ClientBtn;

    private void Awake()
    {
        if(!IsOwner)
        {
            return;
        }
        else
        {
            ServerBtn.onClick.AddListener(() =>
            {
                Debug.Log("Pressed");
                NetworkManager.Singleton.StartServer();
            });
        }

        if (!IsOwner)
        {
            return;
        }
        else
        {
            ServerBtn.onClick.AddListener(() =>
            {
                Debug.Log("Pressed");
                NetworkManager.Singleton.StartServer();
            });
        }
        if (!IsOwner)
        {
            ClientBtn.onClick.AddListener(() =>
            {
                Debug.Log("Pressed");
                NetworkManager.Singleton.StartClient();
            });
        }
      
       
        
    }
}
