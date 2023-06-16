---
uid: enum-doctmplprivacytype
title: Enum values for DocTmplPrivacyType
description: Lists the enum values for DocTmplPrivacyType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# DocTmplPrivacyType Enum

Indicator that this document template has a functional role, related to privacy/GDPR

| Name | Value | Description |
|------|-------|-------------|
|None|0|This document template is in no way related to GDPR|
|PersonRegistered|1|This is a template for the 'you have been added to our system' kind of email; must be an .html email template|

## Usage

* [DocTmpl](../doctmpl.md).privacyDocType - DocTmpl list table. Describes templates available for writing new documents.
