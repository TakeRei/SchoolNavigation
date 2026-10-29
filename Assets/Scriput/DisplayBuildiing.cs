using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DisplayBuildiing : MonoBehaviour
{
    [SerializeField]
    public GameObject CLBlock;

    [SerializeField]
    public GameObject LCBlock;

    [SerializeField] 
    public GameObject Block23;

    [SerializeField] 
    public GameObject Block23_5;

    [SerializeField] 
    public GameObject Block5;

    [SerializeField]
    public GameObject Block5_7;

    [SerializeField] 
    public GameObject Block7;

    [SerializeField]
    public GameObject CLText;

    [SerializeField]
    public GameObject LCText;

   // [SerializeField]
   // public GameObject Yajirusi;

    [SerializeField]
    public GameObject HareRoad;

    [SerializeField] 
    public GameObject RainRoad;

    [SerializeField]
    public Material CLAfterColor;

    [SerializeField]
    public Material LCAfterColor;

    [SerializeField]
    public Material NomalMaterial;

    [SerializeField]
    public Material ClearMaterial;

    private Renderer CLRenderer;
    private Renderer LCRenderer;
    private Renderer Block23Renderer;
    private Renderer Block23_5Renderer;
    private Renderer Block5Renderer;
    private Renderer Block5_7Renderer;
    private Renderer Block7Renderer;

    private Renderer CLTextRenderer;
    private Renderer LCTextRenderer;

    private bool isHareRoad;
    private bool isRainRoad;

    // Start is called before the first frame update
    void Start()
    {
        CLRenderer = CLBlock.GetComponent<Renderer>();
        LCRenderer = LCBlock.GetComponent<Renderer>();
        Block23Renderer = Block23.GetComponent<Renderer>();
        Block23_5Renderer = Block23_5.GetComponent<Renderer>();
        Block5Renderer = Block5.GetComponent<Renderer>();
        Block5_7Renderer = Block5_7.GetComponent<Renderer>();
        Block7Renderer = Block7.GetComponent<Renderer>();

        CLTextRenderer = CLText.GetComponent<Renderer>();
        LCTextRenderer = LCText.GetComponent<Renderer>();

       // Yajirusi.SetActive(false);
        HareRoad.SetActive(false);
        RainRoad.SetActive(false);

        isHareRoad=true;
        isRainRoad=true;
    }

    // Update is called once per frame
    void Update()
    {
       // DisplayBlock();
    }

    //public void DisplayBlock()
    //{
    //    if (isHareRoad)
    //    {
    //        if (CommonArea.isSpellBlock)//LCÇ∆âπê∫Ç™îFéØÇ≥ÇÍÇΩÇÁé¿çsÇ≥ÇÍÇÈ
    //        {
    //            CLRenderer.material = ClearMaterial;
    //            LCRenderer.material = ClearMaterial;
    //            Block23Renderer.material = ClearMaterial;
    //            Block23_5Renderer.material = ClearMaterial;
    //            Block5Renderer.material = ClearMaterial;
    //            Block5_7Renderer.material = ClearMaterial;
    //            Block7Renderer.material = ClearMaterial;

    //            CLTextRenderer.material.color = CLAfterColor;
    //            LCTextRenderer.material.color = LCAfterColor;
    //            // Yajirusi.SetActive(true);
    //            HareRoad.SetActive(true);

    //            isHareRoad = false;
    //        }
    //    }

    //    if(!isHareRoad) 
    //    {
    //        CLRenderer.material = NomalMaterial;
    //        LCRenderer.material = NomalMaterial;
    //        Block23Renderer.material = NomalMaterial;
    //        Block23_5Renderer.material = NomalMaterial;
    //        Block5Renderer.material = NomalMaterial;
    //        Block5_7Renderer.material = NomalMaterial;
    //        Block7Renderer.material = NomalMaterial;

    //        CLTextRenderer.material = NomalMaterial;
    //        LCTextRenderer.material = NomalMaterial;
    //        // Yajirusi.SetActive(true);
    //        HareRoad.SetActive(false);

    //        isHareRoad = true;
    //    }
    //}

    public void DisplayLC_Hare()
    {
        if (isHareRoad)
        {
            CLRenderer.material = ClearMaterial;
            LCRenderer.material = ClearMaterial;
            Block23Renderer.material = ClearMaterial;
            Block23_5Renderer.material = ClearMaterial;
            Block5Renderer.material = ClearMaterial;
            Block5_7Renderer.material = ClearMaterial;
            Block7Renderer.material = ClearMaterial;

            CLTextRenderer.material = CLAfterColor;
            LCTextRenderer.material = LCAfterColor;

            HareRoad.SetActive(true);

            isHareRoad = false;
        }

        else
        {
            CLRenderer.material = NomalMaterial;
            LCRenderer.material = NomalMaterial;
            Block23Renderer.material = NomalMaterial;
            Block23_5Renderer.material = NomalMaterial;
            Block5Renderer.material = NomalMaterial;
            Block5_7Renderer.material = NomalMaterial;
            Block7Renderer.material = NomalMaterial;

            CLTextRenderer.material = NomalMaterial;
            LCTextRenderer.material = NomalMaterial;
            // Yajirusi.SetActive(true);
            HareRoad.SetActive(false);

            isHareRoad = true;
        }
    }

    public void DisplayLC_Rain()
    {
        if (isRainRoad)
        {
            CLRenderer.material = ClearMaterial;
            LCRenderer.material = ClearMaterial;
            Block23Renderer.material = ClearMaterial;
            Block23_5Renderer.material = ClearMaterial;
            Block5Renderer.material = ClearMaterial;
            Block5_7Renderer.material = ClearMaterial;
            Block7Renderer.material = ClearMaterial;

            CLTextRenderer.material = CLAfterColor;
            LCTextRenderer.material = LCAfterColor;

            RainRoad.SetActive(true);

            isRainRoad = false;
        }

        else
        {
            CLRenderer.material = NomalMaterial;
            LCRenderer.material = NomalMaterial;
            Block23Renderer.material = NomalMaterial;
            Block23_5Renderer.material = NomalMaterial;
            Block5Renderer.material = NomalMaterial;
            Block5_7Renderer.material = NomalMaterial;
            Block7Renderer.material = NomalMaterial;

            CLTextRenderer.material = NomalMaterial;
            LCTextRenderer.material = NomalMaterial;
            // Yajirusi.SetActive(true);
            RainRoad.SetActive(false);

            isRainRoad = true;
        }
    }
}
