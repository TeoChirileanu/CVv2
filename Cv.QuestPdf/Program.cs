using Cv.QuestPdf;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

QuestPDF.Settings.License = LicenseType.Community;

var document = Document.Create(container => {
    container.Page(page => {
        page.Size(PageSizes.A4);
        // page.Content().Padding(10).Column(new FullProfile().Get);
        page.Content().Padding(10).Column(new TemplateProfile().Get);
    });
});

document.GeneratePdf(@"..\..\..\..\cv.pdf");
// document.ShowInCompanion();