using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScene : MonoBehaviour {

    GameObject Aorta;
    GameObject LCA;

    GameObject PA;
    GameObject PV;

    GameObject RCA;
    GameObject VC;
    GameObject Vmuscle;

    // Use this for initialization
    void Start () {
         Aorta = new GameObject("Aorta");
        OBJ a = Aorta.AddComponent<OBJ>();
        a.objPath = "https://arsrc.visual3d.cn/models/Aorta.obj";
        Aorta.transform.SetParent(gameObject.transform);

        LCA = new GameObject("LCA");
        OBJ b = LCA.AddComponent<OBJ>();
        b.objPath = "https://arsrc.visual3d.cn/models/LCA.obj";
        LCA.transform.SetParent(gameObject.transform);


        PA = new GameObject("PA");
        OBJ c = PA.AddComponent<OBJ>();
        c.objPath = "https://arsrc.visual3d.cn/models/PA.obj";
        PA.transform.SetParent(gameObject.transform);

        PV = new GameObject("PV");
        OBJ d = PV.AddComponent<OBJ>();
        d.objPath = "https://arsrc.visual3d.cn/models/PV.obj";
        PV.transform.SetParent(gameObject.transform);



        RCA = new GameObject("RCA");
        OBJ e = RCA.AddComponent<OBJ>();
        e.objPath = "https://arsrc.visual3d.cn/models/RCA.obj";
        RCA.transform.SetParent(gameObject.transform);


        VC = new GameObject("VC");
        OBJ f = VC.AddComponent<OBJ>();
        f.objPath = "https://arsrc.visual3d.cn/models/VC.obj";
        VC.transform.SetParent(gameObject.transform);


        Vmuscle = new GameObject("Vmuscle");
        OBJ g = Vmuscle.AddComponent<OBJ>();
        g.objPath = "https://arsrc.visual3d.cn/models/V-muscle.obj";
        Vmuscle.transform.SetParent(gameObject.transform);



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
