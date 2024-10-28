using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class truckInteract : interactable
{
    
    public bool battery;
    public bool can;
    public bool kit;
    public bool flashlight;
    public bool matches;
    public bool pills;
    public bool tape;
    public bool radio;
    public bool water;

    [Header("Items")]
    [SerializeField]
    private GameObject batteryT;
    [SerializeField]
    private GameObject batteryOP;
    [SerializeField]
    private GameObject canT;
    [SerializeField]
    private GameObject canOP;
    [SerializeField]
    private GameObject kitT;
    [SerializeField]
    private GameObject kitOP;
    [SerializeField]
    private GameObject lightT;
    [SerializeField]
    private GameObject lightOP;
    [SerializeField]
    private GameObject matchesT;
    [SerializeField]
    private GameObject matchesOP;
    [SerializeField]
    private GameObject pillsT;
    [SerializeField]
    private GameObject pillsOP;
    [SerializeField]
    private GameObject tapeT;
    [SerializeField]
    private GameObject tapeOP;
    [SerializeField]
    private GameObject radioT;
    [SerializeField]
    private GameObject radioOP;
    [SerializeField]
    private GameObject waterT;
    [SerializeField]
    private GameObject waterOP;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    protected override void Interact()
    {

        if (battery)
        {
            batteryT.SetActive(true);
            batteryOP.SetActive(false);
        }
        if (can)
        {
            canT.SetActive(true);
            canOP.SetActive(false);
        }
        if (kit)
        {
            kitT.SetActive(true);
            kitOP.SetActive(false);
        }
        if(flashlight)
        {
            lightT.SetActive(true);
            lightOP.SetActive(false);
        }
        if (matches)
        {
            matchesT.SetActive(true);
            matchesOP.SetActive(false);
        }
        if (pills)
        {
            pillsT.SetActive(true);
            pillsOP.SetActive(false);
        }
        if (tape)
        { 
           tapeT.SetActive(true);
           tapeOP.SetActive(false);
        }
        if (radio)
        {
            radioT.SetActive(true); 
            radioOP.SetActive(false);
        }
        if (water)
        {
            waterT.SetActive(true);
            waterOP.SetActive(false);
        }
    }


    public void SetBattery()
    {
        battery = true;
    }
    public void SetCan()
    {
        can = true;
    }
    public void SetKit()
    {
        kit = true;
    }
    public void SetLight()
    {
        flashlight = true;
    }
    public void SetMatches()
    {
        matches = true;
    }
    public void SetPills() 
    { 
        pills = true; 
    }
    public void SetTape()
    {
        tape = true;
    }
    public void SetRadio()
    {
        radio = true;
    }
    public void SetWater()
    {
        water = true;
    }
}
