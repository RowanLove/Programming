using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GoneHome
{
    public class GameManager : MonoBehaviour
    {
        //swtiches to next scene when called
        public void NextLevel()
        {
            //get the current loaded scene
            Scene currentScene = SceneManager.GetActiveScene();
            //load the one next to it (using build index)
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }

        public void ResetLevel()
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex);
        }
    }
}