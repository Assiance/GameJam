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
            // launch the server
            public void LaunchServer()
            {
                // Start a server that enables NAT punchthrough,
                // listens on port 25005,
                // and allows 8 clients to connect
                if (!Network.isClient && !Network.isServer)
                {
                    Network.InitializeServer(4, 25005, true);
                    MasterServer.RegisterHost(typeName, gameName);
                }
            }
            // called when the server has been initialized
            void OnServerInitialized()
            {
                Debug.Log("Server initialized");
            }
        
    }
}
