using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject Backgrounds;
    public Vector3 MoveDirection;
    public int MaxTime = 120;

    int Timer = 0;
    Vector3 InitialPosition;
    private void Start()
    {
        InitialPosition = Backgrounds.transform.position;
    }
    private void FixedUpdate()
    {
        if (Timer < MaxTime)
        {
            Backgrounds.transform.position -= MoveDirection;
            Timer++;
            return;
        }
        Timer = 0;
        Backgrounds.transform.position = InitialPosition;
    }
}
