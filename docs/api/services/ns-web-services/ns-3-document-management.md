---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: ns_3_document_management       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Web service document management # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates             # Your GitHub alias.
so.date: 06.11.2008
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Web service document management

In this document, the focus will be on how to create, as well as edit, and upload a modified document.

## Create a Document

This document focuses on how to create a new document in SO\_ARC based on a specific template. It also demonstrates how to download the new document to a local folder and open it.

To create a new document, first create a document entity and set the document properties. In this example, we have used a specific document template on which the document is based. The owner of the document is set, followed by the associated person and project with which the document is connected.

```csharp
public int CreateDocument()
{
    // create a document entity
    DocumentEntity documentEntity = new DocumentEntity();

    // set properties of document entity
    documentEntity.Attention = "Thomas O S";
    documentEntity.Header = "Test document";
    documentEntity.Name = "Test.doc";
    documentEntity.OurRef = "Our Reference";
    documentEntity.YourRef = "Your Reference";
    documentEntity.Description = "This is a new document entity created using IDocument Agent";

    documentEntity.Date = DateTime.Today;
    documentEntity.ExternalRef = "External Reference";

    // set the document template for the document
    DocumentTemplate docTmpl = new DocumentTemplate();
    docTmpl.DocumentTemplateId = 1;
    documentEntity.DocumentTemplate = docTmpl;

    // set the owner of the document
    Associate owner = new Associate();
    owner.AssociateId = 110;
    documentEntity.Associate = owner;

    // set the person to whom the document is connected : optional

    Person person = new Person();
    person.PersonId = 12;
    documentEntity.Person = person;

    // set the contact associated with the document: can also be null
    Contact contact = new Contact();
    contact.ContactId = 4;
    documentEntity.Contact = contact;

    // set the project to which the document is connected  : optional
    Project project = new Project();
    project.ProjectId = 15;
    documentEntity.Project = project;

    //create new instance
    DocumentAgent agent = new DocumentAgent();
    DocumentEntity createdDocumentEntity = agent.SaveDocumentEntity(documentEntity);

    // create a new physical document and store it in the document archive
    agent.CreateNewPhysicalDocumentFromTemplate(createdDocumentEntity.Contact.ContactId,
        createdDocumentEntity.Person.PersonId,
        0,
        createdDocumentEntity.DocumentId,
        0, 
        0,
        createdDocumentEntity.Project.ProjectId);

    return createdDocumentEntity.DocumentId;
}
```

Once the property values are set, the document is persisted to the database using the IDocumentAgent.SaveDocumentEntity method. This call creates a new Document record in the database and returns a DocumentEntity instance that now contains a document id.

With a document-record in the database, you create the physical document and save it in the document archive. Do this using the IDocumentAgent.CreateNewPhysicalDocumentFromTemplate method. CreateNewPhysicalDocumentFromTemplate requires the contact, person, appointment, sale, selection, and project IDs, along with the document ID.

The following code example demonstrates how to download the created document to a local directory and open it.

```csharp
private void DownloadDocument(int documentId)
{
    // create an IDocumentAgent object and retrieve a document
    DocumentAgent agent = new DocumentAgent();
    DocumentEntity documentEntityExisting = agent.GetDocumentEntity(documentId);

    // check if the document exists
    if (documentEntityExisting != null)
    {
        // generate the file name for the downloaded document
        string extentionOfOriginalDocument = 
            Path.GetExtension(documentEntityExisting.Name);

        string fileName = "tempFile" + extentionOfOriginalDocument;

        // download the document to the temporary folder
        agent.CreateTempFile(fileName, agent.GetDocumentStream(documentEntityExisting));

        // read the path for the temporary folder from the config file
        string tempFilePath = 
            Path.Combine(SuperOffice.Configuration.ConfigFile.Documents.TemporaryPath, 
            SoContext.CurrentPrincipal != null ? 
            SoContext.CurrentPrincipal.Associate : "ALL");

        // full path for the downloaded document
        string fullPath = Path.Combine(tempFilePath.Replace("\\\\", "\\"), fileName);

        // open the document using the open shell command
        if (File.Exists(fullPath))
        {
            // create a process
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

            // pass the file name with extension to open the file
            myProcess.StartInfo.FileName = fullPath;
            myProcess.StartInfo.WindowStyle = 
                System.Diagnostics.ProcessWindowStyle.Normal;

            myProcess.Start();
        }
        else
        {
            MessageBox.Show("The document has not been downloaded properly.");
        }
    }
    else
    {
        MessageBox.Show(
            "The document you are trying to open does not exist in the server.");
    }
}
```

In the example above, we first retrieve the document using IDocumenyAgent.GetDocumentEntity. This is used by the IDocumentAgent.GetDocumentStream method to get the actual file from the document archive. You must also provide a name for the file. This name becomes the temporary file name where the file is downloaded, built-up, and opened from. You must be sure the extensions of both the original and the downloaded document are the same. Now you are ready to download the document. Use the IDocumentAgent.CreateTempFile method to execute the download.

The example here uses the System.Diagnostics.Process class to open the file. This ensures that the default application assigned to open this file type is launched to view the document.

## Download, Edit, and Upload Document Changes

To modify a document we will first have to download the document to a temporary folder so that it is available locally for the user to make modifications. Once modified, the temporary file is uploaded to the document archive folder.

The first step retrieves the document using an Agent instance, IDocumenyAgent. With the use of SuperOffice.CRM.Services.AgentFactory, IDocumentAgent object is retrieved. The IDocumentAgent.GetDocumentEntity method is invoked to get a DocumentEntity instance, which contains all properties of the document you are going to download - such as Header and Description.

When downloading a document, you must specify a name that will be used to name a copy of the original document. Make sure the extensions of both the original and the downloaded document are the same. In the example below, the original file extension is extracted and then appended to the end of the temporary file name. Now you are ready to download the document.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;
using System.IO;

/// 
/// This method is used to download an existing document, modify it and upload it to document archive
///
/// The id of the document to be updated
private void UpdateDocument(int documentId)
{
    // Create an IDocumentAgent object and retrieve a document
    DocumentAgent agent = new DocumentAgent();
    DocumentEntity documentEntityExisting = agent.GetDocumentEntity(documentId);

    // Check if the document exists
    if (documentEntityExisting != null)
    {
        // Generate the file name for the downloaded document
        string extentionOfOriginalDocument =
            Path.GetExtension(documentEntityExisting.Name);

        string fileName = "tempFile" + extentionOfOriginalDocument;
       
        // Download the document to the temporary folder
        Stream originalDocumentStream = agent.GetDocumentStream(documentId);
        agent.CreateTempFile(fileName, originalDocumentStream);

        // Close and dispose the stream
        originalDocumentStream.Close();
        originalDocumentStream.Dispose();

        // Now the file is ready to be modified....
        // Read the path for the temporary folder from the config file
        string tempFilePath = 
            Path.Combine(SuperOffice.Configuration.ConfigFile.Documents.TemporaryPath,
            SoContext.CurrentPrincipal != null ? 
            SoContext.CurrentPrincipal.Associate : "ALL");

        // Full path for the downloaded document
        string fullPath = Path.Combine(tempFilePath.Replace("\\\\", "\\"), fileName);

        // Check if the temporary document exists              
        if (File.Exists(fullPath))
        {
            // Assuming the user has modified the temporary file...
            // Get the file stream for the temporary local file
            Stream tempStream = newFileStream(fullPath, FileMode.Open, FileAccess.Read);
            agent.SetDocumentStream(documentEntityExisting, tempStream, true);
        }
    }
}
```

When calling the IDocumentAgent.CreateTempFile method, the temporary file name and the document stream for the original document are passed into the method.

IDocumentAgent.GetDocumentStream is used to download the document contents from the server. The temp filename is used for storing the contents locally and, once the file is created, you have to explicitly close and dispose the steam to eliminate concurrent access issues. At this point, you can modify the document.

Assuming the modifications are done, the next step is to upload the modified document to the document archive folder. This is achieved by setting the file stream of the temporary modified file as the document stream for the original document entity. Using a FileStream instance, and passing in the full path to the local file, the file open mode, and the file access details, you prepare the document for upload.

The IDocumentAgent.SetDocumentStream method is used to do perform the actual upload. SetDocumentStream requires three parameters: the original document entity, the stream for the temporary local file, and the Boolean value specifying whether the stream will overwrite an existing file with the same name stored in the document archive.

For the application to run properly, some modifications are required in the application configuration file. The following section illustrates the modifications required in the Documents section of the configuration file.

```xml
<Documents>
    <add key="ArchivePath" value="C:\\SO_ARC" />
    <add key="TemporaryPath" value="C:\\temp" />
    <add key="ImpersonateUser" value="false" />
</Documents>
```

The ArchivePath specifies the physical location of the archive folder. This applies to the services/server-side. The TemporaryPath key should have the physical location for temporary files on the client. Finally, specify the impersonation key value. Impersonation is for file access. Impersonation should be set to true in a scenario where SO\_ARC is located on a remote server because the web-server user runs as a restricted local account, which has no rights to access a file-share on a different server. If the impersonation set to true, the domain, user, and the password values for a user that has access to SO\_ARC and temp folder have to be provided. In this example, we have set the impersonation false because this is a windows application and the client runs the NetServer code in the same process, and the application inherits the user's identity.
