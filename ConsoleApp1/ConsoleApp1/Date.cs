using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
	internal class Date {
		private int month;
		public int Month {
			get { 
				return month; }
			set {
				if (value < 1 || value > 12)
					throw new ArgumentException("month must be between 1-12");
				month = value;
			} 
		}
	}
}
