---
uid: sop-create-document
title: Create Document
description: How to create a Document using the soprotocol
keywords: soprotocol, document, create
author: Eivind Fasting
date: 11.26.2024
content_type: howto
category: customization
topic: soprotocol
redirect_from: /en/ui/soprotocol/howto/create-document
language: en
---

# Create document

The soprotocol should be on the format: ```soprotocol:document.main[new=true]?appointment_id=0&...other args...```

Refer to the [document arguments](#document-arguments) for full list of available properties/args.

## Create new document

```soprotocol:document.main[new=true]?document_id=0```

## Create new document with pre-selected documenttemplate_id equals 10

```soprotocol:document.main[new=true]?document_id=0&documenttemplate_id=10```

## Document arguments

The following arguments are supported when creating a new document:

| Property                     | Description                                                                         |
|------------------------------|-------------------------------------------------------------------------------------|
| `document_id`                | Document ID, if 0, a new document is created.                                       |
| `contact_id`                 | Set the current contact.                                                            |
| `person_id`                  | Set the current person.                                                             |
| `sale_id`                    | Set the current sale.                                                               |
| `project_id`                 | Set the current project.                                                            |
| `logicmode`                  | "default" or "sendandarchive"                                                       |
| `setvisiblefor`              | If true, use the same logic as if the preference "remember visible for" is enabled. |
| `suggesteddocument_id`       | Suggested document ID.                                                              |
| `email_item_id`              | If set, the document is created from this email.                                    |
| `email_attachment_id`        | Email attachment ID.                                                                |
| `savedreport`                | If true, create the document from a saved report.                                   |
| `reportid`                   | Report ID.                                                                          |
| `documenttemplate_id`        | The template to use for the document.                                               |
| `documentdate_name`          | The date of the document in C# "ticks".                                             |
| `documentheading_name`       | The heading of the document.                                                        |
| `documentfile_name`          | Filename to use.                                                                    |
| `documentforeignkey_name`    | Set a custom field in the document entity.                                          |
| `documentforeignkey_type`    | The value of the custom field defined above.                                        |
