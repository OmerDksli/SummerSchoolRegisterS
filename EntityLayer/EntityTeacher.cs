using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityTeacher
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nameSurname;

        public string NameSurname
        {
            get { return nameSurname; }
            set { nameSurname = value; }
        }
        private int subject;//öğretmen branşı

        public int Subject
        {
            get { return subject; }
            set { subject = value; }
        }

    }
}
