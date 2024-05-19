using System;

namespace LlogaritPagen
{
    public class Employee
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public string Pozita { get; set; }
        public double Rroga { get; set; }

        public Employee(int id, string emri, string pozita, double rroga)
        {
            Id = id;
            Emri = emri;
            Pozita = pozita;
            Rroga = rroga;
        }

        public virtual double LlogaritBonusin(double rroga)
        {
            return 0;
        }
    }

}
