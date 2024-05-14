using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ConferenceClass
    {
        private int _id;

        public int Id
        {
            get { return _id; }
        }

        public ConferenceClass()
        {
            _id = new Random().Next(1, int.MaxValue);
        }

        public ConferenceClass(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Должно быть положительное число");
            }

            _id = id;
        }
    }
}
