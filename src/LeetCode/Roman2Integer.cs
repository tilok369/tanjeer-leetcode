﻿
namespace LeetCode;

public class Roman2Integer
{
    public static int RomanToInt(string s)
    {
        var integer = 0;
        for (var i = s.Length - 1; i >= 0; i--)
        {
            var part = ProcessSymbol((i >= 1 ? s[i - 1] + "" : "") + s[i]); ;
            if (part == 0 && i >= 1)
            {
                part = ProcessSymbol(s[i] + "");
            }
            else
            { 
                i--; 
            }
            integer += part;
        }
        return integer;
    }

    private static int ProcessSymbol(string symbol)
    {
        switch (symbol)
        {
            case "IV":
                return 4;
            case "IX":
                return 9;
            case "XL":
                return 40;
            case "XC":
                return 90;
            case "CD":
                return 400;
            case "CM":
                return 900;
            case "I":
                return 1;
            case "V":
                return 5;
            case "X":
                return 10;
            case "L":
                return 50;
            case "C":
                return 100;
            case "D":
                return 500;
            case "M":
                return 1000;
            default:
                return 0;
        }
    }
}
