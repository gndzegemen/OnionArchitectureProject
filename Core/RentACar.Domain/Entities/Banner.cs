using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class Banner
    {
        public int BannerID { get; set; }
        public int Title { get; set; }
        public int Description { get; set; }
        public int VideoDescription { get; set; }
        public int VideoUrl { get; set; }

    }
}
