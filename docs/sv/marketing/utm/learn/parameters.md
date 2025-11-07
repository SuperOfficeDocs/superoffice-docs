---
uid: help-sv-utm-parameters
title: UTM-parametrar
description: UTM-parametrar
keywords: UTM-parametrar, länk, kampanj, spårning, SuperOffice Marketing
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: concept
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# UTM-parametrar

Det finns fem standard UTM-parametrar som du kan lägga till i slutet av dina kampanjlänkar:

## Standard UTM-parametrar

| Parameter | Vad den visar | Exempelvärden | Liknelse |
|---|---|---|---|
| **utm_source** | Identifierar var trafiken kommer ifrån. Hjälper dig att se vilken plattform eller referens som skickade besökare till din webbplats. | `google`, `linkedin`, `nyhetsbrev`, `mässa` | Platsen de kom ifrån |
| **utm_medium** | Visar marknadsföringskanalen eller metoden som användes för att leverera budskapet. | `email`, `cpc`, `banner`, `organisk`, `event` | Vägen de tog |
| **utm_campaign** | Anger kampanjen, kampanjen eller temat som länken är kopplad till. | `vinter_sale`, `ebook_lansering`, `black_friday`, `q2_brand_ads` | Fordonet de använde |
| **utm_term** | Fångar det betalda sökordet som användes i annonser och ledde till besöket. | `crm+programvara`, `marketing+automation` | Skylten som ledde dem |
| **utm_content** | Skiljer flera länkar eller kreativa element i samma annons eller kampanj. | `cta_knapp`, `toppbanner`, `textlink_a` | Körfältet de valde |

## Bästa praxis för UTM-namn

Följ dessa riktlinjer för att säkerställa konsekvent och korrekt UTM-spårning i SuperOffice och analysverktyg.

* **Endast gemener:** Använd små bokstäver för alla UTM-värden för att undvika dubbletter.
* **Använd understreck eller bindestreck:** Välj en separator och använd den konsekvent (till exempel `webinar_sept2025`).
* **Dokumentera din struktur:** Skapa en enkel guide så att hela teamet taggar länkar på samma sätt.
* **Automatisera taggning:** Använd ett UTM-byggarverktyg för att minska manuella fel och upprätthålla konsekvens.
* **Granska regelbundet:** Kontrollera dina analyser efter inkonsekvenser och städa vid behov.
* **Använd ett konsekvent namnformat:** Kom överens om ett kampanjnamnformat och använd det på alla länkar.

**Exempel på kampanjnamn:**
`leadgen_smb_webinar_sept2025`

**Exempel på spårnings-URL:**
`https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=leadgen_smb_webinar_sept2025`

Läs mer om hur dessa parametrar används för att mäta leadkällor i SuperOffice CRM i [Konverteringsspårning][1].

## Relaterat innehåll

* [Aktivera UTM-spårning för formulärinlämningar][2]
* [UTM-byggare för SuperOffice-formulär][3]
* [Google Analytics Campaign URL Builder][4]
* [UTM Builder][5]

[1]: index.md
[2]: ../admin/set-up.md
[3]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: https://utmbuilder.net
