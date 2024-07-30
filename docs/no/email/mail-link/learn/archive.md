---
uid: help-no-mail-link-archive
title: Arkiver e-post til SuperOffice
description: Arkiver e-post til SuperOffice
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail Link
topic: howto
language: no
---

# Arkivere en e-post

Når du klikker på **Arkiver e-post**-knappen på verktøylinjen i e-postklienten vises en meny med arkiveringsalternativer.

> [!NOTE]
> Denne knappen vises også i e-postvinduet når du åpner en e-post du har mottatt.

**Alternativer:**

* [Arkivering av e-post på firmaer/personer][2]
* [Arkivering av e-post som aktiviteter][1]
* [Arkivere vedlegg][3]
* [Arkivering av e-post som saker][4]

For alle de forskjellige arkiveringsalternativene kan du velge alternativet **Advar meg når en e-post er større enn (i KB)** i [ruten **Generelle innstillinger**][5] i dialogboksen for **SuperOffice CRM-alternativer**. Når du prøver å arkivere en e-post som inneholder et vedlegg som er over den angitte grensen, vil en dialogboks informere deg om dette og spørre deg om du vil arkivere den likevel.

## Forskjeller mellom Outlook, Notes og SuperOffice CRM

Du kan opprette e-postmeldinger på flere forskjellige måter, både [fra Outlook][6] og [fra SuperOffice CRM][8]. Hvis dialogboksen **Dokument** vises, behandles e-postmeldingen som et SuperOffice-dokument og arkiveres. Hvis dialogboksen **Dokument** ikke vises, arkiveres e-postmeldingen basert på innstillingene i dialogboksen **SuperOffice CRM**.

Dialogboksen **Dokument** åpnes automatisk hvis du:

* Klikk på **Skriv**-knappen i SuperOffice CRM.

* Klikk på ned-pilen til høyre for **Ny e-post**-knappen på Microsoft Outlook-verktøylinjen og velg en av malene på undermenyen **SuperOffice-melding**.

Dialogboksen **Dokument** åpnes ikke automatisk hvis du:

* Klikk på **Ny e-post**-knappen i e-postklienten. E-postene vil imidlertid bli arkivert hvis **Arkiver e-post som standard når: opprettet fra e-postklienten**-alternativet i dialogboksen **SuperOffice CRM-alternativer** er valgt.

* Klikk på **E-post**-knappen i SuperOffice CRM. E-postene vil imidlertid bli arkivert hvis **Arkiver e-post som standard når: opprettet fra SuperOffice CRM**-alternativet i dialogboksen **SuperOffice CRM-alternativer** er valgt.

* Når du oppretter en e-post ved hjelp av **E-post**-knappen i SuperOffice CRM, er det mulig å bruke en forhåndsdefinert e-postmal som standard hvis alternativet **Bruk SuperOffice e-posttekst** i dialogboksen**SuperOffice CRM-alternativer** er valgt.

> [!NOTE]
> Dette gjelder også hvis du klikker på en e-postadresse i SuperOffice CRM, sender en e-post fra detaljkortet **Personer**, eller svarer på/videresender en e-post fra **Aktiviteter**.

## E-posten er allerede arkivert i SuperOffice CRM

Når en e-post arkiveres av en bruker, merkes den med en unik ID i SuperOffice CRM. Dette betyr at neste gang noen prøver å arkivere den samme e-posten, vises en advarsel som informerer dem om dette; På denne måten er det mulig å unngå duplikater i databasen.

Hvis du åpner en e-post som allerede er arkivert, vil **Arkiver e-post**-knappen ![icon][img1] vises grønt med en hvit hake. Hvis du holder musepekeren over knappen, vises en infoboks som forteller deg når og av hvem e-posten ble arkivert. Dette forutsetter at du valgte alternativet **Se etter duplikater når en e-post åpnes** i dialogboksen **SuperOffice CRM**.

## Relatert innhold

* [Alternativer for arkivering][9]
* [Generelle innstillinger][5]

<!-- Referenced links -->
[1]: archive-as-activity.md
[2]: archive-on-contact.md
[3]: archive-attachment.md
[4]: archive-as-request.md
[5]: settings/general.md
[9]: settings/default.md
[6]: create-in-outlook.md
[8]: create-in-superoffice.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/mail-link/already-archived.png
