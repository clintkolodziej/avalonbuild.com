using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace avalonbuild.com.Models
{
	public class Image
	{
		public Image()
		{
			Galleries = new List<GalleryImage>();
		}

		public int ID { get; set; }

        [Display(Name = "Name (optional)")]
        public string Name { get; set; }

        [Display(Name = "Title")]
		public string Title { get; set; }

        [Display(Name = "Description")]
		public string Description { get; set; }

		public string FileName { get; set; }

		public string ThumbnailFileName { get; set; }

		public List<GalleryImage> Galleries { get; set; }
	}
}