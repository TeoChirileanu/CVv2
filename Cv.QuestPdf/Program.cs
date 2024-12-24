using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

QuestPDF.Settings.License = LicenseType.Community;

var document = Document.Create(container => {
   container.Page(page => {
      page.Size(PageSizes.A4);
      
      page.Content().Padding(10).Column(col => {
         col.Item().Row(AddHeader);
      });
   });
});

document.ShowInCompanion();
return;

void AddHeader(RowDescriptor row) {
   row.ConstantItem(140).Image(@"C:\CV\src\assets\ai-profile.jpg");
   
   row.RelativeItem().Column(col => {
      col.Item().Text("Abstract").FontSize(20).AlignCenter();
      col.Item().Text("Professional programmer with 10+ years in developing software solutions").AlignCenter();
               
      col.Item().PaddingTop(10).Text("About").FontSize(20).AlignCenter();
      col.Item().PaddingHorizontal(10).Text("An A-list developer with hands-on expertise in financial services, " +
                                            "energy distribution and crypto exchanges. Leveraging clean code, " +
                                            "simple design and responsible AI to improve time to market " +
                                            "and reduce operational costs.").Justify();
               
      col.Item().PaddingTop(10).Text("Skills").FontSize(20).AlignCenter();
      col.Item().Text(".NET, Azure, AWS, Blazor, Angular, Python, SQL, Docker, Redis, PS, VB").AlignCenter();
               
      col.Item().PaddingTop(10).Text("Contact").FontSize(20).AlignCenter();
      col.Item().PaddingHorizontal(45).Row(r => {
         r.RelativeItem().Text("\ud83d\udce7 teodorchirileanu@gmail.com").AlignCenter();
         r.RelativeItem().Text("\ud83d\udcde +40 748 333 619").AlignCenter();
      });
   });
}