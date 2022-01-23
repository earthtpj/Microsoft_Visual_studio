# Microsoft Visual Studio C++ and C#

	C++ Dynamic Link Library 
	
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
	
	![image](https://user-images.githubusercontent.com/72020402/150664646-ccc2275e-acb8-4f21-9ba8-82afde3df666.png)


