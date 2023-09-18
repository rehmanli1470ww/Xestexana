using System;
using System.Collections.Generic;


namespace Xestexana
{




   

    public class Program
    {
        static Dictionary<string, List<string>> appointments = new Dictionary<string, List<string>>();

        static void MakeAppointment()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            string phone = Console.ReadLine();

            Console.WriteLine("Select a choice:");
            int wardChoice;


            List<Doctor> doctors = new List<Doctor>
        {
            new PediatricsDoctor("Dr. Ali Work experience: 2 year"),
            new PediatricsDoctor("Dr. Mehemmed Work experience: 4 year"),
            new PediatricsDoctor("Dr. Rubail Work experience: 7 year"),
            new TraumatologyDoctor("Dr. İsa Work experience: 11 month"),
            new TraumatologyDoctor("Dr. Pervin Work experience: 4 year"),
            new DentistryDoctor("Dr. Muhammed Work experience: 2 month"),
            new DentistryDoctor("Dr. İsmayil Work experience: 5 year"),
            new DentistryDoctor("Dr. Samir Work experience: 3 year"),
            new DentistryDoctor("Dr. Fariz Work experience: 1 year")
        };

            for (int i = 0; i < doctors.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {doctors[i].Specialty} - {doctors[i].Name}");
            }

            if (int.TryParse(Console.ReadLine(), out wardChoice) && wardChoice >= 1 && wardChoice <= doctors.Count)
            {
                Doctor selectedDoctor = doctors[wardChoice - 1];

                if (!appointments.ContainsKey(selectedDoctor.Name))
                {
                    appointments[selectedDoctor.Name] = new List<string>();
                }

                List<string> availableHours = new List<string> { "09:00-11:00", "12:00-14:00", "15:00-17:00" };
                Console.WriteLine("Available appointment hours:");
                for (int i = 0; i < availableHours.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {availableHours[i]}");
                }

                int hourChoice;
                Console.Write("Enter the number of the hour: ");
                if (int.TryParse(Console.ReadLine(), out hourChoice) && hourChoice >= 1 && hourChoice <= availableHours.Count)
                {
                    string selectedHour = availableHours[hourChoice - 1];

                    if (!appointments[selectedDoctor.Name].Contains(selectedHour))
                    {
                        appointments[selectedDoctor.Name].Add(selectedHour);
                        Console.WriteLine($"Thank you, {name} {surname}, you set the appointment for {selectedDoctor.Name} at {selectedHour}.");
                    }
                    else
                    {
                        Console.WriteLine("This hour is already reserved. Please choose another hour.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid hour selection.");
                }
            }
            else
            {
                Console.WriteLine("Invalid doctor selection.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to our Hospital");
                MakeAppointment();
            }
        }
    }



}