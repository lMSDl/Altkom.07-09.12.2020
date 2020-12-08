namespace WPCSharp.DesignPatterns.Structural.Facade.II
{
    public interface IPaymentService
    {
        void Pay(int cartId, float amount);
    }
}