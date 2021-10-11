using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRESTexcercise.Models
{
	public class Item
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int ItemQuality { get; set; }
		public int Quantity { get; set; }

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
