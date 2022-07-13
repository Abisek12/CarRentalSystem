namespace CarRentalSystem.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }=string.Empty;
        public string LastName { get; set; }=string.Empty ;
        public int Age { get; set; }
        public int DrivingLicenceNo { get; set; }
    }
}
