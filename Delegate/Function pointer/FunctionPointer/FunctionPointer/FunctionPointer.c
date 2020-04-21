#include <stdio.h>

int Add(int a, int b)
{
	int result = a + b;
	return result;
}

int Sub(int a, int b)
{
	int result = a - b;
	return result;
}

typedef int(*Calc)(int a, int b);

int main()
{
	int x = 100;
	int y = 200;
	int z;
	Calc funcPoint1 = &Add;
	Calc funcPoint2 = &Sub;

	z = funcPoint1(x, y);
	printf("%d + %d = %d\n", x, y, z);

	z = funcPoint2(x, y);
	printf("%d + %d = %d\n", x, y, z);

	system("pause");
}