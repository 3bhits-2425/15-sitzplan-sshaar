using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTableLayout", menuName = "Seatplan/table")]
public class TableLayoutData : ScriptableObject
{
    public int row;
    public int column;
    public float tableSpacing;
    public float chairSpacing;

}
