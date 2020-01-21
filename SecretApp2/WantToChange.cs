using System;
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

        public void Set(bool isThatTrue)
        {
            Want = isThatTrue;
        }

        public void ReturnBool()
        {
            Console.WriteLine(Want);
        }
    }
}
