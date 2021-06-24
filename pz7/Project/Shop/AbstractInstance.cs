using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    abstract class AbstractInstance
    {
        public dynamic Result { get; set; }
        private bool isDone = false;
        protected abstract void Init();
        protected abstract void Idle();
        protected abstract void CleanUp();
        protected void SetDone()
        {
            isDone = true;
        }
        public void Run()
        {
            Init();
            while(!isDone)
            {
                Idle();
            }
            CleanUp();
        }
    }
}
