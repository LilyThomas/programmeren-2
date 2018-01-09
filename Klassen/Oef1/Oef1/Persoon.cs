using System;
namespace Oef1
{
    public class Persoon
    {
        private const int MIN_YEAR = 1990;
        private const int MIN_MONTH = 1;
        private const int MIN_DAY = 1;

        private string voornaam;
        private string achternaam;
        private DateTime geboortedatum;

        public Persoon(string voornaam, string achternaam, DateTime geboortedatum)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Geboortedatum = geboortedatum;
        }

        public string Voornaam
        {
            get;
            set;
        }

        public string Achternaam 
        {
            get;
            set;
        }

        public DateTime Geboortedatum
        {
            get
            {
                return geboortedatum;
            }
            set
            {
                DateTime underlimit = new DateTime(MIN_YEAR, MIN_MONTH, MIN_DAY);
                if(value > underlimit)
                {
                    geboortedatum = value;
                }
                else
                {
                    geboortedatum = DateTime.Today;
                }
            }
        }

        public int BerekenLeeftijd()
        {
            DateTime today = DateTime.Today;
            int leeftijd = geboortedatum.Year - today.Year;

            if(geboortedatum.Month == today.Month)
            {
                if(geboortedatum.Day <= today.Day)
                {
                    if(geboortedatum.Day == today.Day)
                    {
                        if(geboortedatum.Year != today.Year)
                        {
                            leeftijd++;
                        }
                    }
                }
                else
                {
                    leeftijd++;
                }
            }
            else
            {
                if(geboortedatum.Month < today.Month)
                {
                    leeftijd++;
                }
            }

            return leeftijd;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} is {3} jaar oud, geboren op {2}", Voornaam, Achternaam, Geboortedatum.ToShortDateString(), BerekenLeeftijd());
        }
    }
}
