using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.FileStorage
{
    /// <summary>
    /// Represents a file associated to an existing Dataverse record.
    /// </summary>
    public interface IFileAttachment
    {
        /// <summary>
        /// The unique identifier of the file to be uploaded(i.e. the Guid of the fileattachment record)
        /// </summary>
        string Id { get; set; }
        
        /// <summary>
        /// The file name, including the file extension
        /// </summary>
        string FileName { get; set; }
        
        /// <summary>
        /// The file MIME type
        /// </summary>
        string MimeType { get; set; }
        
        /// <summary>
        /// The actual file contents as a byte array
        /// </summary>
        byte[] Content { get; set; }
        
        /// <summary>
        /// The associated record to which this file belongs
        /// </summary>
        EntityReference Target { get; set; }
        
        /// <summary>
        /// The logical name of the File or Image column / field of the Target EntityReference
        /// </summary>
        string AttributeName { get; set; }
    }
}