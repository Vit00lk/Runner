using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject objects;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObjects", 1, 1);
    }

    // Update is called once per frame
    void CreateObjects()
    {
        Instantiate(objects, new Vector3(12.35f, 3.69f, 0), Quaternion.identity);
    }
}
