using CarRentalSystem.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarRentalController : ControllerBase
    {

        private static List<Vehicle> vehicleList = new List<Vehicle>()
        {
            new Vehicle() {Id = 101, Make = "Honda", Model = "Accord", Year = 2017, Millage = 30000, StartingPrice = 300, DailyPrice = 200, IsAvailable = true},
            new Vehicle() {Id = 102, Make = "Honda", Model = "Civic", Year = 20187, Millage = 33000, StartingPrice = 250, DailyPrice = 150, IsAvailable = false}
        };
        private static List<User> userList = new List<User>()
        {
            new User (){Id = 1, FirstName = "Ram", LastName= "Thapa", Age = 25, DrivingLicenceNo = 336473},
            new User (){Id = 2, FirstName = "Sam", LastName= "Smith", Age = 21, DrivingLicenceNo = 567467}
        };
        private static List<RentedVehicle> rentedVehicleList = new List<RentedVehicle>()
        {
            new RentedVehicle() {RentedId = 1, VehicleId = 102,UserId = 1, Millage = 33000, StartingPrice = 250, DailyPrice = 150, IsGasTankFull = true}
        };
        private static List<ReturnVehicle> returnVehicleList = new List<ReturnVehicle>()
        {
            new ReturnVehicle(){RentedID = 1, VehicleId = 102, UserId = 1, MillageIncrease = 3000, IsGasTankFull = true}
        };
        [HttpGet("{id}")]
        public async Task<ActionResult> GetNewMillage(int id )
        {
            var newMillage = returnVehicleList.Join(rentedVehicleList, a => a.RentedID, b => b.RentedId, (a, b) =>
            new
            {
                RentedVehicleId = a.RentedID,
                NewMillage = b.Millage + a.MillageIncrease
            }).
            Where(h => h.RentedVehicleId == id);
            if (id == 0)
                return BadRequest("Wrong vehicle ID,");
            return Ok(newMillage);
        }

        [HttpGet]   
        public async Task<ActionResult> Get()
        {
            return Ok(vehicleList);
        }

    }
}
