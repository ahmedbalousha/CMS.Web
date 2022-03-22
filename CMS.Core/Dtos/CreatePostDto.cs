using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Dtos
{
   public class CreatePostDto
    {
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "العنوان")]
        public string Title { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "التفاصيل")] 
        public string Body { get; set; }
        [Display(Name = "وقت القراءة")]
        public int TimeInMinute { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "التصنيف")]
        public int CategoryId { get; set; }
        //[Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الناشر")]
        public string AuthorId { get; set; }

        [Display(Name = "المرفقات")]
        public List<IFormFile> Attachments { get; set; }

    }
}
