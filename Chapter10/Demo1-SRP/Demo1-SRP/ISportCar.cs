﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_SRP
{
    interface ISportCar
    {
        bool Accelerate();
        System.Drawing.Bitmap Photo { get; }
        string Brand { get; }
        int Speed { get; }
        int MaxSpeed { get; }
    }
}
