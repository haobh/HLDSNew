using UMC.Model.Entity;
using UMC.WApp.ViewModel;

namespace UMC.WApp.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateShift(this Shift shift, ShiftViewModel shiftVm)
        {
            shift.ID = shiftVm.ID;
            shift.Name = shiftVm.Name;
            shift.StartHour = shiftVm.StartHour;
            shift.StartMinute = shiftVm.StartMinute;
            shift.EndHour = shiftVm.EndHour;
            shift.EndMinute = shiftVm.EndMinute;
        }
        public static void UpdateLine(this Line line, LineViewModel lineVm)
        {
            line.ID = lineVm.ID;
            line.Name = lineVm.Name;
        }
        public static void UpdateStation(this Station station, StationViewModel stationVm)
        {
            station.ID = stationVm.ID;
            station.Name = stationVm.Name;
            station.NumberConfig = stationVm.NumberConfig;
        }
        public static void UpdateQuantities(this Quantity quantity, QuantitiesViewModel quantitiesVm)
        {
            quantity.ID = quantitiesVm.ID;
            quantity.ShiftCode = quantitiesVm.ShiftCode;
            quantity.Type = quantitiesVm.Type;
            quantity.LineID = quantitiesVm.LineID;
            quantity.StationID = quantitiesVm.StationID;
            quantity.CreatedDate = quantitiesVm.CreatedDate;
            quantity.UpdatedDate = quantitiesVm.UpdatedDate;
            quantity.T1 = quantitiesVm.T1;
            quantity.T2 = quantitiesVm.T2;
            quantity.T3 = quantitiesVm.T3;
            quantity.T4 = quantitiesVm.T4;
            quantity.T5 = quantitiesVm.T5;
            quantity.T6 = quantitiesVm.T6;
            quantity.T7 = quantitiesVm.T7;
            quantity.T8 = quantitiesVm.T8;
            quantity.T9 = quantitiesVm.T9;
            quantity.T10 = quantitiesVm.T10;
            quantity.T11 = quantitiesVm.T11;
            quantity.T12 = quantitiesVm.T12;
        }
        public static void UpdateTimeSetting(this TimeSetting timeSetting, TimeSettingViewModel timeSettingVm)
        {
            timeSetting.ID = timeSettingVm.ID;
            timeSetting.T1 = timeSettingVm.T1;
            timeSetting.T2 = timeSettingVm.T2;
            timeSetting.T3 = timeSettingVm.T3;
            timeSetting.T4 = timeSettingVm.T4;
            timeSetting.T5 = timeSettingVm.T5;
            timeSetting.T6 = timeSettingVm.T6;
            timeSetting.T7 = timeSettingVm.T7;
            timeSetting.T8 = timeSettingVm.T8;
            timeSetting.T9 = timeSettingVm.T9;
            timeSetting.T10 = timeSettingVm.T10;
            timeSetting.T11 = timeSettingVm.T11;
            timeSetting.T12 = timeSettingVm.T12;
        }
        public static void UpdateTimeDaily(this TimeDaily timeDaily, TimeDailyViewModel timeDailyVm)
        {
            timeDaily.ID = timeDailyVm.ID;
            timeDaily.Time1 = timeDailyVm.Time1;
            timeDaily.Time2 = timeDailyVm.Time2;
            timeDaily.Time3 = timeDailyVm.Time3;
            timeDaily.Time4 = timeDailyVm.Time4;
            timeDaily.Time5 = timeDailyVm.Time5;
            timeDaily.Time6 = timeDailyVm.Time6;
        }
    }
}