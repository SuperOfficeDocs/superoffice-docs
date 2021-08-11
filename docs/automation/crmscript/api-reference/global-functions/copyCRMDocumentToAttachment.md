---
title: Integer copyCRMDocumentToAttachment(Integer crmDocId)
description: Integer copyCRMDocumentToAttachment(Integer crmDocId)
intellisense: Void.copyCRMDocumentToAttachment
langref: 1
keywords: copyCRMDocumentToAttachment(Integer)
so.topic: reference
---

# Integer copyCRMDocumentToAttachment(Integer crmDocId)

This method will copy the content of a CRM Document, given the ID, to a new Service Attachment. There is no sync between these two, so only a copy at the point of time is made.

* **crmDocId:** The id of the CRM Document to copy
* **Returns:** Integer The id of the newly created Service Attachment
