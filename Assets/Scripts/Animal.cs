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
        private bool _isOnGroud;

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
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.CompareTag("ground"))
                _isOnGroud = true;
        }

        // ENCAPSULATION
        private void Jump()
        {
            if(_isOnGroud)
            {
                JumpBehavior.Jump(_rigidbody);
                _isOnGroud = false;
            }
        }

    }
}
