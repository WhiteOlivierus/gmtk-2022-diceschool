using TMPro;
using UnityEngine;

public class ShowTime : MonoBehaviour
{
    private TextMeshProUGUI timeText;
    public void Awake()
    {
        TryGetComponent(out timeText);
    }

    public void Update()
    {
        timeText.text = GameManager.Instance.GetTime().ToString(@"mm\:ss");
    }
}
