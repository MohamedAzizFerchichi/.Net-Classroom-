//Console.WriteLine("Entrer une chaine de caractere");
//string chaine = Console.ReadLine();
//Console.WriteLine(chaine);
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(age);

using AM.ApplicationCore.Domain;

//Personne p = new Personne();

//p.Email = "az";
//p.Password = "az";
//p.DateNaissance = DateTime.Now;
//p.Nom = "az";
//p.Prenom = "az";

//Personne person = new Personne(
//        1,"test","test","test","test",DateTime.Now
//);

//Personne personne2 = new Personne()
//{
//    Email = "az",
//    Password = "az",
//    DateNaissance = DateTime.Now,
//    Nom = "az",
//    Prenom = "az",
//};
//Console.WriteLine(p);
//Console.WriteLine(personne2);

//Personne e = (Etudiant)  new Etudiant();
//personne2.getMyType();
//e.getMyType();



Plane plane = new Plane();
plane.PlaneId = 1;
plane.Capacity = 150;
plane.ManufacturedDate = DateTime.Now;
plane.Plane_Type = Plane.PlaneType.Boing;
plane.flights = null;

//Plane plane2 = new Plane(Plane.PlaneType.Airbus, 100, DateTime.Now);

Plane plane3 = new Plane()
{
    PlaneId = 1,
    Capacity = 100,
    ManufacturedDate = DateTime.Now,
    Plane_Type = Plane.PlaneType.Boing,
    flights = null
};  

Staff staff = new Staff();
staff.EmploymentDate = DateTime.Now;
staff.Function = "test";
staff.Salary = 1000;
staff.FirstName = "test";
staff.EmailAdresse = "test@Test.com";
staff.LastName = "test";

Traveller traveller = new Traveller();

traveller.HealthInfomation = "test";
traveller.Nationality = "test";
traveller.FirstName = "test1";
staff.FirstName = "test1";
staff.EmailAdresse = "test2@Test.com";
staff.LastName = "test1";

staff.PassengerType();
traveller.PassengerType();










