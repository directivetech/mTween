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
  /// Tween point.
  /// </summary>
  public class TweenPoint : MonoBehaviour 
  {

    private float x = 0;
    private float y = 0;
    private float z = 0;

    /// <summary>
    /// Initializes a new instance of the <see cref="TweenPoint"/> class.
    /// </summary>
    TweenPoint() 
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TweenPoint"/> class.
    /// </summary>
    /// <param name="x">The x coordinate.</param>
    /// <param name="y">The y coordinate.</param>
    /// <param name="z">The z coordinate.</param>
    TweenPoint(float x, float y, float z) 
    {
      this.x = x;
      this.y = y;
      this.z = z;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TweenPoint"/> class.
    /// </summary>
    /// <param name="point">Point.</param>
    TweenPoint(Vector3 point)
    {
      this.x = point.x;
      this.y = point.y;
      this.z = point.z;
    }

    /// <summary>
    /// Gets or sets the x.
    /// </summary>
    /// <value>The x.</value>
    public float X
    {
      get 
      {
        return x;
      }

      set
      { 
        x = value;
      }
    }

    /// <summary>
    /// Gets or sets the y.
    /// </summary>
    /// <value>The y.</value>
    public float Y
    {
      get
      {
        return y;
      }

      set
      {
        y = value;
      }
    }

    /// <summary>
    /// Gets or sets the z.
    /// </summary>
    /// <value>The z.</value>
    public float Z
    {
      get
      {
        return z;
      }

      set
      {
        z = value;
      }
    }
  }
}