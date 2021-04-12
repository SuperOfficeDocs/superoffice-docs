---
title: quote_scenario_cust_product_codes
description: Quote connector scenario - dealing with customer-specific product codes
author: {github-id}       
so.date:
keywords: quote
so.topic: guide
---

# Dealing with customer-specific product codes

Some, typically large, customers demand that you send quotes to them using the customer's product codes. How should you go about solving this with SuperOffice?

There must be an alias database somewhere that knows how to translate the product codes into customer codes. We call this the **Alias database**.

## Using fast search

When a user uses the fast search (that’s the "google" search in the **QuoteLine** dialog) he enters the proprietary customer alias "BOEING\_111".

1. Your connector sends a search to the Alias database to see if the customer + search word (-s) has a match.

2. That search returns a match on the "BOEING\_111" which is "Pcx\_222"

3. You then add the word "Pcx\_222" to the user input

4. Pass the changed user input to the SuperOffice connector.

5. The SuperOffice connector then returns a match on "Pcx\_222".

6. You then change the product code "Pcx\_222" in the result to the correct customer code "BOEING\_111".

7. The user sees that he found the "BOEING\_111" product and accepts it.

## Performance gains

* We assume that only a few of the customers have this issue. Perhaps you should therefore consider to mark a quote with if it is such a customer and only search the alias database if the customer has actual aliases.

* You could easily create what we call a partner table in SuperOffice and fill it with the alias data. Such a table would contain the following columns:

* id
* customerid
* customer alias
* your product code

It would automatically be transported onto travel if you configure it to do so. All you have to do is, like with the product register, to synchronize it regularly.

When it comes to the complex search, where the user can specify which fields they want to search in, you can make your own search provider. This provider could make it possible for you to allow the user to enter text into a search criterion you can call "Customer Code". It would then be easy to perform the correct search against the alias data store (whether internally to SuperOffice or externally) and present the user with a result that shows the customer code or whatever you need.
