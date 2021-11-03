---
uid: crmscript_docs
title: Documents
description: How to manage documents with CRMScript; document properties vs. the file itself
author: Bergfrid Skaara Dias
so.date: 11.02.2021
keywords: CRMScript, documents
so.topic: concept
---

# Documents

Letters, memos, sale proposals, order confirmations, terms & conditions - there's a huge amount of **documents** pertaining to customer relations. This section takes a deep dive into how to manage those documents with CRMScript.

> [!NOTE]
> Don't confuse *document* entities with documents in the customer service knowledge base or entities connected to Super Office Quote!

## Document properties vs. the file itself

Information **about** the document is stored in the [document table][1] and managed through the `NSDocumentAgent` and its corresponding carriers.

The document **files** we are dealing with here are stored in a central repository (so_arc).

## Documents vs. activities

Documents are part of a broader group of entities labeled **activities**:

* follow-ups
  * [appointment][2]
  * [task][3]
  * [call][4]
* documents
  * document (this section)
  * email
* mailings and form submissions
* chat sessions

> [!NOTE]
> It is important to understand the distinction between activities and documents. When you get data from the [appointment table][5] or use the CRMScript [NSAppointment class][6], it is crucial that you pay attention to the **type** field.

There's always a corresponding appointment record for a document. You can navigate the relation between them in both directions. Each document-type appointment record has a corresponding document record - always. However, the document-type appointments are not visible in the UI and they should not be mistaken for **linked activities**.

## Documents vs. other entities

When working with documents, data will often intersect with the following entities:

* [company][7] (contact table)
* [contact][8] (person table)
* [follow-ups][9] (appointment table)
* [project][11]
* [sale][10]

<!-- Referenced links -->
[1]: ../../../database/docs/tables/document.md
[2]: ../follow-ups/appointment.md
[3]: ../follow-ups/task.md
[4]: ../follow-ups/call.md
[5]: ../../../database/docs/tables/appointment.md
[6]: ../api-reference/CRMScript.NetServer.NSAppointment.yml
[7]: ../persons-and-organizations/company.md
[8]: ../persons-and-organizations/customer.md
[9]: ../follow-ups/index.md
[10]: ../sales/index.md
[11]: ../projects/index.md
