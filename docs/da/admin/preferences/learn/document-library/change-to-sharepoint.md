---
uid: help-da-document-library-change-to-sharepoint
title: Konfigurer SharePoint-dokumentbibliotek
description: Konfigurer SharePoint-dokumentbibliotek
author: SuperOffice RnD
so.date: 03.21.2023
keywords: dokument, SharePoint
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Konfigurer SharePoint-dokumentbibliotek

> [!NOTE]
> Før du kan starte denne konfiguration, skal du konfigurere dit SharePoint-websted, dine biblioteker og dine tilladelser. Alle brugere skal godkende ved hjælp af Microsoft 365.

Når du konfigurerer dit nye dokumentbibliotek, viser administratoren en mellemliggende tilstand.

Når du er færdig og har bekræftet, at du vil bruge SharePoint, ændres tilstanden i Administrator til Microsoft SharePoint Online.

Det er muligt at ændre nogle af indstillingerne i guiden senere

**Trin:**

1. [!include[Open preferences](../includes/open-preferences.md)]
2. Vælg fanen **Dokumentbibliotek**.
3. Klik på **Skift**. Siden opdateres med oplysninger om det forbundne SharePoint-websted. Ændringen er endnu ikke afsluttet.
4. Klik på **Fuldfør ændringen** for at bekræfte, at du vil bruge SharePoint som standarddokumentbibliotek. Ændringen er nu fuldført.
5. Klik på **Indstillinger**.
6. Udfør de fire trin i konfigurationsguiden, der er beskrevet nedenfor.

## Trin 1 – Websteder og mapper

I dette trin skal du konfigurere placering, mapper og filnavne til dine SuperOffice-dokumenter og -skabeloner.

### SuperOffice-dokumenter – placering, mapper og filnavne

* **Websted i SharePoint**: Vælg dit websted på listen.
* **Dokumentbibliotek**: Vælg biblioteket på listen.
* **Mappestruktur**: Vælg den foretrukne mappestruktur (mappenavne).
* **Organiser mapperne i årlige undermapper**: Vælg denne indstilling for at tilføje undermapper pr. år.
* **Filnavn**: Vælg den foretrukne navngivning af filer.

### SuperOffice-dokumentskabeloner – placering

* **Websted i SharePoint**: Vælg dit websted på listen.
* **Dokumentbibliotek**: Vælg biblioteket på listen.

Klik på **Næste trin** for at fortsætte.

## Trin 2 – Dokumentegenskaber

På dette trin skal du vælge, hvilke dokumentfelter der skal overføres som dokumentegenskaber fra SuperOffice til SharePoint.

> [!NOTE]
> Vi anbefaler, at du vælger alle tilgængelige felter. Disse felter vises som kolonner i SharePoint-dokumentbiblioteket.

Disse felter kan bruges til at oprette visninger i dit SharePoint-dokumentbibliotek. Du kan også søge efter og gruppere efter disse felter i SharePoint. Specifikke felter kan skjules, hvis det er nødvendigt.

> [!NOTE]
> For at opretholde ændringer i dokumenter i SuperOffice skal vi gemme felternes id. Id-kolonner kan skjules i dine SharePoint-dokumentvisninger.

Klik på **Næste trin** for at fortsætte.

## Trin 3 – Grupper og adgang

På dette trin kan du aktivere gruppeadgang til SharePoint-dokumenter baseret på indstillingerne "Synlig for" i SuperOffice.

Hvis du planlægger ikke at bruge "Synlig for", skal du ikke vælge denne indstilling.

1. Vælg **Aktivér gruppeadgang på SharePoint-dokumenter baseret på indstillingerne "Synlig for" i SuperOffice**.

2. For at angive tilladelser til dokumenter i SharePoint har vi brug for læse-/skrivetilladelser til det valgte websted. Dette er en engangsgodkendelse og omfatter kun det websted, du valgte til dine SuperOffice-dokumenter.

    > [!NOTE]
    > Kun en global Microsoft 365-administrator kan godkende disse tilladelser. Derudover skal den globale Microsoft 365-administrator være medlem af ejergruppen af webstedet, da der kræves tilladelser til webstedsejer for at angive læse-/skrivetilladelser.

    Gør ét af følgende:

    * Hvis du er Microsoft 365 Global Administrator: Klik på **Godkend nu** for at godkende.

    * Hvis du IKKE er Microsoft 365 Global Administrator: Klik på **Kopiér URL-adressen til godkendelse**, og send den til en Microsoft 365 Global-administrator i din organisation.

3. Hvis du skal vente på en godkendelse, har du følgende muligheder:

    * Klik på **Gem og luk** for at fortsætte konfigurationen sent. Sideteksten opdateres for at angive, at godkendelsen afventer.

    * Klik på **Kontroller status igen** for at se, om Microsoft 365 Global Administrator har godkendt appen.

4. For hver SuperOffice-brugergruppe skal du vælge den matchende brugergruppe i SharePoint. Alle SuperOffice-brugergrupper skal tilknyttes, før du kan gå til næste trin.

5. Klik på **Næste trin** for at fortsætte.

## Trin 4 – Gennemgå og bekræft

Gennemgå konfigurationen omhyggeligt, og sørg for, at indstillingerne er korrekte.

Når du har bekræftet indstillingerne, kan de ikke redigeres:

SuperOffice-dokumenter

* Websted i SharePoint
* Dokumentbibliotek

SuperOffice-dokumentskabeloner

* Websted i SharePoint
* Dokumentbibliotek

Klik på **Bekræft**, når du er færdig.

## Relaterede emner

* [SharePoint-dokumenter][1] – teknisk oversigt

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/index.html

<!-- Referenced images -->
