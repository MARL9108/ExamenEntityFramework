using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PizzeriaEntityFrameWork.Models
{
    public  static class PaginationPizza
    {

        public static IEnumerable<Pizza> Page<Pizza>(this IEnumerable<Pizza> source)
        {
            var page = Convert.ToInt32(ConfigurationManager.AppSettings["page"]);
            var pageSize= Convert.ToInt32(ConfigurationManager.AppSettings["pageSize"]);
            return source.Skip((page - 1) * pageSize).Take(pageSize);
            
        }
    }
}
