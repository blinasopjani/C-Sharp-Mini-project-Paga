using System;

namespace LlogaritPagen
{
    public class Admin : Employee
    {
        public Admin(int id, string emri, string pozita, double rroga) : base(id, emri, pozita, rroga)
        {
        }
        public override double LlogaritBonusin(double rroga)
        {
            return 5000;
        }
    }
}
