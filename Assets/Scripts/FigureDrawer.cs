using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureDrawer : MonoBehaviour
{
    public FigureData figuredata;
    public static event Action<Vector3> OnTransformUpdate;
    public static event Action<Vector3> OnScaleUpdate;
    private void OnEnable()
    {
        OnTransformUpdate += figuredata.UpdateTransform;
        OnScaleUpdate += figuredata.UpdateScale;
    }
    private void OnDisable()
    {
        OnTransformUpdate -= figuredata.UpdateTransform;
        OnScaleUpdate -= figuredata.UpdateScale;
    }
    private void Update()
    {
        OnTransformUpdate(transform.position);
        OnScaleUpdate(transform.localScale);
    }
    private void OnDrawGizmos()
    {
        if(figuredata == null || figuredata.pivots == null)
        {
            return;
        }
        for (int i=0; i < figuredata.pivots.Count; i++)
        {
            PivotInfo pivot = figuredata.pivots[i];
            Vector3 translation = transform.position + Vector3.Scale(pivot.localPosition, figuredata.scaleVector) + figuredata.vectorTranslation;
            Gizmos.color = pivot.color;
            Gizmos.DrawWireSphere(translation, 0.3f);
            if (pivot.pivotConnections != null)
            {
                Gizmos.color = Color.white;
                foreach (int Index in pivot.pivotConnections)
                {
                    if (Index >= 0 && Index < figuredata.pivots.Count && Index != i)
                    {
                        Vector3 position = transform.position + Vector3.Scale(figuredata.pivots[Index].localPosition, figuredata.scaleVector) + figuredata.vectorTranslation;
                        Gizmos.DrawLine(translation, position);
                    }
                }
            }
        }
    }
    //public void TranslatePivot(Vector3 translation)
    //{
    //    _translateVector = translation;

    //    transform.position = startPosition + _translateVector;
    //}

    //public void ScalePivot(Vector3 scale)
    //{
    //    _scaleVector = scale;

    //    transform.position = startScale + Vector3.Scale(startPosition, _scaleVector) + _translateVector;
    //}
}
