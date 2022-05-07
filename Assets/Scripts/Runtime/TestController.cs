using UnityEngine;

namespace Runtime
{
    public class TestController : IController
    {
        public void OnStart()
        {
            Debug.Log("OnStart");
        }

        public void OnStop()
        {
            Debug.Log("OnStop");
        }

        public void OnTick()
        {
            Debug.Log("OnTick");
        }
    }
}