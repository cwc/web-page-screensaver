namespace WebPageScreensaver
{
    /// <summary>
    /// Specifies the different ways a screensaver can be shown in multiple screens.
    /// </summary>
    internal enum MultiScreenMode
    {
        /// <summary>
        /// Same webpage in all screens.
        /// </summary>
        Mirror,

        /// <summary>
        /// Each screen has its own individual list of webpages.
        /// </summary>
        Separate,

        /// <summary>
        /// Show one webpage split among all the screens.
        /// </summary>
        Span
    }
}
