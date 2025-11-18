---
uid: help-da-utm-setup
title: Opsæt UTM-sporing
description: Lær, hvordan du aktiverer og bruger UTM-sporing i SuperOffice Marketing til at indsamle leadkilder.
keywords: aktiver UTM, konverteringssporing, leadkilde
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Opsæt UTM-sporing

UTM-sporing gør det muligt for SuperOffice at indsamle oplysninger om kilden, mediet og kampagnen, der genererede et lead. Denne opsætning sikrer, at hver formularindsendelse kan spores tilbage til den marketingaktivitet, der drev den.

Du skal udføre en **engangsopsætning** (af en administrator eller webudvikler) og derefter følge nogle **gentagne trin** for hver kampagne.

## Trinoverblik

| Trin | Hvem | Frekvens | Formål |
|---|---|---|---|
| **1. Aktivér overførsel af UTM-data** | Administrator | Én gang | Gør det muligt for formularer at indsamle UTM-data og gemme dem i CRM-felter. |
| **2. Tilføj UTM-sporingsscriptet til dit websted** | Webudvikler | Én gang | Muliggør vedvarende UTM-sporing på tværs af sider og sessioner. |
| **3. Opret kampagnelinks med UTM-parametre** | Markedsfører | For hver kampagne | Identificér, hvor trafikken kommer fra. |
| **4. Anvend linket i kampagner** | Markedsfører | For hver kampagne | Brug de mærkede links i annoncer, e-mails og sociale medier. |
| **5. Udgiv din formular korrekt** | Markedsfører | For hver kampagne | Sørg for, at formularen udgives på en måde, der opfanger UTM-data. |
| **6. Test og verificér opsætningen** | Markedsfører | Efter første opsætning og før hver kampagne | Bekræft, at sporing og datafangst fungerer. |
| **7. Analyser og visualisér resultater** | Markedsfører | Efter hver kampagne | Mål kampagneresultater i dashboards og rapporter. |

## <a id="enable"></a>1. Aktivér overførsel af UTM-data

**Hvem:** Administrator

**Hvornår:** Én gang

Aktivering af overførsel af UTM-data gør det muligt for SuperOffice at indsamle information om, hvor besøgende kom fra, da de indsendte en formular.

Dataene bliver tilgængelige på både **personkortet** og **formularindsendelsen**.

1. Gå til **Indstillinger og vedligeholdelse** > **Marketing**.
1. Aktivér **Overfør UTM-data ved formularindsendelser**.

    ![Siden Marketingindstillinger i SuperOffice Indstillinger og vedligeholdelse, der viser valgmuligheden for at aktivere UTM-dataoverførsel og instruktioner til at tilføje et UTM-sporingsscript. -screenshot][img1]

## <a id="script"></a>2. Tilføj UTM-sporingsscriptet til dit websted

**Hvem:** Webudvikler eller webansvarlig

**Hvornår:** Én gang

Dette script muliggør vedvarende sporing. Det opfanger UTM-parametre i URL'en og gemmer dem midlertidigt i browseren, så selv hvis en besøgende besøger flere sider, inden en formular indsendes, registreres første kontakt stadig.

1. Kopiér scriptet nedenfor.
1. Indsæt det i webstedets kode lige efter `<head>`-tagget.
1. Udgiv den opdaterede side.

```html
<!-- SuperOffice UTM tag -->
<script src="https://sod2.superoffice.com/CustXXXXX/cs/javascript/utm.js"></script>
```

> [!TIP]
> Uden scriptet indsamles UTM-data stadig for direkte formularlinks, men ikke for besøgende, der navigerer mellem sider før indsendelse.

## <a id="build-url"></a>3. Opret kampagnelinks med UTM-parametre

**Hvem:** Markedsfører

**Hvornår:** For hver kampagne

UTM-parametre identificerer, hvor dine besøgende kommer fra, og hvordan de interagerer med dine kampagner.

Du kan tilføje parametrene manuelt eller bruge et UTM-builderværktøj.

```text
https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=webinar_sept
```

Brug [SuperOffice UTM-builder til formularsider][1] eller [Googles Campaign URL Builder][4] for at oprette ensartede kampagnelinks og reducere manuelle fejl.

**Standardparametre:**
utm_source, utm_medium, utm_campaign, utm_term, utm_content

For beskrivelser og navngivningskonventioner, se [UTM-parametre][2].

## <a id="tag"></a>4. Anvend linket i dine kampagner

**Hvem:** Markedsfører

**Hvornår:** For hver kampagne

Brug linket, hvor du promoverer kampagnen, f.eks.:

* Blog-knapper
* Nyhedsbreve
* Facebook-annoncer
* Google Ads
* LinkedIn-opslag

## <a id="publish"></a>5. Udgiv formularen korrekt

**Hvem:** Markedsfører

**Hvornår:** For hver kampagne

SuperOffice kan opfange UTM-data, uanset om formularen er **indlejret** på dit websted eller **hostet** af SuperOffice.

| Metode | Beskrivelse | Opfanger første interaktion? |
|---|---|---|
| **Indlejret formular** | Tilføj scriptet på dit websted og brug en landingsside med UTM-links. | <i class="ph ph-check-circle" aria-hidden="true"></i> Ja |
| **SuperOffice-hostet formular (direkte link)** | Tilføj UTM-parametre til SuperOffice-formularens URL. | <i class="ph ph-warning-circle" aria-hidden="true"></i> Nej |

> [!TIP]
> Link ikke direkte fra dit websted til en SuperOffice-hostet formular, da UTM-tags vil gå tabt mellem sider.

## <a id="test"></a>6. Test og verificér opsætningen

**Hvem:** Markedsfører

**Hvornår:** Efter første opsætning og før hver ny kampagne

1. Klik på et af dine kampagnelinks.
1. Udfyld og indsend formularen.
1. Åbn det nye personkort i SuperOffice.
1. Bekræft, at felterne **kilde**, **medium** og/eller **kampagne** indeholder data.

Hvis data mangler, skal du tjekke, at:

* Scriptet er korrekt installeret.
* UTM-parametrene er stavet og formateret korrekt.
* Browsercookies ikke er blokeret eller slettet.

## <a id="analyze"></a>7. Analyser og visualisér resultater

**Hvem:** Markedsfører

**Hvornår:** Efter hver kampagne

Når data er indsamlet, kan du måle resultater i dashboards og rapporter.

* Se nye leads efter **første kontaktkilde**.
* Se nye leads efter **kampagne**.
* Opret en **dashboard-flise**, der viser nye leads efter kilde, medium eller kampagne for indeværende år.

Læs mere om dashboards i [Marketing-dashboards og rapporter][5].

[2]: ../learn/parameters.md
[1]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: ../../../dashboard/learn/show-leads.md

[img1]: ../../../../media/loc/en/marketing/conversion-tracking.png
