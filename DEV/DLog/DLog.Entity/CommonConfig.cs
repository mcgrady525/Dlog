//------------------------------------------------------------------------------
// <auto-generated>
//     此代码是根据模板生成的。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，则所做更改将丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using DLog.Entity.Metadata;

namespace DLog.Entity
{
    /// <summary>
    /// <para>【DLogDB.Entity.tt生成的，与数据库对应的】</para>
    /// 
    /// </summary>
    [Serializable]
    [DataContract(IsReference = true)]
    [MetadataType(typeof(CommonConfigMetadata))]
    public partial class CommonConfig
    {
    
    	/// <summary>
        /// 獲取或設置
    	/// </summary>
        [DatabaseTableColumn]
        [DataMember]
        public int ID { get; set; }
    
    	/// <summary>
        /// 獲取或設置
    	/// </summary>
        [DatabaseTableColumn]
        [DataMember]
        public string Content { get; set; }
    
    	/// <summary>
        /// 獲取或設置
    	/// </summary>
        [DatabaseTableColumn]
        [DataMember]
        public System.DateTime LastUpdateTime { get; set; }
    
    	/// <summary>
        /// 獲取或設置
    	/// </summary>
        [DatabaseTableColumn]
        [DataMember]
        public string LastUpdateUser { get; set; }
    }
    
}
