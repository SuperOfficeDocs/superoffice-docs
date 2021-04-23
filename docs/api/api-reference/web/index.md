---
uid: soap-web-services
title: SOAP Web services

---

# SuperOffice Web Application API

The SuperOffice Sales & Marketing web-client can be customized in many different ways. The web-client is built using a reusable set of components. The web-client can be extended with new components and configured to use custom components. The SuperOffice Web Client [nuget package](https://www.nuget.org/packages/SuperOffice.Crm.Web/) adds the needed assemblies to extend the web client. This will also install the SuperOffice web services package and the SuperOffice Core package.

The web-client is built using the NetServer Services API layer, which enables the web-server to be run on a separate server from the business logic implemented in the web-services.

The web-client also uses the Dynamic Client Foundation (DCF) on top of the web services to handle globalization and to define the page builder infrastructure.

The major components in the Web GUI are:

* The [page builder framework](../../../../user-interface/docs/web-application/index.yml) used in CRM.web. This means the config files for the framework and the many components and interfaces that the PageBuilder uses.
* The page, panel, card and archive components used to render the pages.
* The AJAX libraries that integrate the web front end with the web server.