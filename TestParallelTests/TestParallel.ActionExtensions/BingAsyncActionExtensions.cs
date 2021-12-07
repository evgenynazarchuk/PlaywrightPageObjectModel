﻿using Microsoft.Playwright;

namespace TestParallel.ActionExtensions;

public static class BingAsyncActionExtensions
{
    public static async Task SearchByTextAsync(this IPage page, string searchText)
    {
        await page.TypeAsync("input#sb_form_q", searchText);
        await page.PressAsync("input#sb_form_q", "Enter");
        await page.WaitForLoadStateAsync(LoadState.NetworkIdle);
    }

    public static async Task ClearSearchTextAsync(this IPage page)
    {
        var searchInputElement = await page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await page.FocusAsync("input#sb_form_q");
        await page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await page.Keyboard.PressAsync("Backspace");
        }
    }

    public static async Task OpenBingComAsync(this IPage page)
    {
        await page.GotoAsync("https://bing.com");
        await page.WaitForLoadStateAsync(LoadState.NetworkIdle);
    }
}
