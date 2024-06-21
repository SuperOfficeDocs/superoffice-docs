---
uid: help-no-company-merge
title: Slå sammen firmaer
description: "For å være effektiv i arbeidet med kunder og personer er det viktig å ha et ryddig miljø. Dette betyr å slette ubrukte firmaer og personer, og å slå sammen dupliserte firmaer og personer."
author: SuperOffice RnD
date: 12.15.2022
keywords: firma
topic: howto
language: no
---

# Slå sammen firmaer

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Du kan slå sammen dupliserte databaseoppføringer for firmaer. Personer og aktiviteter blir flyttet til målfirmaet, og kildefirmaet blir slettet.

Hvis to firmaer i kundedatabasen velger å slå seg sammen, eller ett av firmaene har kjøpt det andre firmaet, kan du slå sammen disse firmaene til ett firma. Personer (og relaterte saker), fakturaer og registrerte domener beholdes for begge firmaene.

## Trinn

[!include[Go to company](../../learn/includes/goto-company.md)]

1. Velg **Vedlikehold firmaer** fra ![ikon][img3] **Oppgave**-knappen, og klikk deretter på **Slå sammen firmaer**.
    Dialogboksen **Slå sammen firmaer** åpnes. Kildefirmaet er angitt under **Fra**.

1. Under **Til firma** velger du firmaet som skal oppdateres med informasjon fra kildefirmaet. Begynn å skrive i feltet for å søke etter et firma.

    > [!TIP]
    > Hvis du vil bytte **Fra**- og **Til**-firmaene, klikker du på ![ikon][img1] knappen.

1. Under **Detaljinformasjon om firma og personer** kan du merke av for følgende:

    * Slå sammen identiske personer. Hvis du velger dette alternativet, slås personer med likt navn sammen.

        > [!NOTE]
        > Navnene må være helt like – fornavn, mellomnavn og etternavn – for at de skal slås sammen.

    * **Overskriv tomme felt i [target company] med verdier fra [source company]**. Hvis dette alternativet velges, vil tomme felt for **Til**-firmaet overskrives med data fra **Fra**-firmaet.

    [!include[Preview results](../../learn/includes/note-preview-results.md)]

1. Klikk på **Slå sammen**. Da skjer følgende:

    * Firmaene slås sammen.
    * Personer flyttes eller slås sammen.
    * Alle aktiviteter flyttes.
    * Prosjektdeltakelse og medlemskap i statiske utvalg følger firmaet.
    * Alle detaljer slås sammen hvis du har valgt **Erstatt tomme felt på &lt;målfirma&gt; med verdier fra &lt;kildefirma&gt;**.
    * Kildefirmaet slettes.

![Dialogboksen Slå sammen firmaer -screenshot][img4]

[I dialogboksen Slå sammen firmaer må du velge riktig firma i Fra-feltet og Til-feltet][img5]

![Hvis du vil ha mer informasjon før du slår sammen de to firmaene, klikker du på Info-knappen på Vis resultat. -screenshot][img6]

> [!TIP]
> Du kan også slå sammen firmaer i dynamiske og statiske utvalg.

## Aktuelle emner

* [Slå sammen personer][2]

<!-- Referenced links -->
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/info-ball.png
[img3]: ../../../media/icons/btn-menu.png
[img4]: ../../../media/loc/en/company/merge-companies.png
[img5]: ../../../media/loc/en/company/company-merge.png
[img6]: ../../../media/loc/en/company/company-merge-info.png
