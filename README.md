# Microsoft Visual Studio C++ and C#

	Dynamic Link Library 
	
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
