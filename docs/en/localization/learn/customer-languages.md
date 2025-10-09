---
uid: help-en-languages
title: Customer languages
description: Customer languages
keywords: language
author: digitaldiina
date: 10.09.2025
version: 11.5
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
category: localization
topic: language
redirect_from: /en/admin/options/learn/custlang/index
language: en
---

# Customer languages

[!include[Requirement](../../learn/includes/req-cep.md)]

To offer great customer experience you need to support your customers in their local language when they visit your Customer centre and in the communication with the customer.

By [setting up extra languages][1] you make it easy for your customers to register, comment on and check the status of their requests in their preferred language. In addition, they will have access to all the FAQs in their chosen language.

## How SuperOffice selects the customer language for new contacts

When a new contact sends in a request, SuperOffice tries to decide which customer language should be shown for the contact.

### Scenario 1

1. John, a new contact, registers a new request in the customer centre cs.liberty.com with the email address `john@coca-cola.se`.

2. The new request is sent to the system, where John's email domain (coca-cola.se) is checked. coca-cola.se is registered as domain for the company Coca-Cola.

3. John is added as a new contact for Coca-Cola, instead of being added as a new contact without a company.

4. SuperOffice then checks if the email domain .se is linked to one of the registered customer languages. .se is registered as domain for the customer language Swedish.

5. The customer language for contact John is therefore set as Swedish.

6. SuperOffice sends a Swedish reply template (if created) to John, informing them that the request was received and registered.

7. John receives a user name and password from SuperOffice, and can log on to cs.liberty.com and access the Swedish version of SuperOffice Customer Centre. John will also have access to Swedish FAQs if this is set up in SuperOffice.

### Scenario 2

1. Maria, a new contact, registers a new request in the customer centre cs.liberty.com with the email address `maria@coca-cola.nl`.
2. SuperOffice checks the email domain and this is registered to the company Coca-Cola.
3. Maria is added as a new contact for Coca-Cola.
4. SuperOffice then checks if the email domain .nl is linked to one of the registered customer languages. The email domain .nl is *not* linked to a customer language and no customer language can therefore be decided for Maria.
5. Maria receives a reply template in the default language for their company. SuperOffice Customer Centre and FAQs are also shown in the default language.

### Scenario 3

1. Dutch is added as a new customer language in SuperOffice and linked to the domain .nl.
2. Maria does not automatically get Dutch as customer language. This must be done manually for the contact. Only new contacts are checked against new customer languages.

On installation, 6 customer language folders (DE, DK, EN, NL, NO and SE) were placed in the folder **\\templates** on the server. You must set up these customer languages yourself.

<!-- Referenced links -->
[1]: ../admin/add-customer-language.md

<!-- Referenced images -->
