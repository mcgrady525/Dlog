
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码是根据模板生成的。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，则所做更改将丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using DataAnnotationsExtensions;//http://dataannotationsextensions.org/


namespace DLog.Entity.Metadata
{

/// <summary>
///  CustomMetadata基類
/// </summary>
[DataContract]
public class DebugLogMetadataBase
{


	/// <summary>
    /// 
	/// </summary>
    [Key]
        [Required]
        [Digits]
        [Max(long.MaxValue)]
        [DataMember]
    public object ID { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [Required]
        [Digits]
        [Max(int.MaxValue)]
        [DataMember]
    public object ThreadID { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [Required]
        [StringLength(64)]
        [DataMember]
    public object SystemCode { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [Required]
        [StringLength(64)]
        [DataMember]
    public object Source { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [Required]
        [StringLength(512)]
        [DataMember]
    public object Message { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [StringLength(64)]
        [DataMember]
    public object MachineName { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [Required]
        [StringLength(1024)]
        [DataMember]
    public object AppDomainName { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [Required]
        [Digits]
        [Max(int.MaxValue)]
        [DataMember]
    public object ProcessID { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [Required]
        [StringLength(1024)]
        [DataMember]
    public object ProcessName { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [StringLength(1024)]
        [DataMember]
    public object ThreadName { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [DataMember]
    public object Detail { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [Required]
        [DataType(DataType.Date)]
        [UIHint("DatePicker")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataMember]
    public object CreateTime { get; set; }


	/// <summary>
    /// 
	/// </summary>
    [StringLength(256)]
        [DataMember]
    public object IpAddress { get; set; }

}


}
