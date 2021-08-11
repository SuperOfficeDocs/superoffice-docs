---
uid: crmscript_ref_InvoiceEntry_setValue_String_field_String_value
title: InvoiceEntry.setValue(String field, String value)
intellisense: InvoiceEntry.setValue
sortOrder: 441
keywords: setValue(String,String)
so.topic: reference
---

# InvoiceEntry.setValue(String field, String value)

This method will set a field of the current InvoiceEntry object with the given value.

## Available fields

 - messageId the id of the message which this invoice entry is connected to
 - description a description of the invoice entry
 - type the id of the type which this invoice entry will be saved as
 - quantity number of invoiced unites (this can be a float value)
 - pricePrUnit price pr. unit (this can be a float value of precision 2)
 - discount discount given in percentage (float value of precision 2). If discountMoney is also specified, this field will be ignored
 - discountMoney discount in money
 - date the date of the invoice entry

## Parameters

 - field: on of the above field
 - value: the value of the specified field

