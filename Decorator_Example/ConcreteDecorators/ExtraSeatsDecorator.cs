namespace Decorator
{
	class ExtraSeatsDecorator : BaseDecoratorCar
	{
		public ExtraSeatsDecorator(BaseComponentCar original) : base(original)
		{
			// Intentionally left blank.
		}

		public override string GetDescription()
		{
			return base.GetDescription() + " + 2 extra seats";
		}

		public override int GetPassengerSeatCount()
		{
			return base.GetPassengerSeatCount() + 2;
		}
	}
}