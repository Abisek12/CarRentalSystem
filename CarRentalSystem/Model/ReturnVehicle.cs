namespace CarRentalSystem.Model
{
    public class ReturnVehicle
    {
        public int RentedID { get; set; }
        public int VehicleId { get; set; }
        public int UserId { get; set; }
        public int MillageIncrease { get; set; }
        public bool IsGasTankFull   { get; set; }
    }
}
