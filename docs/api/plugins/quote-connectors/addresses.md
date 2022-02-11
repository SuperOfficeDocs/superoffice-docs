---
title: Address Provider
uid: address_provider
description: Address Provider
author: {github-id}
so.date:
keywords: quote
so.topic: howto
---

# Address Provider

ERP systems often have addresses, and when creating a quote, the CRM system calls these to functions to get the default addresses (the user can change the addresses later if they should happen to be wrong).

## AddressInfo[] GetAddresses (QuoteAlternativeContextInfo context )

Gets both the invoice and the delivery addresses. This is normally based on the contact, but can also be based on the project.

* [0] = the invoice address
* [1] = the delivery address.

Always return an array, but the cell will be null if no address was found on one (or both).

If the connector returns NULL or does not support addresses, SuperOffice will use the contact’s street and postal addresses as defaults.
