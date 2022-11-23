public interface IHuman : IOmnivore , IFeedable
{
    void Eat();
    void Talk();
    void Walk();
    void Sleep();
    void Run();
}