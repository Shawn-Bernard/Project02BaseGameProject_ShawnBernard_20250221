using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager Instance;
    //Throwing in my UI manager script so I can have access to the methods
    public UIManager UImanager;
    public LevelManager LevelManger;
    public GameStateManager gameStateManager;

    void Start()
    {
        
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            //Doesn't destroy when new scene is loaded
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }

}
