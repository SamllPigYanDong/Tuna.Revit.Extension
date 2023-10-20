﻿using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tuna.Revit.Extension;

[Transaction(TransactionMode.Manual)]
internal class TestCommand : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        UIDocument uiDocument = commandData.Application.ActiveUIDocument;
        Document document = uiDocument.Document;


        //uiDocument.SelectElement(e => e.Category?.Id == BuiltInCategories.Door);
        //uiDocument.SelectElements(e => e.Category?.Id == BuiltInCategories.Door);

        //uiDocument.SelectObject(Autodesk.Revit.UI.Selection.ObjectType.Edge, e => e.Category?.Id == BuiltInCategories.Door, "选择门边线");

        //uiDocument.SelectPoint();


        return Result.Succeeded;
    }
}
