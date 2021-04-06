---
uid: crmscript_ref_InvoiceEntry_getDiscount
title: InvoiceEntry.getDiscount()
intellisense: InvoiceEntry.getDiscount
sortOrder: 434
keywords: getDiscount()
so.topic: reference
---


This method will get the discount of the current InvoiceEntry object in percent.
It will be returned as a String-representation of a number with 2 decimals accuracy.
The save-function calculates the discount in percent and money.
So if the discount is set in money (setDiscountMoney()),  you have to save the invoiceentry before getting the corresponding value in percent.



* **Returns:** The dicount in percent.


