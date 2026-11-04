using System;
namespace VotingApp
{
	public class AgeEligable
	{
		public void CheckAge()
		{
            Console.Write("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 16)
            {
                throw new InvalidAgeException("\nYou are not eligable to vote.");
            }
            Console.WriteLine("\nYou're eligable to vote.");

        }
	}
}

