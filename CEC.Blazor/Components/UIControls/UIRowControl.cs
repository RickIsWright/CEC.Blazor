﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CEC.Blazor.Components.UIControls
{
    /// <summary>
    /// UI Rendering Wrapper to build a row
    ///  Provides a structured  mechanism for managing Bootstrap class elements used in Editors and Viewers in one place. 
    /// The properties are pretty self explanatory and therefore not decorated with summaries
    /// </summary>

    public class UIRowControl : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool IsFormGroup { get; set; }

        [Parameter]
        public string AddOnCss { get; set; } = string.Empty;

        private string FormGroup => this.IsFormGroup ? "form-group " : string.Empty;

        private string Css => $"row {this.FormGroup}{AddOnCss.Trim()}".Trim();

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", this.Css);
            builder.AddContent(2, ChildContent);
            builder.CloseElement();
        }
    }
}