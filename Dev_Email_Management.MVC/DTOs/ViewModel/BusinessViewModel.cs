
namespace Dev_Email_Management.MVC.DTOs.ViewModel
{
    public class BusinessViewModel
    {
        public int BusinessId { get; set; }
        public string BusinessName { get; set; }
        public bool BusinessNNI { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CanceledAt { get; set; }
        public List<BusinessCityViewModel> Cities { get; set; }
        public List<BusinessStateViewModel> States { get; set; }
        public List<BusinessEmailViewModel> Emails { get; set; }
        public List<BusinessPhoneViewModel> Phones { get; set; }
    }
}
