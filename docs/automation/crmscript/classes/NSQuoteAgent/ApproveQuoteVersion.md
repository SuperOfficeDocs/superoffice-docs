---
title: crmscript_ref_NSQuoteAgent_ApproveQuoteVersion
description: ApproveRejectResponse ApproveQuoteVersion(Integer quoteVersionId, String approvedByText, Integer approvedByAssociateId, String approvalText)
intellisense: NSQuoteAgent.ApproveQuoteVersion
keywords: NSQuoteAgent,ApproveQuoteVersion
so.topic: reference
---

Approves a quote version

**Parameters:**
 - **quoteVersionId** QuoteVersionId to approve.
 - **approvedByText** 'Approved by' prefix to ApprovalText used when creating appointment task to log approval. Must be passed since service does not know which language to use for 'Approved By' string.
 - **approvedByAssociateId** AssociateId of the associate who approved the quote version.
 - **approvalText** Approval text.

**Returns:** Response of the the operation

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
String approvedByText;
Integer approvedByAssociateId;
String approvalText;
ApproveRejectResponse res = agent.ApproveQuoteVersion(quoteVersionId, approvedByText, approvedByAssociateId, approvalText);
```

