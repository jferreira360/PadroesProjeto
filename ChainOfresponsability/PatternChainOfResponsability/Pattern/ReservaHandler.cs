using PatternChainOfResponsability.Model;

namespace PatternChainOfResponsability
{
    public class ReservaHandler : AbstractBookingHandle
    {
        public override void Handle(ReservaEntity reserva)
        {
            //Realiza os procedimentos de efetivacao da reserva
            Console.WriteLine("Executando efetivacao da reserva");

            //Verifica se existe algo a ser executado na sequencia
            //se houver, chama o próximo na cadeia de execução
            if (_successor != null)
                _successor.Handle(reserva);

        }
    }
}
