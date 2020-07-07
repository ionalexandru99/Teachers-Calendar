using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TeachersCalender.Entities
{
    [Serializable]
    public class Teacher : ICloneable
    {

        #region Properties
        public string Name { get; set; }

        #endregion

        #region Constructors
        public Teacher(string name)
        {
            this.Name = name;
        }

        public Teacher()
        {
            this.Name = String.Empty;
        }



        #endregion

        #region Methods

        public object Clone()
        {
            Teacher teacher = new Teacher(this.Name.Clone() as string);

            return teacher;
        }
        #endregion
    }
}
