using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadam.course.capstone
{
    class Hello
    {
        private static string stdname;
        private static int nocourse;
        private static DateTime datTime;
        private static string type;

        public static void getsn()
        {
            Welcome.setsName(stdname);

        }

        public static void setsn(String sname)
        {
            stdname = sname;
            getsn();
        }

        public static void getcourseno()
        {
            Welcome.setsnocours(nocourse);

        }

        public static void setcourseno(int course)
        {
            nocourse = course;
            getcourseno();
        }

        public static void getstartdate()
        {
            Welcome.setdate(datTime);

        }

        public static void setstartdate(DateTime dtTime)
        {
            datTime = dtTime;
            getstartdate();
        }

        public static void getclasstype()
        {
            Welcome.settype(type);

        }

        public static void setclasstype(string Type)
        {
            type = Type;
            getclasstype();
        }
    }

    
}

