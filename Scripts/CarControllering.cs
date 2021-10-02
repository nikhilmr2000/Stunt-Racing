using UnityEngine;
using System.Collections;
public class CarControllering : MonoBehaviour {
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
    private float maxTorque = 1200f;
    void Start () 
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centreofmass.transform.localPosition;
    }
    
   void FixedUpdate () {
     if(!braked){
            WheelFL.brakeTorque = 0;
            WheelFR.brakeTorque = 0;
            WheelRL.brakeTorque = 0;
            WheelRR.brakeTorque = 0;
        }
        //speed of car, Car will move as you will provide the input to it.
        WheelRR.motorTorque = maxTorque*Input.GetAxis("Vertical");
        WheelRL.motorTorque = maxTorque*Input.GetAxis("Vertical");
        //changing car direction
//Here we are changing the steer angle of the front tyres of the car so that we can change the car direction.
        WheelFL.steerAngle = 30 * Input.GetAxis("Horizontal");
        WheelFR.steerAngle = 30 * Input.GetAxis("Horizontal");
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
    public void HandBrake()
    {
        //Debug.Log("brakes " + braked);
        if(Input.GetButton("Jump"))        {
            braked = true;
        }
        else
        {
            braked = false;
        }
        if(braked){
         
            WheelRL.brakeTorque = maxBrakeTorque * 50;//0000;
            WheelRR.brakeTorque = maxBrakeTorque * 50;//0000;
            WheelRL.motorTorque = 0;
            WheelRR.motorTorque = 0;
        }
    }
}