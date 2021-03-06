﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bondora.Api.Client.Sample.DotNet.Models
{
    public class ApiResultBids : ApiResult<IList<BidSummary>>
    {
        /// <summary>
        /// Total number of investments found
        /// </summary>
        public int TotalCount { get; set; }
    }
}
