using MudBlazor;
using MudBlazor.Utilities;
using static MudBlazor.Colors;

namespace Cascadia_MetalFlow_System.Themes
{
    public class MainTheme : MudTheme
    {
        public MainTheme()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = Teal.Darken1,
                Secondary = new MudColor("#7C3AED"),
                Success = new MudColor("#16A34A"),
                Warning = new MudColor("#D97706"),
                Error = new MudColor("#DC2626"),
                AppbarBackground = new MudColor("#FFFFFF"),
                AppbarText = new MudColor("#0F172A"),
                Surface = new MudColor("#FFFFFF"),
                DrawerBackground = new MudColor("#F8FAFC"),
                DrawerText = new MudColor("#0F172A"),
                Background = new MudColor("#F8FAFC"),
                TextPrimary = new MudColor("#0F172A"),
            };

            Typography = new Typography()
            {
                Default = new DefaultTypography()
                {
                    FontFamily = new[] { "Roboto", "Helvetica", "Arial", "sans-serif" },
                    FontWeight = "400",
                },
                H4 = new H4Typography()
                {
                    FontWeight = "500",
                },
                H6 = new H6Typography()
                {
                    FontWeight = "500",
                }
            };

            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "8px"
            };
        }
    }
}
