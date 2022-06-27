using System.Collections.Generic;
using System.Linq;
using Комп_ютерний_практикум___1.MainClasses;

namespace Комп_ютерний_практикум___1.Extra_classes
{
    class YearHouseCollection
    {
        /// <summary>
        /// Рік
        /// </summary>
        public int Year { get; init; }

        /// <summary>
        /// Інформація про будинок
        /// </summary>
        public IEnumerable<House> HousesCollection { get; init; }

        public override string ToString()
        {
            string housesInfo = $"У {Year} році побудовано { HousesCollection.Count()} будинків.\nСписок будинків:\n";
            foreach (House house in HousesCollection)
            {
                housesInfo += house.ToString();
                housesInfo += "\n";
            }
            return housesInfo;
        }
    }
}
