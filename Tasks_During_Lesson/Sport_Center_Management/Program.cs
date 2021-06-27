using System;
using System.Collections;

public class Program
{
	public static void Main()
	{
		ArrayList list = new ArrayList();
		Console.WriteLine("Edeceyiniz emeliyyatı seçin : ");
		string[] operations = {"1-Uzv daxil edin",
"2-Uzvu qeydiyyatdan silin",
"3-Uzvlerin siyahisini gorun",
"4-Uzvlerin siyahini ters cevirin",
"5-Uzvlerin qeydiyyatda olub olmamasini yoxlayin",
"6-Uzvlerin siyahisini bashdan sona siralayin",
"7-Butun uzvlerin qeydiyyatini silin",
"8-Sport kompleksi qeydiyyat sisteminden cixin"};

		int operation;
		
		do
		{
			foreach (string operation_ in operations)
			{
				Console.WriteLine(operation_);
			}
			operation = int.Parse(Console.ReadLine());

			
			
				



			switch (operation)
			{
				case 1:
					int n;
					int i = 0;

					Console.WriteLine("Neçe üzv daxil etmek isteyirsiniz?");
					n = int.Parse(Console.ReadLine());
					Console.WriteLine("Adları daxil edin ");
					while (i < n)
					{
						list.Add(Console.ReadLine());
						Console.WriteLine("Elave edildi");
						i++;
					}



					break;
				case 2:
					foreach (string name in list)
					{
						Console.WriteLine(name);
					}
					Console.WriteLine("Hansı adı silmek isteyirsiniz?");
					string nameForDelete = Console.ReadLine();
					list.Remove(nameForDelete);
					Console.WriteLine("Silindi");
					break;
				case 3:
					Console.WriteLine("Üzvlerin siyahısı");
					foreach(string name in list)
                    {
						Console.WriteLine(name);
                    }
					break;
				case 4:
					Console.WriteLine("Üzvler siyahısı :");
					foreach (string name in list) {

						Console.WriteLine(name);
					}
					//Tərsinə siyahı üçün klonladıq
					ArrayList reversedList = (ArrayList) list.Clone();
					reversedList.Reverse();
					Console.WriteLine("Tersine çevrilmiş üzvler siyahısı :");
					foreach (string name in reversedList)
                    {
						Console.WriteLine(name);
                    }
					break;
				case 5:
					Console.WriteLine("Yoxlanılacaq adı yazın :");
					string nameForCheckStatus = Console.ReadLine();
                    if (list.Contains(nameForCheckStatus))
                    {
						Console.WriteLine("Sistemde var");

                    }
                    else
                    {
						Console.WriteLine("Sistemde yoxdur");
                    }
					break;
				case 6:
					ArrayList sortedList = (ArrayList)list.Clone();
					sortedList.Sort();
					Console.WriteLine("Sıralanmış siyahı :");
					foreach(string name in sortedList)
                    {
						Console.WriteLine(name);
                    }
					break;
				case 7:
					Console.WriteLine("Eminsiniz?Davam üçün 1,dönmek üçün 0 daxil edin");
					int checkAgain = int.Parse(Console.ReadLine());
                    if (checkAgain == 1)
                    {
						list.Clear();
						Console.WriteLine("Bütün üzvler silindi");
                    }
                    else
                    {
						Console.WriteLine("Çörəksiz qalacaqdıq az qala :)");
                    }
					break;
				case 8:
					Console.WriteLine("Sistemden çıxıldı");
					break;
				default:
					Console.WriteLine("Xetalı emeliyyat isteyi!");
					break;

			}
			Console.WriteLine("*****************************************");
		} while (operation != 8);
	}
}