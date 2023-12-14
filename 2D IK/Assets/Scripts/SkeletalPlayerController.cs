using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletalPlayerController : MonoBehaviour
{
    Animator thisAnimator;

    float inpHor;

    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        thisAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inpHor = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * inpHor * speed * Time.deltaTime;

        if (inpHor < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (inpHor > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        thisAnimator.SetFloat("Speed" , Mathf.Abs (inpHor));
    }
}
