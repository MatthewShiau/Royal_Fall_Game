using UnityEngine;

public class ObstacleController4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0f, -2f) * Time.deltaTime;
    }
}
