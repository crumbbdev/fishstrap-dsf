﻿namespace Bloxstrap.AppData
{
    public class RobloxStudioData : CommonAppData, IAppData
    {
        public string ProductName => "Roblox Studio";

        public string BinaryType => "WindowsStudio64";

        public string RegistryName => "RobloxStudio";

        public override string ExecutableName => App.RobloxStudioAppName;

        public override AppState State => App.RobloxState.Prop.Studio;

        public override IReadOnlyDictionary<string, string> PackageDirectoryMap { get; set; } = new Dictionary<string, string>()
        {
            { "RobloxStudio.zip",                @"" },
            { "LibrariesQt5.zip",                @"" },

            { "content-studio_svg_textures.zip", @"content\studio_svg_textures\"},
            { "content-qt_translations.zip",     @"content\qt_translations\" },
            { "content-api-docs.zip",            @"content\api_docs\" },

            { "extracontent-scripts.zip",        @"ExtraContent\scripts\" },

            { "studiocontent-models.zip",        @"StudioContent\models\" },
            { "studiocontent-textures.zip",      @"StudioContent\textures\" },

            { "BuiltInPlugins.zip",              @"BuiltInPlugins\" },
            { "BuiltInStandalonePlugins.zip",    @"BuiltInStandalonePlugins\" },

            { "ApplicationConfig.zip",           @"ApplicationConfig\" },
            { "Plugins.zip",                     @"Plugins\" },
            { "Qml.zip",                         @"Qml\" },
            { "StudioFonts.zip",                 @"StudioFonts\" },
            { "RibbonConfig.zip",                @"RibbonConfig\" }
        };
    }
}
