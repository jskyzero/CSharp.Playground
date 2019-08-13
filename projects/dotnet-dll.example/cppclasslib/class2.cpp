#include "pch.h"
#include "class2.h"
#include <cstdio>

extern "C"
{
	__declspec(dllexport) void PrintStr2() {
		printf("World");
	}
}