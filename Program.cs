using System;
using Комп_ютерний_практикум___1.MainClasses;
using Комп_ютерний_практикум___1.Presentation_layer;

namespace Комп_ютерний_практикум___1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            DataLists dataLists = new DataLists();
            Query query = new Query();

            query.InfoAboutHouseAndItsDistrictName(dataLists.Houses, dataLists.Districts, dataLists.DistrictsHouses)
                 .WriteConsole("Інформація пробудинок та районів, де він знаходиться:");

            query.GroupHousesByProjectType(dataLists.Houses)
                 .WriteConsole("Будинки кожного типу проекту: ");

            query.HousesMoreSomeFloorsAndBuildAfterSomeYear(dataLists.Houses, 2000, 7)
                 .WriteConsole("Інформація про будинки побудованих після 2000 року, в яких більше 7 поверхів:");

            query.HousesInDistrWithTheLargestArea(dataLists.Houses, dataLists.Districts, dataLists.DistrictsHouses)
                 .WriteConsole("Інформація про будинки в найбільшому районі:");

            query.DistrictWhereInhabitMoreThanAverage(dataLists.Districts)
                 .WriteConsole("Інформаці про райони, де кільксть жителів більше середньої. Відсортована по спаданню за площею:");

            query.AgencyAndItsHouses(dataLists.Houses, dataLists.HousesAgencies, dataLists.Agencies)
                 .WriteConsole("Назва агенства та будинки з якими вони працюють:");

            query.TheNewestHouse(dataLists.Houses, dataLists.Districts, dataLists.DistrictsHouses)
                 .WriteConsole("Інформація про найновіший будинок:");

            query.GroupHouseByBuiltYeardAndMoreThanSomeYear(dataLists.Houses, 2010)
                .WriteConsole("Інформація про кількість будинків побудованих в кожному році, після 2010 " +
                              "та інформація про будинки за кожен рік:");

            query.HouseLocatedInAreaRank3rdOfMagnified(dataLists.Houses, dataLists.Districts, dataLists.DistrictsHouses)
                 .WriteConsole("Інформація про будинки, які знаходяться в третьому по величинні районі:");

            query.HouseWithLessThanSomeFloors(dataLists.Houses, 10)
                .WriteConsole("Інформація про будинки, в яких меньше 10 поверхів." +
                              " Відсортувати по зростанню кількості поверхів, а потім по кількості під'їздів:");

            query.DistrictAndItsDensity(dataLists.Districts)
                 .WriteConsole("Плотність населення кожного району:");

            query.DistrictAndItsHousesType(dataLists.Houses, dataLists.Districts, dataLists.DistrictsHouses)
                 .WriteConsole("Перелік типів проекту, які є в районі:");

            query.GetDistrictMaxMinInabitants(dataLists.Districts)
                 .WriteConsole("Будинки з мінімальною та максимальною населеністю:");

            query.HousesInTheAreaWhereAdminInAvenue(dataLists.Houses, dataLists.Districts, dataLists.DistrictsHouses)
                 .WriteConsole("Інформацію про будинки, у яких районний адміністративний центр знаходиться на проспекті:");

            query.HouseWithSomeTypeBuildAndTheLowestDensityArea(dataLists.Houses, dataLists.Districts, dataLists.DistrictsHouses, HouseType.Новобудова)
                 .WriteConsole("Інормацію про будинки з типом проекту 'Новобудова', " +
                              "які знаходяться в районі з найменшею плотністью населення:");

            Console.WriteLine("Закінчення роботи програми. Натисніть будь-яку клвішу");
            Console.ReadKey();
        }
    }
}