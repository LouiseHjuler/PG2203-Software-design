namespace Decorator
{
	abstract class BaseDecoratorCar : BaseComponentCar
	{
		private readonly BaseComponentCar _original;

		protected BaseDecoratorCar(BaseComponentCar original)
		{
			_original = original;
		}

		public override string GetDescription()
		{
			return _original.GetDescription();
		}

		public override string GetTopSpeed()
		{
			return _original.GetTopSpeed();
		}

		public override int GetPassengerSeatCount()
		{
			return _original.GetPassengerSeatCount();
		}
	}
}