﻿using System;

namespace UnityEngine.Rendering.Knight
{
    /// <summary>
    ///   <para>Prevents ScriptableRendererFeatures of same type to be added more than once to a Scriptable Renderer.</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal class DisallowMultipleRendererFeature : Attribute
    {
    }
}
