﻿using Autodesk.Revit.UI;
using Autodesk.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuna.Revit.Extension.Ribbon.Abstraction;

namespace Tuna.Revit.Extension;

/// <summary>
/// 功能面板
/// </summary>
public interface IRibbonPanel : IRibbonItemsCollector, IRibbonItem
{
    /// <summary>
    /// 面板的标题
    /// </summary>
    string Title { get; }

    /// <summary>
    /// 添加滑动式抽屉
    /// </summary>
    void AddSlideOut();

    /// <summary>
    /// 添加分割线
    /// </summary>
    IRibbonPanel AddSeparator();

    /// <summary>
    /// 添加按钮
    /// </summary>
    /// <typeparam name="T"></typeparam>
    IRibbonPanel AddPushButton<T>() where T : class, IExternalCommand, new();

    /// <summary>
    /// 添加下拉按钮
    /// </summary>
    IRibbonPanel AddPulldownButton(string title, Action<IRibbonPulldownButton> handle = null);

    /// <summary>
    /// 添加下拉按钮
    /// </summary>
    /// <param name="title"></param>
    /// <param name="handle"></param>
    /// <returns></returns>
    IRibbonPanel AddSplitButton(string title, Action<IRibbonSplitButton> handle = null);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    IRibbonPanel AddRadioButtonGroup();

    /// <summary>
    /// 添加文本输入框
    /// </summary>
    /// <returns></returns>
    IRibbonPanel AddTextBox();

    /// <summary>
    /// 添加下拉框
    /// </summary>
    /// <returns></returns>
    IRibbonPanel AddComboBox(string name, Action<IRibbonComboBox> handle = null);
}
