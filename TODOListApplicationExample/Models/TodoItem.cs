using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOListApplicationExample.Models
{
    public class TodoItem
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public bool IsChecked { get; set; }
    }
}
