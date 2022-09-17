using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void START()
    {
        SceneManager.LoadScene("level 1");
    }
}
