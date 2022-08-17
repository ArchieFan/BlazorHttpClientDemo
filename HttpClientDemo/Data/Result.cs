namespace HttpClientDemo.Data
{

    public class Result
    {
        public string? Asset { get; set; }
        public string? AssetLong { get; set; }
        public int MinConfirmation { get; set; }
        public float WithdrawTxFee { get; set; }
        public float WithdrawTxFeePercent { get; set; }
        public string? SystemProtocol { get; set; }
        public bool IsActive { get; set; }
        public string? InfoMessage { get; set; }
        public bool MaintenanceMode { get; set; }
        public string? MaintenanceMessage { get; set; }
        public string? FormatPrefix { get; set; }
        public string? FormatSufix { get; set; }
        public string? DecimalSeparator { get; set; }
        public string? ThousandSeparator { get; set; }
        public int DecimalPlaces { get; set; }
        public string? withdrawal_fee_schedule { get; set; }
    }



}
