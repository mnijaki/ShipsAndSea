using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

// Own implementation of NetworkManager (overrides some of its methods and add some new ones).
public class MyNetworkManager : NetworkManager
{
  // ---------------------------------------------------------------------------------------------------------------------
  // Public fields
  // ---------------------------------------------------------------------------------------------------------------------
  #region



  #endregion


  // ---------------------------------------------------------------------------------------------------------------------
  // Private fields
  // ---------------------------------------------------------------------------------------------------------------------
  #region

  #endregion


  // ---------------------------------------------------------------------------------------------------------------------
  // Public methods
  // ---------------------------------------------------------------------------------------------------------------------
  #region

  // Start hosting.
  public void MyHostStart()
  {
    Debug.Log(Time.timeSinceLevelLoad+"MyHostStart");

    // Create server and first client(who is hosting).
    this.StartHost();
  } // End of MyHostStart

  // Event - on hosting has started (overriden).
  public override void OnStartHost()
  {
    Debug.Log(Time.timeSinceLevelLoad+"OnStartHost");
  } // End of OnStartHost

  // Event - on client has started (overriden).
  public override void OnStartClient(NetworkClient client)
  {
    Debug.Log(Time.timeSinceLevelLoad+"OnStartClient");
  } // End of OnStartClient

  // Event - called on client side, when he will connect to the server (overriden).
  public override void OnClientConnect(NetworkConnection conn)
  {
    Debug.Log(Time.timeSinceLevelLoad+"OnClientConnect, IP="+conn.address);
  } // End of OnClientConnect

  #endregion


  // ---------------------------------------------------------------------------------------------------------------------
  // Private methods
  // ---------------------------------------------------------------------------------------------------------------------
  #region

  // Initialization.
  private void Start()
  {
	} // End of Start

  

  #endregion











} // End of MyNetworkManager