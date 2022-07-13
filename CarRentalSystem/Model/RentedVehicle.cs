namespace CarRentalSystem.Model
{
    public class RentedVehicle
    {
        public int VehicleId { get; set; }
        public int UserId { get; set; }
        public int Millage { get; set; }  
        public int StartingPrice { get; set; }
        public int DailyPrice { get; set; }
        public bool IsGasTankFull { get; set; }
    }
}
