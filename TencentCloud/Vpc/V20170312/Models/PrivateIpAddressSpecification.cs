/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrivateIpAddressSpecification : AbstractModel
    {
        
        /// <summary>
        /// 内网IP地址。
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddress{ get; set; }

        /// <summary>
        /// 是否是主IP。
        /// </summary>
        [JsonProperty("Primary")]
        public bool? Primary{ get; set; }

        /// <summary>
        /// 公网IP地址。
        /// </summary>
        [JsonProperty("PublicIpAddress")]
        public string PublicIpAddress{ get; set; }

        /// <summary>
        /// EIP实例ID，例如：eip-11112222。
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// 内网IP描述信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 公网IP是否被封堵。
        /// </summary>
        [JsonProperty("IsWanIpBlocked")]
        public bool? IsWanIpBlocked{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrivateIpAddress", this.PrivateIpAddress);
            this.SetParamSimple(map, prefix + "Primary", this.Primary);
            this.SetParamSimple(map, prefix + "PublicIpAddress", this.PublicIpAddress);
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsWanIpBlocked", this.IsWanIpBlocked);
        }
    }
}

