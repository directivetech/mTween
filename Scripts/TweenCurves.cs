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
  /// Tween curves.
  /// </summary>
  public class TweenCurves : MonoBehaviour 
  {

    /// <summary>
    /// The ease in quad.
    /// </summary>
    public static AnimationCurve easeInQuad = new AnimationCurve(

      new Keyframe(0.0f, 0.00f, 0.0f, 0.0f), 
      new Keyframe(0.1f, 0.01f, 0.2f, 0.2f),
      new Keyframe(0.2f, 0.04f, 0.4f, 0.4f), 
      new Keyframe(0.3f, 0.09f, 0.6f, 0.6f),
      new Keyframe(0.4f, 0.16f, 0.8f, 0.8f), 
      new Keyframe(0.5f, 0.25f, 1.0f, 1.0f),
      new Keyframe(0.6f, 0.36f, 1.2f, 1.2f), 
      new Keyframe(0.7f, 0.49f, 1.4f, 1.4f),
      new Keyframe(0.8f, 0.64f, 1.6f, 1.6f), 
      new Keyframe(0.9f, 0.81f, 1.8f, 1.8f),
      new Keyframe(1.0f, 1.00f, 2.0f, 2.0f));

    /// <summary>
    /// The ease out quad.
    /// </summary>
    public static AnimationCurve easeOutQuad = new AnimationCurve(

      new Keyframe(0.0f, 0.00f, 2.0f, 2.0f), 
      new Keyframe(0.1f, 0.19f, 1.8f, 1.8f),
      new Keyframe(0.2f, 0.36f, 1.6f, 1.6f),
      new Keyframe(0.3f, 0.51f, 1.4f, 1.4f),
      new Keyframe(0.4f, 0.64f, 1.2f, 1.2f),
      new Keyframe(0.5f, 0.75f, 1.0f, 1.0f),
      new Keyframe(0.6f, 0.84f, 0.8f, 0.8f),
      new Keyframe(0.7f, 0.91f, 0.6f, 0.6f), 
      new Keyframe(0.8f, 0.96f, 0.4f, 0.4f), 
      new Keyframe(0.9f, 0.99f, 0.2f, 0.2f),
      new Keyframe(1.0f, 1.00f, 0.0f, 0.0f));

    /// <summary>
    /// The ease in out quad.
    /// </summary>
    public static AnimationCurve easeInOutQuad = new AnimationCurve(

      new Keyframe(0.0f, 0.00f, 0.0f, 0.0f), 
      new Keyframe(0.1f, 0.02f, 0.4f, 0.4f),
      new Keyframe(0.2f, 0.08f, 0.8f, 0.8f),
      new Keyframe(0.3f, 0.18f, 1.2f, 1.2f),
      new Keyframe(0.4f, 0.32f, 1.6f, 1.6f),
      new Keyframe(0.5f, 0.50f, 1.8f, 1.8f),
      new Keyframe(0.6f, 0.68f, 1.6f, 1.6f),
      new Keyframe(0.7f, 0.82f, 1.2f, 1.2f), 
      new Keyframe(0.8f, 0.92f, 0.8f, 0.8f), 
      new Keyframe(0.9f, 0.98f, 0.4f, 0.4f),
      new Keyframe(1.0f, 1.00f, 0.0f, 0.0f));

    /// <summary>
    /// The ease in cubic.
    /// </summary>
    public static AnimationCurve easeInCubic = new AnimationCurve(

      new Keyframe(0.0f, 0.000f, 0.00f, 0.00f), 
      new Keyframe(0.1f, 0.001f, 0.04f, 0.04f),
      new Keyframe(0.2f, 0.008f, 0.13f, 0.13f), 
      new Keyframe(0.3f, 0.027f, 0.28f, 0.28f),
      new Keyframe(0.4f, 0.064f, 0.49f, 0.49f),
      new Keyframe(0.5f, 0.125f, 0.76f, 0.76f),
      new Keyframe(0.6f, 0.216f, 1.09f, 1.09f), 
      new Keyframe(0.7f, 0.343f, 1.48f, 1.48f),
      new Keyframe(0.8f, 0.512f, 1.93f, 1.93f), 
      new Keyframe(0.9f, 0.729f, 2.44f, 2.44f),
      new Keyframe(1.0f, 1.000f, 3.01f, 3.01f));

    /// <summary>
    /// The ease out cubic.
    /// </summary>
    public static AnimationCurve easeOutCubic = new AnimationCurve(

      new Keyframe(0.0f, 0.000f, 3.01f, 3.01f), 
      new Keyframe(0.1f, 0.271f, 2.44f, 2.44f),
      new Keyframe(0.2f, 0.488f, 1.93f, 1.93f),
      new Keyframe(0.3f, 0.657f, 1.48f, 1.48f),
      new Keyframe(0.4f, 0.784f, 1.09f, 1.09f),
      new Keyframe(0.5f, 0.875f, 0.76f, 0.76f),
      new Keyframe(0.6f, 0.936f, 0.49f, 0.49f),
      new Keyframe(0.7f, 0.973f, 0.28f, 0.28f), 
      new Keyframe(0.8f, 0.992f, 0.13f, 0.13f), 
      new Keyframe(0.9f, 0.999f, 0.04f, 0.04f),
      new Keyframe(1.0f, 1.000f, 0.00f, 0.00f));

    /// <summary>
    /// The ease in out cubic.
    /// </summary>
    public static AnimationCurve easeInOutCubic = new AnimationCurve(

      new Keyframe(0.0f, 0.000f, 0.00f, 0.00f), 
      new Keyframe(0.1f, 0.004f, 0.16f, 0.16f),
      new Keyframe(0.2f, 0.032f, 0.52f, 0.52f),
      new Keyframe(0.3f, 0.108f, 1.12f, 1.12f),
      new Keyframe(0.4f, 0.256f, 1.96f, 1.96f),
      new Keyframe(0.5f, 0.500f, 2.44f, 2.44f),
      new Keyframe(0.6f, 0.744f, 1.96f, 1.96f),
      new Keyframe(0.7f, 0.892f, 1.12f, 1.12f), 
      new Keyframe(0.8f, 0.968f, 0.52f, 0.52f), 
      new Keyframe(0.9f, 0.996f, 0.16f, 0.16f),
      new Keyframe(1.0f, 1.000f, 0.00f, 0.00f));

    /// <summary>
    /// The ease in quart.
    /// </summary>
    public static AnimationCurve easeInQuart = new AnimationCurve(

      new Keyframe(0.0f, 0.0000f, 0.000f, 0.000f), 
      new Keyframe(0.1f, 0.0001f, 0.008f, 0.008f),
      new Keyframe(0.2f, 0.0016f, 0.040f, 0.040f), 
      new Keyframe(0.3f, 0.0081f, 0.120f, 0.120f),
      new Keyframe(0.4f, 0.0256f, 0.272f, 0.272f), 
      new Keyframe(0.5f, 0.0625f, 0.520f, 0.520f),                                                    
      new Keyframe(0.6f, 0.1296f, 0.888f, 0.888f), 
      new Keyframe(0.7f, 0.2401f, 1.400f, 1.400f),                           
      new Keyframe(0.8f, 0.4096f, 2.080f, 2.080f), 
      new Keyframe(0.9f, 0.6561f, 2.952f, 2.952f),
      new Keyframe(1.0f, 1.0000f, 4.040f, 4.040f));

    /// <summary>
    /// The ease out quart.
    /// </summary>
    public static AnimationCurve easeOutQuart = new AnimationCurve(

      new Keyframe(0.0f, 0.0000f, 4.040f, 4.040f), 
      new Keyframe(0.1f, 0.3439f, 2.952f, 2.952f),
      new Keyframe(0.2f, 0.5904f, 2.080f, 2.080f),
      new Keyframe(0.3f, 0.7599f, 1.400f, 1.400f),
      new Keyframe(0.4f, 0.8704f, 0.888f, 0.888f),
      new Keyframe(0.5f, 0.9375f, 0.520f, 0.520f),
      new Keyframe(0.6f, 0.9744f, 0.272f, 0.272f),
      new Keyframe(0.7f, 0.9919f, 0.120f, 0.120f), 
      new Keyframe(0.8f, 0.9984f, 0.040f, 0.040f), 
      new Keyframe(0.9f, 0.9999f, 0.008f, 0.008f),
      new Keyframe(1.0f, 1.0000f, 0.000f, 0.000f));

    /// <summary>
    /// The ease in out quart.
    /// </summary>
    public static AnimationCurve easeInOutQuart = new AnimationCurve(

      new Keyframe(0.0f, 0.0000f, 0.000f, 0.000f), 
      new Keyframe(0.1f, 0.0008f, 0.064f, 0.064f),
      new Keyframe(0.2f, 0.0128f, 0.320f, 0.320f),
      new Keyframe(0.3f, 0.0648f, 0.960f, 0.960f),
      new Keyframe(0.4f, 0.2048f, 2.176f, 2.176f),
      new Keyframe(0.5f, 0.5000f, 2.952f, 2.952f),
      new Keyframe(0.6f, 0.7952f, 2.176f, 2.176f),
      new Keyframe(0.7f, 0.9352f, 0.960f, 0.960f), 
      new Keyframe(0.8f, 0.9872f, 0.320f, 0.320f), 
      new Keyframe(0.9f, 0.9992f, 0.064f, 0.064f),
      new Keyframe(1.0f, 1.0000f, 0.000f, 0.000f));

    /// <summary>
    /// The ease in quint.
    /// </summary>
    public static AnimationCurve easeInQuint = new AnimationCurve(

      new Keyframe(0.0f, 0.00000f, 0.0000f, 0.0000f), 
      new Keyframe(0.1f, 0.00001f, 0.0016f, 0.0016f), 
      new Keyframe(0.2f, 0.00032f, 0.0121f, 0.0121f), 
      new Keyframe(0.3f, 0.00243f, 0.0496f, 0.0496f), 
      new Keyframe(0.4f, 0.01024f, 0.1441f, 0.1441f), 
      new Keyframe(0.5f, 0.03125f, 0.3376f, 0.3376f), 
      new Keyframe(0.6f, 0.07776f, 0.6841f, 0.6841f), 
      new Keyframe(0.7f, 0.16807f, 1.2496f, 1.2496f), 
      new Keyframe(0.8f, 0.32768f, 2.1121f, 2.1121f),
      new Keyframe(0.9f, 0.59049f, 3.3616f, 3.3616f), 
      new Keyframe(1.0f, 1.00000f, 5.1001f, 5.1001f));

    /// <summary>
    /// The ease out quint.
    /// </summary>
    public static AnimationCurve easeOutQuint = new AnimationCurve(

      new Keyframe(0.0f, 0.00000f, 5.1001f, 5.1001f), 
      new Keyframe(0.1f, 0.40951f, 3.3616f, 3.3616f),
      new Keyframe(0.2f, 0.67232f, 2.1121f, 2.1121f),
      new Keyframe(0.3f, 0.83193f, 1.2496f, 1.2496f),
      new Keyframe(0.4f, 0.92224f, 0.6841f, 0.6841f),
      new Keyframe(0.5f, 0.96875f, 0.3376f, 0.3376f),
      new Keyframe(0.6f, 0.98976f, 0.1441f, 0.1441f),
      new Keyframe(0.7f, 0.99757f, 0.0496f, 0.0496f), 
      new Keyframe(0.8f, 0.99968f, 0.0121f, 0.0121f), 
      new Keyframe(0.9f, 0.99999f, 0.0016f, 0.0016f),
      new Keyframe(1.0f, 1.00000f, 0.0000f, 0.0000f));

    /// <summary>
    /// The ease in out quint.
    /// </summary>
    public static AnimationCurve easeInOutQuint = new AnimationCurve(

      new Keyframe(0.0f, 0.00000f, 0.0000f, 0.0000f), 
      new Keyframe(0.1f, 0.00016f, 0.0256f, 0.0256f),
      new Keyframe(0.2f, 0.00512f, 0.1936f, 0.1936f),
      new Keyframe(0.3f, 0.03888f, 0.7936f, 0.7936f),
      new Keyframe(0.4f, 0.16384f, 2.3056f, 2.3056f),
      new Keyframe(0.5f, 0.50000f, 3.3616f, 3.3616f),
      new Keyframe(0.6f, 0.83616f, 2.3056f, 2.3056f),
      new Keyframe(0.7f, 0.96112f, 0.7936f, 0.7936f), 
      new Keyframe(0.8f, 0.99488f, 0.1936f, 0.1936f), 
      new Keyframe(0.9f, 0.99984f, 0.0256f, 0.0256f),
      new Keyframe(1.0f, 1.00000f, 0.0000f, 0.0000f));

    /// <summary>
    /// The ease in sine.
    /// </summary>
    public static AnimationCurve easeInSine = new AnimationCurve(

      new Keyframe(0.0f, 0.000000000f, 0.000000000f, 0.000000000f), 
      new Keyframe(0.1f, 0.012311659f, 0.244717420f, 0.244717420f),
      new Keyframe(0.2f, 0.048943484f, 0.483409085f, 0.483409085f), 
      new Keyframe(0.3f, 0.108993476f, 0.710197610f, 0.710197610f),
      new Keyframe(0.4f, 0.190983006f, 0.919498715f, 0.919498715f), 
      new Keyframe(0.5f, 0.292893219f, 1.106158710f, 1.106158710f),
      new Keyframe(0.6f, 0.412214748f, 1.265581405f, 1.265581405f), 
      new Keyframe(0.7f, 0.546009500f, 1.393841290f, 1.393841290f),
      new Keyframe(0.8f, 0.690983006f, 1.487780175f, 1.487780175f), 
      new Keyframe(0.9f, 0.843565535f, 1.545084970f, 1.545084970f),
      new Keyframe(1.0f, 1.000000000f, 1.564344650f, 1.564344650f));

    /// <summary>
    /// The ease out sine.
    /// </summary>
    public static AnimationCurve easeOutSine = new AnimationCurve(

      new Keyframe(0.0f, 0.000000000f, 1.564344650f, 1.564344650f), 
      new Keyframe(0.1f, 0.156434465f, 1.545084970f, 1.545084970f),
      new Keyframe(0.2f, 0.309016994f, 1.487780175f, 1.487780175f), 
      new Keyframe(0.3f, 0.453990500f, 1.393841290f, 1.393841290f),
      new Keyframe(0.4f, 0.587785252f, 1.265581405f, 1.265581405f), 
      new Keyframe(0.5f, 0.707106781f, 1.106158710f, 1.106158710f),
      new Keyframe(0.6f, 0.809016994f, 0.919498715f, 0.919498715f), 
      new Keyframe(0.7f, 0.891006524f, 0.710197610f, 0.710197610f), 
      new Keyframe(0.8f, 0.951056516f, 0.483409085f, 0.483409085f), 
      new Keyframe(0.9f, 0.987688341f, 0.244717420f, 0.244717420f),
      new Keyframe(1.0f, 1.000000000f, 0.000000000f, 0.000000000f));

    /// <summary>
    /// The ease in out sine.
    /// </summary>
    public static AnimationCurve easeInOutSine = new AnimationCurve(

      new Keyframe(0.0f, 0.000000000f, 0.000000000f, 0.000000000f), 
      new Keyframe(0.1f, 0.024471742f, 0.477457515f, 0.477457515f),
      new Keyframe(0.2f, 0.095491503f, 0.908178160f, 0.908178160f), 
      new Keyframe(0.3f, 0.206107374f, 1.250000000f, 1.250000000f),
      new Keyframe(0.4f, 0.345491503f, 1.469463130f, 1.469463130f), 
      new Keyframe(0.5f, 0.500000000f, 1.545084970f, 1.545084970f),
      new Keyframe(0.6f, 0.654508497f, 1.469463130f, 1.469463130f), 
      new Keyframe(0.7f, 0.793892626f, 1.250000000f, 1.250000000f),
      new Keyframe(0.8f, 0.904508497f, 0.908178160f, 0.908178160f), 
      new Keyframe(0.9f, 0.975528258f, 0.477457515f, 0.477457515f),
      new Keyframe(1.0f, 1.000000000f, 0.000000000f, 0.000000000f));

    /// <summary>
    /// The ease in expo.
    /// </summary>
    public static AnimationCurve easeInExpo = new AnimationCurve(

      new Keyframe(0.0f, 0.000000000f, 0.000000000f, 0.000000000f), 
      new Keyframe(0.1f, 0.001953125f, 0.019531250f, 0.019531250f),
      new Keyframe(0.2f, 0.003906250f, 0.029296875f, 0.029296875f), 
      new Keyframe(0.3f, 0.007812500f, 0.058593750f, 0.058593750f),
      new Keyframe(0.4f, 0.015625000f, 0.117187500f, 0.117187500f), 
      new Keyframe(0.5f, 0.031250000f, 0.234375000f, 0.234375000f),
      new Keyframe(0.6f, 0.062500000f, 0.468750000f, 0.468750000f), 
      new Keyframe(0.7f, 0.125000000f, 0.937500000f, 0.937500000f),
      new Keyframe(0.8f, 0.250000000f, 1.875000000f, 1.875000000f), 
      new Keyframe(0.9f, 0.500000000f, 3.750000000f, 3.750000000f),
      new Keyframe(1.0f, 1.000000000f, 7.500000000f, 7.500000000f));

    /// <summary>
    /// The ease out expo.
    /// </summary>
    public static AnimationCurve easeOutExpo = new AnimationCurve(

      new Keyframe(0.0f, 0.000000000f, 7.500000000f, 7.500000000f), 
      new Keyframe(0.1f, 0.500000000f, 3.750000000f, 3.750000000f),
      new Keyframe(0.2f, 0.750000000f, 1.875000000f, 1.875000000f), 
      new Keyframe(0.3f, 0.875000000f, 0.937500000f, 0.937500000f),
      new Keyframe(0.4f, 0.937500000f, 0.468750000f, 0.468750000f), 
      new Keyframe(0.5f, 0.968750000f, 0.234375000f, 0.234375000f),
      new Keyframe(0.6f, 0.984375000f, 0.117187500f, 0.117187500f), 
      new Keyframe(0.7f, 0.992187500f, 0.058593750f, 0.058593750f),
      new Keyframe(0.8f, 0.996093750f, 0.029296875f, 0.029296875f), 
      new Keyframe(0.9f, 0.998046875f, 0.019531250f, 0.019531250f),
      new Keyframe(1.0f, 1.000000000f, 0.000000000f, 0.000000000f));

    /// <summary>
    /// The ease in out expo.
    /// </summary>
    public static AnimationCurve easeInOutExpo = new AnimationCurve(

      new Keyframe(0.0f, 0.000000000f, 0.000000000f, 0.000000000f), 
      new Keyframe(0.1f, 0.001953125f, 0.039062500f, 0.039062500f),
      new Keyframe(0.2f, 0.007812500f, 0.146484375f, 0.146484375f), 
      new Keyframe(0.3f, 0.031250000f, 0.585937500f, 0.585937500f),
      new Keyframe(0.4f, 0.125000000f, 2.343750000f, 2.343750000f), 
      new Keyframe(0.5f, 0.500000000f, 3.750000000f, 3.750000000f),
      new Keyframe(0.6f, 0.875000000f, 2.343750000f, 2.343750000f), 
      new Keyframe(0.7f, 0.968750000f, 0.585937500f, 0.585937500f),
      new Keyframe(0.8f, 0.992187500f, 0.146484375f, 0.146484375f), 
      new Keyframe(0.9f, 0.998046875f, 0.039062500f, 0.039062500f),
      new Keyframe(1.0f, 1.000000000f, 0.000000000f, 0.000000000f));

    /// <summary>
    /// The ease in circ.
    /// </summary>
    public static AnimationCurve easeInCirc = new AnimationCurve(

      new Keyframe(0.0000f, 0.000000000f, 0.000000000f, 0.000000000f), 
      new Keyframe(0.1000f, 0.005012563f, 0.101020515f, 0.101020515f),
      new Keyframe(0.2000f, 0.020204103f, 0.205241180f, 0.205241180f), 
      new Keyframe(0.3000f, 0.046060799f, 0.316403790f, 0.316403790f),
      new Keyframe(0.4000f, 0.083484861f, 0.439568985f, 0.439568985f), 
      new Keyframe(0.5000f, 0.133974596f, 0.582575695f, 0.582575695f),
      new Keyframe(0.6000f, 0.200000000f, 0.759412805f, 0.759412805f), 
      new Keyframe(0.7000f, 0.285857157f, 1.000000000f, 1.000000000f),
      new Keyframe(0.8000f, 0.400000000f, 1.249067753f, 1.249067753f), 
      new Keyframe(0.8500f, 0.473217312f, 1.641101060f, 1.641101060f),
      new Keyframe(0.9000f, 0.564110106f, 1.957541120f, 1.957541120f),
      new Keyframe(0.9250f, 0.620032896f, 2.472799880f, 2.472799880f),
      new Keyframe(0.9500f, 0.687750100f, 3.155244880f, 3.155244880f),
      new Keyframe(0.9750f, 0.777795140f, 4.123490587f, 4.123490587f),
      new Keyframe(0.9875f, 0.842380997f, 8.888194400f, 8.888194400f),
      new Keyframe(1.0000f, 1.000000000f, 10.00000000f, 10.00000000f)); //eyeballed tangent value - not calculated

    /// <summary>
    /// The ease out circ.
    /// </summary>
    public static AnimationCurve easeOutCirc = new AnimationCurve(

      new Keyframe(0.0000f, 0.000000000f, 10.00000000f, 10.00000000f), //eyeballed tangent values - not calculated
      new Keyframe(0.0125f, 0.157619003f, 8.888194400f, 8.888194400f),
      new Keyframe(0.0250f, 0.222204860f, 4.123490587f, 4.123490587f),
      new Keyframe(0.0500f, 0.312249900f, 3.155244880f, 3.155244880f),
      new Keyframe(0.0750f, 0.379967104f, 2.472799880f, 2.472799880f),
      new Keyframe(0.1000f, 0.435889894f, 1.957541120f, 1.957541120f),
      new Keyframe(0.1500f, 0.526782688f, 1.641101060f, 1.641101060f),
      new Keyframe(0.2000f, 0.600000000f, 1.249067753f, 1.249067753f), 
      new Keyframe(0.3000f, 0.714142843f, 1.000000000f, 1.000000000f),
      new Keyframe(0.4000f, 0.800000000f, 0.759412805f, 0.759412805f), 
      new Keyframe(0.5000f, 0.866025404f, 0.582575695f, 0.582575695f),
      new Keyframe(0.6000f, 0.916515139f, 0.439568985f, 0.439568985f), 
      new Keyframe(0.7000f, 0.953939201f, 0.316403790f, 0.316403790f),
      new Keyframe(0.8000f, 0.979795897f, 0.205241180f, 0.205241180f), 
      new Keyframe(0.9000f, 0.994987437f, 0.101020515f, 0.101020515f), 
      new Keyframe(1.0000f, 1.000000000f, 0.000000000f, 0.000000000f));

    /// <summary>
    /// The ease in out circ.
    /// </summary>
    public static AnimationCurve easeInOutCirc = new AnimationCurve(

      new Keyframe(0.0000f, 0.000000000f, 0.000000000f, 0.000000000f), 
      new Keyframe(0.1000f, 0.010102051f, 0.208712155f, 0.208712155f),
      new Keyframe(0.2000f, 0.041742431f, 0.449489745f, 0.449489745f), 
      new Keyframe(0.3000f, 0.100000000f, 0.674574320f, 0.674574320f),
      new Keyframe(0.3500f, 0.142928579f, 1.000000000f, 1.000000000f),
      new Keyframe(0.4000f, 0.200000000f, 1.249067693f, 1.249067693f),
      new Keyframe(0.4250f, 0.236608656f, 1.641101060f, 1.641101060f),
      new Keyframe(0.4500f, 0.282055053f, 2.145327880f, 2.145327880f),
      new Keyframe(0.4750f, 0.343875050f, 2.849133787f, 2.849133787f),
      new Keyframe(0.4875f, 0.388897570f, 6.244998000f, 6.244998000f),
      new Keyframe(0.5000f, 0.500000000f, 8.888194400f, 8.888194400f), 
      new Keyframe(0.5125f, 0.611102430f, 6.244998000f, 6.244998000f),
      new Keyframe(0.5250f, 0.656124950f, 2.849133787f, 2.849133787f),
      new Keyframe(0.5500f, 0.717944947f, 2.145327880f, 2.135327880f),
      new Keyframe(0.5750f, 0.763391344f, 1.641101060f, 1.641101060f),
      new Keyframe(0.6000f, 0.800000000f, 1.249067693f, 1.249067693f),
      new Keyframe(0.6500f, 0.857071421f, 1.000000000f, 1.000000000f),
      new Keyframe(0.7000f, 0.900000000f, 0.674574320f, 0.674574320f),
      new Keyframe(0.8000f, 0.958257569f, 0.449489745f, 0.449489745f), 
      new Keyframe(0.9000f, 0.989897949f, 0.208712155f, 0.208712155f),
      new Keyframe(1.0000f, 1.000000000f, 0.000000000f, 0.000000000f));

    /// <summary>
    /// The ease in bounce.
    /// </summary>
    public AnimationCurve easeInBounce = new AnimationCurve(

      new Keyframe(0.00f, 0.000000000f,  0.000000000f,  0.000000000f), 
      new Keyframe(0.05f, 0.015468750f,  0.118750000f,  0.118750000f),
      new Keyframe(0.10f, 0.011875000f,  0.393750000f,  0.393750000f),
      new Keyframe(0.15f, 0.054843750f,  0.481250000f,  0.481250000f),
      new Keyframe(0.20f, 0.060000000f, -0.275000000f, -0.275000000f),
      new Keyframe(0.25f, 0.027343750f,  0.093750000f,  0.093750000f),
      new Keyframe(0.30f, 0.069375000f,  1.400000000f,  1.400000000f),
      new Keyframe(0.35f, 0.167343750f,  1.581250000f,  1.581250000f),
      new Keyframe(0.40f, 0.227500000f,  0.825000000f,  0.825000000f), 
      new Keyframe(0.45f, 0.249843750f,  0.068750000f,  0.068750000f),
      new Keyframe(0.50f, 0.234375000f, -0.687500000f, -0.687500000f),
      new Keyframe(0.55f, 0.181093750f, -1.443750000f, -1.443750000f),
      new Keyframe(0.60f, 0.090000000f, -1.075000000f, -1.075000000f), 
      new Keyframe(0.65f, 0.073593750f,  2.293750000f,  2.293750000f), 
      new Keyframe(0.70f, 0.319375000f,  4.159375000f,  4.159375000f),
      new Keyframe(0.80f, 0.697500000f,  3.025000000f,  3.025000000f), 
      new Keyframe(0.90f, 0.924375000f,  1.512500000f,  1.512500000f),
      new Keyframe(1.00f, 1.000000000f,  0.000000000f,  0.000000000f));

    /// <summary>
    /// The ease out bounce.
    /// </summary>
    public AnimationCurve easeOutBounce = new AnimationCurve(

      new Keyframe(0.0f, 0.00f), 
      new Keyframe(0.1f, 0.075625f),
      new Keyframe(0.2f, 0.3025f), 
      new Keyframe(0.3f, 0.680625f),
      new Keyframe(0.4f, 0.91f), 
      new Keyframe(0.5f, 0.765625f),
      new Keyframe(0.6f, 0.7725f), 
      new Keyframe(0.7f, 0.930625f),
      new Keyframe(0.8f, 0.94f), 
      new Keyframe(0.9f, 0.988125f),
      new Keyframe(1.0f, 1.0f));

    /// <summary>
    /// The ease in out bounce.
    /// </summary>
    public static AnimationCurve easeInOutBounce = new AnimationCurve(

      new Keyframe(0.0f, 0.0f), 
      new Keyframe(0.1f, 0.0f),
      new Keyframe(0.2f, 0.0f), 
      new Keyframe(0.3f, 0.0f),
      new Keyframe(0.4f, 0.0f), 
      new Keyframe(0.5f, 0.0f),
      new Keyframe(0.6f, 0.0f), 
      new Keyframe(0.7f, 0.0f),
      new Keyframe(0.8f, 0.0f), 
      new Keyframe(0.9f, 0.0f),
      new Keyframe(1.0f, 1.0f));

    /// <summary>
    /// The ease in back.
    /// </summary>
    public AnimationCurve easeInBack = new AnimationCurve(

      new Keyframe(0.0f,  0.000000000f,  0.000000000f,  0.000000000f), 
      new Keyframe(0.1f, -0.014314220f, -0.232252800f, -0.232252800f),
      new Keyframe(0.2f, -0.046450560f, -0.329426600f, -0.329426600f), 
      new Keyframe(0.3f, -0.080199540f, -0.264505600f, -0.264505600f),
      new Keyframe(0.4f, -0.099351680f, -0.037489800f, -0.037489800f), 
      new Keyframe(0.5f, -0.087697500f,  0.351620800f,  0.351620800f),
      new Keyframe(0.6f, -0.029027520f,  0.902826300f,  0.902826300f), 
      new Keyframe(0.7f,  0.092867740f,  1.616126400f,  1.616126400f),
      new Keyframe(0.8f,  0.294197760f,  2.491521300f,  2.491521300f), 
      new Keyframe(0.9f,  0.591172020f,  3.529011200f,  3.529011200f),
      new Keyframe(1.0f,  1.000000000f,  4.000000000f,  4.000000000f)); //tangent not calculated

    /// <summary>
    /// The ease out back.
    /// </summary>
    public AnimationCurve easeOutBack = new AnimationCurve(

      new Keyframe(0.0f, 0.000000000f,  4.000000000f,  4.000000000f), //tangent not calculated
      new Keyframe(0.1f, 0.408827980f,  3.529011200f,  3.529011200f),
      new Keyframe(0.2f, 0.705802240f,  2.491521300f,  2.491521300f), 
      new Keyframe(0.3f, 0.907132260f,  1.616126400f,  1.616126400f),
      new Keyframe(0.4f, 1.029027520f,  0.902826300f,  0.902826300f), 
      new Keyframe(0.5f, 1.087697500f,  0.351620800f,  0.351620800f),
      new Keyframe(0.6f, 1.099351680f, -0.037489800f, -0.037489800f), 
      new Keyframe(0.7f, 1.080199540f, -0.264505600f, -0.264505600f),
      new Keyframe(0.8f, 1.046450560f, -0.329426600f, -0.329426600f), 
      new Keyframe(0.9f, 1.014314220f, -0.232252800f, -0.232252800f),
      new Keyframe(1.0f, 1.000000000f,  0.000000000f,  0.000000000f));

    /// <summary>
    /// The ease in out back.
    /// </summary>
    public AnimationCurve easeInOutBack = new AnimationCurve(

      new Keyframe(0.0f,  0.000000000f,  0.000000000f,  0.000000000f), 
      new Keyframe(0.1f, -0.037518552f, -0.462778280f, -0.462778280f),
      new Keyframe(0.2f, -0.092555656f, -0.206574660f, -0.206574660f), 
      new Keyframe(0.3f, -0.078833484f,  0.912407240f,  0.912407240f),
      new Keyframe(0.4f,  0.089925792f,  2.894167420f,  2.894167420f), 
      new Keyframe(0.5f,  0.500000000f,  4.100742080f,  4.100742080f),
      new Keyframe(0.6f,  0.910074208f,  2.894167420f,  2.894167420f), 
      new Keyframe(0.7f,  1.078833484f,  0.912407240f,  0.912407240f),
      new Keyframe(0.8f,  1.092555656f, -0.206574660f, -0.206574660f), 
      new Keyframe(0.9f,  1.037518552f, -0.462778280f, -0.462778280f),
      new Keyframe(1.0f,  1.000000000f,  0.000000000f,  0.000000000f));

    /// <summary>
    /// The ease in elastic.
    /// </summary>
    public static AnimationCurve easeInElastic = new AnimationCurve(

      new Keyframe(0.00f,  0.000000000f,  0.000000000f,  0.000000000f), 
      new Keyframe(0.10f,  0.001953125f, -0.009765625f, -0.009765625f),
      new Keyframe(0.20f, -0.001953125f, -0.029296875f, -0.029296875f), 
      new Keyframe(0.30f, -0.003906250f,  0.087890625f,  0.087890625f),
      new Keyframe(0.40f,  0.015625000f, -0.058593750f, -0.058593750f), 
      new Keyframe(0.50f, -0.015625000f, -0.234375000f, -0.234375000f),
      new Keyframe(0.60f, -0.031250000f,  0.703125000f,  0.703125000f), 
      new Keyframe(0.70f,  0.125000000f,  0.797588984f,  0.797588984f),
      new Keyframe(0.75f,  0.088388347f, -2.500000000f, -2.500000000f),
      new Keyframe(0.80f, -0.125000000f, -4.419417382f, -4.419417382f), 
      new Keyframe(0.85f, -0.353553390f, -1.250000000f, -1.250000000f),
      new Keyframe(0.90f, -0.250000000f,  9.023689271f,  9.023689271f),
      new Keyframe(1.00f,  1.000000000f, 10.000000000f, 10.000000000f)); //tangent not calculated value

    /// <summary>
    /// The ease out elastic.
    /// </summary>
    public static AnimationCurve easeOutElastic = new AnimationCurve(

      new Keyframe(0.00f, 0.000000000f, 10.000000000f, 10.000000000f), //tangent not calculated value
      new Keyframe(0.10f, 1.250000000f,  9.023689267f,  9.023689267f),
      new Keyframe(0.15f, 1.353553390f, -1.250000000f, -1.250000000f),
      new Keyframe(0.20f, 1.125000000f, -4.419417380f, -4.419417380f),
      new Keyframe(0.25f, 0.911611652f, -2.500000000f, -2.500000000f),
      new Keyframe(0.30f, 0.875000000f,  0.797588987f,  0.797588987f),
      new Keyframe(0.40f, 1.031250000f,  0.703125000f,  0.703125000f), 
      new Keyframe(0.50f, 1.015625000f, -0.234375000f, -0.234375000f),
      new Keyframe(0.60f, 0.984375000f, -0.058593750f, -0.058593750f), 
      new Keyframe(0.70f, 1.003906250f,  0.087890625f,  0.087890625f),
      new Keyframe(0.80f, 1.001953125f, -0.029296875f, -0.029296875f), 
      new Keyframe(0.90f, 0.998046875f, -0.009765625f, -0.009765625f),
      new Keyframe(1.00f, 1.000000000f,  0.000000000f,  0.000000000f));

    /// <summary>
    /// The ease in out elastic.
    /// </summary>
    public static AnimationCurve easeInOutElastic = new AnimationCurve(

      new Keyframe(0.00f,  0.000000000f,  0.000000000f,  0.000000000f), 
      new Keyframe(0.10f,  0.000339157f, -0.019531250f, -0.019531250f),
      new Keyframe(0.20f, -0.003906250f,  0.077535247f,  0.077535247f), 
      new Keyframe(0.25f,  0.011969444f,  0.278451390f,  0.278451390f),
      new Keyframe(0.30f,  0.023938889f, -0.432194440f, -0.432194440f),
      new Keyframe(0.35f, -0.031250000f, -1.414004670f, -1.414004670f),
      new Keyframe(0.40f, -0.117461578f,  3.541666667f,  3.541666667f), 
      new Keyframe(0.50f,  0.500000000f,  6.174615780f,  6.174615780f),
      new Keyframe(0.60f,  1.117461578f,  3.541666667f,  3.541666667f),
      new Keyframe(0.65f,  1.031250000f, -1.414004660f, -1.414004660f),
      new Keyframe(0.70f,  0.976061112f, -0.432194440f, -0.432194440f),
      new Keyframe(0.75f,  0.988030556f,  0.278451380f,  0.278451380f),
      new Keyframe(0.80f,  1.003906250f,  0.077535247f,  0.077535247f),
      new Keyframe(0.90f,  0.999660843f, -0.019531250f, -0.019531250f),
      new Keyframe(1.00f,  1.000000000f,  0.000000000f,  0.000000000f));

    /// <summary>
    /// The linear.
    /// </summary>
    public static AnimationCurve linear = new AnimationCurve(

      new Keyframe(0.0f, 0.0f, 1.0f, 1.0f),
      new Keyframe(0.1f, 0.1f, 1.0f, 1.0f),
      new Keyframe(0.2f, 0.2f, 1.0f, 1.0f),
      new Keyframe(0.3f, 0.3f, 1.0f, 1.0f),
      new Keyframe(0.4f, 0.4f, 1.0f, 1.0f), 
      new Keyframe(0.5f, 0.5f, 1.0f, 1.0f),
      new Keyframe(0.6f, 0.6f, 1.0f, 1.0f), 
      new Keyframe(0.7f, 0.7f, 1.0f, 1.0f),
      new Keyframe(0.8f, 0.8f, 1.0f, 1.0f), 
      new Keyframe(0.9f, 0.9f, 1.0f, 1.0f),
      new Keyframe(1.0f, 1.0f, 1.0f, 1.0f));
  
    /// <summary>
    /// The spring.
    /// </summary>
    public AnimationCurve spring = new AnimationCurve(

      new Keyframe(0.0f, 0.0f, 1.0f, 1.0f),
      new Keyframe(0.1f, 0.1f, 1.0f, 1.0f),
      new Keyframe(0.2f, 0.2f, 1.0f, 1.0f),
      new Keyframe(0.3f, 0.3f, 1.0f, 1.0f),
      new Keyframe(0.4f, 0.4f, 1.0f, 1.0f), 
      new Keyframe(0.5f, 0.5f, 1.0f, 1.0f),
      new Keyframe(0.6f, 0.6f, 1.0f, 1.0f), 
      new Keyframe(0.7f, 0.7f, 1.0f, 1.0f),
      new Keyframe(0.8f, 0.8f, 1.0f, 1.0f), 
      new Keyframe(0.9f, 0.9f, 1.0f, 1.0f),
      new Keyframe(1.0f, 1.0f, 1.0f, 1.0f));

    /// <summary>
    /// The punch.
    /// </summary>
    public static AnimationCurve punch = new AnimationCurve(

      new Keyframe(0.0f, 0.0f), 
      new Keyframe(0.1f, 0.0f),
      new Keyframe(0.2f, 0.0f), 
      new Keyframe(0.3f, 0.0f),
      new Keyframe(0.4f, 0.0f), 
      new Keyframe(0.5f, 0.0f),
      new Keyframe(0.6f, 0.0f), 
      new Keyframe(0.7f, 0.0f),
      new Keyframe(0.8f, 0.0f), 
      new Keyframe(0.9f, 0.0f),
      new Keyframe(1.0f, 1.0f));

  }
}