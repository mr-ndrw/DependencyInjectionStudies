using System;
using System.Reflection;
using Ninject;
using NinjectStudy.BLL;

namespace NinjectStudy
{
	internal interface ILogger
	{
		string logMessage(string message);
	}

	internal interface INumberPrepender
	{
		string PrependANumber(string message);
	}

	internal class FileLogger : ILogger
	{
		private INumberPrepender _numberPrepender;

		public FileLogger(INumberPrepender numberPrepender)
		{
			_numberPrepender = numberPrepender;
		}
		public string logMessage(string message)
		{
			return _numberPrepender.PrependANumber(string.Format("File: {0}", message));
		}
	}

	internal class SMSLogger : ILogger
	{
		private INumberPrepender _numberPrepender;

		public SMSLogger(INumberPrepender numberPrepender)
		{
			_numberPrepender = numberPrepender;
		}

		public string logMessage(string message)
		{
			return _numberPrepender.PrependANumber(string.Format("SMS: {0}", message));
		}
	}

	internal class ZeroesPrepender : INumberPrepender
	{
		public string PrependANumber(string message)
		{
			return string.Format("000 {0}", message);
		}
	}

	internal class OnesPrepender : INumberPrepender
	{
		public string PrependANumber(string message)
		{
			return string.Format("000 {0}", message);
		}
	}

	internal class Service
	{
		private readonly ILogger _logger;

		[Inject]
		public Service(ILogger logger)
		{
			_logger = logger;
		}

		public string SendMessage(string message)
		{
			return _logger.logMessage(message);
		}
	}










	public class Program
	{
		private static void Main(string[] args)
		{
			var kernel = new StandardKernel();
			kernel.Load(Assembly.GetExecutingAssembly());

			IFlowPostServices services = kernel.Get<IFlowPostServices>();

			Console.ReadKey();
		}
	}
}