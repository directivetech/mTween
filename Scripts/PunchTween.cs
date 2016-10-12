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
  /// Punch tween.
  /// </summary>
  public class PunchTween : Tween 
  {
    Vector3 from;
    Vector3 amount;
    Vector3 current;
    TweenPoint lookAtPoint;
    Vector3 originalRotation;
    Vector3 currentRotation;
    Transform lookAtTransform;
    AxisType lookAxisOfRotation;
    bool orientToPath = false;
    float lookTime = 0.0f;
    float diminishingControl = 0.0f;
    delegate void ApplyStub();
    ApplyStub apply = null;
    Space space;
    int punchXDirection = 1;
    int punchYDirection = 1;
    int punchZDirection = 1;

    /// <summary>
    /// Initialize this instance.
    /// </summary>
    public override void Initialize()
    {
    }

    /// <summary>
    /// Punchs the position.
    /// </summary>
    /// <param name="amount">Amount.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="axis">Axis.</param>
    /// <param name="lookAtTransform">Look at transform.</param>
    /// <param name="lookAtPoint">Look at point.</param>
    /// <param name="orientToPath">If set to <c>true</c> orient to path.</param>
    /// <param name="lookTime">Look time.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public void PunchPosition(Vector3 amount, float duration, float delay = 0, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, AxisType axis = null, Transform lookAtTransform = null, TweenPoint lookAtPoint = null, bool orientToPath = false, float lookTime = 0, bool ignoreTimescale = false)
    {
    
      this.from = transform.position;
      this.amount = amount;
      this.duration = duration;
      this.originalRotation = transform.eulerAngles;
      this.OnStart = OnStart;
      this.OnUpdate = OnUpdate;
      this.OnComplete = OnComplete;
      this.loop = loop;
      this.lookAtPoint = lookAtPoint;
      this.lookAtTransform = lookAtTransform;
      this.lookAxisOfRotation = axis;
      this.orientToPath = orientToPath;
      this.lookTime = lookTime;
      apply = PositionApply;
      if(this.amount.x < 0)
      {
        punchXDirection = -1;
        this.amount.x = Mathf.Abs(this.amount.x);
      }
      if(this.amount.y < 0)
      {
        punchYDirection = -1;
        this.amount.y = Mathf.Abs(this.amount.y);
      }
      if(this.amount.z < 0)
      {
        punchZDirection = -1;
        this.amount.z = Mathf.Abs(this.amount.z);
      }
    
    }

    /// <summary>
    /// Punchs the rotation.
    /// </summary>
    /// <param name="amount">Amount.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="axis">Axis.</param>
    /// <param name="space">Space.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public void PunchRotation(Vector3 amount, float duration, float delay = 0, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, AxisType axis = null, Space space = Space.World, bool ignoreTimescale = false)
    {
    
      this.from = transform.position;
      this.amount = amount;
      this.duration = duration;
      this.originalRotation = transform.eulerAngles;
      this.OnStart = OnStart;
      this.OnUpdate = OnUpdate;
      this.OnComplete = OnComplete;
      this.loop = loop;
      this.space = space;
      apply = RotateApply;
    }

    /// <summary>
    /// Punchs the scale.
    /// </summary>
    /// <param name="amount">Amount.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="axis">Axis.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public void PunchScale(Vector3 amount, float duration, float delay = 0, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, AxisType axis = null, bool ignoreTimescale = false)
    {
    
      this.from = transform.localScale;
      this.amount = amount;
      this.duration = duration;
      this.originalRotation = transform.eulerAngles;
      this.OnStart = OnStart;
      this.OnUpdate = OnUpdate;
      this.OnComplete = OnComplete;
      this.loop = loop;
      apply = ScaleApply;  
    }

    /// <summary>
    /// Apply this instance.
    /// </summary>
    protected override void Apply()
    {
      if(apply != null)
      {
        apply();
      }
    }

    /// <summary>
    /// Positions the apply.
    /// </summary>
    private void PositionApply()
    {

      currentRotation = transform.eulerAngles;

      current.x = punchXDirection * punch (amount.x, percentage);
      current.y = punchYDirection * punch (amount.y, percentage);
      current.z = punchZDirection * punch (amount.z, percentage);
    
      transform.Translate(current - from);

      from = current;

      if(lookAtPoint != null || lookAtTransform != null)
      {
        transform.eulerAngles = currentRotation;
      }
    }

    /// <summary>
    /// Scales the apply.
    /// </summary>
    private void ScaleApply()
    {
      current.x = punchXDirection * punch (amount.x, percentage);
      current.y = punchYDirection * punch (amount.y, percentage);
      current.z = punchZDirection * punch (amount.z, percentage);
    
      transform.localScale = from + current;
    }

    /// <summary>
    /// Rotates the apply.
    /// </summary>
    private void RotateApply()
    { 
      current.x = punchXDirection * punch (amount.x, percentage);
      current.y = punchYDirection * punch (amount.y, percentage);
      current.z = punchZDirection * punch (amount.z, percentage);
    
      transform.Rotate(current - from,space);

      from = current;
    }

    /// <summary>
    /// Punch the specified amplitude and value.
    /// </summary>
    /// <param name="amplitude">Amplitude.</param>
    /// <param name="value">Value.</param>
    private float punch(float amplitude, float value)
    {
      float s = 9;
      if (value == 0){
        return 0;
      }
      else if (value == 1){
        return 0;
      }
      float period = 1 * 0.3f;
      s = period / (2 * Mathf.PI) * Mathf.Asin(0);
      return (amplitude * Mathf.Pow(2, -10 * value) * Mathf.Sin((value * 1 - s) * (2 * Mathf.PI) / period));
    }
  }
}