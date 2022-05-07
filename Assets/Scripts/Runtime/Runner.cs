using System;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime
{
    public class Runner : MonoBehaviour 
    {
        private List<IController> m_Controllers;
        private bool m_IsRinning = false;

        private void Update() 
        {
            if (!m_IsRinning) 
            {
                return;
            }
            TickControllers();
        }

        public void StartRunning()
        {
            CteateAllControllers();
            OnStartControllers();
            m_IsRinning = true;
        }

        public void StopRunning()
        {
            OnStopControllers();
            m_IsRinning = false;
        }

        private void CteateAllControllers()
        {
            m_Controllers = new List<IController>();
            m_Controllers.Add(new TestController());
        }
        
        private void OnStartControllers()
        {
            foreach (IController controller in m_Controllers)
            {
                try
                {
                    controller.OnStart();
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }
        }

        private void TickControllers()
        {
            foreach (IController controller in m_Controllers)
            {
                try
                {
                    controller.OnTick();
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }
        }

        private void OnStopControllers()
        {
            foreach (IController controller in m_Controllers)
            {
                try
                {
                    controller.OnStop();
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }
        }
    }
}