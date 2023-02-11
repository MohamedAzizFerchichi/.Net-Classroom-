using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        //Birth date : int , PassportNumber : int , FirstName : string , LastName : string , EmailAdresse : TelNumber  : int7

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdresse { get; set; }


        public int TelNumber { get; set; }

        public int PassportNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public IList<Flight> Flights { get; set; }

        public bool CheckProfile(string nom, string prenom)
        {
           return nom == LastName && prenom == FirstName;
        }

        //public bool CheckProfile(string nom, string prenom, string email)
        //{
        //    return nom == LastName && prenom == FirstName && email == EmailAdresse;
        //}

        //concatine tow las methode 
        public bool CheckProfile(string nom, string prenom, string email=null)
        {
            return (nom == LastName && prenom == FirstName) || (nom == LastName && prenom == FirstName && email == EmailAdresse);
        }

     

        public virtual void PassengerType()
        {
            Console.Write("Passenger");
        }

        //ToString
        public override string ToString()
        {
            return $" FirstName: {FirstName}, LastName: {LastName}, EmailAdresse: {EmailAdresse}, TelNumber: {TelNumber}, PassportNumber: {PassportNumber}, BirthDate: {BirthDate}";
        }
       

    }
}
