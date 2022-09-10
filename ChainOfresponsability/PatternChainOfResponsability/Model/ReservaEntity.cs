namespace PatternChainOfResponsability.Model
{
    public class ReservaEntity
    {
        public Guid IdReserva { get; set; }
        public int QtdeHospedes { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime PeriodoReservaDe { get; set; }
        public DateTime PeriodoReservaAte { get; set; }
        public bool ReservaPaga { get; set; }

    }
}
