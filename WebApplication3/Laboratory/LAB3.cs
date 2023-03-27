using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Subject;

namespace WebApplication3.Departaments
{
    public interface ILAB3
    {
        void ManagePC();
    }
    public class LAB3 : ILAB3, IResignationObserver
    {
        public LAB3(IResignation resignation)
        {
            resignation.AddObserver(this);
        }
        public void CalculateSalary()
        {
            // calculates salary
        }

        public void ManagePC()
        {
 
        }

        public void Notify(string employeeId)
        {
            // whenever employee resigns notification will come here.
            // Finance department will take necessary action accordingly.

            UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
            xmlHelper.UpdateNotificationDetail("LAB3", employeeId);
        }


    }
}
