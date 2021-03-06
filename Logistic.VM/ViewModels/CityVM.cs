namespace Logistic.VM.ViewModels
{
    public class CityVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
