// BaseDataObject.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using Newtonsoft.Json;
using System;

namespace androidandios
{
    public class BaseDataObject : ObservableObject, IBaseDataObject
    {
        public BaseDataObject()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Id for item
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Azure created at time stamp
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTimeOffset CreatedAt { get; set; }
    }
}
