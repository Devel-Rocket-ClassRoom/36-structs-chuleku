using System;
ColorRGB red = new ColorRGB { R = 255, G = 0, B = 0 };
ColorRGB white = new ColorRGB { R = 255, G = 255, B = 255 };
ColorRGB custum = new ColorRGB { R = 100, G = 150, B = 200 };
Console.WriteLine("=== RGB 색상 밝기 계산 ===");
Console.Write($"빨강 - R: {red.R}, G: {red.G}, B: {red.B} -> ");
red.GetBrightness();
Console.WriteLine();
Console.Write($"흰색 - R: {white.R}, G: {white.G}, B: {white.B} -> ");
white.GetBrightness();
Console.WriteLine();
Console.Write($"커스텀 - R: {custum.R}, G: {custum.G}, B: {custum.B} -> ");
custum.GetBrightness();
Console.WriteLine();

