namespace Microsoft.Protocols.TestSuites.MS_OXCPERM
{
    using System;

    /// <summary>
    /// The value of this property is the attach method
    /// </summary>
    public struct AttachMethod : IPropertyInterface
    {
        /// <summary>
        /// The value of this property is the attach method
        /// </summary>
        private uint attachMethod;

        /// <summary>
        /// Input the value from rawData to structure
        /// </summary>
        /// <param name="rawData">The byte array returned from the GetLists</param>
        /// <param name="count">The count point to the current digit</param>
        /// <returns>A IPropertyInterface structure contains the value</returns>
        public IPropertyInterface InputValue(byte[] rawData, ref int count)
        {
            AttachMethod value;
            value.attachMethod = (uint)BitConverter.ToInt32(rawData, count);
            count += 4;
            return value;
        }

        /// <summary>
        /// Output the value saved in the IPropertyInterface structure
        /// </summary>
        /// <param name="list">The list from the input</param>
        /// <returns>Certain value of each property</returns>
        public object OutputValue(IPropertyInterface list)
        {
            AttachMethod fid1 = (AttachMethod)list;
            uint value = fid1.attachMethod;
            return value;
        }
    }
}