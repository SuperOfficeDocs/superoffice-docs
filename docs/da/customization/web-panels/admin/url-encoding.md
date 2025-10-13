---
uid: help-da-url-encoding
title: Url-kodning
description: URL-kodning i webpaneler
keywords: webpanel, URL-kodning
author: digitaldiina
date: 10.13.2025
version: 11.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
language: da
index: true
---

# Url-kodning

Browsere anmoder om sider fra webservere ved hjælp af en URL – **adressen på en webside**.

Disse URL'er kan kun sendes over internettet som ASCII-tegn. De vil dog ofte indeholde ikke-ASCII-tegn, for eksempel *mellemrum*.

**URL-kodning** konverterer den oprindelige URL til det korrekte format. Når du tilføjer nye webpaneler, kan du vælge URL-kodning direkte i en rullemenu.

## ANSI

Konverteringen erstatter usikre tegn med et procenttegn (%) efterfulgt af 2 hexadecimale cifre. For eksempel bliver mellemrum til *%20*. Således:

* Tegn op til 0x7F (127) overføres uændret
* Tegn fra 0x7F til 0xFF bliver kodet

## Unicode

Konverteringen transformerer alle tegn til UTF-8 og præfikser derefter hver tegns 1–3 byte hexadecimale værdi med % i henhold til RFC 2279.
