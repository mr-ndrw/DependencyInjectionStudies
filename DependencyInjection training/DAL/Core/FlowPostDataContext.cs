using System.Data.Entity;
using NinjectStudy.BLL;
using NinjectStudy.BLL.Entities;
using NinjectStudy.DAL.Interfaces;

namespace NinjectStudy.DAL
{
	public class FlowPostDataContext : DbContext, IFlowPostDataContext
	{
		//public FlowPostDataContext() 
		//	:base("name=FlowPost")
		//{ }
		public DbSet<User> Users { get; set; }
		public DbSet<Group> Groups { get; set; }
	}
}