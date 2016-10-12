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
  /// Color tween.
  /// </summary>
  public class ColorTween : Tween {

    public Color current;
    public Color to;
    public Color from;
    public AnimationCurve curve = TweenCurves.linear;
    private int type = 0;
    int count = 0;

    /// <summary>
    /// Initialize this instance.
    /// </summary>
    public override void Initialize()
    {
    }

    /// <summary>
    /// Colors to.
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
    public void ColorTo(Color to, float duration, float delay = 0, AnimationCurve curve = null, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, bool ignoreTimescale = false)
    {
      this.current = getColor ();
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
    /// Colors from.
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
    public void ColorFrom(Color from, float duration, float delay = 0, AnimationCurve curve = null, System.Action OnStart = null, System.Action OnUpdate = null, System.Action OnComplete = null, LoopType loop = null, bool ignoreTimescale = false)
    {

      this.from = from;
      this.current = from;
      this.to = getColor ();
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
      current.r = from.r + ((to.r - from.r) * curve.Evaluate (percentage));
      current.g = from.g + ((to.g - from.g) * curve.Evaluate (percentage));
      current.b = from.b + ((to.b - from.b) * curve.Evaluate (percentage));
      current.a = from.a + ((to.a - from.a) * curve.Evaluate (percentage));

      //replace with delegates for Apply based on type of color in getColor so don't have to check repeatedly?
      //set delegate in setup function - ColorTo or ColorFrom - once instead of doing it each apply cycle
      switch(type)
      {
      case 1:
        transform.GetComponent<GUITexture>().color = current;
        break;
      case 2:
        transform.GetComponent<GUIText>().color = current;
        break;
      case 3:
        GetComponent<Renderer>().material.color = current;
        break;
      case 4:
        transform.GetComponent<Light>().color = current;
        break;
      default:
        break;
      }
    }

    /// <summary>
    /// Gets the color.
    /// </summary>
    /// <returns>The color.</returns>
    private Color getColor()
    {
      if(transform.GetComponent<GUITexture>() != null)
      {
        type = 1;
        return transform.GetComponent<GUITexture>().color;
      }
      else if(transform.GetComponent<GUIText>() != null)
      {
        type = 2;
        return transform.GetComponent<GUIText>().color;
      }
      else if(transform.GetComponent<Renderer>() != null)
      {
        type = 3;
        return transform.GetComponent<Renderer>().material.color;
      }
      else if(transform.GetComponent<Light>() != null)
      {
        type = 4;
        return transform.GetComponent<Light>().color;
      }

      return Color.green;
    }
  }
}