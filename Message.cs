using MimeKit;

namespace GateKeeperV1.Services.ServicoEmail
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public TextPart Content { get; set; }

        public Message(IEnumerable<string> to, string subject, TextPart content)
        {
            To = new List<MailboxAddress>();

            To.AddRange(to.Select(x => new MailboxAddress("", x)));
            Subject = subject;
            Content = content;
        }
    }
}
