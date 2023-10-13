using System;

namespace Decorator
{
	class Program
	{
		public static void Main()
		{
			BaseComponentCar volvo = new MidsizeCar("240 km/h");
			BaseComponentCar porsche = new SportsCar("310 km/h");
			BaseComponentCar jetEngineVolvo = new JetEngineDecorator(volvo);
			BaseComponentCar extraSeatsVolvo = new ExtraSeatsDecorator(volvo);
			BaseComponentCar veryFastPorsche = new JetEngineDecorator(porsche);
			BaseComponentCar extraExtraSeatsVolvo = new ExtraSeatsDecorator(extraSeatsVolvo);
			BaseComponentCar flyingVeryFastPorsche = new WingsDecorator(veryFastPorsche);

			PrintCarInformation(volvo);
			PrintCarInformation(porsche);
			PrintCarInformation(jetEngineVolvo);
			PrintCarInformation(extraSeatsVolvo);
			PrintCarInformation(veryFastPorsche);
			PrintCarInformation(extraExtraSeatsVolvo);
			PrintCarInformation(flyingVeryFastPorsche);
		}

		private static void PrintCarInformation(BaseComponentCar car)
		{
			Console.WriteLine($"{car.GetDescription()}:");
			Console.WriteLine($" - Top speed: {car.GetTopSpeed()}");
			Console.WriteLine($" - Passenger seat count: {car.GetPassengerSeatCount()}\n");
		}
	}
}