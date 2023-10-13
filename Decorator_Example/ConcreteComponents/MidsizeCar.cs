namespace Decorator
{
	public class MidsizeCar : BaseComponentCar
	{
		public MidsizeCar(string topSpeed) : base(topSpeed, 5)
		{
			// Intentionally left blank.
		}

		public override string GetDescription()
		{
			return "A typical mid-size car";
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