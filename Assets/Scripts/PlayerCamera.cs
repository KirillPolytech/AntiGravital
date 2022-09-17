using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject Player;
    public int Offset = 10;

    private void FixedUpdate()
    {
        transform.position = new(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z + Offset);
    }
}
