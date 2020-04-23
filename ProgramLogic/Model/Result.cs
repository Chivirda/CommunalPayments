using System;

namespace ProgramLogic.Model
{
    class Result
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HouseId { get; set; }
        public virtual House House { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int RateId { get; set; }
        public virtual Rate Rate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string ToString()
        {
            return $"Расчёт стоимости платежа за услуги ЖКХ для квартиры {Room.Name}, площадью {Room.Area} в доме {House.Name}, за период с {StartDate.ToString("dd.MM.yy")} по {EndDate.ToString("dd.MM.yy")}";
        }
    }
}
