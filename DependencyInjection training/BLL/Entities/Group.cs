
using System.Collections;
using System.Collections.Generic;

namespace NinjectStudy.BLL.Entities
{
	public class Group
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<User> Users { get; set; }
	}
}
