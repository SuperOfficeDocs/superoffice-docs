---
uid: help-no-utm-setup
title: Konfigurer UTM-sporing
description: Lær hvordan du aktiverer og bruker UTM-sporing i SuperOffice Marketing for å fange opp lead-kilder.
keywords: aktiver UTM, konverteringssporing, lead-kilde
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: no
---

# Konfigurer UTM-sporing

UTM-sporing lar SuperOffice fange opp kilden, mediet og kampanjen som genererte et lead. Denne oppsettprosessen sikrer at hver skjemainnsending kan spores tilbake til markedsaktiviteten som førte til den.

Du må fullføre et **engangsoppsett** (utført av en administrator eller webutvikler) og deretter følge noen **gjentakende trinn** for hver kampanje.

## Oversikt over trinn

| Trinn | Hvem | Frekvens | Hensikt |
|---|---|---|---|
| **1. Aktiver overføring av UTM-data** | Administrator | Én gang | Gjør det mulig for skjemaer å fange opp UTM-data og lagre dem i CRM-felter. |
| **2. Legg til UTM-sporingsskriptet på nettstedet ditt** | Webutvikler | Én gang | Aktiver vedvarende UTM-sporing på tvers av sider og økter. |
| **3. Opprett kampanjekoblinger med UTM-parametere** | Markedsfører | For hver kampanje | Identifiser hvor trafikken kommer fra. |
| **4. Bruk den merkede koblingen i kampanjer** | Markedsfører | For hver kampanje | Bruk koblingen i annonser, e-poster og sosiale medier. |
| **5. Publiser skjemaet riktig** | Markedsfører | For hver kampanje | Sørg for at skjemaet er publisert slik at det fanger opp UTM-data. |
| **6. Test og verifiser oppsettet** | Markedsfører | Etter første oppsett og før hver kampanje | Kontroller at sporing og datainnsamling fungerer. |
| **7. Analyser og visualiser resultater** | Markedsfører | Etter hver kampanje | Mål kampanjeresultater i dashbord og rapporter. |

## <a id="enable"></a>1. Aktiver overføring av UTM-data

**Hvem:** Administrator

**Når:** Én gang

Å aktivere UTM-dataoverføring lar SuperOffice samle informasjon om hvor besøkende kom fra da de sendte inn et skjema.

Dataene blir tilgjengelige både på **personkortet** og på **skjemainnsendinger**.

1. Gå til **Innstillinger og vedlikehold** > **Marketing**.
1. Slå på **Aktiver overføring av UTM-data ved skjemainnsendinger**.

    ![Siden for markedsføringsinnstillinger i SuperOffice Innstillinger og vedlikehold, som viser alternativet for å aktivere UTM-dataoverføring ved skjemainnsendinger og instruksjoner for å legge til UTM-sporingsskript. -screenshot][img1]

## <a id="script"></a>2. Legg til UTM-sporingsskriptet på nettstedet ditt

**Hvem:** Webutvikler eller ansvarlig for nettstedet

**Når:** Én gang

Dette skriptet muliggjør vedvarende sporing. Det lytter etter UTM-parametere i URL-en og lagrer dem midlertidig i nettleseren, slik at selv om en besøkende blar gjennom flere sider før de sender inn et skjema, blir data om første interaksjon fortsatt registrert.

1. Kopier skriptet nedenfor.
1. Lim det inn i nettstedets kode rett etter `<head>`-taggen.
1. Publiser den oppdaterte siden.

```html
<!-- SuperOffice UTM tag -->
<script src="https://sod2.superoffice.com/CustXXXXX/cs/javascript/utm.js"></script>
```

> [!TIP]
> Uten skriptet fanges UTM-data fortsatt for direkte skjemakoblinger, men ikke for besøkende som beveger seg mellom sider før innsending.

## <a id="build-url"></a>3. Opprett kampanjekoblinger med UTM-parametere

**Hvem:** Markedsfører

**Når:** For hver kampanje

UTM-parametere identifiserer hvor besøkende kommer fra, og hvordan de samhandler med kampanjen.

Du kan legge til parametrene manuelt eller bruke et UTM-byggerverktøy.

```text
https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=webinar_sept
```

Bruk [SuperOffice UTM-bygger for skjemaer][1] eller [Googles Campaign URL Builder][4] for å lage konsistente kampanjekoblinger og redusere manuelle feil.

**Standardparametere:**
utm_source, utm_medium, utm_campaign, utm_term, utm_content

For beskrivelser og navnekonvensjoner, se [UTM-parametere][2].

## <a id="tag"></a>4. Bruk koblingen i kampanjer

**Hvem:** Markedsfører

**Når:** For hver kampanje

Bruk koblingen der du promoterer kampanjen, for eksempel i:

* Handlingsknapper på blogg
* Nyhetsbrev
* Facebook-annonser eller retargeting
* Google Ads
* LinkedIn-innlegg

## <a id="publish"></a>5. Publiser skjemaet riktig

**Hvem:** Markedsfører

**Når:** For hver kampanje

SuperOffice kan fange opp UTM-data enten skjemaet er **innebygd** på nettstedet ditt eller **hostet** av SuperOffice.

| Metode | Beskrivelse | Fanger første interaksjon? |
|---|---|---|
| **Innebygd skjema** | Legg til sporingsskriptet på nettstedet ditt og bruk en landingsside med UTM-merket URL. | <i class="ph ph-check-circle" aria-hidden="true"></i> Ja |
| **SuperOffice-hostet skjema (direktelenke)** | Legg til UTM-parametere i SuperOffice-skjemaets URL. | <i class="ph ph-warning-circle" aria-hidden="true"></i> Nei |

> [!TIP]
> Ikke koble direkte fra nettstedet ditt til et SuperOffice-hostet skjema, da UTM-tagger vil gå tapt mellom sider.

## <a id="test"></a>6. Test og verifiser oppsettet

**Hvem:** Markedsfører

**Når:** Etter første oppsett og før hver ny kampanje

1. Klikk på en av kampanjekoblingene dine.
1. Fyll ut og send inn skjemaet.
1. Åpne det nye personkortet i SuperOffice.
1. Kontroller at feltene **kilde**, **medium** og/eller **kampanje** inneholder data.

Hvis data mangler, sjekk at:

* Sporingsskriptet er korrekt installert.
* UTM-parametrene er stavet og formatert riktig.
* Nettleserens informasjonskapsler ikke er blokkert eller slettet mellom besøk.

## <a id="analyze"></a>7. Analyser og visualiser resultater

**Hvem:** Markedsfører

**Når:** Etter hver kampanje

Når data er fanget, kan du måle resultatene i dashbord og rapporter.

* Vis nye leads etter **første kontaktkilde** (hvilken kanal genererte trafikk).
* Vis nye leads etter **kampanje** (hvilken kampanje genererte konverteringer).
* Lag en **dashbordflis** som viser nye leads etter kilde, medium eller kampanje for inneværende år.

Les mer om dashbord i [Markedsføringsdashbord og rapporter][5].

[2]: ../learn/parameters.md
[1]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: ../../../dashboard/learn/show-leads.md

[img1]: ../../../../media/loc/en/marketing/conversion-tracking.png
