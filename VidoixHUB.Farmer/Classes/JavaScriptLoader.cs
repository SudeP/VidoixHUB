#pragma warning disable
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
#pragma warning restore

public static class JavaScriptLoader
{
    public static Assembly _assembly = Assembly.GetExecutingAssembly();
    public static void RegisterAllSource(this ChromiumWebBrowser chromiumWebBrowser)
    {
        IEnumerable<ScriptType> scriptTypies = Enum.GetValues(typeof(ScriptType)).Cast<ScriptType>();


        foreach (var scriptType in scriptTypies)
            chromiumWebBrowser.RegisterResourceHandler(chromiumWebBrowser.GetMainFrame().GetUrl(scriptType), GetStreamResource($"VidoixHUB.Farmer.Resources.{scriptType}.js"), "text/javascript");
    }
    public static void ReRegisterSource(this ChromiumWebBrowser chromiumWebBrowser, ScriptType scriptType, Dictionary<string, string> replaces, bool consoleLog)
    {
        chromiumWebBrowser.UnRegisterResourceHandler(chromiumWebBrowser.GetMainFrame().GetUrl(scriptType));

        string javaScriptText = GetStringResource(scriptType);

        if (!consoleLog)
            javaScriptText = javaScriptText.Replace("consolelog(\"", "//consolelog(\"");

        if (replaces != null)
            foreach (KeyValuePair<string, string> item in replaces)
                javaScriptText = javaScriptText.Replace(item.Key, item.Value);

        chromiumWebBrowser.RegisterResourceHandler(chromiumWebBrowser.GetMainFrame().GetUrl(scriptType), javaScriptText.GenerateStreamFromString(), "text/javascript");
    }
    public static void Load(this IFrame frame, ScriptType scriptType)
    {
        frame.ExecuteJavaScriptAsync(GetStringResource(ScriptType.Adder).Replace("{{url}}", frame.GetUrl(scriptType)));
    }
    public static string GetUrl(this IFrame frame, ScriptType scriptType) => $"{new Uri(frame.Browser.MainFrame.Url).Scheme}://{new Uri(frame.Browser.MainFrame.Url).Host}/Resources/{scriptType}.js";

    public static Stream GenerateStreamFromString(this string s)
    {
        var stream = new MemoryStream();
        var writer = new StreamWriter(stream);
        writer.Write(s);
        writer.Flush();
        stream.Position = 0;
        return stream;
    }
    public static Stream GetStreamResource(string name) => _assembly.GetManifestResourceStream(name);
    public static string GetStringResource(ScriptType scriptType) => GetStringResource(scriptType.ToString());
    public static string GetStringResource(string name) => new StreamReader(GetStreamResource($"VidoixHUB.Farmer.Resources.{name}.js"), Encoding.GetEncoding(1254)).ReadToEnd();
}