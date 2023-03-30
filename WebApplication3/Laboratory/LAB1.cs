using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Subject;

namespace WebApplication3.Departaments
{
    public interface ILAB1
    {
        void CalculateSalary();
    }

    public class LAB1 : ILAB1, IResignationObserver
    {
        public LAB1(IResignation resignation)
        {
            resignation.AddObserver(this);
        }

        public void CalculateSalary()
        {
            // calculates salary
        }
        public void Notify(string pcid)
        {
            // whenever employee resigns notification will come here.
            // Finance department will take necessary action accordingly.

            UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
            xmlHelper.UpdateNotificationDetail("LAB1", pcid);
        }

    }
}
