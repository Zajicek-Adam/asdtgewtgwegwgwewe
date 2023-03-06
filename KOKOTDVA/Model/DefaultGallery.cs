using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KOKOTDVA.Model
{
    public class DefaultGallery : Gallery
    {
        public User GalleryUser { get; set; }

        [Key]
        public Guid DGalleryId;

    }
}
