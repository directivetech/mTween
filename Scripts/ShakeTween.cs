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
  /// Shake tween.
  /// </summary>
  public class ShakeTween : Tween 
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

    /// <summary>
    /// Initialize this instance.
    /// </summary>
    public override void Initialize()
    {
    }

    /// <summary>
    /// Shakes the position.
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
    public void ShakePosition(Vector3 amount, float duration, float delay = 0, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, AxisType axis = null, Transform lookAtTransform = null, TweenPoint lookAtPoint = null, bool orientToPath = false, float lookTime = 0, bool ignoreTimescale = false)
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
    
    }

    /// <summary>
    /// Shakes the rotation.
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
    public void ShakeRotation(Vector3 amount, float duration, float delay = 0, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, AxisType axis = null, Space space = Space.World, bool ignoreTimescale = false)
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
    /// Shakes the scale.
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
    public void ShakeScale(Vector3 amount, float duration, float delay = 0, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, AxisType axis = null, bool ignoreTimescale = false)
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

      //if(percentage == 0)
      //{
      //  transform.Translate(amount, Space.World);
      //}

      currentRotation = transform.eulerAngles;

      transform.position = from;

      diminishingControl = 1 - percentage;

      current.x = Random.Range (-amount.x * diminishingControl, amount.x * diminishingControl);
      current.y = Random.Range (-amount.y * diminishingControl, amount.y * diminishingControl);
      current.z = Random.Range (-amount.z * diminishingControl, amount.z * diminishingControl);

      transform.position += current;

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

      transform.localScale = from;

      diminishingControl = 1 - percentage;
    
      current.x = Random.Range (-amount.x * diminishingControl, amount.x * diminishingControl);
      current.y = Random.Range (-amount.y * diminishingControl, amount.y * diminishingControl);
      current.z = Random.Range (-amount.z * diminishingControl, amount.z * diminishingControl);

      transform.localScale += current;
    }

    /// <summary>
    /// Rotates the apply.
    /// </summary>
    private void RotateApply()
    {
      transform.eulerAngles = from;

      diminishingControl = 1 - percentage;
    
      current.x = Random.Range (-amount.x * diminishingControl, amount.x * diminishingControl);
      current.y = Random.Range (-amount.y * diminishingControl, amount.y * diminishingControl);
      current.z = Random.Range (-amount.z * diminishingControl, amount.z * diminishingControl);

      transform.Rotate(current,space);
    }
  }
}