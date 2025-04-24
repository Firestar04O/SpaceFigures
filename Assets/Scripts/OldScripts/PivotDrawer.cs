using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotDrawer : MonoBehaviour
{
    [SerializeField] private PivotDrawer pivotDrawer1;
    [SerializeField] private PivotDrawer pivotDrawer2;
    [SerializeField] private PivotDrawer pivotDrawer3;
    [SerializeField] private float pivotRadious = 0.25f;
    [SerializeField] private Color pivotColor = Color.black;
    [SerializeField] private Color rayColor = Color.white;
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 startScale;

    private Vector3 _translateVector;
    private Vector3 _scaleVector;
    public Vector3 PivotPosition => transform.position;

    private void Awake()
    {
        startPosition = transform.position;
        startScale = transform.localScale;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = pivotColor;
        Gizmos.DrawWireSphere(PivotPosition, pivotRadious);

        Gizmos.color = rayColor;
        Gizmos.DrawLine(PivotPosition, pivotDrawer1.PivotPosition);
        Gizmos.DrawLine(PivotPosition, pivotDrawer2.PivotPosition);
        Gizmos.DrawLine(PivotPosition, pivotDrawer3.PivotPosition);
    }

    public void TranslatePivot(Vector3 translation)
    {
        _translateVector = translation;

        transform.position = startPosition + _translateVector;
    }

    public void ScalePivot(Vector3 scale)
    {
        _scaleVector = scale;

        transform.position = startScale + Vector3.Scale(startPosition, _scaleVector) + _translateVector;
    }
}
