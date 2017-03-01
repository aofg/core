using System;

namespace AOFG.Core
{
    /// <summary>
    /// Core modules wrapper
    /// </summary>
    public class Module
    {
        /// <summary>
        /// Initials module instance.
        /// </summary>
        public void Initial() { }

        /// <summary>
        /// Fabric method to create instance of module
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotSupportedException">Not implemented yet</exception>
        public static Module Create()
        {
            throw new NotSupportedException("Not implemented yet");
        }
    }
}