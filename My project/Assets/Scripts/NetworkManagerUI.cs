using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button ServerBtn;
    [SerializeField] private Button HostBtn;
    [SerializeField] private Button ClientBtn;

    private void Awake()
    {
        ServerBtn.onClick.AddListener(() =>
        {
            Debug.Log("Pressed");
            NetworkManager.Singleton.StartServer();
        });
        HostBtn.onClick.AddListener(() =>
        {
            Debug.Log("Pressed");
            NetworkManager.Singleton.StartHost();
        });
        ClientBtn.onClick.AddListener(() =>
        {
            Debug.Log("Pressed");
            NetworkManager.Singleton.StartClient();
        });
    }
}
