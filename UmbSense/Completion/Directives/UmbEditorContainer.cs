﻿using System.Collections.Generic;
using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

namespace UmbSense.Completion.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, "umb-editor-container")]
    [ContentType("htmlx")]
    class UmbEditorContainer : BaseCompletion
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "umb-editor-sub-header", "" }
        };
    }
}