using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewChairLayout", menuName = "Seatplan/chair")]
public class ChairLayoutData : ScriptableObject
{
    public int row;
    public int column;
    public float tableSpacing;
    public float chairSpacing;
}