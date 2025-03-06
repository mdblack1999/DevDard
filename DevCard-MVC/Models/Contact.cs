using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3,ErrorMessage = "حداقل طول این فیلد 3 کاراکتر است")]
        [MaxLength(100,ErrorMessage = "حداکثر طول این فیلد 100 کاراکتر است")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "ایمیل به صورت صحیح وارد نشده است")]
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Email { get; set; }

        public string Service { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Message { get; set; }
    }
}
