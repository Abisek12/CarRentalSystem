namespace CarRentalSystem.Model
{
    public class ReturnVehicle
    {
        public int VehicleId { get; set; }
        public int UserId { get; set; }
        public int Millage { get; set; }
        public bool IsGasTankFull   { get; set; }
    }
}
