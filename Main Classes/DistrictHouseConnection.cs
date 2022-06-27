namespace Комп_ютерний_практикум___1
{
    class DistrictHouseConnection
    {
        /// <summary>
        /// Шифр будинку
        /// </summary>
        public int IdHouse { get; init; }

        /// <summary>
        /// Шифр району
        /// </summary>
        public int IdDistrict { get; init; }

        /// <summary>
        /// Приведення до строкового типу
        /// </summary>И
        public override string ToString()
        {
            return $"Шифр района {IdDistrict}, якому належить будинок {IdHouse}";
        }
    }
}
