using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace PackageTest2
{
    public class Behavior2
    {
        public IEnumerator Teleport(float xTeleport, float period, GameObject o)
        {
            bool left = true;
            while (true)
            {
                yield return new WaitForSeconds(period);
                if (left)
                {
                    o.transform.position += new Vector3(xTeleport, 0f, 0f);
                    left = false;
                }
                else
                {
                    o.transform.position += new Vector3(-xTeleport, 0f, 0f);
                    left = true;
                }

            }
        }
    }
}
