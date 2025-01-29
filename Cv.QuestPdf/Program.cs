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
            
            col.Item().PaddingTop(10).Text(".NET Developer @ Lykke (CH) : 07/24 - 12/24").FontSize(18).Bold().AlignCenter();
            col.Item().PaddingTop(10).Row(AddLykke);
            
            col.Item().PaddingTop(10).Text(".NET Developer @ ING Bank (RO) : 04/23 - 09/24").FontSize(18).Bold().AlignCenter();
            col.Item().PaddingTop(10).Row(AddIng);
            
            col.Item().PaddingTop(10).Text(".NET Developer @ American Express (US) : 03/23 - 07/24").FontSize(18).Bold().AlignCenter();
            col.Item().PaddingTop(10).Row(AddAmex);
            
            col.Item().PaddingTop(10).Text(".NET Developer @ GlobalLogic (US) : 03/23 - 06/23").FontSize(18).Bold().AlignCenter();
            col.Item().PaddingTop(10).Row(AddGlobalLogic);
            
            col.Item().PaddingTop(10).Text(".NET Developer @ Itineris (BE) : 11/22 - 02/25").FontSize(18).Bold().AlignCenter();
            col.Item().PaddingTop(10).Row(AddItineris);
            
            col.Item().PaddingTop(10).Text(".NET Developer @ Klips (IL) : 08/22 - 03/23").FontSize(18).Bold().AlignCenter();
            
            col.Item().PaddingTop(10).Text(".NET Developer @ Axa IM (FR) : 07/22 - 02/23").FontSize(18).Bold().AlignCenter();
            
            col.Item().PaddingTop(10).Text(".NET Developer @ BeeNear (RO) : 05/21 - 05/22").FontSize(18).Bold().AlignCenter();
            
            col.Item().PaddingTop(10).Text(".NET Developer @ Enedis (FR) : 02/19 - 02/21").FontSize(18).Bold().AlignCenter();
            
            col.Item().PaddingTop(10).Text(".NET Developer @ Societe Generale (FR) : 06/18 - 01/19").FontSize(18).Bold().AlignCenter();
            
            col.Item().PaddingTop(10).Text(".NET Developer @ Tricentis (AT) : 12/17 - 05/18").FontSize(18).Bold().AlignCenter();
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
            text.Span("C#, Razor, Python, SQL, Yaml");
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

void AddIng(RowDescriptor row) {
    row.Spacing(10);

    row.RelativeItem().Column(col => {
        col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Languages: ").Italic();
            text.Span("C#, Visual Basic, SQL, Yaml, JavaScript");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Frameworks: ").Italic();
            text.Span(".NET, ASP.NET, WCF, Arm Templates");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Tools: ").Italic();
            text.Span("Rider, Grafana, Docker, K6, Azure DevOps");
        });

        col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Business: ").Italic();
            text.Span("Established in 1994, considered a leading global financial institution, ING Bank offers a" +
                      " wide range of products and services to individuals, small and medium-sized enterprises, " +
                      "and large corporations.");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Technical: ").Italic();
            text.Span("Within the BPM Core team at ING Bank Romania, I played a crucial role in developing and " +
                      "maintaining the essential runtime platform that powered all internal enterprise applications. " +
                      "This platform, built on an n-tier architecture and utilizing plug-n-play modules, supported a " +
                      "diverse range of mission-critical business applications, including business lending, leads " +
                      "management, business banking, and card issuing. The platform seamlessly integrated with various " +
                      "frontend applications, such as FABO, NARC, and Homebank, through a robust and well-defined API. " +
                      "Responsibilities encompassed collaborating with cross-functional teams to ensure the platform’s " +
                      "stability, performance, and scalability, while actively supporting these business-critical " +
                      "processes.");
        });
    });

    row.RelativeItem().Column(col => {
        col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("User Session Statelessness: ").SemiBold().Italic();
            text.Span("Successfully migrated user session storage from an in-memory model to Redis. This " +
                      "significantly enhanced the fault tolerance and scalability of applications across the" +
                      " entire machine cluster.");
        });

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("L3 Production Support: ").SemiBold().Italic();
            text.Span("Provided comprehensive L3 production support, acting as a liaison between business analysts," +
                      " configurators, and external stakeholders. This involved troubleshooting complex issues, analyzing" +
                      " logs, and communicating solutions effectively to all parties involved.");
        });

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Enhanced Health Checks: ").SemiBold().Italic();
            text.Span("Implemented and extended health checks to encompass all core service dependencies. This " +
                      "included monitoring vital databases and external assemblies developed by other teams, ensuring " +
                      "proactive identification and resolution of potential problems.");
        });
        
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Led the successful upgrade to .NET 8 ").SemiBold().Italic();
            text.Span("across multiple enterprise applications. This upgrade resulted in measurable performance " +
                      "improvements and ensured seamless compatibility with the latest Microsoft technologies.");
        });
        
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Sustainability Initiative: ").SemiBold().Italic();
            text.Span("Championed the adoption of QR code-based business cards for front-office banking officers. ");
        });
    });
}

void AddAmex(RowDescriptor row) {
    row.Spacing(10);

    row.RelativeItem().Column(col => {
        col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Languages: ").Italic();
            text.Span("C#, Visual Basic, Razor, Powershell, Cake");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Frameworks: ").Italic();
            text.Span(".NET, ASP.NET, Blazor, WCF");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Tools: ").Italic();
            text.Span("Rider, Playwright, Bamboo, DataGrip, vATM, WebFT");
        });

        col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Business: ").Italic();
            text.Span("A global integrated payments company, providing customers with access to products, insights, " +
                      "and experiences that enrich lives and build business success, Amex offers a range of financial " +
                      "products and services, including credit and charge cards, merchant acquisition and processing, " +
                      "network services, travel, and insurance.");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Technical: ").Italic();
            text.Span("Contributed to the development and integration of key payment products such as WebFASTest, " +
                      "vATM, and NGS (a payment certification tool). Leveraged expertise in C# on .NET, Razor on Blazor, " +
                      "SQL databases, and Azure Cloud to ensure seamless functionality and integration of these products" +
                      " within the existing payment infrastructure. This work involved extensive collaboration with " +
                      "cross-functional teams and adherence to rigorous industry standards for payment processing and certification.");
        });
    });

    row.RelativeItem().Column(col => {
        col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Introduced UI testing with Playwright: ").SemiBold().Italic();
            text.Span("Implemented automated UI testing framework using Playwright in the absence of a dedicated " +
                      "QA team, ensuring client acceptance criteria for payment certification scenarios were met and " +
                      "reducing manual testing efforts.");
        });

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Spearheaded the greenfield development of NGS: ").SemiBold().Italic();
            text.Span("Led the development of the NGS payment certification tool using modern technologies like " +
                      "Blazor, establishing a robust and flexible UI component system from scratch.");
        });

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Streamlined deployment processes: ").SemiBold().Italic();
            text.Span("Developed PowerShell and Cake scripts for automated building, packaging, and deployment of binaries.");
        });
        
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Provided support and maintenance for a legacy system: ").SemiBold().Italic();
            text.Span("Ensured the continued functionality and stability of a critical legacy system, while also " +
                      "documenting and extracting key information, such as EMV chip card application and tags, to make it" +
                      " accessible throughout the modernized system.");
        });
        
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Mentored junior developers on best practices:: ").SemiBold().Italic();
            text.Span("Shared expertise in test-driven development (TDD), clean code principles, and continuous integration.");
        });
    });
}

void AddGlobalLogic(RowDescriptor row) {
    row.Spacing(10);

    row.RelativeItem().Column(col => {
        col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Languages: ").Italic();
            text.Span("C#, SQL, Gherkin, C++");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Frameworks: ").Italic();
            text.Span(".NET, ASP.NET, Azure, TCP/IP");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Tools: ").Italic();
            text.Span("Rider, Postman, Ingenico, Verifone, Moneris");
        });

        col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Business: ").Italic();
            text.Span("GlobalLogic, a Hitachi Group Company, is a leader in digital product engineering. They help " +
                      "clients design and build innovative products, platforms, and digital experiences for the modern " +
                      "world. Combining experience design with complex engineering, they partner with clients across " +
                      "various industries to accelerate their digital transformation and bring their visions to life.");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Technical: ").Italic();
            text.Span("Ensured 24/7 operational support for a US-based automated car wash business. Developed a " +
                      "hardware virtualization system using C# on .NET and Azure Cloud, enabling automated nightly " +
                      "builds for rigorous system testing. Integrated RESTful APIs and payment SDKs from Moneris, " +
                      "Ingenico, and Verifone to ensure seamless operation of automated gates, car wash robots, " +
                      "and unattended payment terminals.");
        });
    });

    row.RelativeItem().Column(col => {
        col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Led the development of an abstracted, testable system: ").SemiBold().Italic();
            text.Span("Coordinated a team to create a comprehensive virtualized environment simulating the entire " +
                      "car wash operation.");
        });

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Implemented clean code and test-driven development (TDD) practices: ").SemiBold().Italic();
            text.Span("Ensured high-quality codebase, emphasizing maintainability, readability, and testability. " +
                      "This approach facilitated decoupling hardware implementations from software abstractions, " +
                      "resulting in a flexible and resilient system.");
        });

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Introduced architectural patterns for enhanced maintainability: ").SemiBold().Italic();
            text.Span("Employed dependency inversion and interface segregation principles to design a system " +
                      "reliant on abstract interfaces, allowing for easy substitution of hardware components without " +
                      "disrupting the overall system functionality.");
        });
        
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Provided regular updates and presentations to the US client: ").SemiBold().Italic();
            text.Span("Maintained open communication with stakeholders, demonstrating project progress, achieved " +
                      "milestones, and addressing any concerns.");
        });
    });
}

void AddItineris(RowDescriptor row) {
    row.Spacing(10);

    row.RelativeItem().Column(col => {
        col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Languages: ").Italic();
            text.Span("C#, Bicep, Python, Sql");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Frameworks: ").Italic();
            text.Span(".NET, ASP.NET, Azure, D365, Jupyter");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.AlignCenter();
            text.Span("Tools: ").Italic();
            text.Span("Rider, Azure DevOps, Azure Functions, Logic Apps, Api Management, Data Lake, DataBricks");
        });

        col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Business: ").Italic();
            text.Span("Itineris is a technology company specializing in cloud-based software solutions for the " +
                      "utilities industry, particularly energy and water companies. Contributed to UMAX, their flagship" +
                      " product, built on Microsoft Dynamics 365 and hosted in the Azure cloud streamlining processes " +
                      "like meter-to-cash and customer engagement.");
        });
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Technical: ").Italic();
            text.Span("The project spanned several energy-sector organizations focused on " +
                      "leveraging cutting-edge technology to enhance energy management and billing systems. Flogas, a " +
                      "leading energy supplier specializing in LPG, served a wide range of clients from residential to " +
                      "industrial sectors. SSE, a UK-based leader in renewable energy. The projects utilized Azure Cloud " +
                      "infrastructure to manage and process large-scale energy consumption data.");
        });
    });

    row.RelativeItem().Column(col => {
        col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Revamped the TimeSamples System: ").SemiBold().Italic();
            text.Span("Spearheaded the modernization of the TimeSamples system, responsible for ingesting raw meter " +
                      "data, generating billable data, providing estimates for missing reads, and synchronizing with the " +
                      "pricing engine for accurate tariff calculations");
        });

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Reliable Infrastructure as Code: ").SemiBold().Italic();
            text.Span("Successfully implemented and maintained an IaC approach using Bicep, enabling consistent and " +
                      "repeatable deployments with minimal downtime.");
        });

        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Optimized Data Processing: ").SemiBold().Italic();
            text.Span("Significantly improved the performance and scalability of Databricks jobs handling large " +
                      "volumes of metering data, enhancing the ability to process and analyze customer usage data efficiently.");
        });
        
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Modernized Azure Infrastructure: ").SemiBold().Italic();
            text.Span("Led the migration of Azure Functions to .NET 8 and ASEv3, improving performance, security, " +
                      "and scalability of the platform.");
        });
        
        col.Item().PaddingTop(5).Text(text => {
            text.Justify();
            text.Span("Developed D365 F&O Data Entity Management Tool: ").SemiBold().Italic();
            text.Span("Built a custom .NET application to manage Data Entities within Dynamics 365 Finance & Operations.");
        });
    });
}