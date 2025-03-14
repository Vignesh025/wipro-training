﻿using System;
public class Calculator
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }
    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }
    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }
    public double Divide(double num1, double num2)
    {
        try
        {
            return num1 / num2;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: "+ex.Message);
            return 0;
        }
    }
}