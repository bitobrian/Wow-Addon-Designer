namespace Bitobrian.Wow.Addon.IDE.Data;

public class UiModel
{
    public int RectangleId { get; set; }
    public int OriginalX { get; set; }
    public int OriginalY { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }
 
    public string Position
    {
        get
        {
            return $"{X},{Y}";
        }
    }

    public UiModel(int id)
    {
        RectangleId = id;
        Width = Random.Shared.Next(100);
        Height = Random.Shared.Next(60);
        R = Random.Shared.Next(255);
        G = Random.Shared.Next(255);
        B = Random.Shared.Next(255);
    }
}