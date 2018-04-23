using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour {
    private DissableMovement _dissableMovement;
    private Animator _anim;
    private int _walking = Animator.StringToHash("WalkTrue");
    private int _falseWalking = Animator.StringToHash("WalkFalse");
	// Use this for initialization
	void Start () {
        _anim = GetComponent<Animator>();
        _dissableMovement = GameObject.Find("Player").GetComponent<DissableMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		if (_dissableMovement.WalkAnim)
        {
            _anim.SetTrigger(_walking);
            _anim.ResetTrigger(_falseWalking);
        } else
        {
            _anim.ResetTrigger(_walking);
            _anim.SetTrigger(_falseWalking);
        }
	}
}
