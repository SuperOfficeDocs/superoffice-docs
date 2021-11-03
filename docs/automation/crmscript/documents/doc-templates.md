---
uid: crmscript_doc_templates
title: Document templates
description: A document template is a blueprint consisting of regular text and template variables. How to work with document templates in CRMScript.
author: Bergfrid Skaara Dias
so.date: 11.02.2021
keywords: CRMScript, document, document templates
so.topic: concept
---

# Document templates

A *document template* is a blueprint consisting of regular text and template variables. It's pre-made for a specific task and covers both content and design.

**Example signature snippet in a Microsoft Word document:**

```text
With regards
{onam}


{auth}
{atit}
```

For the end-user, these templates behave similarly to the service [reply template][1]. However, how you work with them in CRMScript is different.

> [!CAUTION]
> Template-based documents are only as good as the quality of your CRM data. It's vital that all customer details are kept up to date. A template won't fix bad input.

The **DocTmpl** database table represents an MDO list. The corresponding CRMScript carrier classes are `NSDocumentTemplate`and `NSDocumentTemplateEntity`.

## Why you as a developer should embrace templates

### Save time

When using templates, you won't have to add all the customer details manually to the physical documents. `CreateNewPhysicalDocumentFromTemplate()` is your friend!

### Prevent errors

With templates, you're less likely to get it wrong. And consequently, you have to spend less time hunting down and correcting mistakes.

You're also less likely to have to deal with wonky documents originating from the UI.

### Ensure consistency and sustainable CRMScripts

Brand-wise, you don't have to concern yourself with marketing style guides, because they're built into the templates.

## Find templates

### List all document templates with SearchEngine

SuperOffice includes some standard templates. You can find them as well as custom templates with SearchEngine.

```crmscript!
SearchEngine se;
se.addFields("DocTmpl", "DocTmpl_id,name,rank");
se.addCriteria("DocTmpl.record_type", "Equals", "2", "and", 0);
print(se.executeTextTable());
```

### Fetch all templates with the list agent

```crmscript
NSListAgent listAgent;
NSDocumentTemplate[] templateList = listAgent.GetDocumentTemplates();
```

### Fetch template info with the MDO agent

```crmscript
NSMDOAgent mdoAgent;
NSMDOListItem[] templateList = mdoAgent.GetList("doctmpl", false, "", false);
```

## Set template for document entity

```crmscript
NSDocumentAgent docAgent;
NSDocumentEntity doc = docAgent.CreateDefaultDocumentEntity();

NSDocumentTemplate tpl;
tpl.SetDocumentTemplateId(1);
doc.SetDocumentTemplate(tpl);

doc = agent.SaveDocumentEntity(doc);
```

## Filter documents by template

Like many MDO lists, templates can be grouped by headings, which get their labels from the [Heading table][2].

Thus the methods ending in `ByTemplateHeading()` target a group of templates whereas methods ending in `ByTemplateType()` target a single template.

### NSDocument[] GetDocumentsByTemplateHeading(Integer templateHeadingId)

Fetches **all** documents under this **heading**.

```crmscript
Integer templateHeadingId = 4;
NSDocumentAgent docAgent;
NSDocument[] docList = docAgent.GetDocumentsByTemplateHeading(templateHeadingId);
```

### NSDocument[] GetContactDocumentsByTemplateHeading(Integer contactId, DateTime start, DateTime end, Integer count, Integer templateHeadingId)

Fetches a limited number of documents within a time range for the given **contact** - filtered by template heading.

```crmscript
NSDocumentAgent docAgent;
DateTime start;
DateTime end;

NSDocument[] docList = docAgent.GetContactDocumentsByTemplateHeading(4, start.addMonth(-6), end, 10, 4);
```

### NSDocument[] GetContactDocumentsByTemplateType(Integer contactId, DateTime startTime, DateTime endTime, Integer count, Integer documentTemplateId)

Fetches a limited number of documents within a time range for the given **contact** - filtered by template ID.

```crmscript
NSDocumentAgent docAgent;
DateTime start;
DateTime end;

NSDocument[] docList = docAgent.GetContactDocumentsByTemplateType(4, start.addMonth(-6), end, 10, 106);
```

> [!TIP]
> To retrieve for a **person** rather than a contact, use `GetPersonDocumentsByTemplateHeading()` or `GetPersonDocumentsByTemplateType()`.

## Template variables

A *template variable* is a named placeholder that you can put in a document- or email template. When the template is applied, the variable is **substituted with the actual value**. For example, {name} translates to a company's name while {atln} is the last name of an associate. This lets you automate the personalization of content.

[List of variables][3]

> [!NOTE]
> The date and time in template variables are controlled by the PC's system clock.<br>The short and long date formats are determined by your computer’s settings.

### Substitute template variables

You can still benefit from variable substitution even if you don't use a pre-defined template. `SubstituteTemplateVariables()` will parse a source string and return it with templates substituted. The encoding stays the same (binary data will be returned in Base64).

The variables must have delimiters corresponding to the standard for the given generator encoding.

> [!NOTE]
> Non-text source data, such as the binary content of a Microsoft Word or Excel file, should be passed as Base64.

```crmscript!
NSDocumentAgent agent;

String source = "Hello, <cspn> at <name>";
Integer contactId = 2;

String result = agent.SubstituteTemplateVariables(source, 0, contactId, 0, 0, 0, 0, 0, 0, "");
print(result);
```

**Parameters, in order:**

| Parameter         | Type    | Description                               |
|:------------------|:--------|:------------------------------------------|
| source            | String  | original string with template variables   |
| generatorEncoding | Integer | encoding of input                         |
| contactId         | Integer | contact to get substitution data from     |
| personId          | Integer | person to get substitution data from      |
| appointmentId     | Integer | appointment to get substitution data from |
| documentId        | Integer | document to get substitution data from    |
| saleId            | Integer | sale to get substitution data from        |
| selectionId       | Integer | selection to get substitution data from   |
| projectId         | Integer | project to get substitution data from     |
| cultureName       | String  | for culture-sensitive data, such as dates or multi-language texts |

> [!TIP]
> Use an empty `cultureName` string to accept whatever current culture is set on the server. However, in multi-national organizations with a single server, set an appropriate value to avoid surprises.

## Reference

### Template types

| Type   | Description |
|:------:|:------------|
| 0      | unknown     |
| 2      | document    |
| 3      | email       |
| 4      | fax         |

Types 1, 5, and 6 are not used for *document* templates.

### Frequently used fields

| Field       | Description                             |
|:------------|:----------------------------------------|
| DocTmpl_id  | ID                                      |
| name        | as shown in lists                       |
| rank        | for sorting                             |
| record_type | type                                    |
| direction   | 0 = unknown, 1 = incoming, 2 = outgoing |

> [!NOTE]
> `name` refers to the label displayed in the GUI and not the physical filename of the template.

For a complete list of fields, see the [database reference][4].

### Common encoding

| Value | Description    |
|:-----:|:---------------|
| 0     | Plain text     |
| 1     | HTML           |
| 2     | XML            |
| 3     | Microsoft Word |
| 10    | Adobe PDF      |

See the [full list of encodings][5].

<!-- Referenced links -->
[1]: ../parser-and-templates/reply-template.md
[2]: ../../../database/docs/tables/heading.md
[3]: ../../../superoffice-docs/docs/document/templates/index.md
[4]: ../../../database/docs/tables/doctmpl.md
[5]: ../../../data-access/docs/api-reference/netserver/core/SuperOffice.Data.GeneratorEncoding.yml
