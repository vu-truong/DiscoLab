
using UnityEngine;

namespace Disco.Extensions
{
    public static class GameObjectExtensions
    {
        public static void SetLayer(this GameObject gameObject, int layer)
        {
            var renderers = gameObject.GetComponentsInChildren<Renderer>();
            for (int i = 0; i < renderers.Length; i++)
            {
                renderers[i].gameObject.layer = layer;
            }

            var colliders = gameObject.GetComponentsInChildren<Collider>();

            for (int i = 0; i < colliders.Length; i++)
            {
                colliders[i].gameObject.layer = layer;
            }
        }

        public static void EnableAllRenderers(this GameObject gameObject, bool enabled)
        {
            var renderers = gameObject.GetComponentsInChildren<Renderer>();
            for (int i = 0; i < renderers.Length; i++)
                renderers[i].enabled = enabled;
        }
    }
}   

