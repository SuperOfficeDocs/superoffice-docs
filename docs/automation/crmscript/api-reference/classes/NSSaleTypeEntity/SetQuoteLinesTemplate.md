---
uid: crmscript_ref_NSSaleTypeEntity_SetQuoteLinesTemplate
title: SetQuoteLinesTemplate(Integer quoteLinesTemplate)
intellisense: NSSaleTypeEntity.SetQuoteLinesTemplate
keywords: NSSaleTypeEntity, GetQuoteLinesTemplate
so.topic: reference
---

# SetQuoteLinesTemplate(Integer quoteLinesTemplate)

The template that this sale type should use when producing the product lines offer document; the template must have DocTmplQuoteType=QuoteLines

**Parameter:** 
 - **quoteLinesTemplate** Integer

```crmscript
NSSaleTypeEntity thing;
Integer quoteLinesTemplate;
thing.SetQuoteLinesTemplate(quoteLinesTemplate);
```

