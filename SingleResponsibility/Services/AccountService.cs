public class AccountService
{
    public void DepositMoney(Guid accountId, decimal amount) => Console.WriteLine("deposited");
    public void WithdrawMoney(Guid accountId, decimal amount) => Console.WriteLine("withdrawn");

}