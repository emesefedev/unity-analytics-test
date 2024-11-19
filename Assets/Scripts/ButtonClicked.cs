public class ButtonClicked : Unity.Services.Analytics.Event
{
    public ButtonClicked() : base("ButtonClicked")
    {
    }
    
    public int ButtonId { set { SetParameter("buttonId", value); } }
}