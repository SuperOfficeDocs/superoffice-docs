---
uid: help-nl-url-encoding
title: Url-codering
description: URL-codering in webpanelen
keywords: webpaneel, URL-codering
author: digitaldiina
date: 10.13.2025
version: 11.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
language: nl
index: true
---

# Url-codering

Browsers vragen pagina's op van webservers met behulp van een URL – **het adres van een webpagina**.

Deze URL's kunnen alleen als ASCII-tekens via het internet worden verzonden. Ze bevatten echter vaak niet-ASCII-tekens, bijvoorbeeld *spatie*.

**URL-codering** zet de originele URL om naar het juiste formaat. Wanneer je nieuwe webpaneel toevoegt, kun je URL-codering rechtstreeks kiezen in een vervolgkeuzemenu.

## ANSI

De conversie vervangt onveilige tekens door een procentteken (%) gevolgd door 2 hexadecimale cijfers. Bijvoorbeeld, spatie wordt *%20*. Dus:

* Tekens tot 0x7F (127) worden onveranderd doorgegeven
* Tekens van 0x7F tot 0xFF worden gecodeerd

## Unicode

De conversie zet alle tekens om naar UTF-8 en voegt vervolgens % toe voor de hexadecimale waarde (1–3 bytes) van elk teken volgens RFC 2279.
