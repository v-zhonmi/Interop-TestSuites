﻿namespace Microsoft.Protocols.TestSuites.MS_OXCMAPIHTTP
{
    using System;

    /// <summary>
    /// A class indicates the ResortRestriction request type failure response body.
    /// </summary>
    public class ResortRestrictionFailureResponseBody: AddressBookResponseBodyBase
    {
        /// <summary>
        /// Parse the ResortRestriction request type response body.
        /// </summary>
        /// <param name="rawData">The raw data of response.</param>
        /// <returns>The failure response body of ResortRestriction request.</returns>
        public static ResortRestrictionFailureResponseBody Parse(byte[] rawData)
        {
            ResortRestrictionFailureResponseBody responseBody = new ResortRestrictionFailureResponseBody();
            int index = 0;
            responseBody.StatusCode = BitConverter.ToUInt32(rawData, index);
            index += 4;
            responseBody.AuxiliaryBufferSize = BitConverter.ToUInt32(rawData, index);
            index += 4;
            responseBody.AuxiliaryBuffer = new byte[responseBody.AuxiliaryBufferSize];
            Array.Copy(rawData, index, responseBody.AuxiliaryBuffer, 0, responseBody.AuxiliaryBufferSize);

            return responseBody;
        }
    }
}
