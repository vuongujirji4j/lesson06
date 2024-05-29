using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lesson06.Models
{
    public class PvvSong
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Pvv:hay nhap tieu de")]
        [DisplayName("tieu de")]
        public string PvvTitle { get; set; }
        [Required(ErrorMessage ="Pvv:hay nhap tac gia")]
        [DisplayName("tac gia")]

        public string PvvAuthor { get; set; }
        [Required(ErrorMessage ="Pvv:hay nhap nghe si")]
        [StringLength(50,MinimumLength =2, ErrorMessage = "Pvv:ten nghe si toi thieu 2 ki tu,toi da 50 ky tu")]
        [DisplayName("nghe si")]

        public string PvvArtist { get; set; }
        [Required(ErrorMessage ="Pvv:hay nhap nam xuat ban")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "Pvv:nhap xuat ban phai co 2 ky tu so ")]
        [Range(1900,2024, ErrorMessage = "Pvv:nam xuat ban khoang 1900-2024")]
        public string PvvYearRelease { get; set; }
    }
}