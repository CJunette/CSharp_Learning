#include <iostream>
#include "Student.h"

int main()
{
	Student *pStu = new Student();
	pStu->SayHello();

	double a = 1;
	double b = 2;
	double result = pStu->Add(a, b);
	printf("\n");
	std::cout << a << "+" << b << "=" << result;

	return 0;
}