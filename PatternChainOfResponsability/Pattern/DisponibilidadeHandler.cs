using PatternChainOfResponsability.Model;

namespace PatternChainOfResponsability
{
    public class DisponibilidadeHandler : AbstractBookingHandle
    {
        public override void Handle(ReservaEntity reserva)
        {
            //Realiza os procedimentos de consulta de disponibilidade da reserva
            Console.WriteLine("Consultando a disponibilidade da reserva");
            
            //Verifica se existe algo a ser executado na sequencia
            //se houver, chama o próximo na cadeia de execução
            if(_successor != null)
                _successor.Handle(reserva);

        }
    }
}
