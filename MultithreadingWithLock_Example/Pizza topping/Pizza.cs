using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Pizza {
	public string Name { get; set; } = "";
	protected double _price;
	protected string _description = "";
	public abstract double GetPrice();
	public abstract string GetDescription();
	public abstract string GetName();
}