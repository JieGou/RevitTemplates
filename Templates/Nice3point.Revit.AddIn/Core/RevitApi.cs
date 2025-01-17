﻿#if (ModelessWindow)
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

#endif
namespace Nice3point.Revit.AddIn.Core;

/// <summary>
///     The class contains wrapping methods for working with the Revit API.
/// </summary>
public static class RevitApi
{
#if (ModelessWindow)
    public static UIApplication UiApplication { get; set; }
    public static UIDocument UiDocument => UiApplication.ActiveUIDocument;
    public static Document Document => UiApplication.ActiveUIDocument.Document;
#endif
}