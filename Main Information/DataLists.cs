using System;
using System.Collections.Generic;
using Комп_ютерний_практикум___1.MainClasses;

namespace Комп_ютерний_практикум___1
{
    class DataLists
    {
        // Лист з даними про житлові будинки.
        public List<House> Houses { get; set; } = new List<House>
        {
            new House()
            {
                IdHouse = 1,
                TypeHouse = HouseType.Малосімейка,
                NumOfFloors = 9,
                NumOfEntrances = 2,
                DateOfConstruction = new DateTimeOffset(new DateTime(2000, 9, 20))
            },
            new House()
            {
                IdHouse = 2,
                TypeHouse = HouseType.Хрущовка,
                NumOfFloors = 5,
                NumOfEntrances = 4,
                DateOfConstruction = new DateTimeOffset(new DateTime(1970, 7, 15))
            },
            new House()
            {
                IdHouse = 3,
                TypeHouse = HouseType.Сталінка,
                NumOfFloors = 3,
                NumOfEntrances = 4,
                DateOfConstruction = new DateTimeOffset(new DateTime(1950, 11, 11))
            },
            new House()
            {
                IdHouse = 4,
                TypeHouse = HouseType.Дореволюційна,
                NumOfFloors = 5,
                NumOfEntrances = 3,
                DateOfConstruction = new DateTimeOffset(new DateTime(1916, 12, 07))
            },
            new House()
            {
                IdHouse = 5,
                TypeHouse = HouseType.Високоповерхівка,
                NumOfFloors = 20,
                NumOfEntrances = 1,
                DateOfConstruction = new DateTimeOffset(new DateTime(2021, 12, 12))
            },
            new House()
            {
                IdHouse = 6,
                TypeHouse = HouseType.Новобудова,
                NumOfFloors = 15,
                NumOfEntrances = 2,
                DateOfConstruction = new DateTimeOffset(new DateTime(2018, 6, 8))
            },
            new House()
            {
                IdHouse = 7,
                TypeHouse = HouseType.Літівка,
                NumOfFloors = 9,
                NumOfEntrances = 4,
                DateOfConstruction = new DateTimeOffset(new DateTime(1990, 3, 10))
            },
            new House()
            {
                IdHouse = 8,
                TypeHouse = HouseType.Панель,
                NumOfFloors = 7,
                NumOfEntrances = 2,
                DateOfConstruction = new DateTimeOffset(new DateTime(1997, 4, 1))
            },
            new House()
            {
                IdHouse = 9,
                TypeHouse = HouseType.Хрущовка,
                NumOfFloors = 3,
                NumOfEntrances = 2,
                DateOfConstruction = new DateTimeOffset(new DateTime(1976, 1, 20))
            },
            new House()
            {
                IdHouse = 10,
                TypeHouse = HouseType.Малосімейка,
                NumOfFloors = 7,
                NumOfEntrances = 4,
                DateOfConstruction = new DateTimeOffset(new DateTime(1968, 8, 27))
            },
            new House()
            {
                IdHouse = 11,
                TypeHouse = HouseType.Малосімейка,
                NumOfFloors = 9,
                NumOfEntrances = 4,
                DateOfConstruction = new DateTimeOffset(new DateTime(1960, 5, 17))
            },
            new House()
            {
                IdHouse = 12,
                TypeHouse = HouseType.Новобудова,
                NumOfFloors = 17,
                NumOfEntrances = 1,
                DateOfConstruction = new DateTimeOffset(new DateTime(2017, 11, 19))
            },
            new House()
            {
                IdHouse = 13,
                TypeHouse = HouseType.Новобудова,
                NumOfFloors = 15,
                NumOfEntrances = 2,
                DateOfConstruction = new DateTimeOffset(new DateTime(2021, 9, 1))
            },
            new House()
            {
                IdHouse = 14,
                TypeHouse = HouseType.Новобудова,
                NumOfFloors = 15,
                NumOfEntrances = 1,
                DateOfConstruction = new DateTimeOffset(new DateTime(2017, 4, 12))
            },
             new House()
            {
                IdHouse = 15,
                TypeHouse = HouseType.Панель,
                NumOfFloors = 7,
                NumOfEntrances = 1,
                DateOfConstruction = new DateTimeOffset(new DateTime(2007, 1, 1))
            },
            new House()
            {
                IdHouse = 16,
                TypeHouse = HouseType.Малосімейка,
                NumOfFloors = 9,
                NumOfEntrances = 2,
                DateOfConstruction = new DateTimeOffset(new DateTime(1956, 12, 29))
            },
            new House()
            {
                IdHouse = 17,
                TypeHouse = HouseType.Високоповерхівка,
                NumOfFloors = 20,
                NumOfEntrances = 3,
                DateOfConstruction = new DateTimeOffset(new DateTime(2021, 2, 1))
            },
            new House()
            {
                IdHouse = 18,
                TypeHouse = HouseType.Новобудова,
                NumOfFloors = 15,
                NumOfEntrances = 4,
                DateOfConstruction = new DateTimeOffset(new DateTime(2020, 6, 23))
            },
            new House()
            {
                IdHouse = 19,
                TypeHouse = HouseType.Новобудова,
                NumOfFloors = 17,
                NumOfEntrances = 1,
                DateOfConstruction = new DateTimeOffset(new DateTime(2015, 10, 27))
            },
            new House()
            {
                IdHouse = 20,
                TypeHouse = HouseType.Літівка,
                NumOfFloors = 7,
                NumOfEntrances = 4,
                DateOfConstruction = new DateTimeOffset(new DateTime(1978, 1, 24))
            }
        };

        // Лист з даними про райони міста.
        public List<District> Districts { get; set; } = new List<District>
        {
            new District()
            {
                NameOfDistrict = "Тернівський",
                AddressOfDistrictAdmin = "вул. Короленка, буд. 1А",
                NumberOfInabitants = 82800,
                Area = 7754,
                IdDistrict = 1
            },
            new District()
            {
                NameOfDistrict = "Покровський",
                AddressOfDistrictAdmin = "вул. Шурупова, буд. 2",
                NumberOfInabitants = 126700,
                Area = 5953,
                IdDistrict = 2,
            },
            new District()
            {
                NameOfDistrict = "Саксаганський",
                AddressOfDistrictAdmin = "вул. Володимира Великого, буд. 32",
                NumberOfInabitants = 152235,
                Area = 3920,
                IdDistrict = 3,
            },
            new District()
            {
                NameOfDistrict = "Довгинцівський",
                AddressOfDistrictAdmin = "вул. Дніпровське шосе, 11",
                NumberOfInabitants = 100006,
                Area = 5305,
                IdDistrict = 4,
            },
            new District()
            {
                NameOfDistrict = "Центрально-Міський",
                AddressOfDistrictAdmin = "вул. Староярмарова, буд. 44",
                NumberOfInabitants = 81600,
                Area = 6642,
                IdDistrict = 5,
            },
            new District()
            {
                NameOfDistrict = "Інгулецький",
                AddressOfDistrictAdmin = "пр. Південний, буд. 1;",
                NumberOfInabitants = 59000,
                Area = 14800,
                IdDistrict = 6,
            },
            new District()
            {
                NameOfDistrict = "Металургійний",
                AddressOfDistrictAdmin = "вул. Хабаровська 6, буд. 4",
                NumberOfInabitants = 70378,
                Area = 5190,
                IdDistrict = 7,
            }
        };

        // Лист з даними зв'язку житловий будинок - район.
        public List<DistrictHouseConnection> DistrictsHouses { get; set; } = new List<DistrictHouseConnection>
        {
            new DistrictHouseConnection()
            {
                IdDistrict = 1,
                IdHouse = 7
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 3,
                IdHouse = 16
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 3,
                IdHouse = 9
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 7,
                IdHouse = 1
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 7,
                IdHouse = 3
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 4,
                IdHouse = 13
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 5,
                IdHouse = 15
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 2,
                IdHouse = 2
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 5,
                IdHouse = 20
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 1,
                IdHouse = 18
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 2,
                IdHouse = 12
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 6,
                IdHouse = 19
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 2,
                IdHouse = 6
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 2,
                IdHouse = 14
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 7,
                IdHouse = 10
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 3,
                IdHouse = 5
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 3,
                IdHouse = 4
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 7,
                IdHouse = 8
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 5,
                IdHouse = 11
            },
            new DistrictHouseConnection()
            {
                IdDistrict = 4,
                IdHouse = 17
            }
        };

        //Лист з даними про агенства.
        public List<Agency> Agencies { get; set; } = new List<Agency>
            {
                new Agency()
                {
                    IdAgency = 1,
                    NameOfAgency = "Дом Сервіс",
                    AddressOfAgency = "вул. Петра Дорошенка, буд. 1",
                },
                new Agency()
                {
                    IdAgency = 2,
                    NameOfAgency = "Спектр Міста",
                    AddressOfAgency = "пр. 200-річчя Кривого Рогу, буд. 13",
                },
                new Agency()
                {
                    IdAgency = 3,
                    NameOfAgency = "Тандем",
                    AddressOfAgency = "пр. Миру, будю 2а",
                },
                new Agency()
                {
                    IdAgency = 4,
                    NameOfAgency = "Проспект",
                    AddressOfAgency = "вул. Незалежності України, буд. 18",
                },
                new Agency()
                {
                    IdAgency = 5,
                    NameOfAgency = "UA Reality Group",
                    AddressOfAgency = "пр. Металургів, буд. 38",
                }
        };

        //Лист з даними зв'язку будинок - агенство
        public List<HouseAgencyConnection> HousesAgencies { get; set; } = new List<HouseAgencyConnection>
        {
            new HouseAgencyConnection()
            {
                IdAgency = 1,
                IdHouse = 6,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 2,
                IdHouse = 5,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 3,
                IdHouse = 4,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 4,
                IdHouse = 3,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 5,
                IdHouse = 2,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 5,
                IdHouse = 1,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 4,
                IdHouse = 11,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 4,
                IdHouse = 15,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 3,
                IdHouse = 20,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 2,
                IdHouse = 19,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 2,
                IdHouse = 10,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 1,
                IdHouse = 8,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 1,
                IdHouse = 9,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 4,
                IdHouse = 14,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 4,
                IdHouse = 17,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 1,
                IdHouse = 18,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 5,
                IdHouse = 7,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 5,
                IdHouse = 13,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 3,
                IdHouse = 16,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 1,
                IdHouse = 12,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 1,
                IdHouse = 3,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 5,
                IdHouse = 20,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 5,
                IdHouse = 15,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 2,
                IdHouse = 2,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 2,
                IdHouse = 17,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 4,
                IdHouse = 1,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 3,
                IdHouse = 15,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 3,
                IdHouse = 14,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 2,
                IdHouse = 20,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 5,
                IdHouse = 4,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 3,
                IdHouse = 5,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 1,
                IdHouse = 7,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 4,
                IdHouse = 10,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 3,
                IdHouse = 3,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 5,
                IdHouse = 12,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 2,
                IdHouse = 8,
            },
            new HouseAgencyConnection()
            {
                IdAgency = 2,
                IdHouse = 13,
            }
        };
    }
}
