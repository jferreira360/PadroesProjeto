using PatternChainOfResponsability.Model;

namespace PatternChainOfResponsability
{
    public class PagamentoHandler : AbstractBookingHandle
    {
        public override void Handle(ReservaEntity reserva)
        {
            //Realiza os procedimentos Pagamento da reserva
            Console.WriteLine("Executando ações de pagamento da reserva");

            //Verifica se existe algo a ser executado na sequencia
            //se houver, chama o próximo na cadeia de execução
            if (_successor != null)
                _successor.Handle(reserva);

        }
    }
}
