using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular.General
{
    public abstract class MyMonoBehaviour : MonoBehaviour
    {
        private Transform _cachedTransform;

        protected Transform CachedTransform
        {
            get
            {
                if (_cachedTransform == null)
                    _cachedTransform = GetComponent<Transform>();

                return _cachedTransform;
            }
        }
    }
}
