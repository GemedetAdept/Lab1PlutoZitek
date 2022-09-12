void WorkWithIntegers(int inputX, int inputY) {

	Console.WriteLine("Input parameters:");
	Console.WriteLine($"> x = {inputX}");
	Console.WriteLine($"> y = {inputY}");

	int combined = 0;
		Console.WriteLine("Output value initalized.");

	combined = inputX + inputY; // Addition
		Console.WriteLine($"> {inputX} + {inputY} = {combined}");

	combined = inputX - inputY; // Subtraction
		Console.WriteLine($"> {inputX} - {inputY} = {combined}");

	combined = inputX * inputY; // Multiplication
		Console.WriteLine($"> {inputX} * {inputY} = {combined}");

	combined = inputX / inputY; // Division
		Console.WriteLine($"> {inputX} / {inputY} ≈ {combined}");

}


int valueX = 0;
int valueY = 0;

Console.WriteLine("Input value for X:");
valueX = int.Parse(Console.ReadLine());

Console.WriteLine("Input value for Y:");
valueY = int.Parse(Console.ReadLine());

WorkWithIntegers(valueX, valueY);
