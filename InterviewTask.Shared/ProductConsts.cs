namespace InterviewTask.Common.Shared
{
    public static class ProductConsts
    {
        public const string BasicProductName = "basic electricity tariff";
        public const string PackagedProductName = "Packaged tariff";

        public const decimal BasicProductBaseCosts = 5;
        public const decimal BasicProductConsumptionCoefficient = 0.22m;

        public const decimal PackagedProductBaseCosts = 800;
        public const decimal PackagedProductAdditionalCoefficient = 0.3m;
        public const decimal PackagedProductLimit = 4000;
    }
}
