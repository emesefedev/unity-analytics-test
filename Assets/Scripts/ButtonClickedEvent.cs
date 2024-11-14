public class ButtonClickedEvent : Unity.Services.Analytics.Event
{
    public ButtonClickedEvent() : base("ButtonClicked")
    {
    }
    
    public int ButtonId { set { SetParameter("buttonId", value); } }
}