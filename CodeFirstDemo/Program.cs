using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class CodeFirstDemoContext : DbContext
    {

        public virtual DbSet<CodeFirst_Table> codeFirst_table { get; set; }
    }

    public class CodeFirst_Table
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
