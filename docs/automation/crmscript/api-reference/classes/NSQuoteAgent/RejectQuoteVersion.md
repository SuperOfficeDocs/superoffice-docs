---
uid: crmscript_ref_NSQuoteAgent_RejectQuoteVersion
title: ApproveRejectResponse RejectQuoteVersion(Integer quoteVersionId, String rejectedByText, Integer rejectedByAssociateId, String rejectionText)
intellisense: NSQuoteAgent.RejectQuoteVersion
keywords: NSQuoteAgent, RejectQuoteVersion
so.topic: reference
---

Rejects a quote version

**Parameters:**
 - **quoteVersionId** QuoteVersionId to approve.
 - **rejectedByText** 'Rejected by' prefix to RejectionText used when creating appointment task to log rejection. Must be passed since service does not know which language to use for 'Rejected By' string.
 - **rejectedByAssociateId** AssociateId of the associate who rejected the quote version.
 - **rejectionText** Rejection text.

**Returns:** Response of the the operation

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
String rejectedByText;
Integer rejectedByAssociateId;
String rejectionText;
ApproveRejectResponse res = agent.RejectQuoteVersion(quoteVersionId, rejectedByText, rejectedByAssociateId, rejectionText);
```

