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

// Step 3: "Explore integer precision and limits"


void IntegerPrecision (int inputX, int inputY, int inputZ) {

	Console.WriteLine("Input parameters:");
		Console.WriteLine($"> x = {inputX}");
		Console.WriteLine($"> y = {inputY}");
		Console.WriteLine($"> z = {inputZ}");

	// Return the quotient via integer division and the remainder via modulo operation
	int quotientResult = (inputX + inputY) / inputZ;
	int remainderResult = (inputX + inputY) % inputZ;

	Console.WriteLine($"\nFor the equation ({inputX} + {inputY}) / {inputZ} :");
		Console.WriteLine($"> Quotient = {quotientResult}");
		Console.WriteLine($"> Remainder = {remainderResult}");

	// Print the maximum and minimum value allowed by an integer type
	int upperLimit = int.MaxValue;
	int lowerLimit = int.MinValue;
	Console.WriteLine($"\nAn integer literal can be any number between {lowerLimit} and {upperLimit}");

	// Demonstrate the overflow effect of trying to go above the upper integer limit
	int overflowExample = upperLimit + 3;
	Console.WriteLine($"\nWhen any value is added over the maxium integer value, an overflow occurs.");
	Console.WriteLine($"For example > {overflowExample}");

}

Console.WriteLine("\n");
IntegerPrecision(valueX, valueY, valueZ);

// Step 4: "Work with the double type"


void DoubleType (int inputX, int inputY, int inputZ) {

	Console.WriteLine("Input parameters:");
		Console.WriteLine($"> x = {inputX}");
		Console.WriteLine($"> y = {inputY}");
		Console.WriteLine($"> z = {inputZ}");

	double doubleX = 0.0;
	double doubleY = 0.0;
	double doubleZ = 0.0;

	// Cast the inputted integers to double
	doubleX = (double)inputX;
	doubleY = (double)inputY;
	doubleZ = (double)inputZ;

	Console.WriteLine("Converted input integers to double type.");

	double combined = (doubleX + doubleY) / doubleZ;
	Console.WriteLine($"\n({doubleX} + {doubleY}) / {doubleZ} = {combined}");

	// Print the maximum and minimum value allowed by a double type
	double upperLimit = double.MaxValue;
	double lowerLimit = double.MinValue;
	Console.WriteLine($"\nA double literal can be any number between {lowerLimit} and {upperLimit}");

	double oneThird = 1.0 / 3.0;
	Console.WriteLine("\nAn example of the precision of double arithmetic:");
	Console.WriteLine($"{oneThird}");

}

Console.WriteLine("\n");
DoubleType(valueX, valueY, valueZ);
