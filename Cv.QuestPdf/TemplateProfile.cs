using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace Cv.QuestPdf;

public class TemplateProfile {
    public void Get(ColumnDescriptor columnDescriptor) {
        columnDescriptor.Item().Row(AddHeader);

        columnDescriptor.Item().PaddingTop(10).Text("Experience & Training").FontSize(18).Black().AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddSummary);

        columnDescriptor.Item().PaddingTop(10).Text("What do other say about me?").FontSize(18).Black().AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddRecommendations);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ CFP Energy (UK) : 03/25 - 08/25").FontSize(18).Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddCfpEnergy);
        
        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ Itineris (Belgium) : 11/22 - 08/25").FontSize(18)
            .Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddItineris);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ EUAA (Malta) : 03/25 - 07/25").FontSize(18).Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddEuaa);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ EPS (Lithuania) : 02/25 - 06/25").FontSize(18).Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddEps);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ Lykke (Switzerland) : 07/24 - 12/24").FontSize(18).Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddLykke);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ ING Bank (Romania) : 04/23 - 09/24").FontSize(18)
            .Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddIng);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ American Express (United States) : 03/23 - 07/24")
            .FontSize(18).Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddAmex);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ Klips (Israel) : 08/22 - 03/23").FontSize(18).Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddKlips);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ Axa IM (France) : 07/22 - 02/23").FontSize(18).Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddAxa);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ BeeNear (Romania) : 05/21 - 05/22").FontSize(18).Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddBeeNear);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ Enedis (France) : 02/19 - 02/21").FontSize(18).Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddEnedis);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ Societe Generale (France) : 06/18 - 01/19")
            .FontSize(18).Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddSocGen);

        columnDescriptor.Item().PaddingTop(10).Text("Backend Developer @ Tricentis (Austria) : 12/17 - 05/18").FontSize(18)
            .Bold()
            .AlignCenter();
        columnDescriptor.Item().PaddingTop(10).Row(AddTricentis);
    }
    
    void AddHeader(RowDescriptor row) {
        row.ConstantItem(120).Image("ai-profile.jpeg");

        row.RelativeItem().Column(col => {
            col.Item().Text("Abstract").Bold().FontSize(14).AlignCenter();
            col.Item().Text(text => {
                text.AlignCenter();
                text.Span("Professional programmer").Bold();
                text.Span(" with ");
                text.Span("8 years").Bold();
                text.Span(" of experience in developing ");
                text.Span("software solutions").Italic();
            });

            col.Item().PaddingTop(10).Text("About").FontSize(14).Bold().AlignCenter();
            col.Item().PaddingHorizontal(10)
                .Text(text => {
                    text.Justify();
                    text.Span("An ");
                    text.Span("A-list developer").Italic();
                    text.Span(" with hands-on expertise in ");
                    text.Span("crypto exchanges").Italic();
                    text.Span(", ");
                    text.Span("financial services").Italic();
                    text.Span(" and ");
                    text.Span("energy trading").Italic();
                    text.Span(". Leveraging ");
                    text.Span("clean code").Bold();
                    text.Span(", ");
                    text.Span("simple design").Bold();
                    text.Span(" and ");
                    text.Span("strategic AI usage").Italic();
                    text.Span(" to improve ");
                    text.Span("time to market").Bold();
                    text.Span(" and ");
                    text.Span("accelerate digital transformation").Bold();
                    text.Span(".");
                });

            col.Item().PaddingTop(10).Text("Skills").FontSize(14).Bold().AlignCenter();
            col.Item().Text(text => {
                text.AlignCenter();
                text.Span(".NET").Bold();
                text.Span(", ");
                text.Span("Azure").Bold();
                text.Span(", ");
                text.Span("Angular").Bold();
                text.Span(", ");
                text.Span("Blazor").Italic();
                text.Span(", ");
                text.Span("Python").Italic();
                text.Span(", ");
                text.Span("Docker").Italic();
                text.Span(", ");
                text.Span("Kubernetes").Italic();
                text.Span(
                    ", Kafka, MongoDB, Redis, PowerShell, Visual Basic, Google Cloud Platform, Amazon Web Services");
            });

            col.Item().PaddingTop(10).Text("Contact").FontSize(14).Bold().AlignCenter();
            col.Item().PaddingHorizontal(45).Row(r => {
                r.RelativeItem().Hyperlink("mailto:teodorchirileanu@gmail.com").Text("\ud83d\udce7 Email")
                    .AlignCenter();
                r.RelativeItem().Hyperlink("tel:+40748333619").Text("\ud83d\udcde Phone").AlignCenter();
            });
            col.Item().PaddingHorizontal(45).Row(r => {
                r.RelativeItem().Hyperlink("mailto:teodorchirileanu@gmail.com").Text("teodorchirileanu@gmail.com")
                    .AlignCenter();
                r.RelativeItem().Hyperlink("tel:+40748333619").Text("+40748333619").AlignCenter();
            });
            col.Item().PaddingHorizontal(45).Row(r => {
                r.RelativeItem().Hyperlink("https://github.com/TeoChirileanu").Text("\ud83d\ude80 GitHub")
                    .AlignCenter();
                r.RelativeItem().Hyperlink("https://www.linkedin.com/in/teoch/").Text("\ud83d\udcbc LinkedIn")
                    .AlignCenter();
            });
            col.Item().PaddingHorizontal(45).Row(r => {
                r.RelativeItem().Hyperlink("https://github.com/TeoChirileanu").Text("www.github.com/TeoChirileanu")
                    .AlignCenter();
                r.RelativeItem().Hyperlink("https://www.linkedin.com/in/teoch/").Text("www.linkedin.com/in/teoch")
                    .AlignCenter();
            });
        });
    }

    void AddSummary(RowDescriptor row) {
        row.RelativeItem().Column(col => {
            col.Item().Text("Crypto Exchanges").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ Lykke").AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ Klips").AlignCenter();

            col.Item().PaddingTop(10).Text("Financial Services").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ ING Bank").AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ Amex").AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ Axa IM").AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ SG CIB").AlignCenter();

            col.Item().PaddingTop(10).Text("Energy Distribution & Trading").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ CFP Energy").AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ Itineris").AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ Enedis").AlignCenter();

            col.Item().PaddingTop(10).Text("Other").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ EUAA").AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ EPS").AlignCenter();
            col.Item().PaddingTop(5).Text(".NET Developer @ Tricentis").AlignCenter();
        });

        row.RelativeItem().Column(col => {
            col.Item().Text("Certifications").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text("Microsoft DevOps Engineer Expert").AlignCenter();
            col.Item().PaddingTop(5).Text("AWS DevOps Engineer Professional").AlignCenter();
            col.Item().PaddingTop(5).Text("Google Cloud Professional Developer").AlignCenter();
            col.Item().PaddingTop(5).Text("Blockchain Certified Fintech Expert").AlignCenter();

            col.Item().PaddingTop(10).Text("Courses").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text("Architecture & Design Masters Class by Uncle Bob").AlignCenter();
            col.Item().PaddingTop(5).Text("Professional Scrum Developer by Scrum Alliance").AlignCenter();
            col.Item().PaddingTop(5).Text("TDD, Clean Code & Refactoring by Uncle Bob").AlignCenter();

            col.Item().PaddingTop(10).Text("Education").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text("Bachelor of Computer Science").AlignCenter();
            col.Item().PaddingTop(5).Text("French Baccalaureate Diploma").AlignCenter();

            col.Item().PaddingTop(10).Text("Favorite Books").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text("C# in Depth, Extreme Programming Explained, " +
                                          "Clean Code & Architecture, Refactoring, DDD," +
                                          " Design Patterns, The Pragmatic Programmer, Soft Skills, " +
                                          "Concurrency in C#, The Art of Unit Testing ").AlignCenter();
        });
    }

    void AddRecommendations(RowDescriptor row) {
        row.RelativeItem().Column(col => {
            col.Item().Row(r => {
                r.ConstantItem(20).Text("“")
                    .FontColor(Colors.Brown.Medium)
                    .FontSize(30);

                r.RelativeItem().Text("Teodor is a very valuable addition to our team. " +
                                      "He demonstrated a exceptional depth of technical expertise " +
                                      "and worked very efficiently and fast. He is a pleasure to " +
                                      "work with, both professionally and personally. " +
                                      "Looking forward to his continued growth and the " +
                                      "positive impact he will undoubtedly have on Lykke’s projects.").Justify()
                    .Italic();
            });
            col.Item().Text("— Richard Olsen, CEO @ Lykke").AlignRight().Italic().SemiBold();

            col.Item().PaddingTop(15).Row(r => {
                r.ConstantItem(20).Text("“")
                    .FontColor(Colors.Brown.Medium)
                    .FontSize(30);

                r.RelativeItem().Text(
                    "Teodor is a passionate young man, carrying the Carpathian profundity in his heart. " +
                    "His interests are wide spread and go beyond his profession. As you say: passion does " +
                    "not spread thin - so great level of energy which he brings to each and every task he " +
                    "works on. Keep on going, Teo!").Justify().Italic();
            });
            col.Item().Text("— Wolfgang Platz, Founder @ Tricentis").AlignRight().Italic().SemiBold();

            col.Item().PaddingTop(15).Row(r => {
                r.ConstantItem(20).Text("“")
                    .FontColor(Colors.Brown.Medium)
                    .FontSize(30);

                r.RelativeItem().Text(
                    "Teo has a warm, approachable demeanor and consistently demonstrates an exceptional " +
                    "level of dedication to his work. He creates a supportive environment for those around " +
                    "him, and he’s always willing to go the extra mile to achieve success.").Justify().Italic();
            });
            col.Item().Text("— Gernot Brandl, Director of Product Management @ UIPath").AlignRight().Italic()
                .SemiBold();
        });
    }

    void AddCfpEnergy(RowDescriptor row) {
        row.Spacing(10);

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Languages: ").Italic();
                text.Span("C#, SQL, Mermaid");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Frameworks: ").Italic();
                text.Span(".NET, Azure, Kafka, Entity Framework, PostgreSQL, SignalR");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Tools: ").Italic();
                text.Span("Rider, Postman, Miro, GitHub, Molecule, Aspire, TDD, Azure, Refit, Polly");
            });

            col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Business: ").Italic();
                text.Span(
                    "CFP Energy is a leading energy trading company in the UK, specializing in wholesale electricity " +
                    "and gas trading, risk management, and market analysis. The company focuses on optimizing energy portfolios " +
                    "through advanced data analytics and real-time market monitoring systems. Their platform enables efficient " +
                    "trading operations while ensuring compliance with regulatory requirements and market standards.");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Technical: ").Italic();
                text.Span("Led the backend development of Mercury, a greenfield application designed to streamline " +
                    "trading of carbon instruments. The solution utilized .NET microservices communicating through Kafka " +
                    "topics, real-time frontend updates via SignalR, PostgreSQL for persistent storage, and integration " +
                    "with Molecule API for trade settlement.");
            });
        });

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Designed and Implemented Ring-Fenced Architecture: ").SemiBold().Italic();
                text.Span(
                    "Led the architecture design for automated ring-fencing of carbon trades, leveraging clean " +
                    "architecture principles and expressing complex requirements through Mermaid diagrams.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Implemented Molecule API Integration: ").SemiBold().Italic();
                text.Span(
                    "Created the Molecule API client and adaptor, enabling end-to-end workflows for new trades along " +
                    "with fees and commissions, while ensuring simplicity and resilience.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Micro Frontend Development: ").SemiBold().Italic();
                text.Span(
                    "Developed micro frontends for the backend services, leveraging modern web technologies to achieve ease of testing and faster delivery.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Real-Time Trade Event Notifications: ").SemiBold().Italic();
                text.Span(
                    "Implemented real-time communication with the Angular frontend via SignalR/WebSockets, " +
                    "informing end users about trade events as soon as possible.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Advanced Microservices Communication: ").SemiBold().Italic();
                text.Span(
                    "Optimized inter-service communication by implementing Kafka topics with Avro serialization, " +
                    "achieving high performance and efficient data transfer between microservices.");
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
                text.Span(
                    "Rider, Azure DevOps, Azure Functions, Logic Apps, Api Management, Data Lake, DataBricks");
            });

            col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Business: ").Italic();
                text.Span(
                    "Itineris is a technology company specializing in cloud-based software solutions for the " +
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
                text.Span(
                    "Spearheaded the modernization of the TimeSamples system, responsible for ingesting raw meter " +
                    "data, generating billable data, providing estimates for missing reads, and synchronizing with the " +
                    "pricing engine for accurate tariff calculations");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Reliable Infrastructure as Code: ").SemiBold().Italic();
                text.Span(
                    "Successfully implemented and maintained an IaC approach using Bicep, enabling consistent and " +
                    "repeatable deployments with minimal downtime.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Optimized Data Processing: ").SemiBold().Italic();
                text.Span(
                    "Significantly improved the performance and scalability of Databricks jobs handling large " +
                    "volumes of metering data, enhancing the ability to process and analyze customer usage data efficiently.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Modernized Azure Infrastructure: ").SemiBold().Italic();
                text.Span(
                    "Led the migration of Azure Functions to .NET 8 and ASEv3, improving performance, security, " +
                    "and scalability of the platform.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Developed D365 F&O Data Entity Management Tool: ").SemiBold().Italic();
                text.Span(
                    "Built a custom .NET application to manage Data Entities within Dynamics 365 Finance & Operations.");
            });
        });
    }

    void AddEuaa(RowDescriptor row) {
        row.Spacing(10);

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Languages: ").Italic();
                text.Span("C#, Sql");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Frameworks: ").Italic();
                text.Span(".NET, ASP.NET, Azure, Entity Framework");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Tools: ").Italic();
                text.Span("Rider, Azure DevOps, Visual Studio");
            });

            col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Business: ").Italic();
                text.Span(
                    "EUAA is a European Union agency that plays a crucial role in implementing the EU's common " +
                    "asylum system. It provides operational and technical assistance to EU Member States, ensuring " +
                    "consistent asylum procedures across Europe. The agency delivers training, quality support, and " +
                    "data analysis to strengthen the EU's capacity to protect those seeking international protection.");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Technical: ").Italic();
                text.Span(
                    "The project utilized a Vue.js frontend to provide an administrative interface where users " +
                    "could manage expert assignments to deployment and operational plans. The system allowed " +
                    "administrators to assign countries, track expert availability, and manage various operational " +
                    "aspects through a modern, responsive interface. Backend services were built with .NET Core, " +
                    "providing RESTful APIs.");
            });
        });

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Enhanced Resource Planning with Real-Time Analytics: ").SemiBold().Italic();
                text.Span(
                    "Engineered the backend of an interactive dashboard for deployment plans that provides instant visibility " +
                    "into expert allocation patterns. This feature aggregates and displays monthly summaries.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Rights Management System Redesign: ").SemiBold().Italic();
                text.Span("Contributed to a backend redesign of the rights management system using custom authorization attributes " +
                          "on controllers and middleware-level permission checks. Implemented backend route guards " +
                          "based on user roles and permissions, leading to better page accessibility and security.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Implemented Cascades Functionality: ").SemiBold().Italic();
                text.Span(
                    "Developed a comprehensive table and dialog system for linking expert profiles with tasks, " +
                    "significantly reducing manual data entry time and improving data consistency across the system.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Optimized API Performance: ").SemiBold().Italic();
                text.Span(
                    "Significantly improved task fetching performance by optimizing SQL entity relationships, " +
                    "reducing response time from 600 to 30 seconds.");
            });
        });
    }

    void AddEps(RowDescriptor row) {
        row.Spacing(10);

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Languages: ").Italic();
                text.Span("C#, SQL, Razor");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Frameworks: ").Italic();
                text.Span(".NET, ASP.NET, tSQLt");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Tools: ").Italic();
                text.Span("Rider, GitLab, TeamCity, Octopus, SoapUI");
            });

            col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Business: ").Italic();
                text.Span(
                    "EPS LT is a leading payments solution provider based in Lithuania, serving major clients " +
                    "across the Baltics, Central and Eastern Europe. The company specializes in developing and " +
                    "maintaining robust card-based infrastructure for fleet, insurance, and gift card management, " +
                    "as well as custom corporate payment and loyalty solutions");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Technical: ").Italic();
                text.Span(
                    "Worked on FIG (Fleet, Insurance, Gift Cards), a comprehensive platform where each client " +
                    "had its own suite of solutions including databases, admin web interface, client web portal, " +
                    "and backend services. The role involved providing support and developing new features across " +
                    "the entire technology stack, ensuring seamless integration and optimal performance of all components.");
            });
        });

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Implemented Dynamic Insurance Discount System: ").SemiBold().Italic();
                text.Span("Developed a comprehensive health insurance discount system for pharmacies, enabling " +
                          "automated application of gratuities and reductions based on product categories and insurance policies.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Implemented ATC Code Import System: ").SemiBold().Italic();
                text.Span(
                    "Designed and built a system to import both real and test ATC codes, providing pharmacies an " +
                    "internal tool to flexibly assign reduction codes to products based on standardized templates.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Optimized Database Performance: ").SemiBold().Italic();
                text.Span("Implemented a SQL cleanup procedure that removed expired card limits from production, " +
                          "reducing maintenance costs and providing clearer insights into client usage patterns and trends.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Re-architected Database System: ").SemiBold().Italic();
                text.Span("Successfully consolidated multiple client databases into a single source of truth, " +
                          "reducing operational costs and complexity while moving business logic from stored procedures " +
                          "into maintainable C# code.");
            });
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
                text.Span(
                    "Lykke is a Swiss fintech company using blockchain technology to revolutionize financial " +
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
                text.Span(
                    "Successfully integrated Lykke’s systems with a secrets manager, eliminating the need for " +
                    "hardcoded credentials and significantly improving the security posture of the applications. ");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Foundation for Robust CI/CD Pipeline: ").SemiBold().Italic();
                text.Span(
                    "Laid the groundwork for a new CI/CD automation system, enabling continuous integration and" +
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
                text.Span(
                    "Established in 1994, considered a leading global financial institution, ING Bank offers a" +
                    " wide range of products and services to individuals, small and medium-sized enterprises, " +
                    "and large corporations.");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Technical: ").Italic();
                text.Span(
                    "Within the BPM Core team at ING Bank Romania, I played a crucial role in developing and " +
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
                text.Span(
                    "Provided comprehensive L3 production support, acting as a liaison between business analysts," +
                    " configurators, and external stakeholders. This involved troubleshooting complex issues, analyzing" +
                    " logs, and communicating solutions effectively to all parties involved.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Enhanced Health Checks: ").SemiBold().Italic();
                text.Span(
                    "Implemented and extended health checks to encompass all core service dependencies. This " +
                    "included monitoring vital databases and external assemblies developed by other teams, ensuring " +
                    "proactive identification and resolution of potential problems.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Led the successful upgrade to .NET 8 ").SemiBold().Italic();
                text.Span(
                    "across multiple enterprise applications. This upgrade resulted in measurable performance " +
                    "improvements and ensured seamless compatibility with the latest Microsoft technologies.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Sustainability Initiative: ").SemiBold().Italic();
                text.Span(
                    "Championed the adoption of QR code-based business cards for front-office banking officers. ");
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
                text.Span(
                    "A global integrated payments company, providing customers with access to products, insights, " +
                    "and experiences that enrich lives and build business success, Amex offers a range of financial " +
                    "products and services, including credit and charge cards, merchant acquisition and processing, " +
                    "network services, travel, and insurance.");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Technical: ").Italic();
                text.Span(
                    "Contributed to the development and integration of key payment products such as WebFASTest, " +
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
                text.Span(
                    "Implemented automated UI testing framework using Playwright in the absence of a dedicated " +
                    "QA team, ensuring client acceptance criteria for payment certification scenarios were met and " +
                    "reducing manual testing efforts.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Spearheaded the greenfield development of NGS: ").SemiBold().Italic();
                text.Span(
                    "Led the development of the NGS payment certification tool using modern technologies like " +
                    "Blazor, establishing a robust and flexible UI component system from scratch.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Streamlined deployment processes: ").SemiBold().Italic();
                text.Span(
                    "Developed PowerShell and Cake scripts for automated building, packaging, and deployment of binaries.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Provided support and maintenance for a legacy system: ").SemiBold().Italic();
                text.Span(
                    "Ensured the continued functionality and stability of a critical legacy system, while also " +
                    "documenting and extracting key information, such as EMV chip card application and tags, to make it" +
                    " accessible throughout the modernized system.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Mentored junior developers on best practices:: ").SemiBold().Italic();
                text.Span(
                    "Shared expertise in test-driven development (TDD), clean code principles, and continuous integration.");
            });
        });
    }

    void AddKlips(RowDescriptor row) {
        row.Spacing(10);

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Languages: ").Italic();
                text.Span("C#, Powershell, SQL, JavaScript");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Frameworks: ").Italic();
                text.Span(".NET, ASP.NET, GCP, React, SignalR");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Tools: ").Italic();
                text.Span("Rider, Redis, NATS, Docker, Kubernetes, MongoDB, Grafana, Prometheus");
            });

            col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Business: ").Italic();
                text.Span(
                    "Klips is a fast-growing fintech company revolutionizing the financial industry with its " +
                    "next-generation Financial Hub. This unified platform offers a comprehensive suite of services " +
                    "including CFD trading, digital banking, shares dealing, payments, and CRM.");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Technical: ").Italic();
                text.Span("Together with the team we created an MVP for a cryptocurrency wallet using a modern " +
                          "technology stack including .NET, SignalR, NATS, Redis, React and NoSQL databases. This platform " +
                          "integrated with multiple liquidity providers, enabling essential features like deposits, swaps, " +
                          "and withdrawals.");
            });
        });

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("MVP Delivery & Business Validation: ").SemiBold().Italic();
                text.Span(
                    "Participated in the creation of a minimum viable product (MVP) for a cryptocurrency wallet, " +
                    "validating core business ideas like fiat and crypto deposits, swaps, and withdrawals.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Real-Time Monitoring & Alerting: ").SemiBold().Italic();
                text.Span(
                    "Implemented comprehensive Grafana dashboards to monitor critical system metrics, enabling " +
                    "proactive issue detection and resolution by triggering automated alerts.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Sub-Millisecond Communication Architecture: ").SemiBold().Italic();
                text.Span(
                    "Implemented microservice communication using Kafka topics with Avro serialization, " +
                    "achieving sub-millisecond latency and ensuring data consistency across the system.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Real-Time Crypto Quotations via WebSockets: ").SemiBold().Italic();
                text.Span(
                    "Implemented WebSocket technology to deliver live crypto quotations directly to the mobile " +
                    "wallet page, enhancing user experience and enabling real-time decision-making.");
            });
        });
    }

    void AddAxa(RowDescriptor row) {
        row.Spacing(10);

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Languages: ").Italic();
                text.Span("C#, TypeScript, SQL, JavaScript");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Frameworks: ").Italic();
                text.Span(".NET, ASP.NET, Angular, Cypress");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Tools: ").Italic();
                text.Span("Rider, SSMS, WebStorm, SimCorp Dimension, UFT One");
            });

            col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Business: ").Italic();
                text.Span("As the investment arm of AXA Group, a world leader in financial protection and wealth " +
                          "management, AXA IM is committed to responsible investing, integrating environmental, social, " +
                          "and governance factors into its investment processes.");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Technical: ").Italic();
                text.Span(
                    "The technical environment consists of a mix of .NET and Angular technologies, with a focus " +
                    "on delivering a responsive, scalable, and secure platform for managing derivatives investments. " +
                    "The platform leverages the SimCorp Dimension system for core portfolio management functionality " +
                    "and utilizes SQL for efficient data operations.");
            });
        });

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Derivatives Pricing Innovation: ").SemiBold().Italic();
                text.Span(
                    "Spearheaded the implementation, creation, and extension of a new derivatives credit pricing " +
                    "system, complete with all necessary financial models.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Trader Empowerment Through Automation: ").SemiBold().Italic();
                text.Span(
                    "Delivered mission-critical information about currency & index options directly to traders, " +
                    "enabling automated execution of full unwinds and roll forwards, reducing manual labor by a factor of 10.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Legacy System Decommissioning: ").SemiBold().Italic();
                text.Span(
                    "Successfully decommissioned approximately 20% of Global One, a company-wide legacy system " +
                    "responsible for repurchase agreement management.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Automated Functional Testing Implementation: ").SemiBold().Italic();
                text.Span("Developed a comprehensive suite of automated functional tests using UFT One, covering " +
                          "critical business processes and reducing manual testing efforts by approximately 80%.");
            });
        });
    }

    void AddBeeNear(RowDescriptor row) {
        row.Spacing(10);

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Languages: ").Italic();
                text.Span("C#, TypeScript, SQL, JavaScript");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Frameworks: ").Italic();
                text.Span(".NET, ASP.NET MVC, Angular, WebForms");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Tools: ").Italic();
                text.Span("Visual Studio, SSMS, DataGrip, Autofac, Moq");
            });

            col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Business: ").Italic();
                text.Span(
                    "OpenFinance is Italy’s leading accounting software, empowering businesses to streamline " +
                    "financial operations & make informed decisions. EasyOne is an industry-leading CRM solution " +
                    "widely used across the Iberian peninsula, enabling businesses to build stronger customer relationships.");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Technical: ").Italic();
                text.Span(
                    "OpenFinance leverages a modern frameworks to deliver a responsive, scalable, and secure " +
                    "accounting platform. EasyOne is built on a solid GUI core and has been strategically refactored " +
                    "into a microservices architecture, enhancing its flexibility & maintainability.");
            });
        });

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("OpenGate Modernization: ").SemiBold().Italic();
                text.Span(
                    "Led the successful migration of the legacy OpenGate accounting software from Microsoft " +
                    "WebForms to Angular 12, significantly improving performance and modernizing the technology stack.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Threefold Performance Increase: ").SemiBold().Italic();
                text.Span(
                    "Enhanced OpenGate’s performance by rewriting two critical components in Angular, resulting " +
                    "in a markedly faster and more responsive user experience.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("CRM Refactoring to Microservices: ").SemiBold().Italic();
                text.Span("Spearheaded the transformation of EasyOneCrm from a monolithic WPF application into a " +
                          "microservices architecture, boosting scalability, flexibility, and maintainability.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("7x Faster Login: ").SemiBold().Italic();
                text.Span("Achieved a sevenfold reduction in login loading time through innovative architectural " +
                          "redesign, dramatically improving user access and satisfaction.");
            });
        });
    }

    void AddEnedis(RowDescriptor row) {
        row.Spacing(10);

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Languages: ").Italic();
                text.Span("C#, Python, Mermaid, DPL, C++");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Frameworks: ").Italic();
                text.Span(".NET, Parsimonious, WCF, WPF");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Tools: ").Italic();
                text.Span("Rider, yEd, GoXAM, PyCharm, PowerFactory");
            });

            col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Business: ").Italic();
                text.Span(
                    "Enedis Talon is a powerful internal tool designed to optimize the management of France’s " +
                    "electrical grid. It empowers Enedis to efficiently calculate crucial electro-technical metrics, " +
                    "including the cost of new connections for customers.");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Technical: ").Italic();
                text.Span("Enedis Talon is an N-Tier application framework that leverages advanced algorithms to " +
                          "compute a range of electro-technical metrics for the French electrical grid. Key functionalities " +
                          "include calculating the cost of new connections (raccordements) for end users, providing Enedis " +
                          "with accurate cost estimations.");
            });
        });

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Base Tier Rework: ").SemiBold().Italic();
                text.Span(
                    "Led the successful migration of the legacy OpenGate accounting software from Microsoft " +
                    "WebForms to Angular 12, significantly improving performance and modernizing the technology stack.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("GUI Development for Workflow Generation: ").SemiBold().Italic();
                text.Span(
                    "Designed and implemented a user-friendly GUI using WPF and GoXam, simplifying the process of " +
                    "creating and visualizing complex electrical workflows for non-technical users.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Code Generation Pipeline: ").SemiBold().Italic();
                text.Span("Created an innovative code generation pipeline capable of translating functional " +
                          "specifications directly into C# code, drastically accelerating development cycles.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Supervisor Development: ").SemiBold().Italic();
                text.Span("Built a sophisticated Supervisor module to autonomously monitor, deploy, and " +
                          "configure Talon modules, ensuring optimal system health.");
            });
        });
    }

    void AddSocGen(RowDescriptor row) {
        row.Spacing(10);

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Languages: ").Italic();
                text.Span("C#, Powershell, Gherkin, SQL");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Frameworks: ").Italic();
                text.Span(".NET, ADO, ASP .NET, SSIS");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Tools: ").Italic();
                text.Span("Visual Studio, SSMS, TeamCity, XL Deploy");
            });

            col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Business: ").Italic();
                text.Span(
                    "Liqor is a cutting-edge solution designed to streamline liquidity reporting for financial " +
                    "institutions. By automating the calculation of complex metrics and generating compliant reports " +
                    "for the BDF and BCE, Liqor significantly reduces the time and resources traditionally required for these tasks.");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Technical: ").Italic();
                text.Span(
                    "Liqor is an internal financial application developed to automate liquidity reporting. It " +
                    "utilizes a sophisticated algorithm to calculate various liquidity metrics based on real-time " +
                    "financial data. The application also features a report generation module capable of producing " +
                    "customized reports in accordance with BDF and BCE requirements.");
            });
        });

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Basel III Implementation: ").SemiBold().Italic();
                text.Span("Successfully integrated new liquidity metrics required by Basel III regulations, " +
                          "ensuring compliance and contributing to accurate risk assessment.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("SSIS Script Optimization: ").SemiBold().Italic();
                text.Span("Rewrote and optimized critical SSIS scripts, achieving a 35% performance improvement " +
                          "and reducing processing time.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("XML Parser Development: ").SemiBold().Italic();
                text.Span(
                    "Developed a custom XML parser that reduced data integration time for a new data source by " +
                    "threefold, accelerating development cycles.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("CI Pipeline Redesign: ").SemiBold().Italic();
                text.Span(
                    "Redesigned and upgraded the CI pipeline from TeamCity 2008 to 2018, resulting in a near " +
                    "tenfold performance improvement and streamlined deployment processes.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Production Monitoring: ").SemiBold().Italic();
                text.Span("Ensured stability and performance of Liqor’s production environment.");
            });
        });
    }

    void AddTricentis(RowDescriptor row) {
        row.Spacing(10);

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Technical Environment").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Languages: ").Italic();
                text.Span("C#, TypeScript, SQL");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Frameworks: ").Italic();
                text.Span(".NET, Angular, Entity Framework, ASP .NET");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.AlignCenter();
                text.Span("Tools: ").Italic();
                text.Span("Visual Studio, Robo 3T, Azure DevOps, Auth0");
            });

            col.Item().PaddingTop(5).Text("Project Description").Bold().FontSize(14).AlignCenter();
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Business: ").Italic();
                text.Span(
                    "Tricentis Tosca empowers businesses to achieve faster, higher quality software releases at a " +
                    "lower cost. Its codeless approach and AI-powered risk-based testing streamline the testing process, " +
                    "increasing efficiency and reducing time-to-market.");
            });
            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Technical: ").Italic();
                text.Span(
                    "Tricentis Tosca’s model-based test automation and broad technology support enable the creation " +
                    "of reusable and scalable test cases. This significantly reduces maintenance efforts and allows for " +
                    "efficient testing of diverse applications, from GUI to mobile.");
            });
        });

        row.RelativeItem().Column(col => {
            col.Item().PaddingTop(5).Text("Key Achievements").Bold().FontSize(14).AlignCenter();

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Participated in modernization efforts: ").SemiBold().Italic();
                text.Span(
                    "Worked on the decomposition of a monolithic architecture into microservices, resulting in a " +
                    "significant 50%+ performance improvement.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Introduced valuable features: ").SemiBold().Italic();
                text.Span("Implemented user management and profile editing functionalities in the Cloud Portal, " +
                          "addressing key user needs and increasing platform usability.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Prioritized stability and user experience: ").SemiBold().Italic();
                text.Span("Proactively implemented health check mechanisms for microservices, ensuring system " +
                          "reliability and minimizing downtime. Streamlined authentication processes with configurable " +
                          "Auth0 token storage for improved user experience.");
            });

            col.Item().PaddingTop(5).Text(text => {
                text.Justify();
                text.Span("Established foundation for future growth: ").SemiBold().Italic();
                text.Span("Migrated to Git and developed CI/CD pipelines, fostering efficient and " +
                          "collaborative development environments.");
            });
        });
    }
}