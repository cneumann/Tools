﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrClusterConfig
{
    class AnalogInput : BaseInput
    {
        public AnalogInput(string _id, string _address)
            : base(_id, InputType.analog, _address)
        {
        }
    }
}
