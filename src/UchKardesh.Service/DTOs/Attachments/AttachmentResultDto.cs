namespace UchKardesh.Service.DTOs.Attachments;

public class AttachmentResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Path { get; set; }
    public long? UpdatedFrom { get; set; }
}