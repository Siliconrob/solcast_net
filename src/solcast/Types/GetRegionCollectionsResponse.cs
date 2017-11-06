﻿using System.Collections.Generic;
using ServiceStack;

namespace solcast.types
{
    public class GetRegionCollectionsResponse
    {
        public GetRegionCollectionsResponse()
        {
            Collections = new List<RegionCollection>{};
        }

        public virtual List<RegionCollection> Collections { get; set; }
        public virtual ResponseStatus ResponseStatus { get; set; }
    }
}