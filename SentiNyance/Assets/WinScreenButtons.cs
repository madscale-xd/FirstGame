using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winMenu;
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene("Level");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
