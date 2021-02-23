using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapeNETAccessLib.Models
{
	public class ProductInfo
	{
		public string PURL { get; set; }
		public string Sku { get; set; }
		public string Model { get; set; }
		public string Brand { get; set; }
		public string Title { get; set; }
		public float Price { get; set; }
		public bool InStock { get; set; }

	}
}
