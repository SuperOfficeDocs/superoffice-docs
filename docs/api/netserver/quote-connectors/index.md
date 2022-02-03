---
title: ERP Quote Connector Interface
uid: quote_connectors
description: ERP Quote Connector Interface
author: {github-id}
so.date:
keywords:
so.topic: concept
---

# ERP Quote Connector Interface

The SuperOffice Quote Management system is based on an architecture that allows connection to several ERP systems. This is facilitated through a set of **Quote Connectors**. A quote connector provides specific data and business logic for the ERP system in question. It communicates with SuperOffice through a set of APIs. SuperOffice relies on partners to develop all connectors.

> [!NOTE]
> SuperOffice will certify all available connectors, but will not distribute them or offer them as part of our standard price list.

![interfaces][img1]

![quote database][img2]

[!include[License requirement](../../includes/req-sales-prem.md)]

## Architecture

The *\<SpesificERP>QuoteConnector.DLL* is loaded into the SuperOffice client when the SuperOffice client starts. The information needed to connect to the ERP system is set up and stored in the SuperOffice database first.

![01][img3]

(BaaN ERP system)

## Files

* **SoDatabase.dll** – Contains the business logic and the implementation of the core functionality. It changes with every major and minor release of SuperOffice.

* **SuperOffice.Plugins.Dll** – Contains the interface definitions and data carriers used by the interface. It changes rarely, and then only additions. The goal is that ERP plugins only need to reference the *plugins.dll* so that they are compatible across minor and major releases of SuperOffice.

* **Erp.QuoteConnector.Baan.dll** – Contains the implementation of the `IQuoteConnector` interface defined in *SuperOffice.Plugins.dll*. This DLL should be compatible across minor releases of SuperOffice as long as it does not reference the *SoDatabase.dll* directly.

## The SuperOffice Quote Management API

The API will be implemented as an interface named `IQuoteConnector`, of which an ERPConnector can implement one or more functions. By overloading either `BaseQuoteConnector` or `QuoteConnectorExtender` you get to only overload the parts you want to change.

Functions that we expect to vary between ERP systems we will make available for queries via capability checks. For example, not all connectors will support the creation of orders, so SuperOffice will first check that the capability is available by calling `CanProvideCapability("iorderconsumer_place_order")`.

## Some facts

* A SuperOffice installation can have, 0, 1, or many ERP connectors at the same time. Many large companies have more than one ERP system. (Typically divided over country borders.)

* The connector should be completely without a user interface. It might be run at a server far, far away, far away from the user, by both Windows and Web clients.

* A connector must be installed and configured by the administrator.

* The system will allow the administrator to set up which salesmen shall have access to which ERP clients. If a salesman has access to more than one system, he will be asked which one he wants to use when he creates a quote.

* Since not all connectors will be able to support all functionality, and we don’t want to accept the least common denominator, the connector should be query-able; SuperOffice shall be able to query the connector about its capabilities.

* SuperOffice shall report to the connectors the language the user is running in, and will strongly request that the responses are translated as far as possible (especially the user error responses).

## Company Policy Preferences

SuperOffice Quote system can be configured to enable the various features available:

* Alternatives – available or not.
* Versioning – used or not.
* Discounts on total order amount – or only online items.

## Other company policy rules

See QuoteConnectorExtender chapter for a simple way of adding a specific rule for an installation without having to recompile the whole ERP connector.

## Parts

The system is implemented as one interface, but has some parts:

* **Quote Connector Setup:** Configure the connection to the ERP system. Provides meta-data about connection properties.

* **Basic Connector:** Handles the connection to the ERP system and the work of keeping the ERP system informed about the Quote.

* **Product Provider:** Search products and price lists.

* **Price Provider:** Calculates the discount on a single quoteline and a complete quote.

* **Order Consumer:** Accepts a quote and creates an order in the ERP system.

* **Address Provider** Some ERP systems will be able to supply the default addresses for a quote/order.

* **Product Search Provider:** A set of functions to be able to do more complex searches.

## Config values

Configuration fields can be declared to be one of a number of different types, using the `FieldMetadataInfo`. However, they are always transmitted as strings; and to do the conversion between strongly typed value and string we use the SuperOffice.Globalization.CultureDataFormatter class. Use the ParseXXX methods from the same class to get back to the correct type (int, datetime, etc).

<!-- Referenced images -->
[img1]: media/interfaces.png
[img2]: media/quotedatabase.png
[img3]: media/image001.png
