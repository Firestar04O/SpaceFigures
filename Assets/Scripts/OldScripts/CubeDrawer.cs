using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDrawer : MonoBehaviour
{
    public Vector3 VectorTraslation;
    public Vector3 ScaleVector;
    [Header("Pivot")]
    [SerializeField] public int Pivots = 8;
    [SerializeField] private PivotDrawer pivot1;
    [SerializeField] private PivotDrawer pivot2;
    [SerializeField] private PivotDrawer pivot3;
    [SerializeField] private PivotDrawer pivot4;
    [SerializeField] private PivotDrawer pivot5;
    [SerializeField] private PivotDrawer pivot6;
    [SerializeField] private PivotDrawer pivot7;
    [SerializeField] private PivotDrawer pivot8;
    private void Update()
    {
        transform.position = VectorTraslation;
    }
    private void FixedUpdate()
    {
        pivot1.TranslatePivot(VectorTraslation);
        pivot1.ScalePivot(ScaleVector);
        pivot2.TranslatePivot(VectorTraslation);
        pivot2.ScalePivot(ScaleVector);
        pivot3.TranslatePivot(VectorTraslation);
        pivot3.ScalePivot(ScaleVector);
        pivot4.TranslatePivot(VectorTraslation);
        pivot4.ScalePivot(ScaleVector);
        pivot5.TranslatePivot(VectorTraslation);
        pivot5.ScalePivot(ScaleVector);
        pivot6.TranslatePivot(VectorTraslation);
        pivot6.ScalePivot(ScaleVector);
        pivot7.TranslatePivot(VectorTraslation);
        pivot7.ScalePivot(ScaleVector);
        pivot8.TranslatePivot(VectorTraslation);
        pivot8.ScalePivot(ScaleVector);
    }
}
