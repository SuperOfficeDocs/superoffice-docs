---
uid: crmscript-quote-order
title: Place order
description: Create order based on quote version
keywords: quote, sale, order, QuoteAgent
author: Bergfrid Dias
date: 06.12.2023
version: 10
topic: howto
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
* Should the sale be set to sold? (bool)
* Purchase order number
* Comment
* Culture (for culture-sensitive data, such as dates or multi-language texts)

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

<!-- Referenced links -->
[1]: ../../datatypes/string-type.md
[2]: ../document/index.md
