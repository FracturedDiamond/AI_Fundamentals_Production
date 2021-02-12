using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : Align
{
    public override float getTargetAngle()
    { 
        Vector3 dirToTarget = target.transform.position - character.transform.position;

        float targetAngle = Mathf.Atan2(dirToTarget.x, dirToTarget.z);  // targetAngle is in radians
        targetAngle *= Mathf.Rad2Deg;   // targetAngle is converted to degrees
       
        return targetAngle;
    }
}

    
   

