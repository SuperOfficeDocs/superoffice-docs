---
uid: help-sv-url-encoding
title: Url-kodning
description: URL-kodning i webbpaneler
keywords: webbpanel, URL-kodning
author: digitaldiina
date: 10.13.2025
version: 11.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
language: sv
index: true
---

# Url-kodning

Webbläsare begär sidor från webbservrar med hjälp av en URL – **adressen till en webbsida**.

Dessa URL:er kan endast skickas över internet som ASCII-tecken. De innehåller dock ofta tecken som inte är ASCII, till exempel *mellanslag*.

**URL-kodning** konverterar den ursprungliga URL:en till rätt format. När du lägger till nya webbpaneler kan du välja URL-kodning direkt i en rullgardinsmeny.

## ANSI

Konverteringen ersätter osäkra tecken med ett procenttecken (%) följt av 2 hexadecimala siffror. Till exempel blir mellanslag *%20*. Så:

* Tecken upp till 0x7F (127) skickas oförändrade
* Tecken från 0x7F till 0xFF kodas

## Unicode

Konverteringen omvandlar alla tecken till UTF-8 och lägger till ett % före varje teckens 1–3 byte långa hexadecimala värde enligt RFC 2279.
