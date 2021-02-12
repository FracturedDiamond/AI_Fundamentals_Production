using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Separater : Kinematic
{
    Separation myMoveType;
    Align myAlignRotateType; //We just decided it would be this

    public GameObject[] myTargets = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new Separation();
        myMoveType.character = this;
        myMoveType.targets = myTargets;

        myAlignRotateType = new Align();
        myAlignRotateType.character = this;
        myAlignRotateType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myAlignRotateType.getSteering().angular;
        base.Update();
    }
}
