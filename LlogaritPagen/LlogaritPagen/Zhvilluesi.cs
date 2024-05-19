using System;

namespace LlogaritPagen
{
    public class Zhvilluesi: Employee
    {
        public Zhvilluesi(int id, string emri, string pozita, double rroga) : base(id, emri, pozita, rroga)
        {
        }

        public  override double LlogaritBonusin(double rroga)
        {
          double bonusi = 0;
            if (rroga * 0.20 > 5000)
                bonusi = rroga * 0.20;
            else
                bonusi = 5000;
            return bonusi;

        }
    }
}
