using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Properties_Lesson10
{
    public class User
    {
        public string Name { get; set; }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 18)
                age = value;
            }
        }

        //public int Age { get; set; }

        //public int GetAge()
        //{
        //    return GetAge();
        //}

        //public void SetAge(int newAge)
        //{
        //    SetAge(newAge);
        //}

        public string Email { get; set; }

        public void MethodFromUser()
        {

        }
    }

}
