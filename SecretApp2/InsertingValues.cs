using System;
using System.Collections.Generic;
using System.Text;

namespace SecretApp2
{
    public class InsertingValues : WantToChange
    {
        private string path = @"C:\tmp\tmp2\cos.txt.";
        private Boolean wanna = false;

        public InsertingValues() { }

        public InsertingValues(string path2, Boolean change)
        {
            path = path2;
            wanna = change;
        }


        public string GetString()
        {
            return path;
        }
        public Boolean GetBool()
        {
            return wanna;
        }

    }
}
