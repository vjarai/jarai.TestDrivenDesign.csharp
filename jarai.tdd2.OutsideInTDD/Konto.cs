using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarai.tdd2.OutsideInTDD
{
    public interface IKonto
    {
        public void Einzahlen(int einzuzahlenderBetrag);
        
        public void Abheben(int auszuzahlenderBetrag);

        public string ErstelleKontoauszug();
    }

    public class Konto : IKonto
    {
        public void Einzahlen(int einzuzahlenderBetrag)
        {
            throw new NotImplementedException();
        }

        public void Abheben(int auszuzahlenderBetrag)
        {
            throw new NotImplementedException();
        }

        public string ErstelleKontoauszug()
        {
            return "Test";
        }
    }
}
