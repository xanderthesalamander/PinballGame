using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadScene : MonoBehaviour
{
    


    public void deadBall(){
        Invoke(nameof(SceneReload), 3);
    }

    public void SceneReload(){
        GameManager.Instance.Lives--;
       
        if (GameManager.Instance.Lives == 0){
            GameManager.Instance.endGame();
            ReloadGame();
        } else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }    

    public void ReloadGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameManager.Instance.Start();

     }

    public void QuitGame(){
       // UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    } 

    public void PlayGame(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } 

    public void MainMenu(){
       SceneManager.LoadScene("MainMenu");
    } 


}
