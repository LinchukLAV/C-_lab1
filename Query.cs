using System.Collections.Generic;
using System.Linq;
using Комп_ютерний_практикум___1.Extra_classes;
using Комп_ютерний_практикум___1.MainClasses;

namespace Комп_ютерний_практикум___1
{
    class Query
    {
        public IEnumerable<HouseAndItsDistrictName> InfoAboutHouseAndItsDistrictName
            (IEnumerable<House> houses, IEnumerable<District> districts, IEnumerable<DistrictHouseConnection> districtsHouses)
        {
            return from districtHouses in districtsHouses
                   join district in districts on districtHouses.IdDistrict equals district.IdDistrict
                   join house in houses on districtHouses.IdHouse equals house.IdHouse
                   select new HouseAndItsDistrictName()
                   {
                       NameOfDistrict = district.NameOfDistrict, 
                       HouseInfo = house
                   };
        }

        public Dictionary<HouseType, List<House>> GroupHousesByProjectType
            (IEnumerable<House> houses)
        {
            return (from house in houses
                    group house by house.TypeHouse)
                   .ToDictionary(house => house.Key, house => house.ToList());
        }

        public IEnumerable<House> HousesMoreSomeFloorsAndBuildAfterSomeYear(IEnumerable<House> houses, int year, int floors)
        {
            return houses
                   .Where(house => house.DateOfConstruction.Year > year && house.NumOfFloors > floors);
        }

        public IEnumerable<HouseAndItsDistrictName> HousesInDistrWithTheLargestArea
            (IEnumerable<House> houses, IEnumerable<District> districts, IEnumerable<DistrictHouseConnection> districtsHouses)
        {
            double maxDistrictsItsArea = districts.Max(district => district.Area);
            return from districtHouse in districtsHouses
                   join district in districts on districtHouse.IdDistrict equals district.IdDistrict
                   join house in houses on districtHouse.IdHouse equals house.IdHouse
                   where district.Area == maxDistrictsItsArea
                   select new HouseAndItsDistrictName()
                   {
                       NameOfDistrict = district.NameOfDistrict, 
                       HouseInfo = house,
                   };
        }

        public IEnumerable<District> DistrictWhereInhabitMoreThanAverage(IEnumerable<District> districts)
        {
            double avgDistrictItsNumOfInabit = districts.Average(district => district.NumberOfInabitants);
            return from district in districts
                   where (district.NumberOfInabitants > avgDistrictItsNumOfInabit)
                   orderby district.Area descending
                   select district;

        }

        public Dictionary<string, List<House>> AgencyAndItsHouses
            (IEnumerable<House> houses, IEnumerable<HouseAgencyConnection> housesAgencies, IEnumerable<Agency> agencies)
        {
            var request = from houseAgencie in housesAgencies
                          join house in houses on houseAgencie.IdHouse equals house.IdHouse
                          join agency in agencies on houseAgencie.IdAgency equals agency.IdAgency
                          select new { AgencyName = agency.NameOfAgency, House = house };
            return (from request1 in request
                    group request1 by request1.AgencyName)
                   .ToDictionary(x => x.Key, x => x.Select(x => x.House).ToList());
        }

        public HouseAndItsDistrictName TheNewestHouse
            (IEnumerable<House> houses, IEnumerable<District> districts, IEnumerable<DistrictHouseConnection> districtsHouses)
        {
            return districtsHouses
                      .Join(houses, distrHouse => distrHouse.IdHouse, house => house.IdHouse,
                      (distrHouse, house) => new { All = house, ID = distrHouse.IdDistrict })
                      .Join(districts, districtHouseinfo => districtHouseinfo.ID, district => district.IdDistrict,
                      (districtsHouseinfo, district) => new HouseAndItsDistrictName()
                      {
                          NameOfDistrict = district.NameOfDistrict, 
                          HouseInfo = districtsHouseinfo.All,
                      })
                      .OrderByDescending(infoHouse => infoHouse.HouseInfo.DateOfConstruction)
                      .First();
        }

        public IEnumerable<YearHouseCollection> GroupHouseByBuiltYeardAndMoreThanSomeYear(IEnumerable<House> houses, int years)
        {
            return from house in houses
                   group house by house.DateOfConstruction.Year into year
                   where year.Key > years
                   orderby year.Key descending
                   select new YearHouseCollection()
                   { 
                       Year = year.Key,
                       HousesCollection = from house in year select house,
                   };
        }

        public IEnumerable<House> HouseLocatedInAreaRank3rdOfMagnified
            (IEnumerable<House> houses, IEnumerable<District> districts, IEnumerable<DistrictHouseConnection> districtsHouses)
        {
            District districtTopOneArea = districts
                            .Distinct().OrderByDescending(district => district.Area)
                            .ElementAt(2);
            return districtsHouses
                            .Join(houses, districtHouse => districtHouse.IdHouse, house => house.IdHouse,
                            (districtHouse, house) => new { House = house, ID = districtHouse.IdDistrict })
                            .Where(infoHouseDistr => infoHouseDistr.ID == districtTopOneArea.IdDistrict)
                            .Select(infoHouse => infoHouse.House);
        }

        public IEnumerable<House> HouseWithLessThanSomeFloors(IEnumerable<House> houses, int floors)
        {
            return houses
                    .OrderBy(house => house.NumOfFloors)
                    .ThenBy(house => house.NumOfEntrances)
                    .TakeWhile(house => house.NumOfFloors <= floors);
        }

        public IEnumerable<DistrictDensity> DistrictAndItsDensity(IEnumerable<District> districts)
        {
            return from district in districts
                   select new DistrictDensity() 
                   { 
                       DistrictName = district.NameOfDistrict,
                       Density = district.NumberOfInabitants / (district.Area / 100)
                   };
        }

        public IEnumerable<DistrictHouseTypes> DistrictAndItsHousesType
            (IEnumerable<House> houses, IEnumerable<District> districts, IEnumerable<DistrictHouseConnection> districtsHouses)
        {
            var request1 = districtsHouses
                          .Join(houses, distrHouse => distrHouse.IdHouse, house => house.IdHouse,
                          (distrHouse, house) => new { Type = house.TypeHouse, ID = distrHouse.IdDistrict })
                          .Distinct();
            return districts
                   .GroupJoin(request1, district => district.IdDistrict, houseItsType => houseItsType.ID,
                   (district, houseItsType) => new DistrictHouseTypes()
                   {
                       DistrictName = district.NameOfDistrict, 
                       HouseTypes = houseItsType.Select(house => house.Type)
                   });

        }

        public IEnumerable<District> GetDistrictMaxMinInabitants(IEnumerable<District> districts)
        {
            int maxInabitants = districts.Max(district => district.NumberOfInabitants);
            int minInabitants = districts.Min(district => district.NumberOfInabitants);

            IEnumerable<District> maxInabitantsDistricts = from district in districts
                                                           where district.NumberOfInabitants == maxInabitants
                                                           select district;
            IEnumerable<District> minInabitantsDistricts = from district in districts
                                                           where district.NumberOfInabitants == minInabitants
                                                           select district;
            return maxInabitantsDistricts.Concat(minInabitantsDistricts);
        }

        public IEnumerable<HouseAndItsDistrictName> HousesInTheAreaWhereAdminInAvenue
            (IEnumerable<House> houses, IEnumerable<District> districts, IEnumerable<DistrictHouseConnection> districtsHouses)
        {
            return districtsHouses.Join(districts, distrHouse => distrHouse.IdDistrict, district => district.IdDistrict,
                   (distrHouse, district) => new { Distr = district, ID = distrHouse.IdHouse })
                   .Join(houses, infoDistrict => infoDistrict.ID, house => house.IdHouse,
                   (infoDistrict, house) => new { Name = infoDistrict.Distr.NameOfDistrict, Admin = infoDistrict.Distr.AddressOfDistrictAdmin, House = house })
                   .Where(infoDistrHouse => infoDistrHouse.Admin.Contains("пр."))
                   .Select(info => new HouseAndItsDistrictName()
                   { 
                       NameOfDistrict = info.Name, 
                       HouseInfo = info.House
                   });
        }

        public IEnumerable<HouseAndItsDistrictName> HouseWithSomeTypeBuildAndTheLowestDensityArea
            (IEnumerable<House> houses, IEnumerable<District> districts, IEnumerable<DistrictHouseConnection> districtsHouses, HouseType houseItsType)
        {
            double density = districts.Min(district => district.NumberOfInabitants / (district.Area / 100));
            return from distrHouse in districtsHouses
                   join district in districts on distrHouse.IdDistrict equals district.IdDistrict
                   join house in houses on distrHouse.IdHouse equals house.IdHouse
                   where (district.NumberOfInabitants / (district.Area / 100)) == density && house.TypeHouse == houseItsType
                   select new HouseAndItsDistrictName()
                   { 
                        NameOfDistrict = district.NameOfDistrict, 
                        HouseInfo = house
                   };
        }
    }
}
