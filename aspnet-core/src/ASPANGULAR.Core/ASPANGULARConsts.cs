using ASPANGULAR.Debugging;

namespace ASPANGULAR
{
    public class ASPANGULARConsts
    {
        public const string LocalizationSourceName = "ASPANGULAR";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a701cdafb3b44a3da0435eb2a8a3ddea";
    }
}
