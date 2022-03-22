using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Dtos
{
  public  class CreateAdvertisementDto
    {
        [Required(ErrorMessage ="هذا الحقل مطلوب")]
        [Display(Name ="عنوان الإعلان")]
        public string Title { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "صورة الإعلان")]
        public IFormFile Image { get; set; }
        [Display(Name = "البداية")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public DateTime StartDate { get; set; }
        [Display(Name = "النهاية")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الموقع")]
        [Url]
        public string WebsiteUrl { get; set; }
        [Display(Name = "السعر")]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public float Price { get; set; }
        public CreateUserDto Owner { get; set; }
        [Display(Name = "صاحب الإعلان")]
        public string OwnerId { get; set; }

    }
}
