using UnityEngine;

public class Spikes : MonoBehaviour
{
    public GameObject Spike;
    public int TimerSpawn = 180;
    public int Force = 150;
    public int MaxNumber = 50;

    int Timer = 0;
    float[] Choices = new float[] { 1, 3.67f };

    Rigidbody Rb;
    GameObject NewGameObject;
    int Numbers = 0;
    private void FixedUpdate()
    {
        if (Timer > TimerSpawn && Numbers < MaxNumber)
        {
            NewGameObject = Instantiate(Spike, new Vector3(20, Choices[(int)(Random.Range(0, 2))], 0), Quaternion.identity);
            NewGameObject.tag = "Enemy";
            Rb = NewGameObject.GetComponent<Rigidbody>();
            Rb.AddForce(-Vector3.right * Force);
            Timer = 0;
            Numbers++;
            Debug.Log((int)(Random.Range(0, 2)));
            return;
        }
        Timer++;
    }
}
