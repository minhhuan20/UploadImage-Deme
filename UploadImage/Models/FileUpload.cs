namespace UploadImage.Models
{
    public class FileUpload
    {
        internal readonly string? FileName;

        public IFormFile files { get; set; }

        internal void SaveAs(object p)
        {
            throw new NotImplementedException();
        }
    }
}
