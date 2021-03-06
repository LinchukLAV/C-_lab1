using System.Collections.Generic;
using Комп_ютерний_практикум___1.MainClasses;

namespace Комп_ютерний_практикум___1.Extra_classes
{
    public class DistrictHouseTypes
    {
        /// <summary>
        /// Назва вулиці
        /// </summary>
        public string DistrictName { get; init; } = string.Empty;

        /// <summary>
        /// Інформація про тип будівлі
        /// </summary>
        public IEnumerable<HouseType> HouseTypes { get; init; }     

        public override string ToString()
        {
            string housesInfo = $"У районі {DistrictName} є будинки з типом проекту:";
            foreach (HouseType houseType in HouseTypes)
            {
                housesInfo += houseType;
                housesInfo += "\n";
            }
            return housesInfo;
        }
    }
}
