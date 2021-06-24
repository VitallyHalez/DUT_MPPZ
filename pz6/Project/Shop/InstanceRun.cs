using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class InstanceRun
    {
        IInstance instance;
        public InstanceRun(IInstance instance)
        {
            this.instance = instance;
        }
        public void Run()
        {
            instance.Init();
            while(!instance.IsDone)
            {
                instance.Idle();
            }
            instance.CleanUp();
        }
    }
}
