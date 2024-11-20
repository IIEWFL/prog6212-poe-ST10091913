using System.Collections.Generic;

namespace ContractMonthlyClaimSystem
{
    public static class ClaimStorage
    {
        private static List<Claim> claims = new List<Claim>();

        public static void AddClaim(Claim claim)
        {
            claims.Add(claim);
        }

        public static List<Claim> GetClaims()
        {
            return claims;
        }

        public static Claim GetClaimById(int index) 
        {
            return (index >= 0 && index < claims.Count) ? claims[index] : null;
        }
    }
}
