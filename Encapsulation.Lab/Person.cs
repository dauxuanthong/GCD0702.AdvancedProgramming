﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Lab
{
	class Person
	{
		private string _firstName;
		private string _lastName;
		private int _age;
		private decimal _salary;

		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public int Age { get; private set; }

		public Person(string firstName, string lastName, int age, decimal salary)
		{
			_firstName = firstName;
			_lastName = lastName;
			_age = age;
			_salary = salary;

			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		public override string ToString()
		{
			return _firstName + " " + _lastName + " is " + _age + " years old, receies " + _salary;
		}

		public void IncreaseSalary(decimal percentage)
		{
			if (_age < 30)
			{
				_salary += _salary * percentage / 2 / 100;
			}
			else
			{
				_salary += _salary * percentage / 100;
			}
		}
	}
}
