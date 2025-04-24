using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] public class PivotInfo
{
    public Vector3 localPosition;
    public Color color = Color.white;
    public List<int> pivotConnections = new List<int>();
}
[CreateAssetMenu(menuName = ("ScriptableObjects/FigureData"), order =999)]
public class FigureData : ScriptableObject
{
    public Vector3 vectorTranslation = Vector3.zero;
    public Vector3 scaleVector = Vector3.one;
    public List<PivotInfo> pivots = new List<PivotInfo>();
    public void UpdateTransform(Vector3 outTransform)
    {
        vectorTranslation = outTransform;
    }
    public void UpdateScale(Vector3 outScale)
    {
        scaleVector = outScale;
    }
}
