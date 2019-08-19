﻿using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "umb-button-group")]
    [ContentType("htmlx")]
    class UmbButtonGroup : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "default-button", "The model of the default button" },
            { "sub-buttons", "Array of sub buttons" },
            { "state", "Set a progress state on the button" },
            { "direction", "Set the direction of the dropdown" },
            { "float", "Set the float of the dropdown" }
        };
    }

    [HtmlCompletionProvider(CompletionTypes.Values, "umb-button-group", "*")]
    [ContentType("htmlx")]
    class UmbButtonGroupValues : BaseValueCompletion
    {
        protected override Dictionary<string, List<string>> attribValues => new Dictionary<string, List<string>>()
        {
            { "direction", new List<string> { "up", "down" } },
            { "float", new List<string> { "left", "right" } }
        };
    }

}