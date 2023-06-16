---
uid: enum-doctmplquotetype
title: Enum values for DocTmplQuoteType
description: Lists the enum values for DocTmplQuoteType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# DocTmplQuoteType Enum

The role this document plays in the Quote system, if any

| Name | Value | Description |
|------|-------|-------------|
|None|0|This document template is in no way related to Quote Management|
|MailBody|1|This is a template for the offer mail body|
|MainDocument|2|This is a template for the main offer document, document instances will be referred through Quote.DocumentId|
|QuoteLines|3|This is a template for the AsposeWords merge process, generating the offer line details|
|ConfirmationMailBody|4|This is a template for the mail body of the order confirmation|
|ConfirmationLines|5|This is a template for the lines document that is an attachment to the confirmation mail|

## Usage

* [DocTmpl](../doctmpl.md).quoteDocType - DocTmpl list table. Describes templates available for writing new documents.
