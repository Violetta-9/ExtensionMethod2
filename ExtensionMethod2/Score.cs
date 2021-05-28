using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod2
{
    public  sealed class Score:Person 
    {
        
        public int Balance { get; set; }
        public string Banc { get; set; }
        public Score(string banc, int balance,string name,int age) : base(name,age)
        {
            Balance = balance;
            Banc = banc;
        }

        public override string  ToString() 
        {
            return $"У клиента {NameOfClient} возраста {Age} на счету лежит {Balance} в банке {Banc}";
        }
    }
}
