// Copyright (c) 2016 Brent Harclerode (Directive Technologies)
//
// This file is part of mTween.
//  
// mTween is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//    
// mTween is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//      
// You should have received a copy of the GNU General Public License
// along with mTween.  If not, see <http://www.gnu.org/licenses/>.

using UnityEngine;
using System.Collections;

namespace mTween {

  /// <summary>
  /// Move tween.
  /// </summary>
  public class MoveTween : Tween 
  {
 
    //Public
    public AnimationCurve curve = TweenCurves.linear;
    public bool isLocal = false;
    public bool moveToPath = true;
    public bool orientToPath = false;
    public bool physicsPresent = false;
    public float lookAhead = 0;
    public float lookTime = 0;
    public float speed = 0;
    public int count = 0;
    public Vector3 position = Vector3.zero;

    //Private
    private AnimationCurve defaultCurve = TweenCurves.linear;
    private AxisType lookAxisOfRotation = null;
    private Quaternion q = default(Quaternion);
    private Transform lookAtTransform = null;
    private TweenPoint lookAtPoint = null;
    private Vector3 current = Vector3.zero;
    private Vector3 from = Vector3.zero;
	  private Vector3 to = Vector3.zero;
    private float pathLength = 0;
    private Vector3[] path;
    private Vector3[] expandedPath;
    private float[] segmentLengths;
    private float totalCurveLength = 0;
    private int granularity = 10;
    private Vector3 p0,p1,p2,p3;

	  /// <summary>
    /// Initialize this instance.
    /// </summary>
	  public override void Initialize () 
    {
      if(transform.GetComponent<Rigidbody>() != null)
      {
        physicsPresent = true;
      }
      else
      {
        physicsPresent = false;
      }
	  }


    /// <summary>
    /// Moves To.
    /// </summary>
    /// <param name="to">To.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="axis">Axis.</param>
    /// <param name="lookAtTransform">Look at transform.</param>
    /// <param name="lookAtPoint">Look at point.</param>
    /// <param name="orientToPath">If set to <c>true</c> orient to path.</param>
    /// <param name="pathOfTransforms">Path of transforms.</param>
    /// <param name="pathOfVectors">Path of vectors.</param>
    /// <param name="granularity">Number of interpolation points between control points.</param> 
    /// <param name="lookTime">Look time.</param>
    /// <param name="lookAhead">Look ahead.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public void MoveTo(Vector3 to,
                       float duration,
                       float delay = 0,
                       AnimationCurve curve = null,
                       System.Action OnStart = null,
                       System.Action OnUpdate = null,
                       System.Action OnComplete = null,
                       LoopType loop = null,
                       AxisType axis = null,
                       Transform lookAtTransform = null,
                       TweenPoint lookAtPoint = null,
                       bool orientToPath = false,
                       float lookTime = 0,
                       float lookAhead = 0.05f,
                       bool moveToPath = false,
                       Transform[] pathOfTransforms = null,
                       Vector3[] pathOfVectors = null,
                       int granularity = 10,
                       bool ignoreTimescale = false) 
    {
      if(pathOfTransforms != null && pathOfVectors != null)
      {
        Debug.LogError("mTween Error: Cannot attempt MoveTo path movement with both Vectors and Transforms");
        return;
      }
      if (pathOfTransforms != null) 
      {
        if (pathOfTransforms.Length < 2) 
        {
          Debug.LogError ("mTween Error: Attempting a path movement with MoveTo requires more than one Transform!");
          return;
        } 
        else
        {
          //copy path over to local variable to "lock" it in
          //add first and last control points
          path = new Vector3[pathOfTransforms.Length + 2];
          for(int i=1; i<pathOfTransforms.Length-1; i++)
          {
            path[i] = pathOfTransforms[i-1].position;
          }
          CreatePathTable(path);
        }
      }
      if (pathOfVectors != null)
      {
        if (pathOfVectors.Length < 2) 
        {
          Debug.LogError("mTween Error: Attempting a path movement with MoveTo requires an array of more than 1 entry!");
          return;
        }
        else
        {
          //copy path over to local variable to "lock" it in
          Debug.Log("path of vectors length:= " + pathOfVectors.Length);
          //add two "fake" control points we add on ends
          path = new Vector3[pathOfVectors.Length + 2];
          for(int i=1; i<pathOfVectors.Length+1; i++)
          {
            path[i] = pathOfVectors[i-1];
          }
          CreatePathTable(path);
        }
      }
    

      this.current = transform.position;
      this.from = transform.position;
      this.to = to;
      this.duration = duration;
      if(curve != null)
      {
        this.curve = curve;
      }
      this.OnStart = OnStart;
      this.OnUpdate = OnUpdate;
      this.OnComplete = OnComplete;
      this.loop = loop;
      this.lookAtPoint = lookAtPoint;
      this.lookAtTransform = lookAtTransform;
      this.lookAxisOfRotation = axis;
      this.orientToPath = orientToPath;
      this.lookTime = lookTime;
      this.lookAhead = lookAhead;
      this.ignoreTimescale = ignoreTimescale;
    }

    /// <summary>
    /// Moves from.
    /// </summary>
    /// <param name="from">From.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="axis">Axis.</param>
    /// <param name="lookAtTransform">Look at transform.</param>
    /// <param name="lookAtPoint">Look at point.</param>
    /// <param name="orientToPath">If set to <c>true</c> orient to path.</param>
    /// <param name="lookTime">Look time.</param>
    /// <param name="lookAhead">Look ahead.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public void MoveFrom(Vector3 from,
                         float duration,
                         float delay = 0,
                         AnimationCurve curve = null,
                         System.Action OnStart = null,
                         System.Action OnUpdate = null,
                         System.Action OnComplete = null,
                         LoopType loop = null,
                         AxisType axis = null,
                         Transform lookAtTransform = null,
                         TweenPoint lookAtPoint = null,
                         bool orientToPath = false,
                         float lookTime = 0,
                         float lookAhead = 0.05f,
                         bool moveToPath = false,
                         Transform[] pathOfTransforms = null,
                         Vector3[] pathOfVectors = null,
                         bool ignoreTimescale = false)
    {
      if (pathOfTransforms != null && pathOfTransforms.Length < 2) 
      {
        Debug.LogError("mTween Error: Attempting a path movement with MoveFrom requires an array of more than 1 entry!");
        return;
      }
      if (pathOfVectors != null && pathOfVectors.Length < 2) 
      {
        Debug.LogError("mTween Error: Attempting a path movement with MoveFrom requires an array of more than 1 entry!");
        return;
      }
      transform.position = from;

      this.from = from;
      this.to = transform.position;
      this.current = from;
      this.duration = duration;
      if(curve != null)
      {
        this.curve = curve;
      }
      this.OnStart = OnStart;
      this.OnUpdate = OnUpdate;
      this.OnComplete = OnComplete;
      this.loop = loop;
      this.lookAtPoint = lookAtPoint;
      this.lookAtTransform = lookAtTransform;
      this.lookAxisOfRotation = axis;
      this.orientToPath = orientToPath;
      this.lookTime = lookTime;
      this.lookAhead = lookAhead;
      this.ignoreTimescale = ignoreTimescale;

    }

    /// <summary>
    /// Moves the by.
    /// </summary>
    /// <param name="toAdd">To add.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="axis">Axis.</param>
    /// <param name="lookAtTransform">Look at transform.</param>
    /// <param name="lookAtPoint">Look at point.</param>
    /// <param name="orientToPath">If set to <c>true</c> orient to path.</param>
    /// <param name="lookTime">Look time.</param>
    /// <param name="lookAhead">Look ahead.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public void MoveBy(Vector3 toAdd,
                       float duration,
                       float delay = 0,
                       AnimationCurve curve = null,
                       System.Action OnStart = null,
                       System.Action OnUpdate = null,
                       System.Action OnComplete = null,
                       LoopType loop = null,
                       AxisType axis = null,
                       Transform lookAtTransform = null,
                       TweenPoint lookAtPoint = null,
                       bool orientToPath = false,
                       float lookTime = 0,
                       float lookAhead = 0.05f,
                       bool ignoreTimescale = false)
    {
      this.from = transform.position;
      this.to = this.from + toAdd;
      this.current = transform.position;
      this.duration = duration;
      if(curve != null)
      {
        this.curve = curve; 
      }
      this.OnStart = OnStart;
      this.OnUpdate = OnUpdate;
      this.OnComplete = OnComplete;
      this.loop = loop;
      this.lookAtPoint = lookAtPoint;
      this.lookAtTransform = lookAtTransform;
      this.lookAxisOfRotation = axis;
      this.orientToPath = orientToPath;
      this.lookTime = lookTime;
      this.lookAhead = lookAhead;
      this.ignoreTimescale = ignoreTimescale;

    }

    /// <summary>
    /// Apply this instance.
    /// </summary>
	  protected override void Apply()
	  {
      int i = 0;
      int i1,i2 = 0;
      float curveDistance = curve.Evaluate(percentage) * totalCurveLength;
      float t1,t2 = 0;
      float fraction = 0;
      //need to replace to.? - from.? with static value so not calculated continually
      //curve.Evaluate only needs to be called once also
      if (!this.moveToPath) {
        current.x = from.x + ((to.x - from.x) * curve.Evaluate (percentage));
        current.y = from.y + ((to.y - from.y) * curve.Evaluate (percentage));
        current.z = from.z + ((to.z - from.z) * curve.Evaluate (percentage));
      } 
      else 
      {
        //find control points for point curveDistance on curve
        //find what percentage distance between two curvelength values desired length is located i1,i2
        //returns the complement of the index of the next largest item in array
        Debug.Log ("percentage:= " + percentage);
        Debug.Log ("curveDistance:= " + curveDistance);


        i1 = System.Array.BinarySearch<float>(segmentLengths,curveDistance);
        Debug.Log ("i1 before:= " + i1);
        if(i1 >= 0)
        {
          //set current to control point
          current = expandedPath[i1+1];
        }
        else
        {
          i1 = ~i1;
        
        
        Debug.Log ("i1:= " + i1);
        i2 = i1 + 1;
       
        int temp = Mathf.CeilToInt((float) i1/granularity);
          Debug.Log ("temp:= " + temp);
        p0 = path[temp-1];
        p1 = path[temp];
        p2 = path[temp + 1];
        p3 = path[temp + 2];


     
        fraction = (curveDistance - segmentLengths[i1-1]) / (segmentLengths[i1] - segmentLengths[i1-1]);
          Debug.Log ("fraction:= " + fraction);
        //use this to determine what t value is by multiplying step size between two points by percentage above
        float t = (((i1-1)%granularity))*((float) 1/granularity) + (fraction * ((float) 1/granularity));
          //Debug.Log ("t:= " + t);
        //plug this t into catmull-rom interpolation and you get vector3 that is location at this point in animation curve
          Debug.Log ("p0:= " + p0);
          Debug.Log ("p1:= " + p1);
          Debug.Log ("p2:= " + p2);
          Debug.Log ("p3:= " + p3);

        current = InterpolateCRSplineHelper(t,p0,p1,p2,p3);
        }
      }

      //Handle Move
      if(physicsPresent)
      {
        GetComponent<Rigidbody>().MovePosition(current);
      }
      else
      {
        if(isLocal)
        {
          transform.localPosition = current;
        }
        else
        {
		      transform.position = current;
        }
      }

      //Handle Look
      if (orientToPath == true)
      {
        //use lookahead
        //path constructed from list of v3s using Catmull-Rom Spline
      }
      else if(lookAtTransform != null)
      {
        if(lookAxisOfRotation != null)
        {
          q = Quaternion.LookRotation(lookAtTransform.position);
          if(lookAxisOfRotation == TweenAxes.x)
          {
            q.y = 0;
            q.z = 0;
          }
          else if(lookAxisOfRotation == TweenAxes.y)
          {
            q.x = 0;
            q.z = 0;
          }
          else
          {
            q.x = 0;
            q.y = 0;
          }
          this.transform.rotation = q;
        }
        else
        {
          this.transform.LookAt(lookAtTransform.position);
        }
      }
      else if(lookAtPoint != null)
      {
        this.transform.LookAt(new Vector3(lookAtPoint.X, lookAtPoint.Y, lookAtPoint.Z));
      }
 
    }

    private void InterpolateCRSpline(Vector3[] path, Vector3[] expandedPath)
    {

      int pathLength = path.Length;
      int expandedPathLength = expandedPath.Length; //((path.Length -1) * granularity) + path.Length
      int i,j = 0;

      //fill in knowns (control points)
      expandedPath [0] = path [0];
      expandedPath [expandedPath.Length - 1] = path [pathLength-1];
      for (i = 0; i < pathLength-2; i++) 
      {
        expandedPath[(i*granularity)+1] = path[i+1];
      }

      //interpolate each group of 4 control points to obtain the intermediate points 
      //# of splines = path.Length - 3
      for (i=0; i < pathLength-3; i++) 
      {
        //run through granularity points for each segment
        for(j=1; j<granularity  ;j++)
        {
          expandedPath[(i*granularity)+j+1]= InterpolateCRSplineHelper(j*(1f/granularity), path[i], path[i+1], path[i+2], path[i+3]);
        }
      }

    }
  
    //http://www.iquilezles.org/www/articles/minispline/minispline.htm
    private Vector3 InterpolateCRSplineHelper(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
    {

      Debug.Log ("t:= " + t);
      Vector3 a = 0.5f * (2f * p1);
      Vector3 b = 0.5f * (p2 - p0);
      Vector3 c = 0.5f * (2f * p0 - 5f * p1 + 4f * p2 - p3);
      Vector3 d = 0.5f * (-p0 + 3f * p1 - 3f * p2 + p3);
//      Debug.Log ("a:= " + a);
//      Debug.Log ("b:= " + b);
//      Debug.Log ("c:= " + c);
//      Debug.Log ("d:= " + d);
      Vector3 pos = a + (b * t) + (c * t * t) + (d * t * t * t);
      Debug.Log ("pos:= " + pos);
      return pos;
    }

    private float SegmentLength(Vector3 a, Vector3 b)
    {
      return Mathf.Sqrt (Mathf.Pow ((b.x - a.x), 2) + Mathf.Pow ((b.y - a.y), 2) + Mathf.Pow ((b.z - a.z), 2));
    }

    private void CreatePathTable(Vector3[] path)
    {
      int i;
      int numControlPoints = path.Length; 
       Debug.Log("granularity:= " + granularity);
      Debug.Log ("numControlPoints:= " + numControlPoints);
      expandedPath = new Vector3[(granularity * (numControlPoints-3)) + 3];
      segmentLengths = new float[(granularity * (numControlPoints-3)) + 1];

      //set first and last control points - method of calculation can vary depending on desired result
      path [0] = path[1] + (path[1] - path[2]);
      path [path.Length - 1] = path[path.Length - 2] + (path[path.Length - 2] - path[path.Length - 3]);
      //Create Catmull-Rom Spline over all control points
      for(i=0;i<path.Length;i++)
      {
        Debug.Log ("path[" + i + "]:= " + path[i]);
      }
      InterpolateCRSpline (path, expandedPath);
      for(i=0;i<expandedPath.Length;i++)
      {
        Debug.Log ("expandedPath[" + i + "]:= " + expandedPath[i]);
      }
      segmentLengths [0] = 0;
      //find distance between each of the points and store cumulative sum in array
      for (i = 1; i < segmentLengths.Length; i++)
      {
        segmentLengths[i] = segmentLengths[i-1] + SegmentLength(expandedPath[i], expandedPath[i+1]);

      }
      totalCurveLength = segmentLengths [segmentLengths.Length-1];

      for(i=0;i<segmentLengths.Length;i++)
      {
        Debug.Log ("segmentLengths[" + i + "]:= " + segmentLengths[i]);
      }
      Debug.Log ("totalCurveLength:= " + totalCurveLength);
    }
       
  }


}

