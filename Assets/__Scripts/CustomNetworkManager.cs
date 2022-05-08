using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;


public class CustomNetworkManager : NetworkManager
{
    public override void OnStartServer()
    {
        Debug.Log($"Server started..");
    }

    public override void OnStopServer()
    {
        Debug.Log($"Server stopped..");
    }

    public override void OnClientConnect()
    {
        Debug.Log($"[Player {NetworkClient.connection.connectionId}] connected to server..");
    }

    public override void OnClientDisconnect()
    {
        Debug.Log($"[Player {NetworkClient.connection.connectionId}] disconnected from the server..");
    }
}