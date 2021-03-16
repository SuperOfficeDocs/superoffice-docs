---
title: blogic_anchor_line
description: Anchor line (link row)
author:
so.date:
keywords:
so.topic: reference
---

# Anchor line (link row)

This element will display a horizontal line of clickable URLs.

## Configuration

| Setting          | Description                                       |
|:-----------------|:--------------------------------------------------|
| table            | Set to get a default set of URLs (v.4.0)<br>ticket, customer, person, company, cust_company, contact |
| items            | Array of items to display                         |
| items.length     | Number of items                                   |
| items.n.label    | The label of item n                               |
| items.n.url      | The URL of item n                                 |
| items.n.appendId | Whether to append the active ID to the URL (Bool) |
| items.n.iconUrl  | Custom icon to use (v. 4.0)                       |
| items.n.target   | Target of the URL (optional)                      |
| items.n.alt      | Alternative text (optional)                       |
| items.n.special  | Whether to check for special links (Bool)         |

## Example

```crmscript
table = customer
items.length = 2
items.0.label = New ticket
items.0.url = /bin/ticket?action=newTicket
items.1.label = New customer
items.1.url = /bin/ticket?action=newCustomer
items.0.iconUrl = /doc/icons/clickme.gif
```

## Functions

### getFieldValue(String field)

| Field                  | Description                                        |
|:-----------------------|:---------------------------------------------------|
| numEntries             | The number of anchors in the line                  |
| entry.n.icon           | The icon of entry n                                |
| entry.n.label          | The label of entry n                               |
| entry.n.url            | The URL of entry n                                 |
| entry.n.target         | The target of entry n                              |
| entry.n.warningMessage | The warning message of entry n                     |
| entry.n.disabled       | Whether the entry n is deactivated<br>1=yes, 0=no |

### setFieldValue(String action, Map values)

| Action   | Map keys               | Description                         |
|:---------|:-----------------------|:------------------------------------|
| addEntry | label<br>url<br>target<br>alt<br>icon<br>index<br>warningMessage<br>disabled<br>onClick | Adds an entry |
| delEntry | index<br>group        | Deletes the entry or group          |
