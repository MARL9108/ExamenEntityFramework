using PizzeriaEntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaEntityFrameWork.Repository
{
    public interface IPizzaRepository:IDisposable 
    {
        Pizza GetPizzaId(int PizzaId);
        void InsertPizza(Pizza Pizza);
        void DeletePizza(int PizzaId);
        void UpdatePizza(Pizza Pizza);
        void Save();

    }
}
