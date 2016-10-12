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

namespace mTween{

  /// <summary>
  /// Tween.
  /// </summary>
  public abstract class Tween : MonoBehaviour
  {

    public Boolean reverse = false;
    public float delay = 0;
    public float runningTime = 0;
    public System.Action OnComplete = null;
    public System.Action OnStart = null;
    public System.Action OnUpdate = null;

    protected bool ignoreTimescale = false;
    protected float duration = 0.05f;
    protected float percentage = 0;
    protected LoopType loop = null;
    protected Vector3 v3 = new Vector3(2,0,0);

    private bool increasing = true;
    private float startTime;

  

    /// <summary>
    /// Awake this instance.
    /// <para>Calls Initialize for all derived classes otherwise Start in derived classes would override this one.
    /// This still leaves the ability to override Start in derived class</para>
    /// </summary>
    void Awake()
    {
    
      Initialize();
      if(delay > 0)
      {
        StartCoroutine(StartDelay());
        this.enabled = false;
      }
    }  

    /// <summary>
    /// Start this instance.
    /// </summary>
    void Start () 
    { 
      //startTime = 0;
      mTweens.StopAllRequested += this.OnStopAll;

      if(OnStart != null)
      {
        OnStart();
      }
	  }

    /// <summary>
    /// Starts the delay.
    /// </summary>
    IEnumerator StartDelay()
    {
      yield return new WaitForSeconds(delay);
      this.enabled = true;
    }

    /// <summary>
    /// Initialize this instance.
    /// </summary>
    public abstract void Initialize();
	
    /// <summary>
    /// Update this instance.
    /// </summary>
	  void Update () 
    {  
      Apply();
    
      if(OnUpdate != null)
      {
        OnUpdate();
      }

      UpdatePercentage();
    
      if(percentage == 1.0f)
      {
        if(increasing)
        {
          TweenComplete ();
        }
      }
    
      if(percentage == 0.0f)
      {
      
        if(!increasing)
        {
          TweenComplete();
        }
      }

      Apply();
    
      if(OnUpdate != null)
      {
        OnUpdate();
      }
	  }

    /// <summary>
    /// Stop this instance.
    /// </summary>
	  public void Stop()
    {
      enabled = false;
    }

    /// <summary>
    /// Raises the stop all event.
    /// </summary>
    /// <param name="sender">Sender.</param>
    /// <param name="e">E.</param>
    public void OnStopAll(object sender, EventArgs e)
    {
      Stop ();
    }

    /// <summary>
    /// Apply this instance.
    /// </summary>
	  protected abstract void Apply();

    /// <summary>
    /// Loop this instance.
    /// </summary>
    private void Loop()
    {
      runningTime = 0;
      if (loop == TweenLoops.replay) 
      {
        percentage = 0;
      }
      if (loop == TweenLoops.pingpong) 
      {
        increasing = !increasing;
      }
    }

    /// <summary>
    /// Tweens the complete.
    /// </summary>
	  private void TweenComplete()
	  {

      if(OnComplete != null)
      {
        OnComplete();
      }
      if (loop == null) 
      {
        this.enabled = false;
      } 
      else 
      {
        Loop ();
      }
	  }

    /// <summary>
    /// Updates the percentage.
    /// </summary>
	  void UpdatePercentage()
	  {
      runningTime += Time.deltaTime;
      if (increasing)
      {
        percentage = runningTime / duration;
        if (percentage > 1.0f)
        {
          percentage = 1.0f;
        }
      } 
      else 
      {
        percentage = 1 - (runningTime / duration);
        if (percentage < 0.0f)
        {
          percentage = 0.0f;
        }
      }
	  }

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
}
