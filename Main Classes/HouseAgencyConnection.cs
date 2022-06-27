using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Комп_ютерний_практикум___1.MainClasses
{
    class HouseAgencyConnection
    {
        /// <summary>
        /// Шифр будинку
        /// </summary>
        public int IdHouse { get; init; }

        /// <summary>
        /// Шифр агенства
        /// </summary>
        public int IdAgency { get; init; }

        /// <summary>
        /// Приведення до строкового типу
        /// </summary>И
        public override string ToString()
        {
            return $"Шифр агенства {IdAgency}, якому належить будинок {IdHouse}";
        }
    }
}
