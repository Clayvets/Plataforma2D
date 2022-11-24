using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

namespace AnaNanita
{
    public class SceneManager : MonoBehaviour
    {
        
        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void NewGame()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        }
        
        public void Continue()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        }

        public void Exit()
        {
            Application.Quit();
        }
        
    }
}
