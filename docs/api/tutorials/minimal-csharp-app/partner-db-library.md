---
title: Customer data source
uid: partner_db_library
description: Customer data source
author: {github-id}
keywords:
so.topic: tutorial
so.envir: cloud
so.client: online
---

# Customer data source

This project is a shared XML serialization data source that reads and writes customer data to an XML document.

The SuperOffice.DevNet.Online.SystemUser.PartnerDBLibrary project contains one customer model and one customer data source class.

## CustomerInfo customer model

The customer model CustomerInfo contains 6 properties that represent a single customer tenant.

[!include[ALT](./includes/customer-info.md)]

## CustomerDataSource class

The `CustomerDataSource` class could not be more simple. Its sole responsibility is to read CustomerInfo data from and save new CustomerInfo data to, an XML file. This project and data source classes are used by both the MVC website and the console application.

[!include[ALT](./includes/customer-data-source.md)]

## Earlier versions of this example

The first version of this example had an SQL Server dependency: A database with a single table to hold customer information was used as a means to share data between both the MVC application and the console service application.

This sharing proved to be cumbersome for those unfamiliar with SQL Server and over-complicated this example. This has since been replaced with another data source.
