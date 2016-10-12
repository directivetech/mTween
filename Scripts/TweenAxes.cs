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
  /// Axis type.
  /// </summary>
  public class AxisType 
  {
 
    protected string name = "";

    /// <summary>
    /// Initializes a new instance of the <see cref="AxisType"/> class.
    /// </summary>
    public AxisType()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AxisType"/> class.
    /// </summary>
    /// <param name="name">Name.</param>
    public AxisType(string name)
    {
      this.name = name;
    }
  }

  /// <summary>
  /// Tween axes.
  /// </summary>
  public class TweenAxes : MonoBehaviour 
  {

    public static AxisType x = new AxisType("x");
    public static AxisType y = new AxisType("y");
    public static AxisType z = new AxisType("z");

  }
}