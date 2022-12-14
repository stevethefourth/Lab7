using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject item;
    private Tweener tweener;
    // Start is called before the first frame update
    void Start()
    {
        tweener = gameObject.GetComponent<Tweener>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-2.0f, 0.5f, 0.0f), 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(2.0f, 0.5f, 0.0f), 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(0.0f, 0.5f, -2.0f), 0.5f);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(0.0f, 0.5f, 2.0f), 0.5f);
        }


    }
}
