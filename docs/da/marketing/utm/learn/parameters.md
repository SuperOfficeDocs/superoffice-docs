---
uid: help-da-utm-parameters
title: UTM-parametre
description: UTM-parametre
keywords: UTM-parametre, kobling, kampagne, sporing, SuperOffice Marketing
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: concept
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# UTM-parametre

Der findes fem standard UTM-parametre, som du kan tilføje i slutningen af dine kampagnekoblinger:

## Standard UTM-parametre

| Parameter | Hvad den fortæller dig | Eksempelværdier | Analogi |
|---|---|---|---|
| **utm_source** | Identificerer, hvor trafikken kom fra. Hjælper dig med at se, hvilken platform eller henviser der sendte besøgende til dit websted. | `google`, `linkedin`, `nyhedsbrev`, `messe` | Stedet de kom fra |
| **utm_medium** | Viser den markedsføringskanal eller metode, der blev brugt til at levere budskabet. | `email`, `cpc`, `banner`, `organisk`, `event` | Vejen de tog |
| **utm_campaign** | Angiver kampagnen, promotionen eller temaet, som koblingen er tilknyttet. | `forars_salg`, `ebook_lancering`, `black_friday`, `q2_brand_ads` | Køretøjet de brugte |
| **utm_term** | Opfanger det betalte søgeord, der blev brugt i søgeannoncer, som førte til besøget. | `crm+software`, `marketing+automation` | Skiltet, der guidede dem |
| **utm_content** | Skelner mellem flere koblinger eller kreative elementer i den samme annonce eller kampagne. | `cta_knap`, `topbanner`, `tekstkobling_a` | Sporet de valgte |

## Bedste praksis for UTM-navngivning

Følg disse retningslinjer for at sikre ensartet og nøjagtig UTM-sporing i SuperOffice og analyseværktøjer.

* **Kun små bogstaver:** Brug små bogstaver til alle UTM-værdier for at undgå dubletter.
* **Brug understreg eller bindestreg:** Vælg ét separator-tegn og brug det konsekvent (for eksempel `webinar_sept2025`).
* **Dokumentér din struktur:** Opret en simpel vejledning, så hele teamet tagger koblinger på samme måde.
* **Automatisér tagging:** Brug et UTM-builderværktøj for at reducere manuelle fejl og sikre konsistens.
* **Revider regelmæssigt:** Tjek dine analyser for uoverensstemmelser og ryd op efter behov.
* **Brug et ensartet navneformat:** Aftal et kampagnenavnsformat og brug det på alle koblinger.

**Eksempel på kampagnenavn:**
`leadgen_smb_webinar_sept2025`

**Eksempel på sporings-URL:**
`https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=leadgen_smb_webinar_sept2025`

For at lære, hvordan disse parametre bruges til at måle lead-kilder i SuperOffice CRM, se [Konverteringssporing][1].

## Relateret indhold

* [Aktivér UTM-sporing for formularindsendelser][2]
* [UTM-builder til SuperOffice-formularer][3]
* [Google Analytics Campaign URL Builder][4]
* [UTM Builder][5]

[1]: index.md
[2]: ../admin/set-up.md
[3]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: https://utmbuilder.net
