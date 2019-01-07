﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Graphics;

namespace Splat
{
    /// <summary>
    /// Extension methods associated with the <see cref="SplatColor"/> struct.
    /// </summary>
    public static class SplatColorExtensions
    {
        /// <summary>
        /// Converts a <see cref="SplatColor"/> into the android native <see cref="Color"/>.
        /// </summary>
        /// <param name="value">The color to convert.</param>
        /// <returns>The <see cref="Color"/> generated.</returns>
        public static Color ToNative(this SplatColor value)
        {
            return new Color(value.R, value.G, value.B, value.A);
        }

        /// <summary>
        /// Converts a <see cref="Color"/> into the android native <see cref="SplatColor"/>.
        /// </summary>
        /// <param name="value">The color to convert.</param>
        /// <returns>The <see cref="SplatColor"/> generated.</returns>
        public static SplatColor FromNative(this Color value)
        {
            return SplatColor.FromArgb(value.A, value.R, value.G, value.B);
        }
    }
}