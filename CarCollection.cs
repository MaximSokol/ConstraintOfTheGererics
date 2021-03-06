using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstraintOfTheGererics
{
    class CarCollection<T> : MyList<T>
    {
        private readonly MyList<string> carName;
        private readonly MyList<DateTime> carYear;

        public CarCollection()
        {
            carName = new MyList<string>();
            carYear = new MyList<DateTime>();
        }

        public void AddCar(string name, DateTime year)
        {
            carName.Add(name);
            carYear.Add(year);
        }

        public new string this[int index]
        {
            get{ return carName[index] + " " + carYear[index].Year + " г";}
        }

        public int Lenght
        {
            get { return carName.Count; }
        }

        public void Remove()
        {
            carName.Clear();
            carYear.Clear();
        }

        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i < carName.Count; i++)
            {
                stroka += "№" + (i + 1) + " " + carName[i] + " " + carYear[i].Year + " г \n";
            }
            if (stroka != null) return stroka;
            return "В парке нет ни одной машины!";
        }
    }
}
