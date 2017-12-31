﻿/***************************************************************************
* Title       : Depression
* URL         : http://codeforces.com/problemset/problem/80/B
* Occasion    : Codeforces Beta Round #69 (Div. 2 Only)
* Date        : Sept 20 2017
* Complexity  : O(1) 46ms
* Author      : Atiq Rahman
* Status      : Accepted
* Notes       : Simple angle calculation for hour and minute hands
* meta        : tag-geometry, tag-math
***************************************************************************/
using System;
using System.Globalization;

public class Demo {
  static double EPS = 1e-9;
  public static void Main() {
    // feel free to modify
    string[] tokens = Console.ReadLine().Split(':');
    int h = int.Parse(tokens[0]);
    int m = int.Parse(tokens[1]);
    // compute angle for hour hand
    double hA = 30 * h + (double)m / 2;
    if (hA > 360.0 - EPS)
      hA -= 360.0;
    // compute angle for minute hand
    double mA = 6 * m;
    Console.WriteLine(hA.ToString("F1", CultureInfo.CreateSpecificCulture("en-US")) + " " + mA);
  }  
}

/*
 Inputs:
 23:59
 20:15
*/