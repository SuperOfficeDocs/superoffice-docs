---
title: PluginResponseInfo
uid: quote_connector_carrier_pluginresponseinfo
description: ERP Quote Connector Interface data carrier - PluginResponseInfo
author: SuperOffice Product and Engineering
date:
keywords: quote
content_type: reference
redirect_from: /en/api/netserver/plugins/quote-connectors/api/data-carriers/pluginresponseinfo
---

# PluginResponseInfo

PluginResponseInfo exists to be able to respond with more than just a true/false, but also an explanation. Such an explanation can be displayed on for instance a disabled **Place Order** button.

## Bool IsOk

Answer to the question / An indication of whether the operation went well.

## String UserExplanation

A localized explanation to the answer.
Example: US:"Text in English"; NO:"Text in Norwegian"; GE:"Text in German": FR:"Text in French"; and so on

## String TechExplanation

Always in English

## String ErrorCode

An error code, if available.
