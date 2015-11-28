using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class UserEnt
    {
        #region Atributos
        private int id;
        private string name;
        private string last_name;
        private string maternal_surname;
        private string username;
        private string password;
        private string condition;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string NAME
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string LAST_NAME
        {
            get { return this.last_name; }
            set { this.last_name = value; }
        }
        public string MATERNAL_SURNAME
        {
            get { return this.maternal_surname; }
            set { this.maternal_surname = value; }
        }
        public string USERNAME
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string PASSWORD
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string CONDITION
        {
            get { return this.condition; }
            set { this.condition = value; }
        }
        #endregion
    }
}