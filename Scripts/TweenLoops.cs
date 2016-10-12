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
  /// Loop type.
  /// </summary>
  public class LoopType 
  {
 
    protected string name = "";

    /// <summary>
    /// Initializes a new instance of the <see cref="LoopType"/> class.
    /// </summary>
    public LoopType()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LoopType"/> class.
    /// </summary>
    /// <param name="name">Name.</param>
    public LoopType(string name)
    {
      this.name = name;
    }
  }

  /// <summary>
  /// Tween loops.
  /// </summary>
  public class TweenLoops : MonoBehaviour 
  {

    public static LoopType replay = new LoopType("replay");
    public static LoopType pingpong = new LoopType("pingPong");

  }
}
