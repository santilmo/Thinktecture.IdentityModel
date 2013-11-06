﻿using System.Diagnostics;
using System.Linq;
using System.Security.Claims;

namespace ClaimsAuthorizeSample
{
    public class AuthorizationManager : ClaimsAuthorizationManager
    {
        public override bool CheckAccess(AuthorizationContext context)
        {
            Trace.WriteLine("\n\nClaimsAuthorizationManager\n_______________________\n");

            Trace.WriteLine("\nAction:");
            Trace.WriteLine("  " + context.Action.First().Value);

            Trace.WriteLine("\nResources:");
            foreach (var resource in context.Resource)
            {
                Trace.WriteLine("  " + resource.Value);
            }

            Trace.WriteLine("\nClaims:");
            foreach (var claim in context.Principal.Claims)
            {
                Trace.WriteLine("  " + claim.Value);
            }

            return true;
        }
    }
}