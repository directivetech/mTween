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
using System;


//A static base class to allow operations on all Tweens in Scene

/// <summary>
/// mTweens.
/// </summary>
/// 
namespace mTween{
  
public static class mTweens 
{
  public static EventHandler<ErrorEventArgs> StopAllRequested;
   
  /// <summary>
  /// Stops all.
  /// </summary>
  /// <param name="e">E.</param>
  public static void StopAll(EventArgs e)
  {
    EventHandler<ErrorEventArgs> handler = StopAllRequested;       
    if (handler != null) 
    {
      StopAllRequested (null, new ErrorEventArgs(null,""));
    }
  }
    
}

/// <summary>
/// Error event arguments.
/// </summary>
public class ErrorEventArgs : EventArgs
{
  private Exception error;
  private string message;

  /// <summary>
  /// Initializes a new instance of the <see cref="ErrorEventArgs"/> class.
  /// </summary>
  /// <param name="ex">Ex.</param>
  /// <param name="msg">Message.</param>
  public ErrorEventArgs(Exception ex, string msg)
  {
    error = ex;
    message = msg;
  }

  /// <summary>
  /// Gets the error.
  /// </summary>
  /// <value>The error.</value>
  public Exception Error
  {
    get { return error; }
  }
   
  /// <summary>
  /// Gets the message.
  /// </summary>
  /// <value>The message.</value>
  public string Message 
  {
    get { return message; }
  }

}
}