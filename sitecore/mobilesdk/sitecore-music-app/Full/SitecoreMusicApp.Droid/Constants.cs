namespace SitecoreMusicApp.Droid
{
    public class Constants
    {

        public struct Sitecore
        {

            public const string RestBaseUrl = "http://sitecoresandbox_sc81rev151207";
            public const string SitecoreUserName = "admin";
            public const string SitecorePassword = "b";
            public const string SitecoreShellSite = "/sitecore/shell";
            public const string SitecoreDefaultDatabase = "master";
            public const string SitecoreDefaultLanguage = "en";
            public const string SitecoreMediaLibraryRoot = "/sitecore/media library";
            public const string SitecoreMediaPrefix = "~/media/";
            public const string SitecoreDefaultMediaResourceExtension = "ashx";


            public struct MusicStore
            {
                public const string RepositoryPath = "/sitecore/content/Music Store/Repository";
            }

            public struct Templates
            {

                public struct Album
                {
                    public const string TemplateID = "{91D64ACB-78D8-4B9B-A6A0-6C26C6EF2ED5}";
                    public struct Fields
                    {
                        public const string AlbumName = "Album Name";
                        public const string Author = "Author";
                        public const string Year = "Year";
                        public const string Thumbnail = "Thumbnail";
                    }
                }

                public struct Song
                {
                    public const string TemplateID = "{BFA711BE-2372-44EE-89DE-40F219E086B4}";
                    public struct Fields
                    {
                        public const string Number = "Number";
                        public const string SongName = "Song Name";
                        public const string Duration = "Duration";
                        public const string SongFile = "Song File";
                    }
                }

            }

        }

    }

}