﻿using System;
using System.Collections.Generic;

public class Class1
{
    public string str_Angle;
    public string str_Forse;
    private double num_Angle;
    private double num_Velosity;
    public List<double> cord_x = new List<double>();
    public List<double> cord_y = new List<double>();
    public List<double> Timer = new List<double>();
    const double gravity = 9.8;

    public void Time(string str_Angle, string str_Forse)
    {
        double Time_Travel = 2 * Convert.ToDouble(str_Forse) * Math.Sin(Convert.ToDouble(str_Angle))/9.8;
        double i = 0;
        while (i< Time_Travel)
        {
            
            Timer.Add(i);
            i += Time_Travel / 10;
        }
    }

    public void Fly(string str_Angle,string str_Forse)
    {
    
    double Angle = Convert.ToDouble(str_Angle);
    double Forse = Convert.ToDouble(str_Forse);
        double Time_Travel = 2 * Forse * Math.Sin(Angle)/9.8;
        double epsilon = Time_Travel / 100;
        
        
        foreach(double i in Timer)
        {
            cord_x.Add(Forse * Math.Cos(Angle) * i);
            cord_y.Add(Forse * Math.Sin(Angle) * i - gravity * i * i / 2);
        }
}

public double FlyOnCordX(string str_Angle, string str_Forse,double time)
        {
        double Angle = 180 / Math.PI * Convert.ToDouble(str_Angle);
        double Forse = Convert.ToDouble(str_Forse);
        double cord_x;
        cord_x=Forse * Math.Cos(Angle) * time;
        return cord_x;

    }
    public double FlyOnCordY(string str_Angle, string str_Forse, double time)
    {
        double Angle = Convert.ToDouble(str_Angle);
        double Forse = Convert.ToDouble(str_Forse);
        double cord_y;
        cord_y = Forse * Math.Sin(Angle) * time - gravity * time * time / 2;
        return cord_y;

    }


    public Class1(double num_Angle, double num_Velosity)
    {
        this.num_Angle = num_Angle;
        this.num_Velosity = num_Velosity;
    }
}