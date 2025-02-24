---
uid: help-no-project-create
title: Opprette et nytt prosjekt
description: Slik oppretter du et prosjekt for bedre organisering i arbeidet ditt.
keywords: opprette prosjekt, nytt prosjekt, legg til prosjekt, prosjekt
author: Bergfrid Dias
date: 01.30.2025
version: 10.5.1
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Opprette et nytt prosjekt

Du kan opprette et prosjekt i SuperOffice CRM ved å bruke knappen **Ny** i toppraden. Se denne videoen, eller følg trinnene nedenfor:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/zLJwNll223w]

(videolengde – 2:49)

## Trinn

1. Klikk på **Ny** i toppraden, og velg **Prosjekt**.

1. Skriv inn et **prosjektnavn** (obligatorisk, markert i rødt).

    Hvis prosjektnavnet allerede finnes, vises dialogboksen **Duplikater** for å hjelpe deg med å unngå dobbeltregistrering.

    ![Prosjektbildet i redigeringsmodus, viser prosjektinformasjon -screenshot][img1]

1. Bruk det store tekstfeltet til å legge inn en detaljert beskrivelse av prosjektet.

1. Velg **Type** for prosjektet (obligatorisk). Verdiene er forhåndsdefinerte og satt opp i **Innstillinger og vedlikehold**.

1. **Valgfritt: Legg inn mer informasjon** i fanen **Prosjekt**:
    * Legg til en **Web-adresse** og tittel.
    * Velg en **Ansvarlig** for prosjektet.
    * Velg **Status** for prosjektet. Verdiene er forhåndsdefinerte i **Innstillinger og vedlikehold**.
    * Sett en **Sluttdato** ved hjelp av kalenderverktøyet.

1. **Legg til mer detaljer**:
    * Gå til fanen **Mer** for å [registrere egendefinerte felt][12].
    * Gå til fanen **Bilde** for å [laste opp og angi et prosjektbilde][2].
    * Gå til fanen **Notat** for å [legge til notater][11].
    * Gå til fanen **Koblinger** for å [knytte aktiviteter, salg, dokumenter eller nettsteder][10] til prosjektet.

1. Klikk på **Lagre** for å lagre prosjektet. Du er nå klar til å [legge til prosjektdeltakere][5].

## <a id="fields"></a>Forklaring av viktige felt

I prosjektkortet finner du flere felt. Noen fylles inn automatisk, mens andre krever manuell inntasting.

> [!NOTE]
> Felt og layout kan variere avhengig av konfigurasjonene i [Skjermdesigner][13] og andre UI-tilpasninger.

* **Prosjektnavn:** Hovedidentifikatoren for prosjektet. Dette er et obligatorisk felt.
* **Nummer:** Automatisk generert som neste tilgjengelige prosjektnummer hvis dette er satt opp i **Innstillinger og vedlikehold**. Kan redigeres manuelt om nødvendig.
* **Web-side:** Legg inn en URL med en kort beskrivelse av siden. Klikk utenfor tabellen eller trykk **TAB** for å lukke innskrivingsfeltet.
* **Beskrivelse:** Sammendrag av prosjektets mål, omfang eller hensikt. Valgfritt, men nyttig for å holde oversikt over prosjektets retning.
* **Ansvarlig:** Velg en person som er ansvarlig for prosjektet.
* **Type:** Forhåndsdefinerte prosjekttyper. Noen typer kan være knyttet til en [prosjektguide][1].
* **Status:** Spor prosjektets nåværende fase (f.eks. Planlagt, Under arbeid, Fullført). Hvis prosjektet er knyttet til en prosjektguide, vil spesifikke statuser vises i listen.
* **Sluttdato:** Angi prosjektets planlagte sluttdato. Kan justeres ved behov.
* **Neste milepæl:** Hvis prosjektet er knyttet til en prosjektguide, viser dette feltet datoen for neste planlagte oppfølging. Hvis ingen prosjektguide er koblet til, vises prosjektets sluttdato. Datoer før dagens dato vises i rødt.

[!include[3 udef](../../learn/includes/more-udef.md)]

## Duplikatkontroll

Hvis prosjektnavnet ligner på et eksisterende prosjekt, vil dialogboksen **Duplikater** hjelpe deg med å [unngå duplikater][6]. Gjennomgå forslagene og fortsett etter behov.

## Relatert innhold

* [Legg til eller endre et prosjektbilde][2]
* [Legg til prosjektdeltakere][5]
* [Redigere prosjekter][7]
* [Slå sammen prosjekter][8]
* [Slette prosjekter][9]
* [Prosjektguider][1]
* [Aktiviteter][3]

<!-- Refererte koblinger -->
[5]: project-members/add.md
[2]: add-image.md
[7]: edit.md
[8]: merge-projects.md
[9]: delete.md
[1]: project-guides.md
[3]: ../../learn/basics/activity.md
[6]: ../../learn/basics/duplicates.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md
[13]: ../../ui/screen-designer/learn/index.md

<!-- Refererte bilder -->
[img1]: ../../../media/loc/en/project/create-project.png
