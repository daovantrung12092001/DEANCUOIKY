using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PizzaPlace_2022.Shared {
    public class Customer {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Vui lòng nhập tên địa chỉ")]
        public string Street { get; set; } = default!;

        [Required(ErrorMessage = "Vui lòng nhập thành phố")]
        public string City { get; set; } = default!;

        [Required(ErrorMessage = "Vui lòng nhập Số điện thoại")]
        public string SDT { get; set; } = default!;

        [Required(ErrorMessage = "Vui lòng nhập Email")]
        public string Email { get; set; } = default!;
    }
}
