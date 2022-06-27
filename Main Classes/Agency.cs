using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Комп_ютерний_практикум___1.MainClasses
{
    class Agency
    {
        /// <summary>
        /// Код агенства
        /// </summary>
        public int IdAgency { get; init; } 

        /// <summary>
        /// Назва агенства
        /// </summary>
        public string NameOfAgency { get; init; } = string.Empty;

        /// <summary>
        /// Адрес агенства
        /// </summary>
        public string AddressOfAgency { get; init; } = string.Empty;

        /// <summary>
        /// Приведення до строкового типу
        /// </summary>
        public override string ToString()
        {
            return $"Шифр: {IdAgency}. Назва агенства: {NameOfAgency}, адрес {AddressOfAgency}.";
        }
    }
}
