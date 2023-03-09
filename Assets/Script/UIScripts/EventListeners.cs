using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EventListeners : MonoBehaviour
{
    [SerializeField] Button _playGame;
    // Start is called before the first frame update
    void Start()
    {
        _playGame.onClick.AddListener(StartPlayGame);
    }

    private void StartPlayGame()
    {
        ScenesManager.Instance.LoadNewGame();
    }

}
