---
title: services_soap_interface       
description: Services SOAP interface
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: concept
---

# Services SOAP interface

The reference guide to the SOAP interface of SuperOffice Service currently covers the Customer port which contains methods to cover the customer interface.

The structures passed and received from the methods are described in this document, but we recommend that you use the WSDL file as a reference to the methods and arguments when developing. If using a WSDL editor like the free CapeStudio 4.0 WSDL Editor (available from [www.capeclear.com][1] you will get an excellent overview of all methods and structures.

To access the WSDL file you enter the following URL: `http://[cs.mycompany.com]/scripts/SOAP?action=customer`

You replace the domain with your Service URL. *Customer* indicates that this is the *customer* port. For other ports alter this. For IIS, you might have to write *soap.exe* instead of *soap*.

All examples are written in C\# (Microsoft Visual Studio .NET), but it should be easy to convert this to any other language. All examples assume that there is a web reference named *customer*.

> [!NOTE]
> The words *ticket* and *request* are used interchangeably throughout the text.

## Learn more

* [Configuration][2]
* [Error codes][3]
* [Field types][4]
* [Notification types][5]
* [Compatibility][6]
* Port references: [Customer][7], [Ticket][9], [Admin][8]

<!-- Referenced links -->
[1]: http://www.capeclear.com/
[2]: config.md
[3]: error-codes.md
[4]: field-types.md
[5]: notification-types.md
[6]: compatibility.md
[7]: customer-port/index.md
[8]: admin-port/index.md
[9]: ticket-port/index.md
