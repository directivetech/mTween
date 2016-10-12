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
  /// Pitch audio tween.
  /// </summary>
  public class VolumeAudioTween : AudioTween {

    /// <summary>
    /// Volumes from.
    /// </summary>
    /// <param name="from">From.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    public void VolumeFrom(float from, float duration, float delay = 0, AnimationCurve curve = null, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null) 
    {
      this.current = from;
      this.from = from;
      this.to = transform.GetComponent<AudioSource>().pitch;
      this.duration = duration;
      if(curve != null)
      {
        this.curve = curve;
      }
      this.OnStart = OnStart;
      this.OnUpdate = OnUpdate;
      this.OnComplete = OnComplete;
      this.loop = loop;
    }
  
    /// <summary>
    /// Volumes to.
    /// </summary>
    /// <param name="to">To.</param>
    /// <param name="duration">Duration.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    public void VolumeTo(float to, float duration, float delay = 0, AnimationCurve curve = null, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null) 
    {
      this.current = transform.GetComponent<AudioSource>().pitch;
      this.from = transform.GetComponent<AudioSource>().pitch;
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
    }

    /// <summary>
    /// Apply this instance.
    /// </summary>
    protected override void Apply()
    {
      current = from + ((to - from) * curve.Evaluate (percentage));
      transform.GetComponent<AudioSource>().volume = current;
    }

  }
}