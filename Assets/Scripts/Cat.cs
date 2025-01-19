using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    // INHERITANCE
    public class Cat : Animal
    {
        private void Awake()
        {
            JumpBehavior = new CatJumpBehavior();
        }
        
    }
}
