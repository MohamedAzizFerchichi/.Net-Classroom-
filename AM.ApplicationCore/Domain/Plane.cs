using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int PlaneId { get; set; }

        public int Capacity { get; set; }

        public DateTime ManufacturedDate { get; set; }

        public PlaneType Plane_Type { get; set; }

        public IList<Flight> flights { get; set; }
        

        //ToString
        public override string ToString()
        {
            return $"PlaneId: {PlaneId}, Capacity: {Capacity}, ManufacturedDate: {ManufacturedDate}, Plane_Type: {Plane_Type}";
        }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            Plane_Type = pt;
            Capacity = capacity;
            ManufacturedDate = date;
        }   
         
        public  Plane() { }

       
    }
    public enum PlaneType
    {
        Boing,
        Airbus
    }
}
