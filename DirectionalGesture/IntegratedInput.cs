//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // (needs NetworkBehaviour)
//using UnityEngine.UI;
using System;
using UnityEngine;

namespace Labo
{
    interface IIntegratedInput
    {
        Vector2 LeftStick { get; }
        Vector2 RightStick { get; }
    }

    public class IntegratedInput : MonoBehaviour, IIntegratedInput
    {
        public Vector2 LeftStick { get; private set; }
        public Vector2 RightStick { get; private set; }

        private void Update()
        {
            UpdateRightStick();
        }

        private void UpdateLeftStick()
        {
            LeftStick = new Vector2(
                Input.GetAxis("Horizontal"),
                Input.GetAxis("Vertical")
            );
        }

        private void UpdateRightStick()
        {
            RightStick = new Vector2(
                Input.GetAxis("Mouse X"),
                Input.GetAxis("Mouse Y")
                );
        }
    }
}