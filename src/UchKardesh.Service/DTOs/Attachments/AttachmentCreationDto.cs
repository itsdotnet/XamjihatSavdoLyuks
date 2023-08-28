using Microsoft.AspNetCore.Http;

namespace UchKardesh.Service.DTOs.Attachments;

public class AttachmentCreationDto
{
    public IFormFile FormFile { get; set; }
    public long? UpdatedFrom { get; set; }
}