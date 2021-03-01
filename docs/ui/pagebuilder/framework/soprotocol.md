---
title: soprotocol
description: SoProtocol
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# SoProtocol

The SuperState depends on the SoProtocol, which allows you to control the user interface without using scripts. The protocol gives you the possibility of sending a link to the user that will open another specific panel based on the information sent. If no SoProtocol is given, the last valid SuperState will be used.

The *SoContactPanel.config* file includes a lot of views. In the view defenition, it defines the type of the view and the soprotocol name for the view.

For example, soprotocol="udef", soprotocol="interest", and soprotocol="personarchive"

```XML
<view id="interests" type="SoView" soprotocol="interest" current="contact">
```

## Example

The URL `www.example.com/sixweb/default.aspx?contact.interest.personarchive` contains the SoProtocol name "interest", so this page will be shown on the web page.
