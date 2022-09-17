using UnityEngine;
using TMPro;

public class Record : MonoBehaviour
{
    static int RecordDistance = 0;
    TextMeshProUGUI RecordText;
    void Start()
    {
        RecordText = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (Player.DistanceCounter > RecordDistance)
        {
            RecordDistance = Player.DistanceCounter;
        }
        RecordText.text = "Record: " + RecordDistance;
    }
}
