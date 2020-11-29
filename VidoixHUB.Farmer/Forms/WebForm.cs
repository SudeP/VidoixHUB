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
        private const string youtubeURL = "https://www.youtube.com/embed/";
        private const string vidoixURL = "https://www.vidoix.com/";
        private readonly ChromiumWebBrowser chromiumWebBrowser;
        private bool firstLoader = true;
        public WebForm()
        {
            InitializeComponent();

            Text = string.Format("{0} {1}", Program.ThreadName, Program.Username);

            nudWidth.Value = Program.Width;

            nudHeigth.Value = Program.Heigth;

            tbxUserName.Text = Program.Username;

            tbxPassword.Text = Program.Password;

            CefSharpSettings.LegacyJavascriptBindingEnabled = true;

            CefSettings settings = new CefSettings
            {
                CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\VidoixHUB.Farmer." + Program.Username,
                Locale = "tr"
            };

            settings.CefCommandLineArgs["autoplay-policy"] = "no-user-gesture-required";

            Cef.Initialize(settings);

            chromiumWebBrowser = new ChromiumWebBrowser(vidoixURL)
            {
                Parent = this,
                Dock = DockStyle.Fill
            };

            chromiumWebBrowser.FrameLoadEnd += ChromiumWebBrowser_FrameLoadEnd;

        }
        private void ChromiumWebBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Url.StartsWith(vidoixURL))
            {
                if (firstLoader)
                {
                    firstLoader = false;

                    chromiumWebBrowser.RegisterAllSource();

                    chromiumWebBrowser.ReRegisterSource(ScriptType.Includer, null, false);

                    chromiumWebBrowser.ReRegisterSource(ScriptType.Traveler, new Dictionary<string, string> {
                        { "{{username}}", Program.Username },
                        { "{{password}}", Program.Password }
                    }, false);
                }

                e.Frame.Load(ScriptType.Includer);

                e.Frame.Load(ScriptType.Traveler);
            }
            else if (e.Url.StartsWith(youtubeURL))
                e.Frame.Load(ScriptType.Qualityer);
        }
        private void BtnShowDevTool_Click(object sender, EventArgs e) => chromiumWebBrowser.ShowDevTools();
        private void BtnCloseDevTool_Click(object sender, EventArgs e) => chromiumWebBrowser.CloseDevTools();
        private void BtnUIHide_Click(object sender, EventArgs e) => pUI.Visible = false;
        private void BtnUIShow_Click(object sender, EventArgs e) => pUI.Visible = true;
        private void NudWidth_ValueChanged(object sender, EventArgs e) => Width = (int)nudWidth.Value;
        private void NudHeigth_ValueChanged(object sender, EventArgs e) => Height = (int)nudHeigth.Value;
        private void BtnLoadHomePage_Click(object sender, EventArgs e) => chromiumWebBrowser.Load(vidoixURL);
    }
}
