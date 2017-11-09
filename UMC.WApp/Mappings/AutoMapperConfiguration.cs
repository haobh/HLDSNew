using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMC.Model.Entity;
using UMC.WApp.ViewModel;

namespace UMC.WApp.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Shift, ShiftViewModel>();
                cfg.CreateMap<Line,LineViewModel>();
                cfg.CreateMap<Station,StationViewModel>();
                cfg.CreateMap<Quantity, QuantitiesViewModel>();
                cfg.CreateMap<TimeSetting, TimeSettingViewModel>();
            });
        }
    }
}
