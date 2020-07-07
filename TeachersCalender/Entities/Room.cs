using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersCalender.Entities
{
    [Serializable]
    public class Room
    {
        #region Properties
        public string Name { get; set; }
        public int Size { get; set; }
        #endregion

        #region Constructors

        public Room()
        {
            this.Name = String.Empty;
            this.Size = 0;
        }

        public Room(string name, int size)
        {
            this.Name = name;
            this.Size = size;
        }

        #endregion

        #region Methods

        #endregion
    }
}
