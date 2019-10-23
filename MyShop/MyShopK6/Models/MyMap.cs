﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopK6.Models
{
    public class MyMap : Profile
    {
        public MyMap()
        {
            CreateMap<HangHoa, HangHoaView>().ReverseMap();
            //map 1 chiều từ HangHoa --> HangHoaChiTiet
            CreateMap<HangHoa, HangHoaChiTiet>();
        }
    }
}
