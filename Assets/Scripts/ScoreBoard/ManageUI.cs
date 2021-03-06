﻿using System;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScoreBoard
{

    public class ManageUI : MonoBehaviour
    {

        [SerializeField] public GameObject playerBoard;

        void Update()
        {
            playerBoard.SetActive(Input.GetKey(KeyCode.Tab));
        }

        void OnTab(InputValue inputValue)
        {
            playerBoard.SetActive( inputValue.isPressed);
        }
    }
}

