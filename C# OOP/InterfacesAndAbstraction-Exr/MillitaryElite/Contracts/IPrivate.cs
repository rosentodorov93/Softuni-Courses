﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Contracts
{
    public interface IPrivate : ISoldier
    {
        public decimal Salary { get;}
    }
}
