using System.Data.Entity;
using NinjectStudy.BLL;

namespace NinjectStudy.DAL
{
	public class FlowPostDataContext : DbContext, IFlowPostDataContext
	{
		public DbSet<User> Users { get; set; }

	}
}