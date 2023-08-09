using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    void OnCollisionEnter (Collision collisionInfo){
        if(collisionInfo.gameObject.tag == "ball"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // void reload(){

    // }
}
