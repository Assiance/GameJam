using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular.General;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular
{
    public class Character : MyMonoBehaviour
    {
        public bool IsSelected;
        private SpriteRenderer characterSprite;
        private Vector3 _newPosition;

        void Start()
        {
            characterSprite = gameObject.GetComponent<SpriteRenderer>();
        }

        void FixedUpdate()
        {
            if (IsSelected)
            {
                characterSprite.color = Color.grey;
            }
        }

        void Update()
        {
            UpdateTouchInputs();
        }

        void UpdateTouchInputs()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                GetHitObject();
            }
        }

        private void GetHitObject()
        {
            var _hit = Physics2D.Raycast(_newPosition, Vector2.zero);
            if (_hit.collider != null)
            {
                Debug.Log("I'm hitting " + _hit.collider.name);
                var character = _hit.transform.gameObject.GetComponent<Character>();
                character.IsSelected = true;
            }
        }
    }
}
