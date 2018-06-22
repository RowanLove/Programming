using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace Project
{
    public class GameManager : MonoBehaviour
    {
        void Update()
        {
            //
            if(transform.childCount<1)
            {
                // Get active scene
                Scene currentScene = SceneManager.GetActiveScene();
                // Load the next scene up using buildIndex
                SceneManager.LoadScene(currentScene.buildIndex + 1);
            }
        }
       
    }
}