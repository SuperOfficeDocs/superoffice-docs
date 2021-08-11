---
uid: crmscript_ref_InvoiceEntry_getDiscountMoney
title: InvoiceEntry.getDiscountMoney()
intellisense: InvoiceEntry.getDiscountMoney
sortOrder: 435
keywords: getDiscountMoney()
so.topic: reference
---

# InvoiceEntry.getDiscountMoney()

This method will get the discount of the current InvoiceEntry object in money.
It will be returned as a String-representation of a number with 2 decimals
accuracy.
The save-function calculates the discount in percent and money.
So if the discount is set in percent (setDiscount()), you have to save the
invoiceentry before getting the corresponding value in money with this function.

* **Returns:** The discount in money

