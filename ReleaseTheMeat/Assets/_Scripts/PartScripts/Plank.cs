using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Plank : MonoBehaviour
{
    /*[NonSerialized] public Vector2 startPoint;
    [NonSerialized] public Vector2 endPoint;

    [NonSerialized] public GameObject objAttachedToStart;
    [NonSerialized] public GameObject objAttachedToEnd;

    [SerializeField] float springDamp;
    [SerializeField] float springFrequency;

    public void CheckForAttachedParts()
    {
        if (objAttachedToStart)
        {
            Rigidbody2D objAttachedToStartRB = objAttachedToStart.GetComponent<Rigidbody2D>();

            CreateHingeJoint(startPoint, objAttachedToStartRB);
            CreateDistanceJoint(startPoint, objAttachedToStartRB);
        }
        if (objAttachedToEnd)
        {
            Rigidbody2D objAttachedToEndRB = objAttachedToEnd.GetComponent<Rigidbody2D>();

            CreateHingeJoint(endPoint, objAttachedToEndRB);
            CreateDistanceJoint(endPoint, objAttachedToEndRB);
        }
    }

    public void CreateHingeJoint(Vector2 anchor, Rigidbody2D body)
    {
        HingeJoint2D hingeJoint = gameObject.AddComponent<HingeJoint2D>();
        hingeJoint.autoConfigureConnectedAnchor = false;
        hingeJoint.connectedBody = body;
        hingeJoint.anchor = transform.InverseTransformPoint(anchor);
        hingeJoint.connectedAnchor = body.transform.InverseTransformPoint(anchor);
    }

    public void CreateDistanceJoint(Vector2 anchor, Rigidbody2D body)
    {
        DistanceJoint2D distanceJoint = gameObject.AddComponent<DistanceJoint2D>();

        distanceJoint.autoConfigureDistance = false;
        distanceJoint.distance = 0;

        distanceJoint.maxDistanceOnly = true;
        distanceJoint.autoConfigureConnectedAnchor = false;
        

        distanceJoint.connectedBody = body;
        distanceJoint.anchor = transform.InverseTransformPoint(anchor);
        distanceJoint.connectedAnchor = body.transform.InverseTransformPoint(anchor);
    }*/
}

