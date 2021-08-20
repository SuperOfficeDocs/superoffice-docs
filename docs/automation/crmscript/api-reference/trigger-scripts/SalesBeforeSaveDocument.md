---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesBeforeSaveDocument (1004)

Called before an document is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

|Variable|Description|
|---|---|
|DocumentDate|Document date|
|DocumentEntity.ActiveLinks|Active links|
|DocumentEntity.Associate.*|Associate variables|
|DocumentEntity.Attention|Attention|
|DocumentEntity.Completed|Completed|
|DocumentEntity.CompletedBool|true/false|
|DocumentEntity.Contact.*|Contact variables|
|DocumentEntity.CreatedDate|Created date|
|DocumentEntity.Date|Date|
|DocumentEntity.Description|Description|
|DocumentEntity.DocumentId|Document Id
|DocumentEntity.DocumentTemplate.*|Document template variables|
|DocumentEntity.ExternalRef|External ref|
|DocumentEntity.Header|Header|
|DocumentEntity.IsPublished|Is published|
|DocumentEntity.Links.length|Links length|
|DocumentEntity.Name|Document name|
|DocumentEntity.OurRef|Our ref|
|DocumentEntity.Person.*|Person variables|
|DocumentEntity.Project.*|Project variables|
|DocumentEntity.PublishEventDate|Publish event date|
|DocumentEntity.PublishFrom|Publish from|
|DocumentEntity.PublishTo|Publish to|
|DocumentEntity.Sale.*|Sale variables|
|DocumentEntity.Snum|Snum|
|DocumentEntity.SuggestedDocumentId|Suggested documentId|
|DocumentEntity.Type|Type|
|DocumentEntity.UpdatedDate|Updated date|
|DocumentEntity.VisibleFor.length|Visible for length|
|DocumentEntity.VisibleFor[\*].*|List of visible for|
|DocumentEntity.YourRef|Your ref|
|DocumentName|Document name|
|EmailItemId|EmailItemId|
|IsNew|Is new|
|Links.length|Links length|
|SelectedDocumentTemplateLanguage|Document template language|
|TemplateListName|Template list name|
|TemplatesExtraInfo|Extra info

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String param1 = ed.getInputValue("IsNew");
```
