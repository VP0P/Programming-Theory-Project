using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class NoJumpBehavior : IJumpBehavior
    {
        public void Jump(Rigidbody rb)
        {
            Debug.Log("I can't jump");
        }
    }
}
