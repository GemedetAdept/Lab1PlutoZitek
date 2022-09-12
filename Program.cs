// Step 1: "Explore Integer Math"


void WorkWithIntegers(int inputX, int inputY) {

	Console.WriteLine("Input parameters:");
		Console.WriteLine($"> x = {inputX}");
		Console.WriteLine($"> y = {inputY}");

	int combined = 0;
		Console.WriteLine("Output variable initalized.");

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
int valueZ = 0;

Console.WriteLine("Input value for X:");
valueX = int.Parse(Console.ReadLine());

Console.WriteLine("Input value for Y:");
valueY = int.Parse(Console.ReadLine());

Console.WriteLine("Input value for Z:");
valueZ = int.Parse(Console.ReadLine());

WorkWithIntegers(valueX, valueY);


// Step 2: "Explore Order of Operations"


void OrderOfOperations(int inputX, int inputY, int inputZ) {

	Console.WriteLine("Input parameters:");
		Console.WriteLine($"> x = {inputX}");
		Console.WriteLine($"> y = {inputY}");
		Console.WriteLine($"> z = {inputZ}");

	int combined = 0;
		Console.WriteLine("Output variable initalized.");

	// Simple Order of Operations
	combined = inputX + inputY * inputZ;
		Console.WriteLine($"> {inputX} + {inputY} * {inputZ} = {combined}");

	// Directed Order of Operations
	combined = (inputX + inputY) * inputZ;
		Console.WriteLine($"> ({inputX} + {inputY}) * {inputZ} = {combined}");

	combined = (inputX - inputZ) / inputZ * inputY + (inputZ / inputY);
		Console.WriteLine($"> ({inputX} - {inputZ}) / {inputZ} * {inputY} + ({inputZ / inputY}) = {combined}");

}

Console.WriteLine("\n");
OrderOfOperations(valueX, valueY, valueZ);