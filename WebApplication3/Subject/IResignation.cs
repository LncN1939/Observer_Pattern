using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Departaments;

namespace WebApplication3.Subject
{
    public interface IResignation
    {
        void AddObserver(IResignationObserver observer);
        void RemoveObserver(IResignationObserver observer);
        void NotifyObserver(string employeeId);
    }
}
