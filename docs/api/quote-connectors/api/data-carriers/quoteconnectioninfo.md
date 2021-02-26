---
title: quote_connector_carrier_quoteconnectioninfo
description: ERP Quote Connector Interface data carrier - QuoteConnectionInfo
author: {github-id}
so.date:
keywords: quote
so.topic: reference
---

# QuoteConnectionInfo

A Quote Connection is set up in the SuperOffice Admin client. It collects the parameters needed to talk to a single ERP client and gives it a name and an id.

Quote connections will be stored in the table "QuoteConnection" in the CRM database.

## int CRMConnectionId

Primary key in the CRM database.

Definition of a connection to an external system, for the Quote system.

## string ERPName

Name of the ERP system (programmatic).

## string ERPClientName

Name of the client (company) in the ERP system

## string ERPClientKey

The identifier for the client in the ERP system.

## String DisplayName

Connection name shown to user; multi-language support.

The name of the connector to display in a list so that the users can choose between them.

Typically the name of the client, with maybe the ERP system in parenthesis.

## string DisplayDescription

Tooltip/description shown to user; multi-language support.

Any other info available that would make an uncertain user chose the right connector.

Typically, used for tooltip.
