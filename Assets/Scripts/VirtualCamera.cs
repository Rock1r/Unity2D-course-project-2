using Cinemachine;
using UnityEngine;

public class VirtualCamera : MonoBehaviour
{
    private CinemachineVirtualCamera virtualCamera;
    private CinemachineFramingTransposer framingTransposer;

    private void Start()
    {
        // Assuming the script is on the same GameObject as the CinemachineVirtualCamera
        virtualCamera = GetComponent<CinemachineVirtualCamera>();

        if (virtualCamera != null)
        {
            framingTransposer = virtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>();
        }
        else
        {
            Debug.LogError("CinemachineVirtualCamera component not found!");
        }
    }

    public void ResetCamera()
    {
        if (framingTransposer != null)
        {
            // Reset specific properties of the Framing Transposer to their default values
            framingTransposer.m_ScreenX = 0.5f; // Reset ScreenX to center
            framingTransposer.m_ScreenY = 0.5f; // Reset ScreenY to center
            framingTransposer.m_DeadZoneWidth = 0.1f; // Reset DeadZoneWidth to default
            // Add other properties as needed

            // You might also want to reset other components of the virtual camera if applicable
            // For example, you might reset the lookahead values for the Orbiy Transposer
            CinemachineOrbitalTransposer orbitalTransposer = virtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>();
            if (orbitalTransposer != null)
            {
                orbitalTransposer.m_XDamping = 0.1f; // Reset XDamping to default
                // Add other properties as needed
            }
        }
        else
        {
            Debug.LogError("CinemachineFramingTransposer component not found!");
        }
    }
}
