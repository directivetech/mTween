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

namespace mTween{

  /// <summary>
  /// mTween extensions.
  /// </summary>
  public static class mTweenExtensions
  {

    //MoveTween

    /// <summary>
    /// Moves to.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="position">Position.</param>
    /// <param name="time">Time.</param>
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
    public static void MoveTo(this Transform trans,
                              Vector3 position,
                              float time,
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
                              float lookAhead = 0,
                              bool moveToPath = false,
                              Transform[] pathOfTransforms = null,
                              Vector3[] pathOfVectors = null,
                              int granularity = 10,
                              bool ignoreTimescale = false)
    {
		  MoveTween mt = trans.gameObject.AddComponent <MoveTween>();
      mt.MoveTo (position,
                 time,
                 delay,
                 curve,
                 OnStart,
                 OnUpdate,
                 OnComplete,
                 loop,
                 axis,
                 lookAtTransform,
                 lookAtPoint,
                 orientToPath,
                 lookTime,
                 lookAhead, 
                 moveToPath,
                 pathOfTransforms,
                 pathOfVectors,
                 granularity,
                 ignoreTimescale);
    }

    /// <summary>
    /// Moves from.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="position">Position.</param>
    /// <param name="time">Time.</param>
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
    public static void MoveFrom(this Transform trans,
                                Vector3 position,
                                float time,
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
                                float lookAhead = 0,
                                bool moveToPath = false,
                                Transform[] pathOfTransforms = null,
                                Vector3[] pathOfVectors = null,
                                bool ignoreTimescale = false)
    {
      MoveTween mt = trans.gameObject.AddComponent <MoveTween>();
      mt.MoveFrom (position, 
                   time, 
                   delay, 
                   curve, 
                   OnStart, 
                   OnUpdate, 
                   OnComplete, 
                   loop, 
                   axis, 
                   lookAtTransform, 
                   lookAtPoint, 
                   orientToPath, 
                   lookTime, 
                   lookAhead, 
                   moveToPath, 
                   pathOfTransforms, 
                   pathOfVectors, 
                   ignoreTimescale);
    }

    /// <summary>
    /// Moves the by.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="toAdd">To add.</param>
    /// <param name="time">Time.</param>
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
    public static void MoveBy(this Transform trans,
                              Vector3 toAdd,
                              float time,
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
                              float lookAhead = 0,
                              bool ignoreTimescale = false)
    {
      MoveTween mt = trans.gameObject.AddComponent <MoveTween>();
      mt.MoveBy (toAdd, time, delay, curve, OnStart, OnUpdate, OnComplete, loop, axis, lookAtTransform, lookAtPoint, orientToPath, lookTime, lookAhead, ignoreTimescale);
    }


    //RotateTween

    /// <summary>
    /// Rotates to.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="position">Position.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void RotateTo(this Transform trans,
                                Vector3 position,
                                float time,
                                float delay = 0,
                                AnimationCurve curve = null,
                                System.Action OnStart = null,
                                System.Action OnUpdate = null,
                                System.Action OnComplete = null,
                                LoopType loop = null,
                                bool ignoreTimescale = false)
    {
      RotateTween rt = trans.gameObject.AddComponent <RotateTween>();
      rt.RotateTo (position, time, delay, curve, OnStart, OnUpdate, OnComplete, loop, ignoreTimescale);
    }

    /// <summary>
    /// Rotates from.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="position">Position.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void RotateFrom(this Transform trans,
                                  Vector3 position,
                                  float time,
                                  float delay = 0,
                                  AnimationCurve curve = null,
                                  System.Action OnStart = null,
                                  System.Action OnUpdate = null,
                                  System.Action OnComplete = null,
                                  LoopType loop = null,
                                  bool ignoreTimescale = false)
    {
      RotateTween rt = trans.gameObject.AddComponent <RotateTween>();
      rt.RotateFrom (position, time, delay, curve, OnStart, OnUpdate, OnComplete, loop, ignoreTimescale);
    }

    /// <summary>
    /// Rotates the by.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="toAdd">To add.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void RotateBy(this Transform trans,
                                Vector3 toAdd,
                                float time,
                                float delay = 0,
                                AnimationCurve curve = null,
                                System.Action OnStart = null,
                                System.Action OnUpdate = null,
                                System.Action OnComplete = null,
                                LoopType loop = null,
                                bool ignoreTimescale = false)
    {
      RotateTween rt = trans.gameObject.AddComponent <RotateTween>();
      rt.RotateBy (toAdd, time, delay, curve, OnStart, OnUpdate, OnComplete, loop, ignoreTimescale);
    }


    //ColorTween

    /// <summary>
    /// Colors to.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="target">Target.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void ColorTo(this Transform trans,
                               Color target,
                               float time,
                               float delay = 0,
                               AnimationCurve curve = null,
                               System.Action OnStart = null,
                               System.Action OnUpdate = null,
                               System.Action OnComplete = null,
                               LoopType loop = null,
                               bool ignoreTimescale = false)
    {
      ColorTween ct = trans.gameObject.AddComponent <ColorTween>();
      ct.ColorTo (target, time, delay, curve, OnStart, OnUpdate, OnComplete, loop, ignoreTimescale);
    }

    /// <summary>
    /// Colors from.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="target">Target.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void ColorFrom(this Transform trans,
                                 Color target,
                                 float time,
                                 float delay = 0,
                                 AnimationCurve curve = null,
                                 System.Action OnStart = null,
                                 System.Action OnUpdate = null,
                                 System.Action OnComplete = null,
                                 LoopType loop = null,
                                 bool ignoreTimescale = false)
    {
      ColorTween ct = trans.gameObject.AddComponent <ColorTween>();
      ct.ColorFrom (target, time, delay, curve, OnStart, OnUpdate, OnComplete, loop, ignoreTimescale);
    }


    //ScaleTween

    /// <summary>
    /// Scales to.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="target">Target.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void ScaleTo(this Transform trans,
                               Vector3 target,
                               float time,
                               float delay = 0,
                               AnimationCurve curve = null,
                               System.Action OnStart = null,
                               System.Action OnUpdate = null,
                               System.Action OnComplete = null,
                               LoopType loop = null,
                               bool ignoreTimescale = false)
    {
      ScaleTween st = trans.gameObject.AddComponent <ScaleTween>();
      st.ScaleTo (target, time, delay, curve, OnStart, OnUpdate, OnComplete, loop, ignoreTimescale);
    }

    /// <summary>
    /// Scales from.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="target">Target.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void ScaleFrom(this Transform trans,
                                 Vector3 target,
                                 float time,
                                 float delay = 0,
                                 AnimationCurve curve = null,
                                 System.Action OnStart = null,
                                 System.Action OnUpdate = null,
                                 System.Action OnComplete = null,
                                 LoopType loop = null,
                                 bool ignoreTimescale = false)
    {
      ScaleTween st = trans.gameObject.AddComponent <ScaleTween>();
      st.ScaleFrom (target, time, delay, curve, OnStart, OnUpdate, OnComplete, loop, ignoreTimescale);
    }

    /// <summary>
    /// Scales the by.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="target">Target.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void ScaleBy(this Transform trans,
                               Vector3 target,
                               float time,
                               float delay = 0,
                               AnimationCurve curve = null,
                               System.Action OnStart = null,
                               System.Action OnUpdate = null,
                               System.Action OnComplete = null,
                               LoopType loop = null,
                               bool ignoreTimescale = false)
    {
      ScaleTween st = trans.gameObject.AddComponent <ScaleTween>();
      st.ScaleBy (target, time, delay, curve, OnStart, OnUpdate, OnComplete, loop, ignoreTimescale);
    }

    /// <summary>
    /// Scales the add.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="target">Target.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void ScaleAdd(this Transform trans,
                                Vector3 target,
                                float time,
                                float delay = 0,
                                AnimationCurve curve = null,
                                System.Action OnStart = null,
                                System.Action OnUpdate = null,
                                System.Action OnComplete = null,
                                LoopType loop = null,
                                bool ignoreTimescale = false)
    {
      ScaleTween st = trans.gameObject.AddComponent <ScaleTween>();
      st.ScaleAdd (target, time, delay, curve, OnStart, OnUpdate, OnComplete, loop, ignoreTimescale);
    }


    //ShakeTween

    /// <summary>
    /// Shakes the position.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="amount">Amount.</param>
    /// <param name="time">Time.</param>
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
    public static void ShakePosition(this Transform trans,
                                     Vector3 amount,
                                     float time,
                                     float delay = 0,
                                     System.Action OnStart = null,
                                     System.Action OnUpdate = null,
                                     System.Action OnComplete = null,
                                     LoopType loop = null,
                                     AxisType axis = null,
                                     Transform lookAtTransform = null,
                                     TweenPoint lookAtPoint = null,
                                     bool orientToPath = false,
                                     float lookTime = 0,
                                     bool ignoreTimescale = false)
    {
      ShakeTween st = trans.gameObject.AddComponent <ShakeTween>();
      st.ShakePosition (amount, time, delay, OnStart, OnUpdate, OnComplete, loop, axis, lookAtTransform, lookAtPoint, orientToPath, lookTime, ignoreTimescale);
    }

    /// <summary>
    /// Shakes the rotation.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="amount">Amount.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="axis">Axis.</param>
    /// <param name="space">Space.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void ShakeRotation(this Transform trans,
                                     Vector3 amount,
                                     float time,
                                     float delay = 0,
                                     System.Action OnStart = null,
                                     System.Action OnUpdate = null,
                                     System.Action OnComplete = null,
                                     LoopType loop = null,
                                     AxisType axis = null,
                                     Space space = Space.World,
                                     bool ignoreTimescale = false)
    {
      ShakeTween st = trans.gameObject.AddComponent <ShakeTween>();
      st.ShakeRotation (amount, time, delay, OnStart, OnUpdate, OnComplete, loop, axis, space, ignoreTimescale);
    }

    /// <summary>
    /// Shakes the scale.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="amount">Amount.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="axis">Axis.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void ShakeScale(this Transform trans,
                                  Vector3 amount,
                                  float time,
                                  float delay = 0,
                                  System.Action OnStart = null,
                                  System.Action OnUpdate = null,
                                  System.Action OnComplete = null,
                                  LoopType loop = null,
                                  AxisType axis = null,
                                  bool ignoreTimescale = false)
      {
        ShakeTween st = trans.gameObject.AddComponent <ShakeTween>();
        st.ShakeScale (amount, time, delay, OnStart, OnUpdate, OnComplete, loop, axis, ignoreTimescale);
      }

    //PunchTween

    /// <summary>
    /// Punchs the position.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="amount">Amount.</param>
    /// <param name="time">Time.</param>
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
    public static void PunchPosition(this Transform trans,
                                     Vector3 amount,
                                     float time,
                                     float delay = 0,
                                     System.Action OnStart = null,
                                     System.Action OnUpdate = null,
                                     System.Action OnComplete = null,
                                     LoopType loop = null,
                                     AxisType axis = null,
                                     Transform lookAtTransform = null,
                                     TweenPoint lookAtPoint = null,
                                     bool orientToPath = false,
                                     float lookTime = 0,
                                     bool ignoreTimescale = false)
    {
      PunchTween pt = trans.gameObject.AddComponent <PunchTween>();
      pt.PunchPosition (amount, time, delay, OnStart, OnUpdate, OnComplete, loop, axis, lookAtTransform, lookAtPoint, orientToPath, lookTime, ignoreTimescale);
    }

    /// <summary>
    /// Punchs the rotation.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="amount">Amount.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="axis">Axis.</param>
    /// <param name="space">Space.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void PunchRotation(this Transform trans,
                                     Vector3 amount,
                                     float time,
                                     float delay = 0,
                                     System.Action OnStart = null,
                                     System.Action OnUpdate = null,
                                     System.Action OnComplete = null,
                                     LoopType loop = null,
                                     AxisType axis = null,
                                     Space space = Space.World,
                                     bool ignoreTimescale = false)
    {
      PunchTween pt = trans.gameObject.AddComponent <PunchTween>();
      pt.PunchRotation (amount, time, delay, OnStart, OnUpdate, OnComplete, loop, axis, space, ignoreTimescale);
    }

    /// <summary>
    /// Punchs the scale.
    /// </summary>
    /// <param name="amount">A <see cref="Vector3"/></param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    /// <param name="axis">Axis.</param>
    /// <param name="ignoreTimescale">If set to <c>true</c> ignore timescale.</param>
    public static void PunchScale(this Transform trans,
                                  Vector3 amount,
                                  float time,
                                  float delay = 0,
                                  System.Action OnStart = null,
                                  System.Action OnUpdate = null,
                                  System.Action OnComplete = null,
                                  LoopType loop = null,
                                  AxisType axis = null,
                                  bool ignoreTimescale = false)
    {
      PunchTween pt = trans.gameObject.AddComponent <PunchTween>();
      pt.PunchScale (amount, time, delay, OnStart, OnUpdate, OnComplete, loop, axis, ignoreTimescale);
    } 

    /// <summary>
    /// Volumes to.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="volume">Volume.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    public static void VolumeTo(this Transform trans,
                                float volume,
                                float time,
                                float delay = 0,
                                AnimationCurve curve = null,
                                System.Action OnStart = null,
                                System.Action OnUpdate = null,
                                System.Action OnComplete = null,
                                LoopType loop = null)
    {
      if (trans.GetComponent<AudioSource>() != null) 
      {
        VolumeAudioTween vat = trans.gameObject.AddComponent <VolumeAudioTween>();
        vat.VolumeTo (volume, time, delay, curve, OnStart, OnUpdate, OnComplete, loop);
      } 
      else 
      {
        Debug.LogError ("mTween Error: VolumeTo cannot be applied to GameObject without AudioSource");
      }
    }

    /// <summary>
    /// Volumes from.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="volume">Volume.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    public static void VolumeFrom(this Transform trans,
                                  float volume,
                                  float time,
                                  float delay = 0,
                                  AnimationCurve curve = null,
                                  System.Action OnStart = null,
                                  System.Action OnUpdate = null,
                                  System.Action OnComplete = null,
                                  LoopType loop = null)
    {
      if (trans.GetComponent<AudioSource>() != null) 
      {
        VolumeAudioTween vat = trans.gameObject.AddComponent <VolumeAudioTween>();
        vat.VolumeFrom (volume, time, delay, curve, OnStart, OnUpdate, OnComplete, loop);
      } 
      else 
      {
        Debug.LogError ("mTween Error: VolumeFrom cannot be applied to GameObject without AudioSource");
      }
    }

    /// <summary>
    /// Pitchs to.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="pitch">Pitch.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    public static void PitchTo(this Transform trans,
                               float pitch,
                               float time,
                               float delay = 0,
                               AnimationCurve curve = null,
                               System.Action OnStart = null,
                               System.Action OnUpdate = null,
                               System.Action OnComplete = null,
                               LoopType loop = null)
    {
      if (trans.GetComponent<AudioSource>() != null) 
      {
        PitchAudioTween pat = trans.gameObject.AddComponent <PitchAudioTween>();
        pat.PitchTo (pitch, time, delay, curve, OnStart, OnUpdate, OnComplete, loop);
      } 
      else 
      {
        Debug.LogError ("mTween Error: PitchTo cannot be applied to GameObject without AudioSource");
      }
    }

    /// <summary>
    /// Pitchs from.
    /// </summary>
    /// <param name="trans">Trans.</param>
    /// <param name="pitch">Pitch.</param>
    /// <param name="time">Time.</param>
    /// <param name="delay">Delay.</param>
    /// <param name="curve">Curve.</param>
    /// <param name="OnStart">On start.</param>
    /// <param name="OnUpdate">On update.</param>
    /// <param name="OnComplete">On complete.</param>
    /// <param name="loop">Loop.</param>
    public static void PitchFrom(this Transform trans, 
                                 float pitch, float time,
                                 float delay = 0,
                                 AnimationCurve curve = null,
                                 System.Action OnStart = null,
                                 System.Action OnUpdate = null,
                                 System.Action OnComplete = null,
                                 LoopType loop = null)
    {
      if (trans.GetComponent<AudioSource>() != null) 
      {
        PitchAudioTween pat = trans.gameObject.AddComponent <PitchAudioTween>();
        pat.PitchFrom (pitch, time, delay, curve, OnStart, OnUpdate, OnComplete, loop);
      } 
      else 
      {
        Debug.LogError ("mTween Error: PitchFrom cannot be applied to GameObject without AudioSource");
      }
    }

    //Shared

    /// <summary>
    /// Stops all tweens on given GameObject transform
    /// </summary>
    /// <param name="trans">Trans.</param>
    public static void StopTweens(this Transform trans)  
    {
      Component[] comps;

      comps = trans.GetComponents<Tween>();

      foreach (Tween comp in comps)
      {
        comp.Stop();
      }
    }
  }
}