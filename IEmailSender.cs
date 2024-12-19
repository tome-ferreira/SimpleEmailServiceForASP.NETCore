namespace GateKeeperV1.Services.ServicoEmail
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
