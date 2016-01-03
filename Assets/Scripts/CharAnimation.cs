using UnityEngine;
using System.Collections;


public class CharAnimation : MonoBehaviour
{
    public Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
        anim.Play("Walk");
    }
    void Update()
    {
        //Debug.Log(anim.gameObject.name);
        if (Input.GetButtonDown("Fire1"))
        {
            anim.PlayQueued("Attack", QueueMode.PlayNow);
            anim.PlayQueued("Walk", QueueMode.CompleteOthers);
        }    
    }
}
