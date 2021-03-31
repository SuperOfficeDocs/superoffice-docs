---
title: crmscript_ref_NSPersonAgent_SetConsent
description: Void SetConsent(Integer personId, String purpose, String source, String legalBase, String comment)
intellisense: NSPersonAgent.SetConsent
keywords: NSPersonAgent,SetConsent
so.topic: reference
---

Set a specified type of consent on the person.

**Parameters:**
 - **personId** The person id
 - **purpose** The Key of the purpose this affects. e.g. 'STORE' or 'EMARKETING'.
 - **source** The Key of the source of this consent. e.g. 'USER', 'WEBFORM' or 'API'.
 - **legalBase** The Key of the legal base for this consent. e.g. '61A', '61B', '61F'
 - **comment** A comment regarding this consent. May be null or empty.
