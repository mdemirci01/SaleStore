﻿using SaleStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaleStore.Models
{
    public class Product:BaseEntity
    {
        public Product()
        {
            SelectedProduct = false;
        }

        [DisplayName("Ürün Adı"),
         Required(ErrorMessage = "Lütfen bir {0} giriniz."),
         MinLength(3, ErrorMessage = "{0} en az {1} karakter olmalıdır."),
         MaxLength(250, ErrorMessage = "{0} en fazla {1} karakter olmalıdır.")]
        public string Name { get; set; }

        [DisplayName("Ürün Detayı")]
        public string Details { get; set; }

        [DisplayName("Birim Fiyat"),Required(ErrorMessage = "Lütfen bir {0} değeri giriniz."),
         DataType(DataType.Currency)]
        public float? UnitPrice { get; set; }

        [DisplayName("İndirimli Fiyat"),
         Required(ErrorMessage = "Lütfen bir {0} değeri giriniz."),
         DataType(DataType.Currency),]
        public float? SalePrice { get; set; }

        [DisplayName("İndirim Başlangıç Tarihi")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false,
            NullDisplayText = "İndirim Başlangıç Tarihi Girilmemiş")]
        public DateTime SaleStarthDate { get; set; }

        [DisplayName("İndirim Bitiş Tarihi")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false, 
            NullDisplayText = "İndirim Bitiş Tarihi Girilmemiş")]
        public DateTime SaleEndDate { get; set; }
        [DisplayName("Ürün Kategorisi")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [DisplayName("Ürün Resmi")]
        public string ProductImage { get; set; }
        [DisplayName("Firma Adı")]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [DisplayName("Yayında mı?")]
        public bool IsPublish { get; set; }

        [DisplayName("Ürün Anasayfada Görünsün mü? ")]
        public bool SelectedProduct { get; set; }
    }
}
