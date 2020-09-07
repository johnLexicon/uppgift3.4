using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift3._4
{
    class NumericInputError : UserError
    {
        override public string UEMessage()
        {
            return "You tried to use a numeric input in a text only field.This fired an error!";
        }


    }

    
}   
