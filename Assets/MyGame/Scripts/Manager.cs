
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class Manager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tableLayout;
    [SerializeField] private StudentData[] students;
    [SerializeField] private GameObject tablePrefab;
    [SerializeField] private GameObject chairPrefab;
    [SerializeField] private GameObject MenschPrefab;
    [SerializeField] private List<GameObject> chairlist;


    private void Start()
    {
        chairlist = new List<GameObject>(); // wichtig sonst error 
        for (int row = 0; row < tableLayout.row; row++)
        {
            for(int col = 0; col < tableLayout.column; col++)
            {
                Vector3 tabelPosition = new Vector3 (col* tableLayout.tableSpacing,0,row* tableLayout.tableSpacing);
                GameObject table = Instantiate(tablePrefab, tabelPosition, Quaternion.identity, transform);
               

                Transform possition = table.transform.Find("pos1");
                Transform possition2 = table.transform.Find("pos2");
                Transform posMensch = table.transform.Find("Mensch");
                Transform posMensch2 = table.transform.Find("Mensch2");




                if (possition != null)
                { 
                    GameObject chair = Instantiate(chairPrefab, possition.position, possition.rotation,table.transform);
                    chairlist.Add(chair);
                }

                if (possition2 != null)
                {
                    chairlist.Add(Instantiate(chairPrefab, possition2.position, possition2.rotation, table.transform));
                }


                if (posMensch != null)
                {
                    Instantiate(MenschPrefab, posMensch.position, posMensch.rotation, table.transform);
                }
                if (posMensch2 != null)
                {
                    Instantiate(MenschPrefab, posMensch2.position, posMensch2.rotation, table.transform);
                }
               

            }
    
        }
    }

}
