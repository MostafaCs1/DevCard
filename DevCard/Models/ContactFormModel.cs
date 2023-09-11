using System.ComponentModel.DataAnnotations;

namespace DevCard.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "فیلد نام اجباری است")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "تعداد کارکتر وارد شده درست نمی باشد")]
        public string? PersonName { get; set; }

        [Required(ErrorMessage = "فیلد ایمیل اجباری است")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل را به صورت صحیح وارد کنید")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "لطفا یکی از گزینه ها را انتخاب کنید")]
        public string? ServiceType { get; set; }
        public string? Message { get; set; }
    }
}
