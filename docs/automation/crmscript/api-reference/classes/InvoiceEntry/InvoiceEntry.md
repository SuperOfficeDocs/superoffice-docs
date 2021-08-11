---
uid: crmscript_ref_InvoiceEntry
title: InvoiceEntry
intellisense: Void.InvoiceEntry
sortOrder: 430
so.topic: reference
---

# InvoiceEntry

This class represent invoice entries. You will be able to create new or modify existing invoice entries with this class.

## Example

    InvoiceEntry i;
    
    i.setValue("description", "test");
    i.setValue("quantity", "1");
    i.setValue("pricePrUnit", "700");
    i.setValue("discount", "0.2");
    Date d; // Default value for date is today
    i.setValue("date", d.toString());
    i.save();
