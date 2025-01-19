using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    // INHERITANCE
    public abstract class Animal : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        // ENCAPSULATION
        protected IJumpBehavior JumpBehavior { get; set; }


        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Jump();

        }

        // ENCAPSULATION
        private void Jump()
        {
            JumpBehavior.Jump(_rigidbody);
        }
    }
}
