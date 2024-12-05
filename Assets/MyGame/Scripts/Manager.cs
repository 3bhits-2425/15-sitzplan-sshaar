using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Manager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tableLayout;
    [SerializeField] private StudentData[] students;
    [SerializeField] private GameObject tablePrefab;
    [SerializeField] private GameObject chairPrefab;

    private void Start()
    {
        for (int row = 0; row < tableLayout.row; row++)
        {
            for(int col = 0; col < tableLayout.column; col++)
            {
                Vector3 tabelPosition = new Vector3 (col* tableLayout.tableSpacing,0,row* tableLayout.tableSpacing);
                GameObject table = Instantiate(tablePrefab, tabelPosition, Quaternion.identity, transform);

                Transform possition = table.transform.Find("pos1");
                Transform possition2 = table.transform.Find("pos2");

                if (possition != null)
                { 
                    Instantiate(chairPrefab, possition.position, possition.rotation,table.transform);
                }
                if (possition2 != null)
                {
                    Instantiate(chairPrefab, possition2.position, possition2.rotation, table.transform);
                }
            }
    
        }
    }

}
