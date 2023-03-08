Console.WriteLine("Welcome to the BMI calculator application.");
Console.WriteLine("__________________________________________\n");

Console.WriteLine("Which version would you like to use : \n");
Console.WriteLine("1. Standard");
Console.WriteLine("2. Metric\n");
double weight, height, heightInInches, IBMI = 0;
decimal BMI;
string versionType = Console.ReadLine();

switch (versionType)
{
    case "1":
        Console.Write("Enter your weight in pounds (lbs): - ");
        weight = double.Parse(Console.ReadLine());

        Console.Write("\nEnter your height in inches: - ");
        height = double.Parse(Console.ReadLine());

        heightInInches = Math.Pow(height, 2);
        IBMI = (weight / heightInInches) * 703;

        switch (IBMI)
        {
            case < 18.5:
                BMI = Convert.ToDecimal(IBMI);
                BMI = Math.Round(BMI, 2);
                Console.WriteLine($"\nYour Body Mass Index (BMI) is; {BMI}\n");
                Console.WriteLine("Weight Status: Under Weight.");

                break;

            case < 25.0:
                BMI = Convert.ToDecimal(IBMI);
                BMI = Math.Round(BMI, 2);
                Console.WriteLine($"\nYour Body Mass Index (BMI) is; {BMI}\n");
                Console.WriteLine("Weight Status: Healthy Weight.");
                break;

            case < 30.0:
                BMI = Convert.ToDecimal(IBMI);
                BMI = Math.Round(BMI, 2);
                Console.WriteLine($"\nYour Body Mass Index (BMI) is; {BMI}\n");
                Console.WriteLine("Weight Status: OverWeight.");

                break;

            case >= 30.0:
                BMI = Convert.ToDecimal(IBMI);
                BMI = Math.Round(BMI, 2);
                Console.WriteLine($"\nYour Body Mass Index (BMI) is; {BMI}\n");
                Console.WriteLine("Weight Status: Obesity.");

                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }

        Console.WriteLine();
        break;

    // second case: measurement for metric version
    case "2":

        Console.Write("Enter your weight in kilograms (kg): - ");
        weight = double.Parse(Console.ReadLine());

        Console.Write("\nEnter your height in metres: - ");
        height = double.Parse(Console.ReadLine());

        IBMI = weight / Math.Pow(height, 2);

        switch (IBMI)
        {
            case < 18.5:
                BMI = Convert.ToDecimal(IBMI);
                BMI = Math.Round(BMI, 2);
                Console.WriteLine($"\nYour Body Mass Index (BMI) is; {BMI}\n");
                Console.WriteLine("Weight Status: Under Weight.");

                break;

            case < 25.0:
                BMI = Convert.ToDecimal(IBMI);
                BMI = Math.Round(BMI, 2);
                Console.WriteLine($"\nYour Body Mass Index (BMI) is; {BMI}\n");
                Console.WriteLine("Weight Status: Healthy Weight.");
                break;

            case < 30.0:
                BMI = Convert.ToDecimal(IBMI);
                BMI = Math.Round(BMI, 2);
                Console.WriteLine($"\nYour Body Mass Index (BMI) is; {BMI}\n");
                Console.WriteLine("Weight Status: OverWeight.");

                break;

            case >= 30.0:
                BMI = Convert.ToDecimal(IBMI);
                BMI = Math.Round(BMI, 2);
                Console.WriteLine($"\nYour Body Mass Index (BMI) is; {BMI}\n");
                Console.WriteLine("Weight Status: Obesity.");

                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
        break;

    default:
        Console.WriteLine("Invalid input!");
        break;
}
Console.ReadLine();