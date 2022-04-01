namespace Bitobrian.Wow.Addon.IDE.Data.ViewModels;

public class DraggableViewModel
{
    public int ContainerX { get; set; } = 0;
    public int ContainerY { get; set; } = 0;
    public int ElementX { get; set; } = 0;
    public int ElementY { get; set; } = 0;
    public int ContainerMouseX { get; set; } = 0;
    public int ContainerMouseY { get; set; } = 0;
    public bool OverChild { get; set; } = false;
    public int SelectedItem { get; set; } = -1;
    public List<UiModel> Rectangles { get; set; }
    
    public DraggableViewModel()
    {
        Rectangles = new List<UiModel>();
    }
}