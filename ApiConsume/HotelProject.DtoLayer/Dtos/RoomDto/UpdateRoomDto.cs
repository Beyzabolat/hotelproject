﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
   public class UpdateRoomDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını giriniz.")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görselini giriniz.")]
        public string RoomCoverImage { get; set; }


        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığı giriniz.")]
        [StringLength(100, ErrorMessage ="Lütfen en fazla100 karakter veri giriniz!z")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen  yatak saysını giriniz.")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen  banyo saysını giriniz.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen açıklama giriniz.")]
        public string Description { get; set; }


    }
}
