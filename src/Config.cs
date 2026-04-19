namespace TypingCom3
{
    class Config
    {
        // Base Ints
        public static int TypingRate { get; set; } = 99999999999999999999999999999999999999999999999999999;
        public static int Accuracy { get; set; } = 100;

        // Modifier Ints
        public static int TypingRateVariancy { get; set; } = 0;
        public static int AccuracyVariancy { get; set; } = 0;

        // Internal Runtime Settings
        public static bool CheatRunning { get; set; } = false;
    }
}
