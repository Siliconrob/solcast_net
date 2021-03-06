﻿using System.Collections.Generic;
using ServiceStack;

namespace Solcast.ServiceModel
{
    public class GetRadiationEstimatedActualsResponse
    {
        public GetRadiationEstimatedActualsResponse()
        {
            EstimatedActuals = new List<ApiObservation>{};
        }

        public virtual List<ApiObservation> EstimatedActuals { get; set; }
        public virtual ResponseStatus ResponseStatus { get; set; }
    }
}