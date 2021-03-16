---
title: blogic_select_insert_text
description: Select insert text
author:
so.date:
keywords:
so.topic: reference
---

# Select insert text

This element is used to select a predefined text to insert into a message.

Text can be selected from FAQ entries, reply templates, and previous messages.

## Configuration

| Setting        | Description                                                      |
|:---------------|:-----------------------------------------------------------------|
| htmlEditorName | The name of the editor element this element will be connected to |
| customerId     | ID of customer to load into parser                               |
| onlyLeafNodes  | Whether only leaf nodes can be selected                          |

## Functions

### toString()

Returns the ID of the selected entry. The ID is prefixed depending on the type of the selected entry:

* doc.
* faq.
* msg.

### getFieldValue(String field)

| Field              | Description |
|:-------------------|:------------|
| selectedInsertText |             |
| attachmentIds      |             |

### setFieldValue(String action, Map values)

| Action                 | Map keys               | Description                                                        |
|:-----------------------|:-----------------------|:-------------------------------------------------------------------|
| selectInsertTextValues | ticketId<br>faqAccess<br>customerId<br>userId<br>attachmentIds | Sets different values. |

These keys are used to determine which entries can be selected.

The screen must include a CGI variable named `actionType` and set to 0, 1, or 2 for messages, FAQs, and customer and user parser variables to be included automatically.

**faqAccess:**

* 1 KB_ACCESS_PRIVATE
* 2 KB_ACCESS_INTERNAL
* 3 KB_ACCESS_PUBLIC_AUTHENTICATED (default)
* 4 KB_ACCESS_PUBLIC
