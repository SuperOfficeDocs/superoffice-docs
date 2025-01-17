---
uid: help-no-document-library-change-to-sharepoint
title: Konfigurere SharePoint-dokumentbibliotek
description: Konfigurere SharePoint-dokumentbibliotek
author: SuperOffice RnD
so.date: 03.21.2023
keywords: dokument, SharePoint
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: no
---

# Konfigurere SharePoint-dokumentbibliotek

> [!NOTE]
> Før du starter konfigureringen, må du konfigurere SharePoint-området, -biblioteker og -tillatelser. Alle brukere må autentiseres ved hjelp av Microsoft 365.

Når du konfigurerer det nye dokumentbiblioteket, vil Admin vises i en mellomtilstand.

Når du er ferdig og har bekreftet at du vil bruke SharePoint, endres tilstanden i Admin til Microsoft SharePoint Online.

Det er mulig å endre noen av innstillingene i veiviseren senere.

**Trinn:**

1. [!include[Open preferences](../includes/open-preferences.md)]
2. Velg fanen **Dokumentbibliotek**.
3. Klikk på **Endre**. Siden oppdateres med informasjon om det tilkoblede SharePoint-området. Endringen er ennå ikke fullført.
4. Klikk på **Fullfør endringen** for å bekrefte at du vil bruke SharePoint som standard dokumentbibliotek. Endringen er nå fullført.
5. Klikk på **Innstillinger**.
6. Fullfør de fire trinnene i konfigurasjonsveiviseren, som beskrevet nedenfor.

## Trinn 1 - Områder og mapper

I dette trinnet må du konfigurere plassering, mapper og filnavn for SuperOffice-dokumenter og -maler.

### SuperOffice-dokumenter - plassering, mapper og filnavn

* **Område i SharePoint**: Velg området fra listen.
* **Dokumentbibliotek**: Velg biblioteket fra listen.
* **Mappestruktur**: Velg den foretrukne mappestrukturen (mappenavn).
* **Organiser mappene i undermapper per år**: Velg dette alternativet for å legge til undermapper per år.
* **Filnavn**: Velg den foretrukne navngivningen av filer.

### SuperOffice-dokumentmaler - plassering

* **Område i SharePoint**: Velg området fra listen.
* **Dokumentbibliotek**: Velg biblioteket fra listen.

Klikk på **Neste trinn** for å fortsette.

## Trinn 2 - Dokumentegenskaper

I dette trinnet må du velge hvilke dokumentfelt som skal overføres som dokumentegenskaper fra SuperOffice til SharePoint.

> [!NOTE]
> Vi anbefaler at du velger alle tilgjengelige felt. Disse feltene vises som kolonner i SharePoint-dokumentbiblioteket.

Disse feltene kan brukes til å lage visninger i SharePoint-dokumentbiblioteket. Du kan også søke og gruppere etter disse feltene i SharePoint. Det er mulig å skjule felt.

> [!NOTE]
> For å oppdatere endringer i dokumenter i SuperOffice, må vi lagre IDen til feltene. ID-kolonner kan skjules i SharePoint-dokumentvisninger.

Klikk på **Neste trinn** for å fortsette.

## Trinn 3 - Grupper og tilgang

I dette trinnet kan du aktivere gruppetilgang til SharePoint-dokumenter basert på innstillingen "Synlig for" i SuperOffice.

Hvis du planlegger ikke å bruke "Synlig for", velger du ikke dette alternativet.

1. Velg **Aktiver gruppetilgang på SharePoint-dokumenter basert på "Synlig for"-innstillinger i SuperOffice**.

2. For å angi tillatelser for dokumenter i SharePoint trenger vi lese-/skrivetillatelser for det valgte området. Dette er en engangsautorisasjon som bare inkluderer området du har valgt for SuperOffice-dokumentene dine.

    > [!NOTE]
    > Bare en Microsoft 365 Global Administrator kan autorisere disse tillatelsene. I tillegg må Microsoft 365 Global Administrator være medlem av eiergruppen av området, siden områdeeiertillatelser kreves for å angi lese-/skrivetillatelser.

    Gjør ett av følgende:

    * Hvis du er Microsoft 365 Global Administrator: Klikk på **Godkjenn nå** for å autorisere.

    * Hvis du IKKE er en Microsoft 365 Global Administrator: Klikk på **Kopier godkjennings-URL** og send den til en Microsoft 365 Global Administrator i organisasjonen din.

3. Hvis du må vente på autorisasjon, har du følgende alternativer:

    * Klikk på **Lagre og lukk** for å fortsette konfigurasjonen senere. Sideteksten oppdateres for å indikere at autorisasjon venter.

    * Klikk på **Kontroller status på nytt** for å se om Microsoft 365 Global Administrator har godkjent appen.

4. For hver SuperOffice-brukergruppe velger du den samsvarende brukergruppen i SharePoint. Alle SuperOffice-brukergrupper må tilordnes før du kan gå til neste trinn.

5. Klikk på **Neste trinn** for å fortsette.

## Trinn 4 – Gjennomgå og bekreft

Gjennomgå konfigurasjonen nøye og kontroller at innstillingene er riktige.

Når du har bekreftet innstillingene, kan de ikke redigeres:

SuperOffice-dokumenter

* Område i SharePoint
* Dokumentbibliotek

SuperOffice-dokumentmaler

* Område i SharePoint
* Dokumentbibliotek

Klikk på **Bekreft** når du er ferdig.

## Aktuelle emner

* [SharePoint-dokumenter][1] – teknisk oversikt

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/index.html

<!-- Referenced images -->
