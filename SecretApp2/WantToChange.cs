﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SecretApp2
{
    public class WantToChange
    {
        private Boolean Want = false;

        public WantToChange(Boolean wanna)
        {
            Want = wanna;
        }

        public WantToChange() { }


        public void ReturnBool()
        {
            Console.WriteLine(Want);
        }
    }
}