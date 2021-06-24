using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public interface IInstance
    {
        bool IsDone { get; set; }
        void Init();
        void Idle();
        void CleanUp();
    }
}
