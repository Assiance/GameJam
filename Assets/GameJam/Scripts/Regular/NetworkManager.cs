using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.GameJam.Scripts.Regular
{

    public class NetworkManager : MyMonoBehaviour
    {
            private const string typeName = "UniqueGameName";
            private const string gameName = "RoomName";
            private string ip = "169.254.110.43";
            private int port = 50005;
            private HostData[] hostList;

            void Awake()
            {
                hostList = new HostData[1];
                MasterServer.RequestHostList("UniqueGameName");
            }

            void OnMasterServerEvent(MasterServerEvent msEvent)
            {
                if (msEvent == MasterServerEvent.HostListReceived)
                    hostList = MasterServer.PollHostList();
            }

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
                    Network.Connect(hostList[0]);
                }
   
                if (GUILayout.Button("Host", GUILayout.Width(100f)))
                {
                    if (!Network.isClient && !Network.isServer)
                    {
                        Network.InitializeServer(4, 25005, true);
                        MasterServer.RegisterHost(typeName, gameName);
                    }
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
