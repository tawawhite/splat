using System;
using System.Drawing;

namespace Splat
{
    /// <summary>
    /// Extension methods to assist with the <see cref="SizeF"/> struct.
    /// </summary>
    public static class SizeMathExtensions
    {
        /// <summary>
        /// Determines whether two sizes are within epsilon of each other.
        /// </summary>
        /// <param name="value">The size we doing the operation against.</param>
        /// <param name="other">The size to compare if we are equal to.</param>
        /// <param name="epsilon">The tolerated epsilon value.</param>
        /// <returns>If the value is equal based on the epsilon.</returns>
        public static bool WithinEpsilonOf(this SizeF value, SizeF other, float epsilon)
        {
            var deltaW = other.Width - value.Width;
            var deltaH = other.Height - value.Height;
            return Math.Sqrt((deltaW * deltaW) + (deltaH * deltaH)) < epsilon;
        }

        /// <summary>
        /// Scales a size by a scalar value.
        /// </summary>
        /// <param name="value">The size we doing the operation against.</param>
        /// <param name="factor">The amount to scale by.</param>
        /// <returns>The scaled size.</returns>
        public static SizeF ScaledBy(this SizeF value, float factor)
        {
            return new SizeF(value.Width * factor, value.Height * factor);
        }
    }
}