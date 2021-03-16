---
title: blogic_attachment
description: Attachment
author:
so.date:
keywords:
so.topic: reference
---

# Attachment

This element adds the attachment field to your screen.

## Configuration

| Setting      | Description                             |
|:-------------|:----------------------------------------|
| label        | UI label                                |
| multiple     | Allows uploading of several attachments |
| noHardDelete | Whether to delete the actual attachment from the database, or only from the attachment component |

## Example

```crmscript
label = Attachments
multiple = true
```

## Functions

### setValue(String ids)

The string should contain a comma-separated list of attachment IDs.

### setFieldValue(String action, Map values)

| Action        | Map keys     | Description                          |
|:--------------|:-------------|:-------------------------------------|
| addAttachment | attachmentId | Adds an attachment with the given ID |

> [!TIP]
> To add multiple attachments, use `setFieldValue` once for each attachment.

### toInteger()

Returns the ID of a field as a number

### toString()

Returns a comma-separated list with the IDs of all attachments.
