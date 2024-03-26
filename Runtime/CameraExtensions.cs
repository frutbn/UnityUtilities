using UnityEngine;

public static class CameraExtensions
{
    public static Camera GetActiveCamera()
    {
        var allCameras = Camera.allCameras;

        Camera activeCamera = null;
        foreach (var cam in allCameras)
        {
            if (activeCamera != null && activeCamera.enabled && activeCamera.depth > cam.depth) continue;
            activeCamera = cam;
        }

        return activeCamera;
    }
}