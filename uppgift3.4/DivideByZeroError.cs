using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift3._4
{
    class DivideByZeroError: UserError
    {
        override public string UEMessage()
        {
            return "You tried to divide a value by zero why did you do that?";
        }
    }
}
