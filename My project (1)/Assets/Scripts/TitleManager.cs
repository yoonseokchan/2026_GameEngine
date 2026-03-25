using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject help;

    public void GameStart()
    {
        SceneManager.LoadScene("Stage_Door1");
    }

    public void OpenHelp()
    {
        help.SetActive(true);
    }

    public void CloseHelp()
    {
        help.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GameOff()
    {
        Application.Quit();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
