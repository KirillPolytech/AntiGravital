using UnityEngine;
using TMPro;

public class GameSystem : MonoBehaviour
{
    //public GameObject MainCanvas;
    public TextMeshProUGUI FPS;
    public TextMeshProUGUI CurrentTime;

    private void Update()
    {
        Application.targetFrameRate = 60;

        FPS.text = "FPS: " + (int)(1f / Time.unscaledDeltaTime);
        CurrentTime.text = "" + System.DateTime.Now;
    }
}
