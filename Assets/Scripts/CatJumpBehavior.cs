using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class CatJumpBehavior : IJumpBehavior
    {
        // POLYMORPHISM
        public void Jump(Rigidbody rb)
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            Debug.Log("Cat jump!");
        }
    }
}
