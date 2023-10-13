namespace Decorator
{
	class SportsCar : BaseComponentCar
	{
		public SportsCar(string topSpeed) : base(topSpeed, 2)
		{
			// Intentionally left blank.
		}

		public override string GetDescription()
		{
			return "A fancy sportscar";
		}

		public override string GetTopSpeed()
		{
			return _topSpeed;
		}

		public override int GetPassengerSeatCount()
		{
			return _seatCount;
		}
	}
}