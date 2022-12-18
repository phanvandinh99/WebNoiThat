﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Banner
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Hình ảnh")]
        [Required(ErrorMessage = "Trường này không được để trống")]
        public string Images { get; set; }
        [DisplayName("Liên kết")]
        public string Link { get; set; }
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
        [DisplayName("Ngày tạo")]
        public DateTime? Created { get; set; }
        [DisplayName("Ngày sửa")]
        public DateTime? ModifileDate { get; set; }
    }
}
