using System;
using System.ComponentModel.DataAnnotations;

namespace MvcProje.Models
{
    public class Kitap
    {
        [Required(ErrorMessage = "Kitap adı gereklidir.")]
        public string KitapAdi { get; set; }

        [Required(ErrorMessage = "Yazar adı gereklidir.")]
        public string YazarAdi { get; set; }

        [Display(Name = "Yayınlanma Tarihi")]
        [DataType(DataType.Date)]
        public DateTime YayinlanmaTarihi { get; set; }

        [Required(ErrorMessage = "Kitap türü gereklidir.")]
        public string Turu { get; set; }

        [Display(Name = "Sayfa Sayısı")]
        public int SayfaSayisi { get; set; }

        [Display(Name = "Fiyat")]
        [DataType(DataType.Currency)]
        public decimal Fiyat { get; set; }
    }
}

