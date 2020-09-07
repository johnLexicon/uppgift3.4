using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift3._4
{
    class UnassignedVariableError: TextInputError
    {
        override public string UEMessage()
        {
            return "The variable you typed is not assigned a value!";
        }
    }

}
