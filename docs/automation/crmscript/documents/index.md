---
title: Documents
SortOrder: 30
uid: crmscript_docs
---

Letters, memos, sale proposals, order confirmations, terms & conditions - there's a huge amount of **documents** pertaining to customer relations. This section takes a deep dive into how to manage those documents with CRMScript.

> [!NOTE]
> Don't confuse *document* entities with documents in the customer service knowledge base or entities connected to Super Office Quote!

## Document properties vs. the file itself

Information **about** the document is stored in the [document table](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-document.htm) and managed through the `NSDocumentAgent` and its corresponding carriers.

The document **files** we are dealing with here are stored in a central repository (so_arc).

## Documents vs. activities

Documents are part of a broader group of entities labeled **activities**:

* follow-ups
  * [appointment](../follow-ups/appointment.md)
  * [task](../follow-ups/task.md)
  * [call](../follow-ups/call.md)
* documents
  * document (this section)
  * email
* mailings and form submissions
* chat sessions

> [!NOTE]
> It is important to understand the distinction between activities and documents. When you get data from the [appointment table](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-appointment.htm) or use the CRMScript [NSAppointment class](https://community.superoffice.com/documentation/SDK/SO.Customer.Service.Support/html/CRMScript-Classes-NSAppointment-NSAppointment.htm), it is crucial that you pay attention to the **type** field.

There's always a corresponding appointment record for a document. You can navigate the relation between them in both directions. Each document-type appointment record has a corresponding document record - always. However, the document-type appointments are not visible in the UI and they should not be mistaken for **linked activities**.

## Documents vs. other entities

When working with documents, data will often intersect with the following entities:

* [company](../persons-and-organizations/company.md) (contact table)
* [contact](../persons-and-organizations/customer.md) (person table)
* [follow-ups](../follow-ups/index.md) (appointment table)
* project
* [sale](../sales/index.md)

## In this section

1. autolist
