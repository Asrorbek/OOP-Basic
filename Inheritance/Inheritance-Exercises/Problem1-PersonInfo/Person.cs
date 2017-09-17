﻿using System;
using System.Text;

namespace Problem1_PersonInfo
{
	public class Person
	{
		private string name;
		private int age;

		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;

		}
		public string Name
		{ get { return this.name; }
			 set
			{
				if (value.Length<3)
				{
					throw new ArgumentException("Name's length should not be less than 3 symbols!");
				}
				this.name = value;
			}
		}

		public virtual int Age
		{ get { return this.age; }
			 set
			{
				if (value<0)
				{
					throw new ArgumentException("Age must be positive!");
				}
				this.age = value;
			}
		}

		public override string ToString()
		{
			StringBuilder build=new StringBuilder();
			build.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
			return build.ToString();
		}
	}
}