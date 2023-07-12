using NServiceBus;

public class DepositoCommand : ICommand
{

    public int AccountId { get; set; }
    public decimal Amount { get; set; }

}