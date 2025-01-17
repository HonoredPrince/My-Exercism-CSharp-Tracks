﻿using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input) => input.ToLower().Where(char.IsLetter).GroupBy(ch => ch).Count() == 26;
}
