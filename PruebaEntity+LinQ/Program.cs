using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaEntity_LinQ;

namespace PruebaEntity_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new GestionDB.XWingsFactoryEntities();

            var InfoStruct = db.Structure.Select(x => x.idStructure).ToList();

            Console.ReadKey();
        }
    }
}
