---
uid: cs-soap-ports-customer
title: The Customer port
description: Services SOAP interface port reference - customer
keywords: customer port
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/customer/index
---

# The Customer port

This port is meant to provide all the methods needed to create your own customer portal using SOAP.

As many of the methods provide functionality only available when the customer is logged in, a **session key** is central in many of the methods. This key is retrieved from a successful call to `login()` and should be passed to `logout()` when the session is over. If a session is idle for too long (30 minutes), the session key will be deleted from the list of legal keys.

For the methods where the authorized customers have more rights than the non-authorized customers(such as `faq_findEntries()`), an empty session key can be passed to access the publicly available items or a legal key to access all.

## Methods

* [addAttachment][1]
* [addMessage][2]
* [checkPassword][3]
* [closeTicket][4]
* [deleteAttachment][5]
* [faqFindEntries][6]
* [faqFindEntries2][7]
* [faqGetCategory][8]
* [faqGetEntry][9]
* [faqGetGroupEntries][10]
* [faqGetMostPopularEntries][11]
* [faqGetMostReadEntries][12]
* [faqScoreEntry][13]
* [findTickets][14]
* [getAttachment][15]
* [getCategories][16]
* [getCategory][17]
* [getCompany][18]
* [getCustLangCategories][19]
* [getCustomer][20]
* [getErrorMessage][21]
* [getExtraFields][22]
* [getLanguages][23]
* [getMessage][24]
* [getPriorities][25]
* [getTicket][26]
* [login][27]
* [loginAsCustomer][28]
* [logout][29]
* [newCustomer][30]
* [newTicket][31]
* [sendPassword][32]
* [setCustomer][33]

<!-- Referenced links -->
[1]: addattachment.md
[2]: addmessage.md
[3]: checkpassword.md
[4]: closeticket.md
[5]: deleteattachment.md
[6]: faqfindentries.md
[7]: faqfindentries2.md
[8]: faqgetcategory.md
[9]: faqgetentry.md
[10]: faqgetgroupentries.md
[11]: faqgetmostpopularentries.md
[12]: faqgetmostreadentries.md
[13]: faqscoreentry.md
[14]: findtickets.md
[15]: getattachment.md
[16]: getcategories.md
[17]: getcategory.md
[18]: getcompany.md
[19]: getcustlangcategories.md
[20]: getcustomer.md
[21]: geterrormessage.md
[22]: getextrafields.md
[23]: getlanguages.md
[24]: getmessage.md
[25]: getpriorities.md
[26]: getticket.md
[27]: login.md
[28]: loginascustomer.md
[29]: logout.md
[30]: newcustomer.md
[31]: newticket.md
[32]: sendpassword.md
[33]: setcustomer.md
