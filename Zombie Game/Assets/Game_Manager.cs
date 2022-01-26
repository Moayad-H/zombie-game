using UnityEngine.SceneManagement;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public GameObject cam;
    public Game_over_screen GOScreen;
    public GameObject Screen;
    public GameObject end_music;
    public bool GameEnded;
  
    public void EndGame()
    {
        
        cam.SetActive(true);
        GameEnded = true;
        GOScreen.Setup();
        UpdateCursorState();
        Time.timeScale = 0f;
        end_music.SetActive(true);
    }
    private void UpdateCursorState()
    {
        //Update cursor visibility.
        //Update cursor lock state.
        Cursor.lockState =  CursorLockMode.None;
    }
    public void Restart()
    {
       
        //num.num = 0;
        //Application.LoadLevel(Application.loadedLevel);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
