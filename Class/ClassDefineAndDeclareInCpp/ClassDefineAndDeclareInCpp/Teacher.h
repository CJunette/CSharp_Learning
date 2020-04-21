#pragma once
#include "iostream"
class Teacher
{
public:
	Teacher();	
	~Teacher();

	//Combine definition and declaration.
	void SayHello()
	{
		std::cout << "World!" << std::endl;
	}
};

