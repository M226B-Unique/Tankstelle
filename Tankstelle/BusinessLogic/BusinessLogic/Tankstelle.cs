using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Tankstelle
    {
        private Container petrolContainer;
        private Container dieselContainer;
        private Container truckDieselContainer;

        public List<Container> Containers { get; set; }

        public Tankstelle()
        {
            InitContainers();
        }

        public void InitContainers()
        {
            petrolContainer.FuelType = Fuel.Petrol;
            dieselContainer.FuelType = Fuel.Diesel;
            truckDieselContainer.FuelType = Fuel.TruckDiesel;

            InitStartFuelValue();

            Containers.Add(petrolContainer);
            Containers.Add(dieselContainer);
            Containers.Add(truckDieselContainer);
        }

        public void InitStartFuelValue()
        {
            foreach(Container container in Containers)
            {
                container.CurrentFuelValue = container.FuelMax;
            }
        }

        public void RefreshContainerFuelValue(Fuel type, double amountOfFuel)
        {
            foreach(Container container in Containers)
            {
                if(container.FuelType == type)
                {
                    container.RefreshCurrentFuelValue(amountOfFuel);
                }
            }
        }
    }
}
