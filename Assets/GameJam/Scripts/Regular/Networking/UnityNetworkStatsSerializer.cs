using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular.Networking
{
    public class UnityNetworkStatsSerializer: MyMonoBehaviour
    {
        public PlayerStatus playerstats;

        void Start()
        {
            playerstats = GetComponent<PlayerStatus>();
        }

        public void onSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
        {
            //we are currently writing information to the network
            if(stream.isWriting)
            {
                //send player stats
                stream.Serialize(ref playerstats.Morale);
                stream.Serialize(ref playerstats.Population);
                stream.Serialize(ref playerstats.Resources);


            }
            //we are reading information from network
            else
            {
                stream.Serialize(ref playerstats.Morale);
                stream.Serialize(ref playerstats.Population);
                stream.Serialize(ref playerstats.Resources);
                //read the player stats

            }

          
        }
    }
}
