---
uid: enum-ejscriptverb
title: Enum values for EjScriptVerb
description: Lists the enum values for EjScriptVerb.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# EjScriptVerb Enum

The verbs that are blocked when calling a ejscript over HTTP

| Name | Value | Description |
|------|-------|-------------|
|BlockNone|0|All verbs allowed|
|BlockGET|1|Block GET access|
|BlockPOST|2|Block POST access|
|BlockPUT|4|Block PUT access|
|BlockDELETE|8|Block DELETE access|
|BlockPATCH|16|Block PATCH access|
|BlockOPTIONS|32|Block OPTIONS access|
|BlockHEAD|64|Block HEAD access|
|BlockTRACE|128|Block TRACE access|
|BlockCONNECT|256|Block CONNECT access|
|BlockOTHER|512|Block OTHER, can be used for custom verbs|
|BlockAll|-1|No verbs are allowed|

## Usage

* [ejscript](../ejscript.md).blocked_verbs - ejscript
