---
title: End of life - Future of SuperOffice.NetServer.Services package and SOAP web services
uid: eol-pagebuilder
description: An important update regarding our SOAP support (SuperOffice.NetServer.Services package and SOAP web services)
author: Tony Yates
so.date: 09.01.2023
keywords: SuperOffice.NetServer.Services, SOAP, EOL
so.topic: reference
so.version:
so.lang: en
so.envir: onsite
---

# Future of SuperOffice.NetServer.Services package and SOAP web services

At SuperOffice, we greatly value our ongoing partnership and collaboration with you. As we move forward on our journey to enhance and streamline our services, we wanted to provide you with an important update regarding our SOAP support.

While we understand that not all of our existing partners and integration customers will be able to make an immediate shift away from SOAP, we want to share our desire to gradually eliminate SOAP support within the **next few years**. This transition is part of our ongoing efforts to modernize our platform and enhance the overall experience for our users.

Our SOAP offering comprises two key components: the [SOAP proxy client][3] and the [web service endpoints][4].

## SOAP proxy client - SuperOffice.NetServer.Services

Our [SuperOffice.NetServer.Services package][6], which includes the SOAP proxy client for communication with SuperOffice WCF-based SOAP web services, has played a vital role in our journey thus far.

However, we have observed a significant decline in its usage since the introduction of the [RESTful-based proxy client][5], SuperOffice.WebApi. These two clients offer nearly identical functionality, with SuperOffice.WebApi adopting a RESTful protocol approach. While there are some nuanced differences, detailed information is available in our [SuperOffice Docs][2].

## Migration status

We are pleased to inform you that all SuperOffice applications have either completed their migration away from using the assemblies within the SuperOffice.NetServer.Services package or are currently in the process of doing so. This transition has also involved the move from .NET Framework to .NET Standard 2.0, where we replaced legacy NETFramework 4.8 WCF dependencies with CoreWCF.

## Eliminating SOAP support

As part of our ongoing efforts, we have a strong **desire to completely eliminate our SOAP offering when SuperOffice reaches version 12**. While we acknowledge that this transition may not be immediate for all partners and integration customers, it represents our vision for the future of our platform where we would like to offer services in alignment with current trends.

Your input and feedback are of great importance to us, and we believe in fostering a collaborative environment where your insights help shape our decisions. We understand that change can be challenging, and we are committed to supporting you throughout this transition.

We encourage you to [share your thoughts, concerns, and suggestions with us][1]. Your feedback will be instrumental in ensuring a smooth and effective transition away from SOAP.

Thank you for your continued trust and partnership with SuperOffice. Together, we can embrace this evolution in our technology stack and continue to deliver exceptional solutions to our customers.

Should you have any questions or require further information, please do not hesitate to reach out to us.

You can read and comment on the [original post][1] in the SuperOffice technical forum.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/forums/general-forums/announcements/future-of-superoffice.netserver.services-package-and-soap-web-services/
[2]: ../../docs/en/api/web-services/index.md
[3]: ../../docs/en/api/web-services/proxies/built-in.md
[4]: ../../docs/en/api/web-services/endpoints/soap/index.md
[5]: ../../docs/en/api/web-services/endpoints/rest-webapi/index.md
[6]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
