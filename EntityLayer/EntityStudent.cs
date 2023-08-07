using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityStudent
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
