using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : EnemyBase {

    #region Main

    void Start() {
        Init();
    }

    void Update() {

    }

    #endregion

    #region Functions

    public override void OnHitted(Rigidbody2D ball) {
        base.OnHitted(ball);
        //TODO
    }

    #endregion
}