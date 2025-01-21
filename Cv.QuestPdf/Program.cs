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
            col.Item().PaddingTop(10).Text("Experience & Training").FontSize(18).Black().AlignCenter();
            col.Item().PaddingTop(10).Row(AddSummary);
            col.Item().PaddingTop(10).Text(".NET Developer @ Lykke : 07/24 - 12/24").FontSize(18).Bold().AlignCenter();
            col.Item().PaddingTop(10).Row(AddLykke);
        });
    });
});

document.ShowInCompanion();
// document.GeneratePdf(@"C:\CV\CV.pdf");
return;

void AddHeader(RowDescriptor row) {
    row.ConstantItem(120).Image(@"C:\CV\src\assets\ai-profile.jpg");

    row.RelativeItem().Column(col => {
        col.Item().Text("Abstract").Bold().FontSize(14).AlignCenter();
        col.Item().Text("Professional programmer with 10+ years in developing software solutions").AlignCenter();

        col.Item().PaddingTop(10).Text("About").FontSize(14).Bold().AlignCenter();
        col.Item().PaddingHorizontal(10).Text("An A-list developer with hands-on expertise in crypto exchanges, " +
                                              "financial services and energy distribution. Leveraging clean code, " +
                                              "simple design and responsible AI to improve time to market " +
                                              "and reduce operational costs.").Justify();

        col.Item().PaddingTop(10).Text("Skills").FontSize(14).Bold().AlignCenter();
        col.Item().Text(".NET, Azure, AWS, Blazor, Angular, Python, SQL, Docker, K8s, Redis, PS, VB").AlignCenter();

        col.Item().PaddingTop(10).Text("Contact").FontSize(14).Bold().AlignCenter();
        col.Item().PaddingHorizontal(45).Row(r => {
            r.RelativeItem().Text("\ud83d\udce7 teodorchirileanu@gmail.com").AlignCenter();
            r.RelativeItem().Text("\ud83d\udcde +40 748 333 619").AlignCenter();
        });
    });
}

void AddSummary(RowDescriptor row) {
    row.RelativeItem().Column(col => {
        col.Item().Text("Crypto Exchanges").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(".NET Developer with Python and AWS @ Lykke (CH)").AlignCenter();
        col.Item().PaddingTop(5).Text(".NET Developer with JavaScript and GCP @ Klips (IL)").AlignCenter();

        col.Item().PaddingTop(10).Text("Financial Services").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(".NET Developer with VB and Azure @ ING Bank (RO)").AlignCenter();
        col.Item().PaddingTop(5).Text(".NET Developer with Blazor and Azure @ Amex (US)").AlignCenter();
        col.Item().PaddingTop(5).Text(".NET Developer with Angular and Azure @ Axa IM (FR)").AlignCenter();
        col.Item().PaddingTop(5).Text(".NET Developer with SQL and PS @ SG CIB (FR)").AlignCenter();

        col.Item().PaddingTop(10).Text("Energy Distribution").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(".NET Developer with Bicep and Azure @ Itineris (BE)").AlignCenter();
        col.Item().PaddingTop(5).Text(".NET Developer with Python and SQL @ Enedis (FR)").AlignCenter();

        col.Item().PaddingTop(10).Text("Other").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text("Hardware Virtualization Tech Lead @ GlobalLogic (US)").AlignCenter();
        col.Item().PaddingTop(5).Text("Accounting & CRM Team Lead @ Beenear (RO)").AlignCenter();
        col.Item().PaddingTop(5).Text(".NET Developer with Angular and Azure @ Tricentis AT").AlignCenter();
        col.Item().PaddingTop(5).Text("Certified Scratch Trainer @ Cartea Daliei (RO)").AlignCenter();
    });

    row.RelativeItem().Column(col => {
        col.Item().Text("Certifications").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text("Microsoft Certified: DevOps Engineer Expert").AlignCenter();
        col.Item().PaddingTop(5).Text("AWS Certified: DevOps Engineer Professional").AlignCenter();
        col.Item().PaddingTop(5).Text("Google Cloud Certification: Professional Developer").AlignCenter();
        col.Item().PaddingTop(5).Text("Blockchain Council: Certified Fintech Expert").AlignCenter();

        col.Item().PaddingTop(10).Text("Courses").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text("Uncle Bob: Architecture & Design Masters Class").AlignCenter();
        col.Item().PaddingTop(5).Text("Uncle Bob: TDD, Clean Code & Refactoring").AlignCenter();
        col.Item().PaddingTop(5).Text("Scrum Alliance: Professional Scrum Developer").AlignCenter();

        col.Item().PaddingTop(10).Text("Education").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text("UAIC: Bachelor of Computer Science").AlignCenter();
        col.Item().PaddingTop(5).Text("CNME: French Baccalaureate Diploma").AlignCenter();

        col.Item().PaddingTop(10).Text("Favorite Books").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text("C# in Depth, Extreme Programming Explained, " +
                                      "Clean Code & Architecture, Refactoring, DDD," +
                                      " Design Patterns, The Pragmatic Programmer, Soft Skills, " +
                                      "Concurrency in C#, The Art of Unit Testing ").AlignCenter();
    });
}

void AddLykke(RowDescriptor row) {
    row.Spacing(10);

    row.RelativeItem().Column(col => {
        col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Languages: ").Italic();
            text.Span("C#, Python, SQL, Yaml");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Frameworks: ").Italic();
            text.Span(".NET, ASP.NET, Blazor");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Tools: ").Italic();
            text.Span("Rider, PyCharm, Docker, AWS");
        });

        col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Business: ").Italic();
            text.Span("Lykke is a Swiss fintech company using blockchain technology to revolutionize financial " +
                      "markets. It offers a zero-fee cryptocurrency exchange platform with access to various digital assets, " +
                      "while also providing blockchain-based solutions for businesses in the financial " +
                      "and service industries.");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Technical: ").Italic();
            text.Span(
                "Developed and implemented critical components for Lykke’s trading platform and infrastructure, " +
                "focusing on enhancing security, automating deployments, and integrating Python-based quantitative " +
                "models with the existing C# ecosystem. ");
        });
    });

    row.RelativeItem().Column(col => {
        col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Enhanced Security and Streamlined Credential Management: ").SemiBold().Italic();
            text.Span("Successfully integrated Lykke’s systems with a secrets manager, eliminating the need for " +
                      "hardcoded credentials and significantly improving the security posture of the applications. ");
        });

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Foundation for Robust CI/CD Pipeline: ").SemiBold().Italic();
            text.Span("Laid the groundwork for a new CI/CD automation system, enabling continuous integration and" +
                      " delivery of software updates. This included setting up GitHub workflows and establishing " +
                      "deployment pipelines.");
        });

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Bridging the Gap between Python and C#: ").SemiBold();
            text.Span("Made significant progress in developing a critical Python-C# bridge, enabling seamless" +
                      " integration of Lykke’s existing C# infrastructure with new Python-based algorithms and machine" +
                      " learning models. This bridge is essential for upcoming projects focused on trading signal " +
                      "generation, risk analysis, and market prediction.");
        });
    });
}