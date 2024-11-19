using Unity.Services.Analytics;
using Unity.Services.Core;
using UnityEngine;

public class AnalyticsManager : MonoBehaviour
{
    public static AnalyticsManager Instance;
    
    private bool _isInitialized;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one AnalyticsManager in scene");
        }
        
        Instance = this;
    }

    private async void Start()
    {
        await UnityServices.InitializeAsync();
        AnalyticsService.Instance.StartDataCollection(); // Needs user consent
        _isInitialized = true;
    }

    public void ButtonClicked(int buttonId)
    {
        if (!_isInitialized) return;
        CustomEvent buttonClicked = new CustomEvent("ButtonClicked")
        {
            { "buttonId", buttonId }
        };
        AnalyticsService.Instance.RecordEvent(buttonClicked);
        AnalyticsService.Instance.Flush();
        
        Debug.Log("Button clicked event");
    }
    
    
}
