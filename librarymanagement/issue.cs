using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagement
{
    internal class issue
    {
        public void bookissue()
        {
            string dt = DateTime.Now.ToShortDateString();//issuedate
            string returndate = "5/26/2022";

            int perdayCost = 10;
            DateTime dt1 = Convert.ToDateTime(returndate);
            DateTime dt2 = Convert.ToDateTime(dt);

            var d = dt1 - dt2;
            Console.WriteLine(d.Days * perdayCost);

        }
        
    }
}
