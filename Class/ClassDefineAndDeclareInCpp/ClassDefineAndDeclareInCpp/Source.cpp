#include "Student.h"
#include "Teacher.h"

int main()
{
	Student *stu = new Student();
	stu->SayHello();
	
	Teacher *tea = new Teacher();
	tea->SayHello();


	return 0;
}