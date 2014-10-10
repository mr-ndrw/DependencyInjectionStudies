﻿using System.Collections.Generic;

namespace NinjectStudy.BLL.Entities
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Group> Groups { get; set; }
	}
}
