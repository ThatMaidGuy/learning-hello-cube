using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("HelloWorld");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) Destroy(this.gameObject);
    }
}
