using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonecaoShoot : MonoBehaviour
{
    [SerializeField]
    private Transform shootposicao;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private Projectiles projectil;

    private Vector3 mouseposicao;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log(worldPosition);
            projectil.create (shootposicao, worldPosition);
        }

        
    }
}
