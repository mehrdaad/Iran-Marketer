﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranMarketer.Domain.DTO
{
    public class CashFlowDetailDeletion
    {
        public long CashFlowMasterId { get; set; }

        public List<long> DetailIds { get; set; }
    }
}