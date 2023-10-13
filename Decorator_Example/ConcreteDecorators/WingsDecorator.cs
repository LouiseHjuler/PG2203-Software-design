namespace Decorator
{
	class WingsDecorator : BaseDecoratorCar
	{
		public WingsDecorator(BaseComponentCar original) : base(original)
		{
			// Intentionally left blank.
		}

		public override string GetDescription()
		{
			return base.GetDescription() + " + wings";
		}

		public override string GetTopSpeed()
		{
			return $"{base.GetTopSpeed()}\n - Fly speed: {base.GetTopSpeed()}";
		}
	}
}