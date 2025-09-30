using UnityEngine;
using UnityEngine.UIElements;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
