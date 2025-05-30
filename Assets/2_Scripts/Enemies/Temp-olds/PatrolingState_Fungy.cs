﻿using _2_Scripts.Enemies.Temp_FirstApproach;
using UnityEngine;

namespace _2_Scripts.Enemies.Temp_olds
{
    internal class PatrolingState_Fungy : IState
    {
        private Fungy _fungy;
        [SerializeField] private float movingSpeed = 3f;
        private float _timeInterval = 0.5f;
        private float _currentTimeInterval = 0f;


        public PatrolingState_Fungy(Fungy fungy)
        {
            _fungy = fungy;
        }
        public void OnEnter()
        {
        }

        public void OnExit()
        {
        }

        public void OnLogic()
        {
            // Debug.Log("Patrol grzyba: onLogic");
            Jump();
        }

        private void Jump()
        {
            if (_currentTimeInterval >= _timeInterval)
            {
                _currentTimeInterval = 0;
                _fungy.RigidBody.AddForce(new Vector2(0, 2), ForceMode2D.Impulse);
            }
            else
                _currentTimeInterval += Time.deltaTime;
        }
    }
}
