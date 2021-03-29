---
title: crmscript_ref_InvoiceEntry_getValue_String_field
description: InvoiceEntry.getValue(String field)
intellisense: InvoiceEntry.getValue
sortOrder: 437
keywords: getValue(String)
so.topic: reference
---


Get the value of the specifed field.




###The following fields are available:###


 - messageId the id which this invoice entry is connected to
 - description the descriptive text of this invoice entry
 - type id of the type for this invoice entry
 - quantity the number of units invoiced
 - pricePrUnit price per unit (precision 2)
 - discount discount in percentage for this invoice entry (precision 2)
 - discountMoney discount in money (precision 2)
 - date the date for this invoice entry




###Parameter:###


 - field: Name of the field which contains the value


Returns the value of the field.


