using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

// Class overridning NetworkBehaviour.
public class MyNetworkBehaviour: NetworkBehaviour
{
  // ---------------------------------------------------------------------------------------------------------------------
  // Private fields
  // ---------------------------------------------------------------------------------------------------------------------
  #region

  // Input values.
  private Vector3 input_val;

  #endregion


  // ---------------------------------------------------------------------------------------------------------------------
  // Private methods
  // ---------------------------------------------------------------------------------------------------------------------
  #region

  // Event - called when local player is set up (overriden).
  public override void OnStartLocalPlayer()
  {
    // Get camera component.
    //GameObject camera = GetComponentInChildren(typeof(Camera),true).gameObject;
    GameObject camera = gameObject.transform.GetChild(0).transform.gameObject;    
    // Set camera as active.
    camera.SetActive(true);
    // Change color of local player.
    Material mat = this.GetComponent<MeshRenderer>().material;
    mat.color=Color.green;
    this.GetComponent<MeshRenderer>().material=mat;


    Debug.Log(Time.timeSinceLevelLoad+"OnStartLocalPlayer");
  } // End of OnStartLocalPlayer

  #endregion


  // ---------------------------------------------------------------------------------------------------------------------
  // Private methods
  // ---------------------------------------------------------------------------------------------------------------------
  #region

  // Update (called once per frame).
  private void Update ()
  {
    // If not local player then exit from function.
    if(!this.isLocalPlayer)
    {
      return;
    }
    // Get input values.
    this.input_val.x=CrossPlatformInputManager.GetAxis("Horizontal");
    this.input_val.y=0.0F;
    this.input_val.z=CrossPlatformInputManager.GetAxis("Vertical");
    // Actualize position.
    this.transform.Translate(this.input_val);
  } // End of Update

  #endregion

} //  End of MyNetworkBehaviour