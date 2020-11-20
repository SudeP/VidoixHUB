#pragma warning disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.Callback;
using CefSharp.DevTools;
using CefSharp.DevTools.Accessibility;
using CefSharp.DevTools.Animation;
using CefSharp.DevTools.ApplicationCache;
using CefSharp.DevTools.Audits;
using CefSharp.DevTools.BackgroundService;
using CefSharp.DevTools.Browser;
using CefSharp.DevTools.CacheStorage;
using CefSharp.DevTools.Cast;
using CefSharp.DevTools.CSS;
using CefSharp.DevTools.Database;
using CefSharp.DevTools.Debugger;
using CefSharp.DevTools.DeviceOrientation;
using CefSharp.DevTools.DOM;
using CefSharp.DevTools.DOMDebugger;
using CefSharp.DevTools.DOMSnapshot;
using CefSharp.DevTools.DOMStorage;
using CefSharp.DevTools.Emulation;
using CefSharp.DevTools.Fetch;
using CefSharp.DevTools.HeadlessExperimental;
using CefSharp.DevTools.HeapProfiler;
using CefSharp.DevTools.IndexedDB;
using CefSharp.DevTools.Input;
using CefSharp.DevTools.Inspector;
using CefSharp.DevTools.IO;
using CefSharp.DevTools.LayerTree;
using CefSharp.DevTools.Log;
using CefSharp.DevTools.Media;
using CefSharp.DevTools.Memory;
using CefSharp.DevTools.Network;
using CefSharp.DevTools.Overlay;
using CefSharp.DevTools.Page;
using CefSharp.DevTools.Performance;
using CefSharp.DevTools.Profiler;
using CefSharp.DevTools.Runtime;
using CefSharp.DevTools.Security;
using CefSharp.DevTools.ServiceWorker;
using CefSharp.DevTools.Storage;
using CefSharp.DevTools.SystemInfo;
using CefSharp.DevTools.Target;
using CefSharp.DevTools.Tethering;
using CefSharp.DevTools.Tracing;
using CefSharp.DevTools.WebAudio;
using CefSharp.DevTools.WebAuthn;
using CefSharp.Enums;
using CefSharp.Event;
using CefSharp.Handler;
using CefSharp.Internals;
using CefSharp.Internals.Tasks;
using CefSharp.Internals.Wcf;
using CefSharp.JavascriptBinding;
using CefSharp.Lagacy;
using CefSharp.ModelBinding;
using CefSharp.Preferences;
using CefSharp.RenderProcess;
using CefSharp.ResponseFilter;
using CefSharp.SchemeHandler;
using CefSharp.Structs;
using CefSharp.Web;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
#pragma warning restore

namespace VidoixHUB.Farmer.Forms
{
    public partial class WebForm : Form
    {
        private readonly ChromiumWebBrowser chromiumWebBrowser;
        public WebForm()
        {
            InitializeComponent();

            CefSharpSettings.LegacyJavascriptBindingEnabled = true;

            CefSettings settings = new CefSettings
            {
                CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\VidoixHUB.Farmer",
                Locale = "tr"
            };

            settings.CefCommandLineArgs["autoplay-policy"] = "no-user-gesture-required";

            Cef.Initialize(settings);

            chromiumWebBrowser = new ChromiumWebBrowser("https://www.vidoix.com")
            {
                Parent = this,
                Dock = DockStyle.Fill
            };

            chromiumWebBrowser.FrameLoadEnd += ChromiumWebBrowser_FrameLoadEnd;
        }
        private void ChromiumWebBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Url == "https://www.vidoix.com/" || e.Url.StartsWith("https://www.vidoix.com/youtube/"))
            {
                chromiumWebBrowser.RegisterAllSource();

                chromiumWebBrowser.ReRegisterSource(ScriptType.Traveler, new Dictionary<string, string> {
                    { "{{username}}", "betterThanYou" },
                    { "{{password}}", "FM97sivas57" }
                }, false);

                e.Frame.Load(ScriptType.Traveler);
            }
            else if (e.Url.StartsWith("https://www.youtube.com/embed/"))
                e.Frame.Load(ScriptType.Qualityer);
        }
    }
}
