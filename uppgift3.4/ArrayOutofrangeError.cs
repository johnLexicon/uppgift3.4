using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift3._4
{
    class ArrayOutofrangeError:UserError
    {
        public override string UEMessage()
        {
            return "The array index does not match any index of this list";
        }
    }
}
