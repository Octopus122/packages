using System.Collections;
using System.Collections.Generic;

using UnityEngine;
// using UnityEngine.ResourceManagement.AsyncOperations;

namespace TestPackage
{
    public class Behavior2 : MonoBehaviour
    {
        public float xTeleport = 3f;
        public float period = 3f;
        void Start()
        {
            StartCoroutine(Teleport());
        }

        // Update is called once per frame
        void Update()
        {

        }
        private IEnumerator Teleport()
        {
            bool left = true;
            while (true)
            {
                yield return new WaitForSeconds(period);
                if (left)
                {
                    this.transform.position += new Vector3(xTeleport, 0f, 0f);
                    left = false;
                }
                else
                {
                    this.transform.position += new Vector3(-xTeleport, 0f, 0f);
                    left = true;
                }
                
            }
        }
    }
}
