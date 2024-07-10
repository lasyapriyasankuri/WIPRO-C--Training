using System;
class Patient
{
    public int PatientId { get; set; }
    public string PatientName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool IsInsured { get; set; }
    public string ContactNumber { get; set; }
}

class Program
{
    static void Main()
    {
        Patient patient = new Patient();
        Console.WriteLine(" enter Patient ID: ");
        patient.PatientId = int.Parse(Console.ReadLine());
        Console.WriteLine("enter Name: ");
        patient.PatientName = Console.ReadLine();
        Console.WriteLine("enter age: ");
        patient.Age = int.Parse(Console.ReadLine());
        Console.WriteLine("enter gender: ");
        patient.Gender = Console.ReadLine();
        Console.WriteLine("enter weight in kg: ");
        patient.Weight = double.Parse(Console.ReadLine());
        Console.WriteLine("enter height in cm: ");
        patient.Height = double.Parse(Console.ReadLine());
        Console.WriteLine("enter DAte of birth (yyyy-mm-dd): ");
        patient.DateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(" is the patient insures(true/false): ");
        patient.IsInsured = bool.Parse(Console.ReadLine());
        Console.WriteLine("enter contact number: ");
        patient.ContactNumber = Console.ReadLine();

        Console.WriteLine("\nPatient Details: ");
        Console.WriteLine($"Id: {patient.PatientId}");
        Console.WriteLine($"Name: {patient.PatientName}");
        Console.WriteLine($"Age:{patient.Age}");
        Console.WriteLine($"Gender: {patient.Gender}");
        Console.WriteLine($"Weight: {patient.Weight}");
        Console.WriteLine($"Height: {patient.Height}");
        Console.WriteLine($"Date Of Birth: {patient.DateOfBirth.ToString()}");
        Console.WriteLine($"Isured: {patient.IsInsured}");
        Console.WriteLine($"Contact Number: {patient.ContactNumber}");
    }
}
