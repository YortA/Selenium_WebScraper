using Microsoft.EntityFrameworkCore;
using ScrapeNETAccessLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapeNETAccessLib.DataAccess
{
	public class ProductInfoContext : DbContext
	{
		public ProductInfoContext(DbContextOptions options) : base(options) { }
		public DbSet<ProductInfo> ProductInfo { get; set; }
	}
}
