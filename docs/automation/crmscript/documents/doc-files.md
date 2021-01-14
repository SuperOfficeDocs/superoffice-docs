---
title: crmscript_doc_files
description: Document files
author:
so.date:
keywords:
so.topic: concept
---

# Document files

The physical document is tied to the [NSDocumentEntity][1] and stored in the document archive.

## Create physical document from template

Which template to use is set in the document properties.

**Required IDs:**

* company (contact ID)
* person
* appointment
* document
* sale
* selection
* project
* uiCulture (used to select a template of the appropriate language, for example, "en-US" or "nb-NO")

> [!TIP]
> If set to **0**, the company, person, appointment, sale, and project IDs will default to the values set in the document properties.

```crmscript
NSDocumentAgent agent;
NSDocumentEntity doc = agent.GetDocumentEntity(2);

agent.CreateNewPhysicalDocumentFromTemplate(doc.GetContact().GetId(), 0, 0, doc.GetDocumentId(),0,0,0,"");
```

## Filenames

The initial filename is taken from the document properties.

```crmscript
NSDocumentEntity doc;
String filename = doc.GetName();
```

### Rename physical document

When renaming, you can **suggest** a new filename. The document archive may amend this if your suggestion is already used by another file, contains restricted characters, or similar.

```crmscript
String newFilename = "Trebbles.doc";
Integer docId = 3;

NSDocumentAgent agent;
NSDocumentEntity doc = agent.GetDocumentEntity(docId);

String actualName = agent.RenameDocument(docId, newFilename);

doc.SetName(actualName);
agent.SaveDocumentEntity(doc);
```

> [!TIP]
> Don't forget to save the `NSDocumentEntity`!

### Change file extension

```crmscript!
String changeFileExtension(Integer documentId, String extension) {

  NSDocumentAgent agent;
  NSDocumentEntity doc = agent.GetDocumentEntity(documentId);

  String newName = agent.RenameDocument(documentId, doc.GetName().beforeLast(".") + extension);
  doc.SetName(newName);
  agent.SaveDocumentEntity(doc);
  return(newName);
}

printLine(changeFileExtension(3, ".pdf"));
```

## Locked for editing

In SuperOffice CRM, many people are creating, editing, and reading documents at any given time. If multiple users are editing the same document at the same time, they risk overwriting each other's data. To prevent this from happening, SuperOffice CRM will lock a document when it is being edited by a user. Other users can still open the document, but only in read-only mode.

### Is the document checked out

```crmscript!
NSDocumentAgent agent;
NSCheckoutInfo info = agent.GetCheckoutState(2);
printLine(info.GetState().toString() + "\t" + info.GetName());
```

### Check out

```crmscript
String[] returnTypes;
NSDocumentAgent agent;
agent.CheckoutDocument(2, returnTypes);
```

### Undo (abandon) a checkout

```crmscript
String[] returnTypes;
NSDocumentAgent agent;
agent.UndoCheckoutDocument(2, returnTypes);
```

### Check in

If the document or plug-in supports versioning, you can provide a description and metadata for a specific version when you check it in.

```crmscript
String[] returnTypes;
String[] meta;

NSDocumentAgent agent;
agent.CheckinDocument(2, returnTypes, "updated copyright", meta);
```

## Edit physical document - online

File operations are unavailable in CRM Online. All updates happen through document plug-ins using a URL referring to the actual document.

> [!TIP]
> To update only the document properties, [update the NSDocumentEntity][1].

### Get URL

```crmscript!
NSDocumentAgent agent;
Integer docId = 2;
String url = agent.GetDocumentUrl(docId, "", true);
printLine(url);
```

This example gets a writable URL for the latest version of document 2.

## Edit physical document - ONSITE ONLY

This is a 3-step process: download, modify, upload.

### Download document

1. Get the NSDocumentEntity
2. Generate a temporary filename for the local copy with the same extension as the original
3. Get the actual file as a stream

> [!NOTE]
> The extensions of both the original and the downloaded document must be the same!

```crmscript
Integer docId = 2;
NSDocumentAgent agent;
NSDocumentEntity doc = agent.GetDocumentEntity(docId);

String tmpFilename = "tempFile." + doc.GetName().afterLast(".");
NSStream stream = agent.GetDocumentStream(docId);

String download = agent.CreateTempFile(tmpFilename, stream);
```

> [!TIP]
> Remember to call `DeleteTempFile()` when you're done.

### Open document

**Read-only:**

```crmscript
File f;

f.open("test.txt", "r");
print(f.readAll());

f.close();
```

**Read/write:**

```crmscript
File f;

f.open("test.txt", "a+");
f.write("test");

f.close();
```

### Update document

How you go about changing the document locally is completely up to you!

### Upload document

For **modified** documents, you must ensure that the document's status is not **Completed**. Set it to **0** to enable upload.
To overwrite an existing file with the same name stored in the document archive, set the last parameter of `SetDocumentStream()` to **true**.

```crmscript
Integer docId = 2;
String path = "C:\Temp\samplefile.docx";

NSDocumentAgent agent;
NSDocumentEntity doc = agent.GetDocumentEntity(docId);

File f;
f.open(path, "r");

NSStream stream;
stream.SetStream(f.readBinary());

doc = agent.SetDocumentStream(doc, stream, true);

f.close();
```

> [!TIP]
> For robust code, consider placing the file operations in an `if` statement.

For **new** SuperOffice documents based on a local file, you must **create and save the NSDocumentEntity before uploading**.

Simply replace the line `NSDocumentEntity doc = agent.GetDocumentEntity(docId);` with the following code:

```crmscript
NSDocumentEntity doc = agent.CreateDefaultDocumentEntity();

doc.SetName(path);
doc.SetHeader(path);
doc.SetDate(getCurrentDateTime());
doc.SetDescription("document uploaded from CRMScript");
NSAssociateAgent aAgent;
doc.SetAssociate(aAgent.GetAssociate(1));
doc = agent.SaveDocumentEntity(doc);
```

## Delete physical document

```crmscript
String[] returnType;

NSDocumentAgent agent;
agent.DeletePhysicalDocument(5, returnType);
```

## Reference

### Return types (NSReturnInfo)

The document plugin might need to request additional processing. When deleting, you should pass a list of return types that the client is prepared to handle. If there are no restrictions, pass an empty array.

* CustomGui
* Message
* None
* Other
* SoProtocol

<!-- Referenced links -->
[1]: ./doc-properties.md
