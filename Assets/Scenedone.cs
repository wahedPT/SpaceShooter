using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenedone : MonoBehaviour
{
    public void GoToNextScene()
    {
        SceneManager.LoadScene(0);
    }

}
