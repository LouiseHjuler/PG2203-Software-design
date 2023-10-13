namespace Decorator
{
	// NOTE: The base component might just as well be an interface as an abstract class. We could just remove 
	//       the variables and ctor from this one, and let the concrete components handle it. That apporach 
	//       would actually give cleaner decorators: As they don't use any base component variables anyway. 

	public abstract class BaseComponentCar
	{
        protected string _topSpeed;
        protected int _seatCount;

		public BaseComponentCar(string topSpeed = "", int seatCount = 0)
		{
				_topSpeed = topSpeed;
				_seatCount = seatCount;
		}

		public abstract string GetDescription();
        public abstract string GetTopSpeed();
        public abstract int GetPassengerSeatCount();
	}
}