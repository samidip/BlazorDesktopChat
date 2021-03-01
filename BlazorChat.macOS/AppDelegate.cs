using AppKit;
using Foundation;

namespace BlazorChat.macOS
{
    [Register("AppDelegate")]
    public class AppDelegate : Xamarin.Forms.Platform.MacOS.FormsApplicationDelegate
    {
        public AppDelegate()
        {
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;
            var rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);
            MainWindow = new NSWindow(rect, style, NSBackingStore.Buffered, false)
            {
                Title = "My Application",
                TitleVisibility = NSWindowTitleVisibility.Visible,
            };
        }

        public override NSWindow MainWindow { get; }

        public override void DidFinishLaunching(NSNotification notification)
        {   
            NSApplication.SharedApplication.MainMenu = MakeMainMenu();

            Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            base.DidFinishLaunching(notification);
        }

        public override void WillTerminate(NSNotification notification)
        {
           
        }

        private NSMenu MakeMainMenu()
        {
            var menubar = new NSMenu();
            var appMenuItem = new NSMenuItem();
            menubar.AddItem(appMenuItem);

            var appMenu = new NSMenu();
            appMenuItem.Submenu = appMenu;

            var separator = NSMenuItem.SeparatorItem;
            appMenu.AddItem(separator);

            var quitTitle = string.Format("Quit {0}", "BlazorChat.macOS");
            var quitMenuItem = new NSMenuItem(quitTitle, "q", delegate
            {
                NSApplication.SharedApplication.Terminate(menubar);
            });
            appMenu.AddItem(quitMenuItem);

            return menubar;
        }
    }
}
