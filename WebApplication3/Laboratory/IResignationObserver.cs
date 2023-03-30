using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Departaments
{
    public interface IResignationObserver
    {
        void Notify(string pcid);
    }
}
