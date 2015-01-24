using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.General;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular
{
    public class ConnectToGame : MyMonoBehaviour
    {
        private string ip = "172.16.27.25";
        private int port = 25005;

        private void OnGUI()
        {
// let the user enter IP address
            GUILayout.Label("IP Address");
            ip = GUILayout.TextField(ip, GUILayout.Width(200f));
// let the user enter port number
// port is an integer, so only numbers are allowed
            GUILayout.Label("Port");
            string port_str = GUILayout.TextField(port.ToString(),
                GUILayout.Width(100f));
            int port_num = port;
            if (int.TryParse(port_str, out port_num))
                port = port_num;
            // connect to the IP and port
            if (GUILayout.Button("Connect", GUILayout.Width(100f)))
            {
                Network.Connect(ip, port);
            }
            // host a server on the given port, only allow 1 incomingconnection(one other player)
            if (GUILayout.Button("Host", GUILayout.Width(100f)))
            {
                Network.InitializeServer(1, port, true);
            }
        }

        private void OnConnectedToServer()
        {
            Debug.Log("Connected to server");
            // this is the NetworkLevelLoader we wrote earlier in the chapter – pauses the network, loads the level, waits for the level to finish, and then unpauses the network 
            //NetworkLevelLoader.Instance.LoadLevel("Game");
        }

        private void OnServerInitialized()
        {
            Debug.Log("Server initialized");
            //NetworkLevelLoader.Instance.LoadLevel("Game");
        }
    }
}
