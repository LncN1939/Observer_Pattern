using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Subject;

namespace WebApplication3.Departaments
{
    public interface ILAB2
    {
        void AllocateAsset();
    }

    public class LAB2 : ILAB2, IResignationObserver
    {
        public LAB2(IResignation resignation)
        {
            resignation.AddObserver(this);
        }

        public void AllocateAsset()
        {
            // Allocate asset
        }

        public void Notify(string employeeId)
        {
            // whenever employee resigns notification will come here.
            // Finance department will take necessary action accordingly.

            UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
            xmlHelper.UpdateNotificationDetail("LAB2", employeeId);
        }

    }
}
