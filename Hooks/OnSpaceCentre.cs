﻿using System;
using System.Collections;
using UnityEngine;

namespace StateFunding {
  [KSPAddon (KSPAddon.Startup.SpaceCentre, false)]
  public class OnSpaceCentre : MonoBehaviour {
    public void Awake () {
      
    }

    public void Start () {
      ViewManager.removeAll ();
      StateFundingGlobal.fetch.LoadIfNeeded ();
    }

    public void Update () {
      
    }

    public void FixedUpdate () {

    }

    public void OnDestroy () {

    }
  }
}

