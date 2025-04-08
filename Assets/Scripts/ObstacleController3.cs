using UnityEngine;

public class ObstacleController3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.5f, 0f, 0f) * Time.deltaTime;
    }
}
