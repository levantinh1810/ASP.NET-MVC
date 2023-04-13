using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteBanHang.Models
{
    public partial class ProductMasterData
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        [Display(Name = "Hình ảnh")]
        public string Avartar { get; set; }
        [Display(Name = "Tên danh mục")]
        public Nullable<int> CategoryId { get; set; }
        [Display(Name = "Loại sản phẩm")]
        public Nullable<int> TypeId { get; set; }
        [Display(Name = "Tên thương hiệu")]
        public Nullable<int> BrandId { get; set; }
        [Display(Name = "Mô tả ngắn")]
        public Nullable<int> ShortDes { get; set; }
        [Display(Name = "Mô tả đầy đủ")]
        public Nullable<int> FullDescription { get; set; }
        [Required(ErrorMessage = "Giá không được để trống")]
        [Display(Name = "Giá")]
        public Nullable<double> Price { get; set; }
        [Display(Name = "Giá khuyến mãi")]
        public Nullable<double> PriceDiscount { get; set; }
        public string Slug { get; set; }
        public Nullable<bool> Deleted { get; set; }
        [Display(Name = "Hiển thị trang chủ")]
        public Nullable<bool> ShowOnHomePage { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        [Display(Name = "Ngày tạo")]
        public Nullable<System.DateTime> CreatedUtc { get; set; }      
        [Display(Name = "Ngày cập nhật")]
        public Nullable<System.DateTime> UpdatedUtc { get; set; }
    }
}