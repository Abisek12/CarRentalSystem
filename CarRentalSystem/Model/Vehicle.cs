namespace CarRentalSystem.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }= string.Empty;
        public string Model { get; set; }=string.Empty;
        public int Year { get; set; }
        public int Millage { get; set; } 
        public int StartingPrice { get; set; }
        public int DailyPrice { get; set; }
        public bool IsAvailable { get; set; }
    }
}
