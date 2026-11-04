using System;
namespace VotingApp
{
	public class InvalidAgeException:Exception
	{
		public InvalidAgeException(string message):base(message)
		{
			
		}
	}
}

