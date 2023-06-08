# SVNSkillFactory16
## Задание 6.3.1
Вам даны следующие классы:
```console
class Company
{
	public string Type;
	public string Name;
}

class Department
{
	public Company Company;
	public City City;
}

class City
{
	public string Name;
}
```
И экземпляр класса Department,
полученный из метода GetCurrentDepartment (логика работы метода опущена):
```console
class Program
{
	static void Main(string[] args)
	{
		var department = GetCurrentDepartment();
	}

	static Department GetCurrentDepartment()
	{
		// logic
	}
}
```
Напишите такой код, который бы при типе компании, равному типу "Банк",
и городе "Санкт-Петербург" выводил в консоль сообщение "У банка ??? есть отделение
в Санкт-Петербурге", где вместо "???" выводилось бы название компании.
Если у компании нет названия, вместо него должно быть "Неизвестная компания".