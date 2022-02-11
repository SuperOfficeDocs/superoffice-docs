---
title: web-extensions
description: Web Extensions
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# Web Extensions

The **SuperOffice Web Extensions** is a local client that can be installed on the user's machine (without admin rights). It registers a couple of protocol handlers:

* **superoffice:** - used to display a particular soprotocol in the Windows or web client.
* **somail:** - used to display mail messages with the local viewer
* **superoffice-extensions:** - for communicating with the local client (trayapp). Used when downloading and uploading documents, displaying alarm popups.

The SuperOffice 7 Web Extensions, also referred to as **TrayApp**, is the tool that is responsible for downloading documents and showing off alarms to users.

The challenge is that web applications live inside a sand-box (Browser). Yet, we still need to support downloading of documents, allowing the user to make some modifications and make sure the document is sent back to the user.

The TrayApp receives events similar to the famous SoProtocol. All URLs starting with *superoffiece-extensions:* are routed directly to the TrayApp.

The TrayAppManager of SuperOffice.CRMWeb.dll is responsible for compiling superoffice-extensions protocols to TrayApp.

A request looks like this:

`superoffice-extensions:http://[WebInstallDir]/Services/TrayApp2.svc?Module=[ModuleName]&Version=2.0&UserId=[Associate]&Ticket=[Ticket]&Culture=en-US&SerialNumber=[…]&CompanyName=[…]`

The ModuleName can be either **sodwa** for documents or **alarm** for alarms.

Documents require an additional DocumentId like `&DocumentId=[DocumentId]`.
