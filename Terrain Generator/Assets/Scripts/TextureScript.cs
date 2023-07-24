using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScript : MonoBehaviour
{
    Camera cam;
    Vector3 position = new Vector3();
    Vector3 scale = new Vector3();
    

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float height = cam.orthographicSize;
        float width = height * cam.aspect;
        scale.Set(width/4.7f,width/4.7f,width/4.7f);

        transform.localScale = scale;

        float posInWidth = -(width) +(transform.localScale.x);
        position.Set(posInWidth,height-(transform.localScale.y),1);
        transform.position = position;

    }
}
