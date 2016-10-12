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
  /// Scale tween.
  /// </summary>
  public class ScaleTween : Tween 
  {
  
    public Vector3 current;
    public Vector3 to;
    public Vector3 from;
    public AnimationCurve curve = TweenCurves.linear;
    private int type = 0;
  
    /// <summary>
    /// Initialize this instance.
    /// </summary>
    public override void Initialize()
    {
    }

    /// <summary>
    /// Scales to.
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
    public void ScaleTo(Vector3 to, float duration, float delay = 0, AnimationCurve curve = null, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, bool ignoreTimescale = false)
    {
      this.current = transform.localScale;
      this.from = this.current;
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
    /// Scales from.
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
    public void ScaleFrom(Vector3 from, float duration, float delay = 0, AnimationCurve curve = null, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, bool ignoreTimescale = false)
    {
    
      this.from = from;
      this.current = from;
      this.to = transform.localScale;
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
    /// Scales the by.
    /// </summary>
    /// <param name="by">By.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public void ScaleBy(Vector3 by, float duration, float delay = 0, AnimationCurve curve = null, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, bool ignoreTimescale = false)
    {
    
      this.from = transform.localScale;
      this.current = transform.localScale;
      this.to = Vector3.Scale (transform.localScale,by);
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
    /// Scales the add.
    /// </summary>
    /// <param name="add">Add.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public void ScaleAdd(Vector3 add, float duration, float delay = 0, AnimationCurve curve = null, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, bool ignoreTimescale = false)
    {
    
      this.from = transform.localScale;
      this.current = transform.localScale;
      this.to = transform.localScale + add;
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

      transform.localScale = current;
    
    }
   
  }
}
