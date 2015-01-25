using UnityEngine;
using System.Collections;
using Assets.GameJam.Scripts.Regular.General;

public class NetworkingMasterServer : MyMonoBehaviour
{
    // Assuming Master Server and Facilitator are on the samemachine
    public string MasterServerIP = "169.254.110.43";
    void Awake()
    {
        // set the IP and port of the Master Server to connect to
        MasterServer.ipAddress = MasterServerIP;
        MasterServer.port = 23466;
        // set the IP and port of the Facilitator to connect to
        Network.natFacilitatorIP = MasterServerIP;
        Network.natFacilitatorPort = 50005;
    }
}

