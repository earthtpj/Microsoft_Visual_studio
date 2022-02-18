# Microsoft Visual Studio C++ and C#

	Dynamic Link Library 
	
	Create Dynamic Link Library Project
	
	[1] create header file
	[2] Create main.c file
	[3] build the project 

	Header File
		
=======
# C++ Dynamic Link Library 
	Create Dynamic Link Library Project
	[1] create header file
	[2] Create main.c file
	[3] build the project 
	Header File

		#pragma once
		#ifdef FUNTEST_EXPORTS
		#define FUNTEST_API __declspec(dllexport)
		#else
		#define FUNTEST_API __declspec(dllimport)
		#endif

		extern "C" FUNTEST_API int add(int a, int b);

	Main File
		#include "pch.h" // use stdafx.h in Visual Studio 2017 and earlier
		#include <utility>
		#include <limits.h>
		#include "funtest.h"
		static int add(int a, int b);
		int add(int a, int b)
		{
			return (a + b);
		}
        Create console application
		#include <iostream>
		#include "funtest.h"
		int main()
		{
		    std::cout << "Hello World!\n";
		    std::cout << add(5, 7);
		}
	Copy funtest.h(Header file) and funtest (object library file)  from dll project and paste in console project lib folder
# C# Dynamic Link Library 

	Create Class library project
		using System;
		using System.Collections.Generic;
		using System.Text;
		namespace ClassLibrary1
		{
		    public class Algebra
		    {
			public double Addition(double x, double y)
			{
			    return x + y;
			}
			public double Subtraction(double x, double y)
			{
			    return x - y;
			}
			public double Multiplication(double x, double y)
			{
			    return x * y;
			}
			public double Division(double x, double y)
			{
			    return x / y;
			}
		    }
		}
	Build the Project 
	
	Create console application
		using System;
		using ClassLibrary1;
		namespace ConsoleApp1
		{
		    class Program
		    {
			static void Main(string[] args)
			{
			    Algebra alg = new Algebra();
			    double number1 = 100;
			    double number2 = 50;
			    double result = alg.Addition(number1, number2);
			    Console.Write(number1);
			    Console.Write(" + ");
			    Console.Write(number2);
			    Console.Write(" = ");
			    Console.WriteLine(result);
			}
		    }
		}
	Add reference
		Dependencis-> Add project reference
		->classlibrary1.dll





	

