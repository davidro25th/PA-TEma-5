using System;

public class Variable
{
	public Variable( string code )
	{
		this.code = code;
	}

	protected string name;
	protected string code;
	protected Measure_Units measure_Units;

	public string Name { get { return name; } };
	public string Code { get { return code; } };
	public string Measure_Units { get { return measure_Units; } };

}
