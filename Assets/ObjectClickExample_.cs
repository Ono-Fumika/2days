using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ObjectClickExample_ : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D rb2;
    public HingeJoint2D joint;
    public HingeJoint2D joint2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        joint = GetComponent<HingeJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void change_()
    {
        print($"オブジェクト {name} がクリックされたよ！");
        rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rb2.constraints = RigidbodyConstraints2D.None;
        joint.connectedBody = null;
        joint2.connectedBody = rb2;
    }
}
