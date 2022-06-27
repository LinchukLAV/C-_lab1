using Комп_ютерний_практикум___1.MainClasses;

namespace Комп_ютерний_практикум___1
{
    class HouseAndItsDistrictName
    {
        /// <summary>
        /// Назва району
        /// </summary>
        public string NameOfDistrict { get; init; } = string.Empty;

        /// <summary>
        /// Інофрмація про будинок
        /// </summary>
        public House HouseInfo { get; init; }

        public override string ToString()
        {
            return $"{HouseInfo} в районі: {NameOfDistrict}";
        }
    }
}
