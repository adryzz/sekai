// Copyright (c) The Vignette Authors
// Licensed under MIT. See LICENSE for details.

using System.Numerics;

namespace Sekai.Engine;

/// <summary>
/// Represent a camera in the scene.
/// </summary>
public class Camera : Component
{
    /// <summary>
    /// The field of view of the camera in degrees. Used when <see cref="CameraProjectionMode.Perspective"/> is used.
    /// </summary>
    public float FieldOfView = 90.0f;

    /// <summary>
    /// The near clip plane of the camera.
    /// </summary>
    public float NearClipPlane = 0.0001f;

    /// <summary>
    /// The far clip plane of the camera.
    /// </summary>
    public float FarClipPlane = 5000f;

    /// <summary>
    /// The projection mode of the camera.
    /// </summary>
    public CameraProjectionMode Projection = CameraProjectionMode.Perspective;

    internal Matrix4x4 ViewMatrix = Matrix4x4.Identity;
    internal Matrix4x4 ProjMatrix = Matrix4x4.Identity;
}

/// <summary>
/// Camera projection mode
/// </summary>
public enum CameraProjectionMode
{
    Perspective,
    Orthographic,
}
