---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: getting_started       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Getting started with the SuperOffice web services # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Frode Lillerud             # Your GitHub alias.
so-date: 04.28.2015
keywords:
so.topic: article               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Getting started with the SuperOffice web services

![x][img1]

This blogpost is written for developers who want to manipulate the data in SuperOffice using the SuperOffice web services. As part of the installation of server-side SuperOffice is a rich set of web services that can be used to read and write to the database. These are used by SuperOffice’ own products, like Customer Service and Pocket CRM, but can just as well be used by custom applications and websites. This blogpost will give an introduction to how you get started using the web services.

First, you’ll need Visual Studio - you can just grab the free version, like Visual Studio Community 2013 version. Next, the web services needs to be installed on the server. If you are responsible for the SuperOffice installation you can download SuperOffice 7.Web, and either just install the NetServer part (which is basically just the web services), or you can install the full 7.web and make sure you tick the checkbox that asks if you want to make the remote web services available. If you are an external developer that just wants to communicate with SuperOffice just ask the customer to contact their SuperOffice partner to get the web services installed.

Once you’ve got Visual Studio up and running you’ll need to get a few .dlls that you are going to reference in your project. The files can for instance be found in the *bin* folder on the server where the web services are installed. The files you need are:

**Update!**

**For version 8**: See [this blogpost][1] for updated list of assembly files.

**For older version 7.5:**

* SoCore.dll
* SoDatabase.dll
* SoLicense.dll
* SuperOffice.Services.dll
* SuperOffice.Services.WcfProxy.dll
* SuperOffice.Services75.dll
* SuperOffice.Services75.Contract.dll
* SuperOffice.Services75.Wcf.dll
* SuperOffice.Services75.WcfService.dll
* and lastly a reference to System.IdentityModel from .NET 4.

Once you’ve added those references to your Visual Studio project you need to include a few sections in you app.config/web.config.

## Minimum set-up

Here is the minimum setup you’ll need in your .config file:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <configSections>
    <sectionGroup name="SuperOffice">
      <sectionGroup name="Security">
        <section name="Cryptography" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
        <section name="Sentry" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      </sectionGroup>
      <sectionGroup name="Mail">
        <section name="Component" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      </sectionGroup>
      <section name="Diagnostics" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <sectionGroup name="Data">
        <section name="Session" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      </sectionGroup>
      <sectionGroup name="Factory">
        <section name="CustomFactories" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
        <section name="DynamicLoad" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      </sectionGroup>
      <section name="Services" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
    </sectionGroup>
  </configSections>
  
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5" />
  </startup>

  <SuperOffice>
    <Data>
      <Session>
        <add key="Mode" value="Thread" />
      </Session>
    </Data>
    <Services>
      <add key="DefaultMode" value="Remote" />
      <add key="RemoteBaseURL" value="http://samsung-frode/SuperOffice75/Remote/Services75/" />
    </Services>
  </SuperOffice>

</configuration>
```

> [!NOTE]
> There is a key called RemoteBaseURL - this is the URL to where the web services are installed. Once you’ve got this setup in place it’s time to write some code to use the web services.

Here is a basic template for authenticating and displaying the name of the licenseowner for the database.

```csharp
private static void Main(string\[\] args)
{
    String username = "db";
    String password = "db";
    try
    {
        using (SuperOffice.SoSession.Authenticate(username, password))
        {
            Console.Write("Connected to database owned by: ");
            Console.Write(SuperOffice.SoSystemInfo.GetCurrent().CompanyName);
            Console.Write(" with serial number: ");
            Console.WriteLine(SuperOffice.SoSystemInfo.GetCurrent().License.SerialNr);

            //Put business code here...
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}
```

At this point, you’re connected to the database, and have access to do just about anything that a user can do in the client.

Here are a few simple scenarios to give you some examples on what and how you can do stuff.

## Create a new company

In its simplest form you can just call this to create a new company with all default values:

```csharp
ContactAgent contactAgent = new ContactAgent();
ContactEntity contact = contactAgent.CreateDefaultContactEntity();
contact.Name = "Test";
contact = contactAgent.SaveContactEntity(contact);

But most likely you’ll want to set a few properties before saving:

//Create a new company
ContactAgent contactAgent = new ContactAgent();
ContactEntity contact = contactAgent.CreateDefaultContactEntity();
contact.Name = "ACME Inc";
contact.Number2 = "1234";
contact.Address.LocalizedAddress\[0\]\[0\].Value = "Testroad 37";
contact.Associate.AssociateId = 9;
contact.UserDefinedFields\["SuperOffice:5"\] = "A udef string";
contact.Category.Id = 6;
contact = contactAgent.SaveContactEntity(contact);
Console.WriteLine("Created contact with ID: " + contact.ContactId);
```

## Find a project using ProjectId

When you want to retrieve a single entity you just need to pass in the ID, like this:

```csharp
Int32 projectId = 7;
ProjectAgent projectAgent = new ProjectAgent();
ProjectEntity project = projectAgent.GetProjectEntity(projectId);
Console.WriteLine("Found project named: " + project.Name);
```

Many of the main classes come in two variants. A simple and a full one. Or fast and slow, if you want. Contact is the small one, ContactEntity is the big one. Project is the lightweight one, while ProjectEntity has more properties. When you want to make a change and save data back to SuperOffice you need to use the Entity variant.

## Update a person

```csharp
Int32 personId = 30;
PersonAgent personAgent = new PersonAgent();
PersonEntity person = personAgent.GetPersonEntity(personId);
person.BirthDate = new DateTime(1942, 03, 17);
person.Position.Id = 4;
person = personAgent.SavePersonEntity(person);
```

## Create a followup on a customer

```csharp
Int32 contactId = 5;
Int32 contactPersonId = 6;
AppointmentAgent appAgent = new AppointmentAgent();
AppointmentEntity app = appAgent.CreateDefaultAppointmentEntity();
app.Contact = contactAgent.GetContact(contactId);
app.Person = personAgent.GetPerson(contactPersonId);
app.Task.TaskListItemId = 11;
app.Description = "Follow up this customer";
app = appAgent.SaveAppointmentEntity(app);
```

## Delete a sale

```csharp
Int32 saleId = 3;
SaleAgent saleAgent = new SaleAgent();
saleAgent.DeleteSaleEntity(saleId);
```

## Get all items in an MDO list

```csharp
MDOAgent mdoAgent = new MDOAgent();
var items = mdoAgent.GetSimpleList("Category");
foreach (var item in items)
    Console.WriteLine("Entry " + item.Id + " has name " + item.Name);
```

## Upload a document

```csharp
String fullPath = @"C:\\Temp\\samplefile.docx";
FileInfo file = new FileInfo(fullPath);
                    
//Save the document in the database
Console.WriteLine("Creating document");
DocumentAgent docAgent = new DocumentAgent();
DocumentEntity document = docAgent.CreateDefaultDocumentEntity();
document.Header = "A sample document";
document.Type = AppointmentType.Document;
document.Name = Path.GetFileName(fullPath);
document.Date = DateTime.Now;
document.Associate = new Associate {AssociateId = 9};
document.Contact = contactAgent.GetContact(contactId);
document.DocumentTemplate = new DocumentTemplate() {DocumentTemplateId = 4};
document.CreatedBy = document.Associate;
document.CreatedDate = file.CreationTime;
document = docAgent.SaveDocumentEntity(document);

//Upload the file content
FileStream fs = file.OpenRead();
document = docAgent.SetDocumentStream(document, fs, true);
fs.Close();
```

## Search for data in any table

There are several methods for finding data in SuperOffice, but one I like is to use the "dynamic" provider. It’ll allow you to use a dot-syntax to indicate which tables you want data from. Customer Service use this method extensively.

Here is an example where we use the Dynamic provider to search for data in a Customer Service extratable.

```csharp
using (FindAgent find = new FindAgent())
{
    var archiveColumns = new string\[\] {"y\_anlegg.x\_navn"};
    var restriction = new ArchiveRestrictionInfo\[\]
    {
        new ArchiveRestrictionInfo("y\_anlegg.x\_project\_id", "LESS", "10")
    };

    FindResults results = find.FindFromRestrictionsColumns(
        restriction,
        "Dynamic",
        archiveColumns,
        int.MaxValue,
        0);

    foreach (var row in results.ArchiveRows)
    {
        Console.WriteLine(row.ColumnData\["y\_anlegg.x\_navn"\].DisplayValue);
    }
}
```

Hopefully, this is useful for anyone getting started with the SuperOffice web services.

<!-- Referenced links -->
[1]: ../whats-new/80-to-80-sr-1.md

<!-- Referenced images -->
[img1]: media/8183-24657.jpg
