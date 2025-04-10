using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject Button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button.SetActive(false);
        Invoke("ButtonOn", 10f);
    }

    // Update is called once per frame
    void ButtonOn()
    {
        Button.SetActive(true);
    }
}
