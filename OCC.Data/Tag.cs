﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCC.Data
{
    public class Tag
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TagName { get; set; }

    }
}
