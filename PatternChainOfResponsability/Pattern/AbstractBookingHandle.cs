using PatternChainOfResponsability.Model;

namespace PatternChainOfResponsability
{
    public abstract class AbstractBookingHandle : IBookingHandle
    {

        public IBookingHandle _successor;

        public abstract void Handle(ReservaEntity request);
        

        public IBookingHandle SetNext(IBookingHandle sucessor)
        {
            this._successor = sucessor;
            return _successor;
        }
    }
}