using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{

    public PlayerController player;

    public void nextLvl ()
    {
        SceneManager.LoadScene(player.lvlNum);
    }

    public void restartLvl ()
    {
        SceneManager.LoadScene(player.lvlNum);
    }
}
