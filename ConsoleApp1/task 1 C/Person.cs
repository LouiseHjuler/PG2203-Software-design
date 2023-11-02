using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace task_1_C {
	internal class Person {
		private string _firstName;
		private string _lastName;

		public string MiddleName { get; set; } // kan benyttes hvis variabelen (som er gemt) ikke skal behandles/tjekkes inden brug

		public string FirstName { 
			get { 
				return _firstName; } 
			set { 
				_firstName = value; } }
		public string LastName { 
			get {
				if (string.IsNullOrEmpty(_lastName)) {
					return "<last name not set>";
				}
				return _lastName;} 
			set { _lastName = value.Trim(); } }

		public string FullName { 
			get { 
				return FirstName + " " + LastName; } }
	}
}
