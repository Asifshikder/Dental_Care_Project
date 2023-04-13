using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
    public class SqlProperties
    {
        public string ConnectionString { get; set; } = "Server=.\\SQLEXPRESS;Database=easydentaldb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public string DatabaseName { get; set; } = "easydentaldb";
    }
}
