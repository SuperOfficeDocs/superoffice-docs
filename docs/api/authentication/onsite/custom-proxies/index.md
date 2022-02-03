---
title: Authentication
uid: auth_onsite_custom_proxy
description: Authentication with NetServer web service custom proxies
author: AnthonyYates
so.date: 05.08.2018
keywords: authentication, SOAP
so.topic: concept
so.envir: onsite
# so.client:
---

# NetServer web service custom proxies

If you are not developing solutions using Microsoft .NET and can't reference the SuperOffice assemblies, you must rely on your technology stack to either generate SOAP proxies or roll your own.

In many cases, such as PHP and Python, applications depend on loading the WSDL file for interacting with SuperOffice web services. We make those files available for downloads along in the [SOAP web services API reference][1].

With the WSDL files and using a tool like SOAPUI, raw SOAP requests are sent to SuperOffice endpoints for testing. You can, for example, use SOAPUI or compose the SOAP request manually with Fiddler2:

## [SOAPUI](#tab/wsdl-1)

![soapui -screenshot][img5]

## [Fiddler2](#tab/wsdl-2)

![fiddler -screenshot][img6]

***

<!-- Referenced links -->
[1]: ../../../api-reference/soap/index.md

<!-- Referenced images -->
[img5]: media/services-authenticate-soapui.png
[img6]: media/services-authenticate-fiddler.png
