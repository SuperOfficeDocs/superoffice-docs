---
uid: help-no-select-image-for-status
title: Velg bilde for status
description: Velg bilde for status
keywords: SAINT, statusovervåking
author: SuperOffice RnD
date: 02.22.2023
version: 9
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Velge et bilde for en status

[!include[Requirement](../includes/note-saint-req.md)]

Du kan velge et bilde som skal vises i SuperOffice CRM på et firmakort, personkort eller prosjektkort som oppfyller kriteriene som er satt for en bestemt status. Bildene vises som vannmerker, slik at innholdet på kortet ikke skjules.

Det er lurt å legge til et bilde fordi det tiltrekker seg oppmerksomhet og ber deg om å iverksette tiltak hver gang du kommer over et firma (person eller prosjekt) som har denne bestemte statusen. Bruk et bilde som symbolsk illustrerer hvilken type handling du må utføre.

## Er det obligatorisk å ha et bilde?

Nei. Hvis du bare vil bruke statusovervåking til å søke etter og opprette utvalg av firmaer, personer eller prosjekter som oppfyller statuskriteriene, trenger du ikke å tilordne et bilde til statusene.

## Hvilken type bilder kan jeg bruke?

Du bør velge et bilde som visualiserer statusen det skal representere. Statusbildet for et prosjekt som har vært inaktivt lenge, kan for eksempel være et edderkoppnett.

[!include[File type and size](../../learn/includes/image-type-and-size.md)]

Bildene brukes som vannmerker for firmakortet, personkortet eller prosjektkortet i SuperOffice CRM. Gjennomsiktigheten er 40 prosent, slik at bildet ikke skjuler teksten. Men du bør bruke bilder med relativt lyse farger.

## Slik velger du et bilde til statusen

1. [!include[Open SAINT](includes/open-saint-select-tab.md)]

1. Velg ønsket status i statuslisten til venstre i skjermbildet.

1. Merk av for **Visualiser** (på høyre side av skjermen) for å vise statusbildet for firmaer personer eller prosjekter som oppfyller statuskriteriene for denne statusen. Hvis det ikke er merket av for **Visualiser** vises ikke statusbilder i SuperOffice CRM for denne statusen. Dette kan være relevant hvis du bare vil bruke en status for å søke i SuperOffice CRM (se nedenfor).

1. Klikk på **Endre bilde**.

1. Velg bilde. Gjør ett av følgende:

    * Klikk på et av bildene som vises under **Bilder** (til høyre).

        Bilder vises bare hvis de legges til i databasen.

    * Klikk på **Legg til**, klikk på **Last opp** fil, bla til bildet du ønsker og klikk på **Åpne**. Angi en beskrivelse av bildet. Klikk på **Lagre**.

1. Klikk på **OK** for å lukke dialogboksen. Bildet legges til i databasen og vises i feltet til høyre.

## Bruke statuser for søk

I SuperOffice CRM kan du søke etter firmaer, personer eller prosjekter ved hjelp av statuser som du definerer i Innstillinger og vedlikehold. Du kan for eksempel søke etter firma med en bestemt status og legge dem til i et utvalg.

Hvis du bare vil bruke statuser til søk, kan du fjerne avmerkingen **Visualiser**, slik at statusbildet ikke vises på firmakortet, personkortet eller prosjektkortet.

## Aktuelt innhold

* [Velg en standard oppfølgingstype for en status][1]
* [Angi statuskriterier][2]
* [Angi periodelengde][3]
* [Administrer statusovervåking][4]

<!-- Referenced links -->
[1]: select-default-follow-up-type-for-status.md
[2]: select-status-criteria.md
[3]: select-period-length.md
[4]: manage-status-monitors.md

<!-- Referenced images -->
