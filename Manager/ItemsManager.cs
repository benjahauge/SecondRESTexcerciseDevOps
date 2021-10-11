using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstRESTexcercise.Models;

namespace FirstRESTexcercise.Manager
{0
	public class ItemsManager
	{
		private static int _nextId = 1;
		public List<Item> Data = new List<Item>
		{
			new Item {ID = _nextId++, Name = "C#", ItemQuality = 9, Quantity = 10},
			new Item {ID = _nextId++, Name = "Python", ItemQuality = 10, Quantity = 1}
			// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
		};

		public List<Item> GetAll(string substring)
		{
			if (substring != null)
			{
				Data = Data.FindAll(item => item.Name.Contains(substring, StringComparison.OrdinalIgnoreCase));
			}
			return Data;
			// copy constructor
			// Callers should no get a reference to the Data object, but rather get a copy
		}

		public Item GetById(int id)
		{
			return Data.Find(item => item.ID == id);
		}

		public Item Add(Item newItem)
		{
			newItem.ID = _nextId++;
			Data.Add(newItem);
			return newItem;
		}

		public Item Delete(int id)
		{
			Item item = Data.Find(item1 => item1.ID == id);
			if (item == null) return null;
			Data.Remove(item);
			return item;
		}

		public Item Update(int id, Item updates)
		{
			Item item = Data.Find(item1 => item1.ID == id);
			if (item == null) return null;
			item.Name = updates.Name;
			item.Quantity = updates.Quantity;
			return item;
		}
    }
}
