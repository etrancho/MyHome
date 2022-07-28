using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Camera cam;
    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void moveCam(){
        cam.transform.position = new Vector3(19.8219f, 0, -10);
    }
    public void moveCam2(){
        cam.transform.position = new Vector3(0,0,-10);
    }
    
}