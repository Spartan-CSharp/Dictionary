Dictionary<string, string> employees = new Dictionary<string, string>();

bool done = false;

do
{
	string? employeeId;
	string? employeeName;

	do
	{
		Console.Write("Enter Employee ID: ");
		employeeId = Console.ReadLine();
	} while ( string.IsNullOrWhiteSpace(employeeId) );

	do
	{
		Console.Write("Enter Employee Name: ");
		employeeName = Console.ReadLine();
	} while ( string.IsNullOrWhiteSpace(employeeName) );

	try
	{
		employees.Add(employeeId, employeeName);
	}
	catch ( ArgumentException ex )
	{
		Console.WriteLine(ex.Message);
	}

	Console.Write("Add another (yes/no): ");
	string? addAnother = Console.ReadLine();

	if ( addAnother?.ToLower() == "no" )
	{
		done = true;
	}
} while ( !done );

Console.WriteLine();

string? empId;

do
{
	Console.Write("Enter your Employee ID: ");
	empId = Console.ReadLine();
} while ( string.IsNullOrWhiteSpace(empId) );

try
{
	Console.WriteLine($"Welcome {employees[empId]}!");
}
catch ( KeyNotFoundException ex )
{
	Console.WriteLine(ex.Message);
}
