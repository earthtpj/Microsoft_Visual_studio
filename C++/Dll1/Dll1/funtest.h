#pragma once
#ifdef FUNTEST_EXPORTS
#define FUNTEST_API __declspec(dllexport)
#else
#define FUNTEST_API __declspec(dllimport)
#endif

extern "C" FUNTEST_API int add(int a, int b);