﻿using Microsoft.Playwright;
using Playwright.Synchronous;
using System.Collections.Generic;

namespace Playwright.PageObjectModel.ActionExtensions;

public static class BlockModelActionExtensions
{
    public static TBlockModel Click<TBlockModel>(this TBlockModel blockModel, string? selector = null, ElementHandleClickOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.Click(options);
        return blockModel;
    }

    public static TBlockModel DbClick<TBlockModel>(this TBlockModel blockModel, string? selector = null, ElementHandleDblClickOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.DblClick(options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel Hover<TBlockModel>(this TBlockModel blockModel, string? selector = null, ElementHandleHoverOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.Hover(options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel ClearInput<TBlockModel>(this TBlockModel blockModel, string? selector = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.Evaluate("(element) => element.value =''", element);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel Type<TBlockModel>(this TBlockModel blockModel, string? selector = null, string value = "", ElementHandleTypeOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.Type(value, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel Fill<TBlockModel>(this TBlockModel blockModel, string? selector = null, string value = "", ElementHandleFillOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.Fill(value, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel Check<TBlockModel>(this TBlockModel blockModel, string? selector = null, ElementHandleCheckOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.Check(options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel Uncheck<TBlockModel>(this TBlockModel blockModel, string? selector = null, ElementHandleUncheckOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.Uncheck(options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel Focus<TBlockModel>(this TBlockModel blockModel, string? selector = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.Focus();
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel Tap<TBlockModel>(this TBlockModel blockModel, string? selector = null, ElementHandleTapOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.Tap(options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel Press<TBlockModel>(this TBlockModel blockModel, string key, string? selector = null, ElementHandlePressOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.Press(key, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel SelectText<TBlockModel>(this TBlockModel blockModel, string? selector = null, ElementHandleSelectTextOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SelectText(options);
        return blockModel;
    }

    public static TBlockModel SetChecked<TBlockModel>(this TBlockModel blockModel, bool checkedState, string? selector = null, ElementHandleSetCheckedOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SetChecked(checkedState);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel SetInputFiles<TBlockModel>(this TBlockModel blockModel, string files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SetInputFiles(files, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel SetInputFiles<TBlockModel>(this TBlockModel blockModel, FilePayload files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SetInputFiles(files, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel SetInputFiles<TBlockModel>(this TBlockModel blockModel, IEnumerable<string> files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SetInputFiles(files, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel SetInputFiles<TBlockModel>(this TBlockModel blockModel, IEnumerable<FilePayload> files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SetInputFiles(files, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(this TBlockModel blockModel, string values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SelectOption(values, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(this TBlockModel blockModel, IElementHandle values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SelectOption(values, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(this TBlockModel blockModel, IEnumerable<string> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SelectOption(values, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(this TBlockModel blockModel, SelectOptionValue values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SelectOption(values, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(this TBlockModel blockModel, IEnumerable<IElementHandle> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SelectOption(values, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(this TBlockModel blockModel, IEnumerable<SelectOptionValue> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.SelectOption(values, options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }

    public static TBlockModel ScrollIntoViewIfNeeded<TBlockModel>(this TBlockModel blockModel, string? selector = null, ElementHandleScrollIntoViewIfNeededOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        var element = selector is null ? blockModel.Block : blockModel.Block.FindElement(selector);
        element.ScrollIntoViewIfNeeded(options);
        blockModel.WaitForLoadPage();
        return blockModel;
    }
}