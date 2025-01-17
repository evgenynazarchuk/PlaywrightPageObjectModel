﻿using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Samples.BaseModels;

public class UIBlock<TPageModel> : ElementModel<TPageModel>
    where TPageModel : PageModel
{
    public UIBlock(TPageModel pageModel, IElementHandle element) : base(pageModel, element)
    {
    }

    public UIBlock(ElementModel<TPageModel> parentBlockModel, IElementHandle element) : base(parentBlockModel, element)
    {
    }

    public UIBlock(ElementModel<TPageModel> parentBlockModel, string selector, ElementHandleWaitForSelectorOptions? waitOptions = null) : base(parentBlockModel, selector, waitOptions)
    {
    }

    public UIBlock(TPageModel pageModel, string selector, PageWaitForSelectorOptions? waitOptions = null, PageQuerySelectorOptions? queryOptions = null) : base(pageModel, selector, waitOptions, queryOptions)
    {
    }
}