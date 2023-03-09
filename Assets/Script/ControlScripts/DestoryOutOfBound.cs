using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBound : MonoBehaviour
{
    [SerializeField] private float _boundaryZ = 30;
    private float _boundaryX = 60;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > _boundaryZ)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -_boundaryZ)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        if (transform.position.x < -_boundaryX)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        if (transform.position.x > _boundaryX)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
