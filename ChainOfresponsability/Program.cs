// See https://aka.ms/new-console-template for more information
using PatternChainOfResponsability;
using PatternChainOfResponsability.Model;

Console.WriteLine("Iniciando o procedimento");

AbstractBookingHandle handleDisponibilidade = new DisponibilidadeHandler();
AbstractBookingHandle handlePagamento = new PagamentoHandler();
AbstractBookingHandle handleReserva = new ReservaHandler();

var entity = new ReservaEntity
{
    IdReserva = new Guid(),
    DataReserva = DateTime.Now,
    PeriodoReservaDe = DateTime.Now.AddDays(5),
    PeriodoReservaAte = DateTime.Now.AddDays(15),
    QtdeHospedes = 2,
    ReservaPaga = true
};


//Se o cliente deseja pagar a reserva, a cadeia de execução incluirá o pagamento
//senão, apenas vai fazer a reserva sem pagamento

Console.WriteLine("Executando a reserva de um cliente que deseja pagar a reserva:");

Console.WriteLine();
if (entity.ReservaPaga)
{
    handleDisponibilidade.SetNext(handlePagamento);
    handlePagamento.SetNext(handleReserva);
}
else
{
    handleDisponibilidade.SetNext(handleReserva);
}

handleDisponibilidade.Handle(entity);
Console.WriteLine();
Console.WriteLine("*=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=*");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Executando a reserva de um cliente que não deseja pagar a reserva");

Console.WriteLine();

entity.ReservaPaga = false;

if (entity.ReservaPaga)
{
    handleDisponibilidade.SetNext(handlePagamento);
    handlePagamento.SetNext(handleReserva);
}
else
{
    handleDisponibilidade.SetNext(handleReserva);
}

handleDisponibilidade.Handle(entity);
Console.WriteLine();
Console.WriteLine("*=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=**=*");
Console.WriteLine("FIM");



Console.ReadKey();
