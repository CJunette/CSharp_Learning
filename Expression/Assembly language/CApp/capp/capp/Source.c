#include <stdio.h>

double getCylinderVolume(double radius, double height)
{
	double area = 3.1415926 * radius * radius;
	double volume = area * height;
	return volume;
}

int main()
{
	double result = getCylinderVolume(10, 100);
	printf("%f/n", result);
	return 0;
}