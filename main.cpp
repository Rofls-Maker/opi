#include <iostream>

int main()
{
	std::setlocale(LC_ALL, "ru-RU");

	int firstSide;
	int secondSide;
	int thirdSide;
	int upperLimitOfInput;
	bool isCorrect;
	long firstSideSqr;
	long secondSideSqr;
	long thirdSideSqr;
	firstSide = 0;
	secondSide = 0;
	thirdSide = 0;
	upperLimitOfInput = 1000000000;
	isCorrect = true;
	std::cout << "Дано:\tДаны длины сторон треугольника \nЗадача:\tОпределить, является ли данный треугольник прямоугольным.\n\n";
	std::cout << "Введите значение первой стороны треугольника не певышающее 1000000000 " << std::endl;
	while (isCorrect)
	{
		std::cin >> firstSide;
		if (std::cin.fail() || firstSide < 0 || firstSide > upperLimitOfInput)
		{
			std::cin.clear();
			while (std::cin.peek() != '\n')
				std::cin.ignore();

			std::cout << "Введено не корректное число: ";

			if (firstSide < 0)
			{
				std::cout << "сторона не может быть отрицательной, повторите ввод\n";
			}
			else if (firstSide > upperLimitOfInput)
			{
				std::cout << "сторона не может превышать 1000000000, повторите ввод\n";
			}
			else
			{
				std::cout << "сторона должна быть числом, повторите ввод\n";
			}

		}
		else if (std::cin.peek() != '\n') {
			std::cout << "Введено некорректное число, повторите попытку\n";
			while (std::cin.peek() != '\n')
				std::cin.ignore();
		}
		else
		{
			while (std::cin.peek() != '\n')
				std::cin.ignore();
			isCorrect = false;
		}
	}
	isCorrect = true;
	std::cout << "Введите значение второй стороны треугольника не певышающее 1000000000 " << std::endl;
	while (isCorrect)
	{
		std::cin >> secondSide;
		if (std::cin.fail() || secondSide < 0 || secondSide > upperLimitOfInput)
		{
			std::cin.clear();
			while (std::cin.peek() != '\n')
				std::cin.ignore();

			std::cout << "Введено не корректное число: ";

			if (secondSide < 0)
			{
				std::cout << "сторона не может быть отрицательной, повторите ввод\n";
			}
			else if (secondSide > upperLimitOfInput)
			{
				std::cout << "сторона не может превышать 1000000000, повторите ввод\n";
			}
			else
			{
				std::cout << "сторона должна быть числом, повторите ввод\n";
			}
		}
		else if (std::cin.peek() != '\n') {
			std::cout << "Введено некорректное число, повторите попытку\n";
			while (std::cin.peek() != '\n')
				std::cin.ignore();
		}
		else
		{
			while (std::cin.peek() != '\n')
				std::cin.ignore();
			isCorrect = false;
		}
	}
	isCorrect = true;
	std::cout << "Введите значение третьей стороны треугольника не певышающее 1000000000 " << std::endl;
	while (isCorrect)
	{
		std::cin >> thirdSide;
		if (std::cin.fail() || thirdSide < 0 || thirdSide > upperLimitOfInput)
		{
			std::cin.clear();
			while (std::cin.peek() != '\n')
				std::cin.ignore();

			std::cout << "Введено не корректное число ";

			if (thirdSide < 0)
			{
				std::cout << "сторона не может быть отрицательной, повторите ввод\n";
			}
			else if (thirdSide > upperLimitOfInput)
			{
				std::cout << "сторона не может превышать 1000000000, повторите ввод\n";
			}
			else
			{
				std::cout << "сторона должна быть числом, повторите ввод\n";
			}
		}
		else if (std::cin.peek() != '\n') {
			std::cout << "Введено некорректное число, повторите попытку\n";
			while (std::cin.peek() != '\n')
				std::cin.ignore();
		}
		else
		{
			while (std::cin.peek() != '\n')
				std::cin.ignore();
			isCorrect = false;
		}
	}
	firstSideSqr = firstSide * firstSide;
	secondSideSqr = secondSide * secondSide;
	thirdSideSqr = thirdSide * thirdSide;
	if (firstSide < (secondSide + thirdSide) && secondSide < (firstSide + thirdSide) && thirdSide < (secondSide + firstSide) && (firstSide != 0 && secondSide != 0 && thirdSide != 0))
	{
		if (firstSideSqr == secondSideSqr + thirdSideSqr || secondSideSqr == firstSideSqr + thirdSideSqr || thirdSideSqr == firstSideSqr + secondSideSqr)
		{
			std::cout << "Треугольник прямоугольный\n";
		}
		else
		{
			std::cout << "Треугольник не прямоугольный\n";
		}
	}
	else
	{
		std::cout << "Треугольник не существует\n";
	}

	std::cout << "Нажмите любую клавишу, чтобы закрыть это окно:\n";
	std::cin.get();
}