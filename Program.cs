//Console.ForegroundColor();
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

Console.Clear();
ConsoleColor red = ConsoleColor.Red;
ConsoleColor blue = ConsoleColor.DarkCyan;
ConsoleColor tan = ConsoleColor.Gray;
ConsoleColor yellow = ConsoleColor.Yellow;
ConsoleColor darkBlue = ConsoleColor.DarkBlue;
ConsoleColor boots = ConsoleColor.DarkGreen;
ConsoleColor black = ConsoleColor.Black;
string block = "  ";
int space = block.Length;




//Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = blue;

//Write the Light Blue (Cyan) sections
for (int i = 0; i <= 18; i++)
{
    for (int x = 0; x <= 13; x++)
    {
        Console.Write(block);
    }
    Console.SetCursorPosition(0, i);
}


//Tan Sections
Console.SetCursorPosition(3 * space, 3);
Console.BackgroundColor = tan;

//Draw Marios Head
for (int x = 2; x <= 7; x++)
{

    if (x == 3)
    {
        Console.SetCursorPosition(3 * space, x);
    }
    else if (x == 4)
    {
        Console.SetCursorPosition(3 * space, x);
        Console.Write(block + block);

    }
    else if (x == 5)
    {
        Console.SetCursorPosition(3 * space, x);
        Console.Write(block + block + block);
    }
    else if (x == 6)
    {
        Console.SetCursorPosition(4 * space, x);
        Console.Write(block);
    }
    else if (x == 7)
    {
        Console.SetCursorPosition(4 * space, x);
    }

    for (int i = 3; i <= 9; i++) Console.Write(block);

}

//Hands
for (int i = 11; i <= 13; i++)
{
    Console.SetCursorPosition(1*space, i);
    for (int x = 1; x <= 12; x++) Console.Write(block);
}


//Blue Shirt
string colors = String.Concat(Enumerable.Repeat(block, 6));
Console.SetCursorPosition(3 * space, 8);
Console.BackgroundColor = darkBlue;
Console.Write(colors);

colors = String.Concat(Enumerable.Repeat(block, 10));
Console.SetCursorPosition(2 * space, 9);
Console.Write(colors);

colors = String.Concat(Enumerable.Repeat(block, 12));
Console.SetCursorPosition(1 * space, 10);
Console.Write(colors);

colors = String.Concat(Enumerable.Repeat(block, 8));
Console.SetCursorPosition(3 * space, 11);
Console.Write(colors);


//Red Sections
Console.SetCursorPosition(4 * space, 1);
Console.BackgroundColor = red;
for (int i = 0; i <= 5; i++) Console.Write(block);
Console.SetCursorPosition(3 * space, 2);
for (int i = 0; i <= 8; i++) Console.Write(block);

//Overalls
for (int i = 8; i <= 14; i++)
{
    Console.SetCursorPosition(5 * space, i);
    Console.Write(block);
    if (i > 8)
    {
        Console.SetCursorPosition(8 * space, i);
        Console.Write(block);
    }
}

Console.SetCursorPosition(6 * space, 11);
Console.Write(block + block);

for (int i = 4; i <= 9; i++)
{
    Console.SetCursorPosition(i * space, 12);
    Console.Write(block);
}

for (int i = 3; i <= 10; i++)
{
    Console.SetCursorPosition(i * space, 13);
    Console.Write(block);

}


for (int i = 3; i <= 10; i++)
{
    if ((i < 6) ^ (i > 7))
    {
        Console.SetCursorPosition(i * space, 14);
        Console.Write(block);
    }
}



//Marios Face
Console.BackgroundColor = black;
Console.SetCursorPosition(0, 0);
for (int x = 3; x <= 6; x++)
{
    for (int i = 2; i <= 11; i++)
    {
        Console.SetCursorPosition(i * space, x);
        if (x == 3)
        {
            if (i < 6 && i != 2) Console.Write(block);
            else if (i == 8) Console.Write(block);
        }
        else if (x == 4 && (i == 2 ^ i == 4 ^ i == 8)) Console.Write(block);
        else if (x == 5 && (i == 2 ^ i == 4 ^ i == 5 ^ i == 9)) Console.Write(block);
        else if (x == 6 && (i < 4 ^ i > 7)) Console.Write(block);
        else continue;
    }
}


//Boots
Console.BackgroundColor = boots;
for (int i = 1; i <= 11; i++)
{
    for (int x = 15; x <= 16; x++)
    {

        Console.SetCursorPosition(i * space, x);
        if (x == 15 && ((i > 1 && i < 5) ^ (7 < i && i < 11)))
        {
            Console.Write(block);
        }
        else if (x == 16 && (i < 5 ^ i > 7)) Console.Write(block);
    }
}

//Overall Buttons
Console.BackgroundColor = yellow;
Console.SetCursorPosition(5*space, 12);
Console.Write(block);
Console.SetCursorPosition(8*space, 12);
Console.Write(block);


Console.SetCursorPosition(0, 17);
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

