﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    public interface IDeveloper : IComparable
    {
        string Tool { get; set; }

        void Create();

        void Destroy();
    }
}
