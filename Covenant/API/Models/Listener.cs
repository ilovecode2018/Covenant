// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Listener
    {
        /// <summary>
        /// Initializes a new instance of the Listener class.
        /// </summary>
        public Listener()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Listener class.
        /// </summary>
        /// <param name="status">Possible values include: 'Uninitialized',
        /// 'Active', 'Stopped'</param>
        public Listener(int? id = default(int?), string name = default(string), string description = default(string), string bindAddress = default(string), int? bindPort = default(int?), string connectAddress = default(string), int? profileId = default(int?), int? listenerTypeId = default(int?), ListenerStatus? status = default(ListenerStatus?), string covenantToken = default(string), System.DateTime? startTime = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            Description = description;
            BindAddress = bindAddress;
            BindPort = bindPort;
            ConnectAddress = connectAddress;
            ProfileId = profileId;
            ListenerTypeId = listenerTypeId;
            Status = status;
            CovenantToken = covenantToken;
            StartTime = startTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bindAddress")]
        public string BindAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bindPort")]
        public int? BindPort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectAddress")]
        public string ConnectAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "profileId")]
        public int? ProfileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listenerTypeId")]
        public int? ListenerTypeId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Uninitialized', 'Active',
        /// 'Stopped'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ListenerStatus? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "covenantToken")]
        public string CovenantToken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

    }
}
