using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Settings
{
    public class SqlProperties
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = "easydentaldb";
    }
}
