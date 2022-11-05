public class Bird : Animal , IFlyable , IRunnable
{
  public void Run()
  {
    System.Console.WriteLine("Bird runs...");
  } 

  public void Fly()
  {
    System.Console.WriteLine("Bird flies...");
  }
}