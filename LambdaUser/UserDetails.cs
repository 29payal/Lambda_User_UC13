using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaUser
{
    public class UserDetails
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Password;
        public int PhoneNumber;
        public UserDetails(string firstName, string lastName, string email, string password, int phoneNumber )
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
        }
        public static void AddRecords(List<UserDetails> user)
        {
            user.Add(new UserDetails("Payal" , "Sharma" ,"abc@gmail.com" , "ksgkhhcb" , 1234567890));

            foreach (var person in user.OrderBy(x => x.FirstName))
            {
                Console.WriteLine( "FirstName     : " +person.FirstName);
                Console.WriteLine("LastName      : " +person.LastName);
                Console.WriteLine( "Email         : " +person.Email);
                Console.WriteLine("Password       : " +person.Password);
                Console.WriteLine("Mobile Number  : " +person.PhoneNumber);
            }
        }

    }
}
