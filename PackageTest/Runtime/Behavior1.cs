using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PackageTest
{
    public class Behavior1 : MonoBehaviour
    {
        public float xSpeed = 0.1f;
        public float ySpeed = 0.1f;
        public float zSpeed = 0.1f;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            this.transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime, Space.Self);
        }
    }
}