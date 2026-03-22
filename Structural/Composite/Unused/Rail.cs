namespace Composite.Unused;

public class Rail
{
    public List<Attachment> Attachments { get; set; } = new();

    public void AddAttachment(Attachment attachment)
    {
        Attachments.Add(attachment);
    }

    public void ApplyStats()
    {
        Console.WriteLine("应用导轨属性");
        foreach (var attachment in Attachments)
        {
            attachment.ApplyStats();
        }
    }
}