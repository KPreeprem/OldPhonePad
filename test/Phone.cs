using System;
using System.Text; // For StringBuilder class

public class Phone // Class Definition
{
	public static String OldPhonePad(string input) //Method
    {
		/*
		 * Create StringBuilder Object to store input valued that's interpreted into texts
		 */
		StringBuilder sb = new StringBuilder();
		char prevChar = '\0';
		int count = 0;

		foreach (char c in input)
        {
			/* 
			 * Set up count to 1 and have the first character read stored 
			 * in the variable prevChar
			 */
			if (count == 0) 
			{
				count = 1;
				prevChar = c;
				continue; //End the code block in the loop of the first character read
			}

			/*
			 * The value of the current character can be compared to the previous one
			 */
			if (c == prevChar)
			{
				/*
				 * Increase count if the condition is true
				 */
				count++; 
				continue; //End the code block in the loop => read next character
			}

			/*
			 * If the if statement above is false, proceed to the switch statement below.
			 * Use prevChar variable as the expression to account for the first character read
			 */
			switch(prevChar) 
			{
				/*
				 * Assign each case that's related to the old phone pad.
				 * Use if statement to output the right letter from the same number
				 */
				case '1':
					if (count == 1)
						sb.Append('&');
					if (count == 2)
						sb.Append(',');
					if (count == 3)
						sb.Append('(');

					/*
					 * Store the current character to the prevChar Variable 
					 * for the next loop comparison
					 */
					prevChar = c;

					/*
					 * Reset Count to 1 to skip the first if statement in foreach loop
					 */
					count = 1;
					continue;

				case '2':
					if (count == 1)
						sb.Append('A');
					if (count == 2)
						sb.Append('B');
					if (count == 3)
						sb.Append('C');
					prevChar = c;
					count = 1;
					continue;

				case '3':
					if (count == 1)
						sb.Append('D');
					if (count == 2)
						sb.Append('E');
					if (count == 3)
						sb.Append('F');
					prevChar = c;
					count = 1;
					continue;

				case '4':
					if (count == 1)
						sb.Append('G');
					if (count == 2)
						sb.Append('H');
					if (count == 3)
						sb.Append('I');
					prevChar = c;
					count = 1;
					continue;

				case '5':
					if (count == 1)
						sb.Append('J');
					if (count == 2)
						sb.Append('K');
					if (count == 3)
						sb.Append('L');
					prevChar = c;
					count = 1;
					continue;

				case '6':
					if (count == 1)
						sb.Append('M');
					if (count == 2)
						sb.Append('N');
					if (count == 3)
						sb.Append('O');
					prevChar = c;
					count = 1;
					continue;

				case '7':
					if (count == 1)
						sb.Append('P');
					if (count == 2)
						sb.Append('Q');
					if (count == 3)
						sb.Append('R');
					if (count == 4)
						sb.Append('S');
					prevChar = c;
					count = 1;
					continue;

				case '8':
					if (count == 1)
						sb.Append('T');
					if (count == 2)
						sb.Append('U');
					if (count == 3)
						sb.Append('V');
					prevChar = c;
					count = 1;
					continue;

				case '9':
					if (count == 1)
						sb.Append('W');
					if (count == 2)
						sb.Append('X');
					if (count == 3)
						sb.Append('Y');
					if (count == 4)
						sb.Append('Z');
					prevChar = c;
					count = 1;
					continue;

				case '*':
					sb.Length--;
					prevChar = c;
					count = 1;
					continue;

				case '0':
					if (count == 1)
						sb.Append(' ');
					prevChar = c;
					count = 1;
					continue;

				case ' ':
					prevChar = c;
					count = 1;
					continue;

				case '#':
					break;
			}
        }
		/*
		 * Convert the stored values in StringBuilder into String texts
		 */
		return sb.ToString(); 
	}
}
