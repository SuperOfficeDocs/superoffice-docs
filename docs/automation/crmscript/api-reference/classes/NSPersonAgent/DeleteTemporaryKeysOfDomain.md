---
uid: crmscript_ref_NSPersonAgent_DeleteTemporaryKeysOfDomain
title: Void DeleteTemporaryKeysOfDomain(Integer domain, Integer personId)
intellisense: NSPersonAgent.DeleteTemporaryKeysOfDomain
keywords: NSPersonAgent, DeleteTemporaryKeysOfDomain
so.topic: reference
---

# Void DeleteTemporaryKeysOfDomain(Integer domain, Integer personId)

Delete all temporary keys for a given domain and person

**Parameters:**
 - **domain** The domain type to delete
     - Enum: 0 = Unknown 
     - Enum: 1 = MailingRecipient 
     - Enum: 2 = FormSubmitterRecipient 
     - Enum: 3 = ViewTicketInCustomerCenter 
     - Enum: 4 = LoginCustomerCenter 
     - Enum: 5 = PublicFaq 
     - Enum: 6 = ChangePasswordCustomerCenter 
 - **personId** The person for which to delete the keys
