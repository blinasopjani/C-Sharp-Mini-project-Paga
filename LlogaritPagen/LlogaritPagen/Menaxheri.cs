using System;

namespace LlogaritPagen
{
   public class Menaxheri : Employee
    {
        public Menaxheri(int id, string emri, string pozita, double rroga) : base(id, emri, pozita, rroga)
        {
        }
        public override double LlogaritBonusin(double rroga)
        {
            double bonusi = 0;
            if (rroga * 0.25 > 5000)
                bonusi = rroga * 0.25;
            else
                bonusi = 5000;

            return bonusi;
        }
    }
}
