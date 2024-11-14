using Unity.Services.Analytics;
using Unity.Services.Core;
using UnityEngine;
using UnityEngine.UI;


public class ButtonComponent : MonoBehaviour
{
    private Button button;
    [SerializeField] private int id;
    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            Debug.Log($"Button {id} clicked");
            
            ButtonClickedEvent buttonClicked = new ButtonClickedEvent
            {
                ButtonId = id
            };
            AnalyticsService.Instance.RecordEvent(buttonClicked);
            
        });
    }

    private void Start()
    {
        UnityServices.InitializeAsync();
    }
}
