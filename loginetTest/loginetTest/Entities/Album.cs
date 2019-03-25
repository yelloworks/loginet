using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Newtonsoft.Json;

namespace loginetTest.Entities
{
    [Serializable]
    [JsonObject]
    [Table("Albums")]
    public class Album
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }


        [JsonIgnore]
        [IgnoreDataMember]
        public User CurrentUser { get; set; }
    }
}