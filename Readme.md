<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128610021/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T430224)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RichNullText/Form1.cs) (VB: [Form1.vb](./VB/RichNullText/Form1.vb))
<!-- default file list end -->
# How to display specific grayed text (NullText) in RichEditControl when a document is empty


<p>Common text editors provide properties (<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItem_NullTexttopic">NullText </a>and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItemTextEdit_NullValuePrompttopic">NullValuePrompt</a>) to set text displayed as grayed when the editor's value is <strong>null</strong> or an empty string and the editor is not focused. This example demonstrates how to imitate the NullText/NullValuePrompt property behavior for RichEditControl. For this, it's necessary to create a custom <strong>PagePainter</strong> class and override the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPILayoutPagePainter_DrawPagetopic">DrawPage</a> method. In this method, check if the current document is empty using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeDocument_IsEmptytopic">RichEditControl.Document.IsEmpty</a> property and RichEditControl is not focused. If so, draw the required string using the Canvas.DrawString method. </p>
<p>To replace the default page painter with a custom one, handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_BeforePagePainttopic">RichEditControl.BeforePagePaint</a> event and assign a custom painter instance to the <strong>e.Painter</strong> argument.</p>

<br/>


