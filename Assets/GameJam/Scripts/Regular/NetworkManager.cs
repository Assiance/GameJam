using System.Collections;
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
        private HostData[] hostList;

        public void GetHostListAndConnect()
        {
            hostList = new HostData[1];
            MasterServer.RequestHostList(typeName);

            StartCoroutine(Connect());
        }

        public IEnumerator Connect()
        {
            yield return new WaitForSeconds(2f);
            Network.Connect(hostList[0]);
        }

        private void OnMasterServerEvent(MasterServerEvent msEvent)
        {
            if (msEvent == MasterServerEvent.HostListReceived)
                hostList = MasterServer.PollHostList();
        }

        public void JoinServer()
        {
            GetHostListAndConnect();
        }

        public void Host()
        {
            if (!Network.isClient && !Network.isServer)
            {
                Network.InitializeServer(4, 25005, true);
                MasterServer.RegisterHost(typeName, gameName);
            }
        }


        //private void OnConnectedToServer()
        //    {
        //        Debug.Log("Connected to server");
        //        if (Network.connections.Length == 1)
        //        {
        //            NetworkLevelLoader.Instance.LoadLevel("CharacterScene");
        //        }
        //        // this is the NetworkLevelLoader we wrote earlier in the chapter – pauses the network, loads the level, waits for the level to finish, and then unpauses the network 
        //        //NetworkLevelLoader.Instance.LoadLevel("Game");
        //    }

        //    private void OnServerInitialized()
        //    {
        //        Debug.Log("Server initialized");
        //        if (Network.connections.Length == 1)
        //        {
        //            NetworkLevelLoader.Instance.LoadLevel("CharacterScene");
        //        }
        //        //NetworkLevelLoader.Instance.LoadLevel("Game");
        //    }
        
    }
}
