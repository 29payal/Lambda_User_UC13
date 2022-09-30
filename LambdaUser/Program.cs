using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserDetails> listPerson = new List<UserDetails>();
            UserDetails.AddRecords(listPerson);
            Console.ReadLine();

        }
    }
}
