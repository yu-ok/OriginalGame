using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SportyGirlAnimator : MonoBehaviour
{
        private Animator myAnimator;

        // Use this for initialization
        void Start ()
        {

                this.myAnimator = GetComponent<Animator>();

                this.myAnimator.SetFloat ("Speed", 0);
        }

        void Update ()
        {
                if(Input.anyKey)
                {
                this.myAnimator.SetFloat ("Speed", 0.6f);
                }
                else
                {
                this.myAnimator.SetFloat ("Speed", 0);
                }
        }
}

