using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterCompany.Interfaces;

namespace ScooterCompany.Models
{
    internal class ScooterService : IScooterService
    {
        private IList<Scooter> scooterList = new List<Scooter>();
        public void AddScooter(string id, decimal pricePerMinute)
        {
            scooterList.Add(new Scooter(id, pricePerMinute));
        }

        public void RemoveScooter(string id)
        {
            var scooterToRemove = scooterList.Single(scooter => scooter.Id == id);
            if (scooterToRemove.IsRented)
            {
                throw new MissingMemberException("Scooter not available");
                
            }
            else
            {
                scooterList.Remove(scooterToRemove);
            }
        }

        public IList<Scooter> GetScooters()
        {
            return (IList<Scooter>)scooterList.Where(scooter => !scooter.IsRented);
        }

        public Scooter GetScooterById(string scooterId)
        {
            return scooterList.Single(scooter => scooter.Id == scooterId);
        }
    }
}
//List is a class that represents a list of objects which can be accessed by index
//IList is an interface that represents a collection of objects which can be accessed by index