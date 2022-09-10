using PatternChainOfResponsability.Model;

namespace PatternChainOfResponsability
{
    public interface IBookingHandle
    {
        IBookingHandle SetNext(IBookingHandle handler);
        public void Handle(ReservaEntity request);
    }
}
