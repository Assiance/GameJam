using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.General;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular
{
    public class Move : MyMonoBehaviour
    {
        private float lastSynchronizationTime = 0f;
        private float syncDelay = 0f;
        private float syncTime = 0f;
        private Vector3 syncStartPosition;
        private Vector3 syncEndPosition;

        void Start()
        {
            syncStartPosition = new Vector3();
            syncEndPosition = new Vector3();
        }

        void Update()
        {
            if (networkView.isMine)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    transform.position = new Vector3(-0.2f, 0, 0);
                }
            }
            else
            {
                syncTime += Time.deltaTime;
                transform.position = Vector3.Lerp(syncStartPosition, syncEndPosition, syncTime/syncDelay);
            }
        }

        void OnSerializeNetworkView(BitStream stream)
        {
            Vector3 syncPosition = Vector3.zero;
            if (stream.isWriting)
            {
                syncPosition = transform.position;
                stream.Serialize(ref syncPosition);
            }
            else
            {
                stream.Serialize(ref syncPosition);

                syncTime = 0f;
                syncDelay = Time.time - lastSynchronizationTime;
                lastSynchronizationTime = Time.time;

                syncStartPosition = transform.position;
                syncEndPosition = syncPosition;
            }
        }
    }
}
