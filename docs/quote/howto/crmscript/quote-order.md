---
uid: crmscript_quote_order
title: 
author:
so.date:
keywords:
so.topic:
---

# Place order

Once the customer has accepted the quote, you can place the order.

## Create order based on quote version

To create an order, you have to select which alternative to use.

```crmscript!
NSQuoteAgent qa;
Integer quoteAlternativeId = 9;
NSPluginUrlResponse order = qa.PlaceOrder(quoteAlternativeId, true, "256", "fall campaign", "ENG");

if (order.GetIsOk()) {
  printLine("Order placed successfully! " + order.GetUrl());
}
```

### Parameters

* ID of the alternative to place the order on
* should the sale be set to sold? (bool)
* purchase order number
* comment
* culture (for culture-sensitive data, such as dates or multi-language texts)

> [!TIP]
> To place an order for an **archived** version of the quote, call `CreateAndSaveQuoteVersion()` passing the ID of the old version. Then get the quote alternative ID from the newly created copy (which is now the active version).

## Get the order confirmation document

### String GetOrderConfirmation(Integer quoteVersionId, Integer confirmationTemplateId)

Generates a base64-encoded stream (PDF). No permanent document is created or stored anywhere!

```crmscript!
NSQuoteAgent qa;
String orderConfirmation = qa.GetOrderConfirmation(1,1);

printLine(orderConfirmation.subString(0,20));
```

This example prints the 1st 20 characters of the stream.

> [!TIP]
> Learn more about [strings][1] and [documents][2].

## Order-related info you might want to set or check

### Accepted quote alternative

```crmscript!
NSQuoteAgent qa;
NSQuoteEntity quote = qa.GetQuoteEntity(11);
printLine(quote.GetAcceptedQuoteAlternativeId().toString());
```

### PO number

```crmscript!
NSQuoteAgent qa;
NSQuoteEntity quote = qa.GetQuoteEntity(11);
printLine(quote.GetPoNumber());
```

### Accepted by customer?

```crmscript!
NSQuoteAgent qa;
NSQuoteEntity quote = qa.GetQuoteEntity(11);
NSQuoteVersion version = qa.GetQuoteVersion(quote.GetActiveQuoteVersionId());
Integer state = version.GetState();

if (state == 9) {
  printLine("Accepted by customer");
}
else if (state == 8) {
  printLine("Rejected by customer");
}
else {
  printLine("quote not finalized yet");
}
```

### Mark sale as sold

```crmscript
NSQuoteAgent qa;
NSQuoteEntity quote = qa.GetQuoteEntity(11);

NSSaleEntity sale = saleAgent.GetSaleEntity(quote.GetSaleId());
sale.SetStatus(2);
sale = saleAgent.SaveSaleEntity(sale);
```

<!-- Referenced links -->
[1]: ../datatypes/string-type.md
[2]: ../documents/index.md
