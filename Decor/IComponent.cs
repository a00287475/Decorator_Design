﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decor
{
    public interface IComponent<T>
    {
        T GetText();
    }
}