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
  /// Rotate tween.
  /// </summary>
  public class RotateTween : Tween 
  {

    public Vector3 current;
    public Vector3 from;
    public Vector3 to;
    public AnimationCurve curve = TweenCurves.linear;
    public bool physicsPresent = false;
    public bool isLocal = false;
    private Quaternion q = default(Quaternion);

    /// <summary>
    /// Initialize this instance.
    /// </summary>
    public override void Initialize()
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
    /// Rotates to.
    /// </summary>
    /// <param name="to">To.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public void RotateTo(Vector3 to, float duration, float delay = 0, AnimationCurve curve = null, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, bool ignoreTimescale = false) 
    {
      this.current = transform.eulerAngles;
      this.from = transform.eulerAngles;
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
      this.ignoreTimescale = ignoreTimescale;
    }

    /// <summary>
    /// Rotates from.
    /// </summary>
    /// <param name="from">From.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public void RotateFrom(Vector3 from, float duration, float delay = 0, AnimationCurve curve = null, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, bool ignoreTimescale = false)
    {

      transform.eulerAngles = from;
    
      this.from = from;
      this.to = transform.eulerAngles;
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
      this.ignoreTimescale = ignoreTimescale;
    
    }

    /// <summary>
    /// Rotates the by.
    /// </summary>
    /// <param name="toAdd">To add.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public void RotateBy(Vector3 toAdd, float duration, float delay = 0, AnimationCurve curve = null, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, bool ignoreTimescale = false)
    {
      this.from = transform.eulerAngles;
      this.to = transform.eulerAngles + toAdd;
      this.current = transform.eulerAngles;
      this.duration = duration;
      if(curve != null)
      {
        this.curve = curve; 
      }
      this.OnStart = OnStart;
      this.OnUpdate = OnUpdate;
      this.OnComplete = OnComplete;
      this.loop = loop;
      this.ignoreTimescale = ignoreTimescale;
    
    }

    /// <summary>
    /// Apply this instance.
    /// </summary>
    protected override void Apply()
    {
      //need to replace to.? - from.? with static value so not calculated continually
      //curve.Evaluate only needs to be called once also
      current.x = from.x + ((to.x - from.x) * curve.Evaluate (percentage));
      current.y = from.y + ((to.y - from.y) * curve.Evaluate (percentage));
      current.z = from.z + ((to.z - from.z) * curve.Evaluate (percentage));

      //if(isLocal)
      //{
      //  transform.Rotate(current, Space.Self);
      //}
      //else
      //{
      // transform.Rotate(current, Space.World);
      transform.eulerAngles = current;

      //}
    }
  }
}
