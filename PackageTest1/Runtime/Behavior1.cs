using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PackageTest2;

namespace PackageTest1
{
    public class Behavior1 : MonoBehaviour
    {
        public float xSpeed = 0.1f;
        public float ySpeed = 0.1f;
        public float zSpeed = 0.1f;
        public float xTeleport = 3f;
        public float periodTeleport = 3f;

        void Start()
        {
            var beh2 = new Behavior2();
            StartCoroutine(beh2.Teleport(xTeleport, periodTeleport, gameObject));
        }

        // Update is called once per frame
        void Update()
        {
            this.transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime, Space.Self);
        }
    }
}
