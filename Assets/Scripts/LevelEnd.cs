﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        //TODO: finished:

        GlobalState.Instance.Finish();

    }


}
