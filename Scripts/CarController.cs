using UnityEngine;
using System.Collections;
public class CarController : MonoBehaviour {
    public WheelCollider WheelFL;
    public WheelCollider WheelFR;
    public WheelCollider WheelRL;
    public WheelCollider WheelRR;
    public Transform WheelFLtrans;
    public Transform WheelFRtrans;
    public Transform WheelRLtrans;
    public Transform WheelRRtrans;
    public Vector3 eulertest;
    float maxFwdSpeed = -3000;
    float maxBwdSpeed = 1000f;
    float gravity = 9.8f;
    private bool braked = false;
    private float maxBrakeTorque = 800f;
    private Rigidbody rb;
    public Transform centreofmass;
    private float maxTorque = 1700f;
    private bool isPressed;
    private bool wasPressed;
    private bool isLeft;
    private bool isRight;
    private bool isBrake;
    AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    AudioSource audioSource1;
    void Start () 
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centreofmass.transform.localPosition;
        audioSource=GetComponent<AudioSource>();
    }
    
   void FixedUpdate () {
     if(!braked){
            WheelFL.brakeTorque = 0;
            WheelFR.brakeTorque = 0;
            WheelRL.brakeTorque = 0;
            WheelRR.brakeTorque = 0;
        }
        //speed of car, Car will move as you will provide the input to it.
    if(isPressed){
        WheelRR.motorTorque = maxTorque;
        WheelRL.motorTorque =maxTorque;
    }
    else if(wasPressed){
        WheelRR.motorTorque =-maxTorque;
        WheelRL.motorTorque =-maxTorque;
    }
    else{
        WheelRR.motorTorque =0;
        WheelRL.motorTorque =0;

    }
      
        //changing car direction
//Here we are changing the steer angle of the front tyres of the car so that we can change the car direction.
    if(isLeft){
        WheelFL.steerAngle =-30;
        WheelFR.steerAngle =-30;
    }
    else if(isRight){
        WheelFL.steerAngle =30;
        WheelFR.steerAngle =30;

    }
    else{
        WheelFL.steerAngle =0;
        WheelFR.steerAngle =0;
    }

    }
    void Update()
    {
        HandBrake();
        
        //for tyre rotate
        WheelFLtrans.Rotate(0,0,WheelFL.rpm/60*360*Time.deltaTime);
        WheelFRtrans.Rotate(0,0,WheelFR.rpm/60*360*Time.deltaTime);
        WheelRLtrans.Rotate(0,0,WheelRL.rpm/60*360*Time.deltaTime);
        WheelRRtrans.Rotate(0,0,WheelRR.rpm/60*360*Time.deltaTime);
        //changing tyre direction
        /*Vector3 temp = WheelFLtrans.localEulerAngles;
        Vector3 temp1 = WheelFRtrans.localEulerAngles;
        temp.y = WheelFL.steerAngle - (WheelFLtrans.localEulerAngles.y);
        WheelFLtrans.localEulerAngles = temp;
        temp1.y = WheelFR.steerAngle - (WheelFRtrans.localEulerAngles.y);
        WheelFRtrans.localEulerAngles = temp1;
        eulertest = WheelFLtrans.localEulerAngles;*/
    }
    void HandBrake()
    {
        //Debug.Log("brakes " + braked);
        if(isBrake)
        {
            braked = true;
        }
        else
        {
            braked = false;
        }
        if(braked){
         
            WheelRL.brakeTorque = maxBrakeTorque * 80;//0000;
            WheelRR.brakeTorque = maxBrakeTorque * 80;//0000;
            WheelRL.motorTorque = 0;
            WheelRR.motorTorque = 0;
        }
    }

    public void Pressed(){
        isPressed=true;
        audioSource.Play();
    }
    public void Reverse(){
        wasPressed=true;
    }

    public void NotReverse(){
        wasPressed=false;
    }
    public void NotPressed(){
        isPressed=false;
        audioSource.Stop();
    }

    public void Left(){
        isLeft=true;
    }

    public void Right(){
        isRight=true;
    }

    public void NotLeft(){
        isLeft=false;
    }

    public void NotRight(){
        isRight=false;
    }

    public void Braker(){
        isBrake=true;
    }

    public void NotBraker(){
        isBrake=false;
    }
}