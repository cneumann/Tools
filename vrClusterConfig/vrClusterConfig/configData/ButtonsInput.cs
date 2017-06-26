using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrClusterConfig
{
    class ButtonsInput : BaseInput
    {
        public ButtonsInput(string _id, string _address)
            : base(_id, InputType.buttons, _address)
        {
        }
    }
}
