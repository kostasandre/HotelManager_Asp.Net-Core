﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pictures.cs" company="">
//   
// </copyright>
// <summary>
//   The pictures.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DCHotelManagerCore.Lib.Models.Persistent
{
    #region

    using DCHotelManagerCore.Lib.Models.Persistent.Interfaces;

    #endregion

    /// <summary>
    /// The pictures.
    /// </summary>
    public class Picture : IEntity
    {
        /// <summary>
        /// Gets or sets the byte array.
        /// </summary>
        public byte[] ByteArray { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }


    }
}