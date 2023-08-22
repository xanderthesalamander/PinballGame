using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadScene : MonoBehaviour
{
    public Text livesRef;

    void Start(){
    }

    void Update(){
        livesRef.text = "Lives : " + GameManager.Instance.Lives.ToString();

    }

    public void deadBall(){
        Invoke(nameof(SceneReload), 2);
    }

    public void SceneReload(){
        GameManager.Instance.Lives--;
        livesRef.text = "Lives : " + GameManager.Instance.Lives.ToString();
        
        if (GameManager.Instance.Lives == 0){
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
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    } 
}
