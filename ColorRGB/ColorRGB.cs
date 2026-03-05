using System;
using System.Collections.Generic;
using System.Text;

struct ColorRGB
{
    public int R;
    public int G;
    public int B;
    public void GetBrightness()
    {
        int brightness = (R + G + B) / 3;
        Console.Write($"밝기:{brightness}");
    }
}
