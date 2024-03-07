using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxHandler : MonoBehaviour
{
    public List<Material> skyboxMaterialList = new List<Material>();
    public void SetSkybox(int _id)
    {
         RenderSettings.skybox=skyboxMaterialList[_id];
        DynamicGI.UpdateEnvironment();
    }
}
