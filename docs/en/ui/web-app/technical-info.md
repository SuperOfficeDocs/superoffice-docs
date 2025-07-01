---
title: Technical information
uid: web_application_specs
description: Web GUI .Net API technical details
author: SuperOffice Product and Engineering
date:
keywords:
content_type: reference
platform: web
deployment: onsite
---

# Technical information

## Security

SuperOffice can be configured to run everything on the web server. This requires that the web server has direct access to the database, which can be dangerous. In a high-security setup, the web server is placed in a DMZ with direct access from the internet. The database server will then be placed inside your internal network, along with the application server - NetServer web services. The web server uses SOAP web-services to talk to the application server. The web server has no direct access to the database in this scenario.

Please read about [Server][1] and [Web client][2] system requirements for SuperOffice Web.

<!-- Referenced links -->
[1]: ../../onsite/requirements/iis.md
[2]: ../../onsite/requirements/web-client.md
