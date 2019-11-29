using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace uusproov
{
	class Resolution
	{
		public static int Count = 0;

		public string description;

		public Resolution(string _description)
		{
			description = _description;
			Count++;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Kirjuta oma uue aasta lubadused eraldatuna komadega: ");
			string kasutajaLubadus = Console.ReadLine();

			string[] kasutajaList = kasutajaLubadus.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

			List<Resolution> uueAastaLubadus = new List<Resolution>();

			Resolution kasutajaLubadus2 = new Resolution(kasutajaLubadus);
			uueAastaLubadus.Add(kasutajaLubadus2);
			int i = 1;
			foreach (Resolution item in uueAastaLubadus)
			{
				Console.WriteLine($"lubadused on: {item.description}");
			}

			List<string> lines = new List<string>();

			foreach (Resolution item in uueAastaLubadus)
			{
				lines.Add($"{item.description}");
			}

			Console.WriteLine("Lisa lubadused faili: ");

			string filePath = @"C:\Demo\uusaastalubadused.txt";

			File.WriteAllLines(filePath, lines);

			Console.WriteLine("Lisa veel lubadus: ");
			string kasutajaUusSisend = Console.ReadLine();

			Resolution kasutajaLubadus3 = new Resolution(kasutajaUusSisend);
			uueAastaLubadus.Add(kasutajaLubadus3);

			Console.WriteLine("Uuendatud lubadused: ");

			foreach (Resolution lubadus in uueAastaLubadus)
			{
				Console.WriteLine($"Lubadused {i} on: {lubadus.description}");
				i++;
			}

			List<string> outputToWriteToFile = new List<string>();
			foreach (Resolution lubadus in uueAastaLubadus)
			{
				outputToWriteToFile.Add($"{lubadus.description}");
			}

			Console.WriteLine("Lisa lubadused faili: ");
			File.WriteAllLines(filePath, outputToWriteToFile);

			Console.WriteLine("Sinu lubadus on lisatud");

			Console.WriteLine("Eemalda lubadus: "); //see osa ei tööta
			string eemaldatavLubadus = Console.ReadLine();
			Resolution kasutajaLubadus4 = new Resolution(eemaldatavLubadus);
			
			for (int j = 0; j < uueAastaLubadus.Count; j++)
			{

				if (uueAastaLubadus[i].description == kasutajaLubadus4.description)
				{
					uueAastaLubadus.Remove(uueAastaLubadus[i]);
				}
			}
			
			foreach (Resolution lubadus in uueAastaLubadus)
			{
				Console.WriteLine($"Lubadused {i} on: {lubadus.description}");
				i++;
			}

			List<string> outputToWriteToFile2 = new List<string>();
			foreach (Resolution lubadus in uueAastaLubadus)
			{
				outputToWriteToFile2.Add($"{lubadus.description}");
			}

			Console.WriteLine("Lisa lubadused faili: ");
			File.WriteAllLines(filePath, outputToWriteToFile2);

			Console.ReadLine();

		}

	}
}
