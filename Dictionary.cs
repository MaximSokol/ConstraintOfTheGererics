using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstraintOfTheGererics
{
    class Dictionary<Tkey, TValue>
    {
        private readonly MyList<Tkey> key;
        private readonly MyList<TValue> value;
        //-------------------------------------------

        public Dictionary()
        {
            this.key = new MyList<Tkey>();
            this.value = new MyList<TValue>();
        }
        //--------------------------------------------

        public void AddToDictionary(Tkey key, TValue value)
        {
            this.key.Add(key);
            this.value.Add(value);
        }
        //--------------------------------------------

        public string this[int index]
        {
            get { return $"{key[index]} + {value[index]}\n"; }
        }
        //--------------------------------------------

        public string this[Tkey index]
        {
            get 
            {
                for(int i = 0; i < this.key.Count; i++)
                {
                   return $"Was found by key\t{index.ToString()}\t + The value\t{value[i].ToString()}";
                }
                return $"By the key\t{index}\twasn't found the value\n";
            }
        }
        //--------------------------------------------

        public int Count
        {
            get { return key.Count; }
        }
        //--------------------------------------------

        public override string ToString()
        {
            string stroka = string.Empty;
            for (int i = 0; i < key.Count; i++)
            {
                stroka += key[i] + " " + value[i] + "\n";
            }
            if (stroka != null)
                return stroka;
            return "В словаре нет значений.";
        }
        //--------------------------------------------
    }
}
