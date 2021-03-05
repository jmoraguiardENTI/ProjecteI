using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    public int numberOfAsteroids = 0;
    public GameObject asteroid = null;
    public int halfWidth = 0;
    public int halfHeight = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (asteroid != null)
        {
            for (int i = 0; i < numberOfAsteroids; ++i)
            {
                Vector2 asteroidPosition = new Vector2(Random.Range(-halfWidth, halfWidth), Random.Range(-halfHeight, halfHeight));

                GameObject.Instantiate(asteroid, asteroidPosition, new Quaternion());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
