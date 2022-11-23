public interface IAnimal : IOmnivore , IFeedable
{
  void Bark();
  void Walk();
  void Sleep();
  void Run();
  void Bite();
}