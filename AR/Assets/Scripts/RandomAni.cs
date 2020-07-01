using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAni : MonoBehaviour
{
    private Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void Randomani()
    {
        int ra = Random.Range(0, 4);
        ra = ra + 1;
        string str = ra.ToString();

        anim.SetTrigger(str);
    }
}
