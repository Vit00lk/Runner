using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ObjectMove : MonoBehaviour
{
    public float s;

    private void Start()
    {
        s = 0.16f;
    }
    // Start is called before the first frame update
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - s, transform.position.y, 0);
        if (transform.position.x <= -27.5f)

        {

            Destroy(gameObject);

        }
    }
}
