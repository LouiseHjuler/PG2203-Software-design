namespace Decorator
{
	class JetEngineDecorator : BaseDecoratorCar
	{
		public JetEngineDecorator(BaseComponentCar original) : base(original)
		{
			// Intentionally left blank.
		}

		public override string GetDescription()
		{
			return base.GetDescription() + " + jet engine";
		}

		public override string GetTopSpeed()
		{
			return "1000 km/h";
		}
	}
}