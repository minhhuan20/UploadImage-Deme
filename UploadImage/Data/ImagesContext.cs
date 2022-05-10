using Microsoft.EntityFrameworkCore;
using UploadImage.Models;

namespace UploadImage.Data
{
    public class ImagesContext : DbContext
    {
        public ImagesContext(DbContextOptions<ImagesContext> opt) : base(opt)
        {

        }
        public DbSet<FileUpload> files { get; set; }

    }
}
