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
            AnalyticsManager.Instance.ButtonClicked(id);
        });
    }

}
