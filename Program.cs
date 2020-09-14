using System;
using System.Text.RegularExpressions;

namespace FooBarQix
{
				class Program
				{
								static void Main(string[] args)
								{
												Console.WriteLine(FooBarQix("1"));
												Console.WriteLine(FooBarQix("2"));
												Console.WriteLine(FooBarQix("3"));
												Console.WriteLine(FooBarQix("4"));
												Console.WriteLine(FooBarQix("5"));

												Console.WriteLine(FooBarQix("6"));
												Console.WriteLine(FooBarQix("7"));
												Console.WriteLine(FooBarQix("8"));
												Console.WriteLine(FooBarQix("9"));
												Console.WriteLine(FooBarQix("10"));

												Console.WriteLine(FooBarQix("13"));
												Console.WriteLine(FooBarQix("15"));
												Console.WriteLine(FooBarQix("21"));
												Console.WriteLine(FooBarQix("33"));
												Console.WriteLine(FooBarQix("51"));

												Console.WriteLine(FooBarQix("53"));
												Console.WriteLine(FooBarQix("101"));
												Console.WriteLine(FooBarQix("303"));
												Console.WriteLine(FooBarQix("105"));
												Console.WriteLine(FooBarQix("10101"));
								}

								public static string FooBarQix(string line)
								{
												int number = Convert.ToInt32(line);
												line = line.Trim();
												string copy = line;

												line = line.Replace("3", "Foo");
												line = line.Replace("5", "Bar");
												line = line.Replace("7", "Qix");

												if (line.Length != copy.Length) line = Regex.Replace(line, "[1-9]", string.Empty);

												if (number % 7 == 0) line = "Qix" + Regex.Replace(line, "[1-9]", string.Empty);
												if (number % 5 == 0) line = "Bar" + Regex.Replace(line, "[1-9]", string.Empty);
												if (number % 3 == 0) line = "Foo" + Regex.Replace(line, "[1-9]", string.Empty);

												// A *new* business requirement to keep a trace of 0 in numbers, so that 10 now translates to Bar*.
												line = line.Replace("0", "*");

												return line;
								}

				}
}
