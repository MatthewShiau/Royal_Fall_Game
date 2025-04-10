using UnityEngine;

public class CameraControllerScene3 : MonoBehaviour
{
    public GameObject EndCredits;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EndCredits.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("MoveUp", 2f);
    }

    void MoveUp()
    {
        transform.position += new Vector3(0f, 4f, 0f) * 1 / 1200;
        EndCredits.SetActive(true);
    }
}
