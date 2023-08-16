using BtkAkademi.Services.Email.Messages;

namespace BtkAkademi.Services.Email.Repository
{
    public interface IEmailRepository
    {
        //Task SendAndLogEmail(UpdatePaymentResultMessage message);
        void SendAndLogEmail(UpdatePaymentResultMessage message);
    }
}
