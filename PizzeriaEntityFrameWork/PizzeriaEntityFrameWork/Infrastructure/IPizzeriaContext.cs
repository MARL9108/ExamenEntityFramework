using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PizzeriaEntityFrameWork.Models;

namespace PizzeriaEntityFrameWork.Repository
{
    public interface IPizzeriaContext:IUnitOfWork<Pizza>
    {
    }
}
