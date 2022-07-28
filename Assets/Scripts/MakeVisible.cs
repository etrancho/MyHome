using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeVisible : MonoBehaviour
{
    public GameObject object1;
    public GameObject friend1;
    public static bool Inn = false;
    public static bool Inn2 = false;

    public void stateTrue(){
        if(!Inn){
            object1.SetActive(true);
            Inn = true;
        } else{
            object1.SetActive(false);
            Inn = false;
        }
    }
    public void seeFriend(){
        if(!Inn2){
            friend1.SetActive(true);
            Inn2 = true;
        } else{
            friend1.SetActive(false);
            Inn2 = false;
        }
    }
    // void OnCollisionEnter(Collision collision){
    //     if (collision.gameObject.name == "chair")
    //     {
            
    //     }

    //     //Check for a match with the specific tag on any GameObject that collides with your GameObject
    //     if (collision.gameObject.tag == "MyGameObjectTag")
    //     {
            
    //     }
    // }
        
}
