using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        playControllerScript =
            GameObject.Find("Player").GetComponent<PlayController>();

    }
    private float speed = 30;
    private PlayController playControllerScript;
    private float leftBound = -15;

    // Update is called once per frame
    void Update()
    {
        if (playControllerScript.gameOver == false)
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
