﻿using UnityEngine;

namespace Disco
{
	public static class ComponentExtension
	{
        public static void SetLayer_AllChildren<T>(this Component component, int layer, bool includeInactive = false) where T : Component
        {
            DiscoAssert.IsNotNull(component);

            var components = component.GetComponentsInChildren<T>(includeInactive);
            for (int i = 0; i < components.Length; i++)
            {
                components[i].gameObject.layer = layer;
            }
        }

        public static void SetEnabled_AllChildren<T>(this Component component, bool enabled, bool includeInactive = false) where T : Behaviour
        {
            DiscoAssert.IsNotNull(component);

            var behaviours = component.GetComponentsInChildren<T>(includeInactive);

            for (int i = 0; i < behaviours.Length; i++)
            {
                behaviours[i].enabled = enabled;
            }
        }

        public static void InvertEnabled_AllChildren<T>(this Component component, bool includeInactive = false) where T : Behaviour
        {
            DiscoAssert.IsNotNull(component);

            var behaviours = component.GetComponentsInChildren<T>(includeInactive);
            for (int i = 0; i < behaviours.Length; i++)
                behaviours[i].InvertEnabled();
        }

        public static void SetActive(this Component component, bool active)
        {
            DiscoAssert.IsNotNull(component);

            component.gameObject.SetActive(active);
        }

        public static void InvertActive(this Component component)
        {
            DiscoAssert.IsNotNull(component);

            bool isActive = component.GetActiveSelf();
            component.SetActive(!isActive);
        }

        public static void InvertEnabled(this Behaviour behaviour)
        {
            DiscoAssert.IsNotNull(behaviour);

            bool enabled = behaviour.enabled;
            behaviour.enabled = !enabled;
        }

        public static bool GetActiveSelf(this Component component)
        {
            DiscoAssert.IsNotNull(component);

            return component.gameObject.activeSelf;
        }

        public static bool GetActiveInHierarchy(this Component component)
        {
            DiscoAssert.IsNotNull(component);

            return component.gameObject.activeInHierarchy;
        }
    }
}

