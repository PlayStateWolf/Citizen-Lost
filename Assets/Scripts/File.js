var vecttoq : Quaternion;

var parent : Transform; 

function Start(){ var parentRotInv : Quaternion= Quaternion.Inverse(parent.rotation); 

//vecttoq = parentRotInv*transform.rotation; 

} 

function LateUpdate(){ 

transform.rotation=Camera.main.transform.rotation*vecttoq;

}