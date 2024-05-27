using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtenClick : MonoBehaviour
{
    [SerializeField] GameObject PausePannel;
    [SerializeField] EnemyMovement emScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
        PausePannel.SetActive(true);
        Time.timeScale = 0;
       // emScript.enemyMove()
    }
    public void Countinue()
    {
        PausePannel.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);

    }
    public void play()
    {
        SceneManager.LoadSceneAsync(1);
        Time.timeScale = 1;

    }
    public void Quit()
    {
       
    }
    public void Option()
    {

    }
    public void About()
    {

    }

}
