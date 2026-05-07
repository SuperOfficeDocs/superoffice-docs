---
uid: help-no-utm-parameters
title: UTM-parametere
description: UTM-parametere
keywords: UTM-parametere, kobling, kampanje, sporing, SuperOffice Marketing
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: concept
category: marketing
topic: conversion
license: marketingpremium
tier: plus
audience: person
audience_tooltip: SuperOffice Marketing
language: no
---

# UTM-parametere

Det finnes fem standard UTM-parametere du kan legge til på slutten av kampanjekoblingene dine:

## Standard UTM-parametere

| Parameter | Hva den forteller deg | Eksempelverdier | Analogi |
|---|---|---|---|
| **utm_source** | Identifiserer hvor trafikken kom fra. Hjelper deg å se hvilken plattform eller henviser som førte besøkende til nettstedet ditt. | `google`, `linkedin`, `nyhetsbrev`, `messe` | Stedet de kom fra |
| **utm_medium** | Viser markedsføringskanalen eller metoden som ble brukt for å levere budskapet. | `epost`, `cpc`, `banner`, `organisk`, `arrangement` | Veien de tok |
| **utm_campaign** | Angir kampanjen, promoteringen eller temaet koblingen er knyttet til. | `vinter_salg`, `ebook_lansering`, `black_friday`, `q2_merkevareannonser` | Kjøretøyet de brukte |
| **utm_term** | Fanger opp det betalte søkeordet brukt i søkeannonser som førte til besøket. | `crm+programvare`, `markedsforings+automatisering` | Veiskiltet som guidet dem |
| **utm_content** | Skiller flere koblinger eller kreative elementer innenfor samme annonse eller kampanje. | `cta_knapp`, `toppbanner`, `tekstkobling_a` | Filen de valgte |

## Beste praksis for UTM-navngivning

Følg disse retningslinjene for å sikre konsekvent og nøyaktig UTM-sporing i SuperOffice og analyseverktøy.

* **Kun små bokstaver:** Bruk små bokstaver for alle UTM-verdier for å unngå dupliserte oppføringer.
* **Bruk understrek eller bindestrek:** Velg ett skilletegn og bruk det konsekvent (for eksempel `webinar_sept2025`).
* **Dokumenter strukturen din:** Lag en enkel guide slik at alle i teamet merker koblinger på samme måte.
* **Automatiser tagging:** Bruk et UTM-byggerverktøy for å redusere manuelle feil og sikre at konvensjonen følges.
* **Revider jevnlig:** Sjekk analyseverktøyene dine for inkonsekvenser og rydd opp ved behov.
* **Bruk et konsekvent navneformat:** Bli enige om et kampanjenavnformat og bruk det på alle koblinger.

**Eksempel på kampanjenavn:**
`leadgen_smb_webinar_sept2025`

**Eksempel på sporings-URL:**
`https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=leadgen_smb_webinar_sept2025`

For å lære hvordan disse parameterne brukes til å måle lead-kilder i SuperOffice CRM, se [Konverteringssporing][1].

## Relatert innhold

* [Aktiver UTM-sporing for skjemainnsendinger][2]
* [UTM-bygger for SuperOffice-skjemaer][3]
* [Google Analytics Campaign URL Builder][4]
* [UTM Builder][5]

[1]: index.md
[2]: ../admin/set-up.md
[3]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: https://utmbuilder.net
