---
uid: help-nl-utm-parameters
title: UTM-parameters
description: UTM-parameters
keywords: UTM-parameters, koppeling, campagne, tracking, SuperOffice Marketing
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: concept
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# UTM-parameters

Er zijn vijf standaard UTM-parameters die je aan het einde van je campagnekoppelingen kunt toevoegen:

## Standaard UTM-parameters

| Parameter | Wat het je vertelt | Voorbeeldwaarden | Vergelijking |
|---|---|---|---|
| **utm_source** | Geeft aan waar het verkeer vandaan komt. Helpt je te zien welk platform of welke verwijzer bezoekers naar je website heeft gebracht. | `google`, `linkedin`, `nieuwsbrief`, `beurs` | De plek waar ze vandaan kwamen |
| **utm_medium** | Toont het marketingkanaal of de methode die werd gebruikt om het bericht te bezorgen. | `email`, `cpc`, `banner`, `organisch`, `evenement` | De weg die ze namen |
| **utm_campaign** | Geeft de campagne, promotie of het thema aan waarmee de koppeling is verbonden. | `lente_sale`, `ebook_lancering`, `black_friday`, `q2_brand_ads` | Het voertuig dat ze gebruikten |
| **utm_term** | Registreert het betaalde zoekwoord dat in zoekadvertenties werd gebruikt en tot het bezoek leidde. | `crm+software`, `marketing+automation` | Het bord dat hen de weg wees |
| **utm_content** | Onderscheidt meerdere koppelingen of creatieve elementen binnen dezelfde advertentie of campagne. | `cta_knop`, `header_banner`, `tekstkoppeling_a` | De rijstrook die ze kozen |

## Best practices voor UTM-benaming

Volg deze richtlijnen om consistente en nauwkeurige UTM-tracking in SuperOffice en analysetools te garanderen.

* **Alleen kleine letters:** Gebruik kleine letters voor alle UTM-waarden om dubbele vermeldingen te voorkomen.
* **Gebruik underscores of koppeltekens:** Kies één scheidingsteken en gebruik dat consequent (bijvoorbeeld `webinar_sept2025`).
* **Documenteer je structuur:** Maak een eenvoudige handleiding zodat iedereen in je team koppelingen op dezelfde manier tagt.
* **Automatiseer tagging:** Gebruik een UTM-buildertool om handmatige fouten te verminderen en consistentie te waarborgen.
* **Controleer regelmatig:** Controleer je analyses op inconsistenties en ruim op waar nodig.
* **Gebruik een consistent naamgevingsformaat:** Kom overeen welk campagneformaat je gebruikt en pas dit toe op alle koppelingen.

**Voorbeeld campagnenaam:**
`leadgen_smb_webinar_sept2025`

**Voorbeeld tracking-URL:**
`https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=leadgen_smb_webinar_sept2025`

Lees hoe deze parameters worden gebruikt om leadbronnen te meten in SuperOffice CRM in [Conversietracking][1].

## Gerelateerde inhoud

* [UTM-tracking inschakelen voor formulierverzendingen][2]
* [UTM-builder voor SuperOffice-formulieren][3]
* [Google Analytics Campaign URL Builder][4]
* [UTM Builder][5]

[1]: index.md
[2]: ../admin/set-up.md
[3]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: https://utmbuilder.net
