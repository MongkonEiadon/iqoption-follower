﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iqoption.data.Model {
    [Table("Follower")]
    public class FollowerDto : EntityWithDateTimeStamp {
        [Required]
        public IqOptionAccountDto IqOptionAccountDto { get; set; }
    }
}