
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
    [SerializeField] private GameObject menschPrefab;
    [SerializeField] private List<GameObject> chairlist;


    private void Start()
    {
        chairlist = new List<GameObject>();
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
                    GameObject chair = Instantiate(chairPrefab, possition.position, possition.rotation,table.transform);
                    chairlist.Add(chair);
                }

                if (possition2 != null)
                {
                    chairlist.Add(Instantiate(chairPrefab, possition2.position, possition2.rotation, table.transform));
                }

                for(int i = 0; i < chairlist.Count; i++)
                {
                    Transform posMensch = chairlist[i].transform.Find("Mensch");
                    if (posMensch != null)
                    {
                        GameObject mensch= Instantiate(menschPrefab, posMensch.position, posMensch.rotation, chairlist[i].transform);
                        for (int j = 0; j < students.Length; j++)
                        {
                            Sprite image = 
                            image = students[j].studentImage;
                            
                        }
                    }
                }               

            }
    
        }
    }

}
