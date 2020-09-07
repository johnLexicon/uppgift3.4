using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift3._4
{
    class TextInputError : UserError
    {
        override public string UEMessage()
        {
            return "You tried to use a text input in a numeric only field.This fired an error!";
        }
    }
}
