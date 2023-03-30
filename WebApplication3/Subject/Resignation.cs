using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Departaments;

namespace WebApplication3.Subject
{
    public class Resignation : IResignation
    {
        List<IResignationObserver> observerList;
        public Resignation()
        {
            observerList = new List<IResignationObserver>();
        }

        public void AddObserver(IResignationObserver observer)
        {
            observerList.Add(observer);
        }

        public void NotifyObserver(string pcid)
        {
            foreach (var observer in observerList)
            {
                observer.Notify(pcid);
            }
        }

        public void RemoveObserver(IResignationObserver observer)
        {
            observerList.Remove(observer);
        }
    }
}
