---
uid: help-no-url-encoding
title: Url-koding
description: URL-koding i webpaneler
keywords: webpanel, URL-koding
author: digitaldiina
date: 10.13.2025
version: 11.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
language: no
index: true
---

# Url-koding

Nettlesere ber om sider fra webservere ved hjelp av en URL – **adressen til en nettside**.

Disse URL-ene kan kun sendes over Internett som ASCII-tegn. De inneholder imidlertid ofte tegn som ikke er ASCII, for eksempel *mellomrom*.

**URL-koding** konverterer den opprinnelige URL-en til riktig format. Når du legger til nye webpaneler, kan du velge URL-koding direkte fra en nedtrekksmeny.

## ANSI

Konverteringen erstatter usikre tegn med et prosenttegn (%) etterfulgt av 2 heksadesimale sifre. For eksempel blir mellomrom til *%20*. Altså:

* Tegn opptil 0x7F (127) sendes uendret
* Tegn fra 0x7F til 0xFF kodes

## Unicode

Konverteringen gjør om alle tegn til UTF-8 og setter et % foran hver tegns 1–3 byte lange heksadesimale verdi i henhold til RFC 2279.
