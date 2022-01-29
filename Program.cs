using System;

CreateAndTestCoordinates();


void CreateAndTestCoordinates()
{
    Coordinate coordA = new Coordinate(0, 1);
    Coordinate coordB = new Coordinate(3, 8);
    Coordinate coordC = new Coordinate(0, 2);
    Coordinate coordD = new Coordinate(2, 8);

    IsAdjacent(coordA, coordB);
    IsAdjacent(coordA, coordC);
    IsAdjacent(coordA, coordD);

    IsAdjacent(coordB, coordC);
    IsAdjacent(coordB, coordD);

    IsAdjacent(coordC, coordD);
}


void IsAdjacent(Coordinate a, Coordinate b)
{
    if ((a.Column - b.Column) == 0 || (a.Row - b.Row) == 0) // check to see if they are in the row/column
    {
        if (Math.Abs(a.Column - b.Column) == 1 || Math.Abs(a.Row - b.Row) == 1) // check to see if they are off by one row/column
        {
            Console.WriteLine($"Coordinates ({a.Row}, {a.Column}) and ({b.Row}, {b.Column}) are adjacent.");
        }
    }
    else
    {
        Console.WriteLine($"Coordinates ({a.Row}, {a.Column}) and ({b.Row}, {b.Column}) are NOT adjacent.");
    }
}

public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }
}