---
title: Customer Centre
uid: customer-center
description: Customer Centre
author: SuperOffice Product and Engineering
date: 03.16.2023
keywords: Customer Center, CEP
content_type: concept
index: true
---

# Customer Centre

The Customer Centre in SuperOffice CRM is an out-of-the-box support portal, allowing your customers or partners to log in and interact with your support processes. They can post new requests, access their existing requests, modify their personal preferences, and access the Frequently Asked Questions database. All of this is standard functionality, with a visual look and feel that can easily be modified by changing the *framework.html* file.

However, the Customer Centre is also a platform for building more web pages, which allow you to expose parts of your CRM data to your customers and let them interact with them. By including your customers in your CRM processes, you can increase the efficiency of your organization. Instead of having your customers contact you by phone and email, and then updating your CRM data manually, you can save time by letting your customers access a subset of the data directly themselves. Pay attention, this is not out-of-the-box functionality, but rather something you can achieve by customizing your installation.

[!include[License requirement](../../../common/includes/req-cep.md)]

## The nature of a web form

Web forms, in contrast to Windows program's dialogs, are stateless. This means that between the initial form is sent to the client (browser), and the filled-out form is sent back to the server, there is no process waiting with all its variables in memory. This means that the form must contain all variables and parameters that are required to process it. If any of the fields contain an illegal value, we need to redisplay the form (with the fields filled out with supplied values) with an error message. Finally, when the form is posted with correct data, we should display a response or redirect the browser to somewhere else. This process can be illustrated like this:

![Web form flow -screenshot][img5]

As explained, the processes executed on the server (the black box) in this drawing are not connected in any way. Whatever state-like information we want to keep through this pipeline must be a part of the blue or red lines (the form posts and HTML pages returned).

## How do I sort messages in the Customer Center?

It is not possible to do it on the site. To sort requests on Customer Center, you need to perform the actions directly on the SuperOffice database under the CONFIG table.

1. Start the database utility (for example, Microsoft SQL Management Studio).
2. Locate the SuperOffice database and CONFIG table.
3. Under the "Flags" you can add 128 to the number that is already there from before (for example, 68 +128 = 196).

<!-- Referenced images -->
[img5]: media/image005.jpg
