using System;
using System.Linq;
public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        return SetResistorNumberBasedOnColor(colors);
    }

    public static string SetResistorNumberBasedOnColor(string[] colorsList)
    {
        char[] resistorNumberCharArray = new char[2];
        for (int i = 0; i < 2; i++)
        {
            switch (colorsList[i])
            {
                case "black":
                    resistorNumberCharArray[i] = '0';
                    break;
                case "brown":
                    resistorNumberCharArray[i] = '1';
                    break;
                case "red":
                    resistorNumberCharArray[i] = '2';
                    break;
                case "orange":
                    resistorNumberCharArray[i] = '3';
                    break;
                case "yellow":
                    resistorNumberCharArray[i] = '4';
                    break;
                case "green":
                    resistorNumberCharArray[i] = '5';
                    break;
                case "blue":
                    resistorNumberCharArray[i] = '6';
                    break;
                case "violet":
                    resistorNumberCharArray[i] = '7';
                    break;
                case "grey":
                    resistorNumberCharArray[i] = '8';
                    break;
                case "white":
                    resistorNumberCharArray[i] = '9';
                    break;
            }
        }
        string resistorNumberedByColor = new String(resistorNumberCharArray);
        resistorNumberedByColor += SetResistorZeroesAmountBasedOnColor(colorsList[2]);
        return ResistorLabelingViaOHMValue(resistorNumberedByColor);
    }

    public static string SetResistorZeroesAmountBasedOnColor(string numberText)
    {
        switch (numberText)
        {
            case "black":
                return "";
            case "brown":
                return "0";
            case "red":
                return "00";
            case "orange":
                return "000";
            case "yellow":
                return "0000";
            case "green":
                return "00000";
            case "blue":
                return "000000";
            case "violet":
                return "0000000";
            case "grey":
                return "00000000";
            case "white":
                return "000000000";
            default:
                return "";
        }
    }

    public static string ResistorLabelingViaOHMValue(string resistorText)
    {
        char matchChar = '0';
        int zeroCount = resistorText.Count(x => x == matchChar);
        resistorText = resistorText.Split("0")[0];

        switch (zeroCount)
        {
            case 0:
                return resistorText += " ohms";
            case 1:
                return resistorText += "0 ohms";
            case 2:
                return resistorText += "00 ohms";
            case 3:
                return resistorText += " kiloohms";
            case 4:
                return resistorText += "0 kiloohms";
            case 5:
                return resistorText += "00 kiloohms";
            case 6:
                return resistorText += " megaohms";
            case 7:
                return resistorText += "0 megaohms";
            case 8:
                return resistorText += "00 megaohms";
            case 9:
                return resistorText += " gigaohms";
            default:
                return resistorText;
        }
    }
}
