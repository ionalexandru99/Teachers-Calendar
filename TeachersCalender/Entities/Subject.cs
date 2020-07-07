using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace TeachersCalender.Entities
{
    [Serializable]
    public class Subject : ICloneable
    {
        #region Properties

        public string Name { get; set; }
        public int Credits { get; set; }

        #endregion

        #region Contructors
        public Subject(string name, int credits)
        {
            this.Name = name;
            this.Credits = credits;
        }

        public Subject()
        {
            this.Name = String.Empty;
            this.Credits = 0;
        }

        #endregion

        #region Methods
        public object Clone()
        {
            string name = this.Name.Clone() as string;
            Subject subject = new Subject(name, this.Credits);

            return subject;
        }

        #endregion 
    }
}
