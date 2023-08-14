using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadScene : MonoBehaviour
{
    public Text livesRef;
    public short lives;

    void Start(){
        livesRef.text = "Lives : " + lives.ToString();
    }

    void OnCollisionEnter (Collision collisionInfo){
        if(collisionInfo.gameObject.tag == "ball"){
            lives--;
            livesRef.text = "Lives : " + lives.ToString();
            if (lives == 0){
                reload();
            }
        }
    }

    public void reload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }

    public void QuitGame(){
        // UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    } 
}
