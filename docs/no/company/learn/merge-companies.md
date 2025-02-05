---
uid: help-no-company-merge
title: Slå sammen firmaer
description: Hold kundebasen ryddig og effektiv ved å slå sammen dupliserte firmaer eller kombinere poster når et firma kjøper et annet.
keywords: slå sammen firmaer, administrer firmaer, identiske personer, firma
author: Bergfrid Dias
date: 01.23.2025
version: 10.5.1
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Slå sammen firmaer

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Hold kundebasen ryddig og effektiv ved å slå sammen dupliserte firmaer eller kombinere poster når et firma kjøper et annet. Personer, aktiviteter, fakturaer, registrerte domener og andre detaljer blir flyttet eller slått sammen, og kildefirmaet blir slettet.

## Trinn

1. Klikk på **Oppgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) øverst til høyre på firmakortet.
   Velg **Vedlikehold firmaer** > **Slå sammen firmaer** fra menyen.
   Dialogboksen **Slå sammen firmaer** åpnes, med kildefirmaet angitt under **Fra**.

2. I seksjonen **Til firma** søker du etter og velger målfirmaet. Klikk på pilknappen <i class="ph ph-arrows-left-right" aria-hidden="true"></i> for å bytte om på **Fra**- og **Til**-firmaene.

    > [!CAUTION]
    > Sørg for at du velger riktige firmaer i både **Fra**- og **Til**-feltene før du fortsetter.

3. Under **Detaljinformasjon om firma og personer** kan du velge ett eller begge av følgende alternativer:

    * **Slå sammen identiske personer:** Personer med identiske for-, mellom- og etternavn blir slått sammen.
    * **Overskriv tomme felter med verdier fra kildefirmaet:** Tomme felter i målfirmaet oppdateres med data fra kildefirmaet.

4. Klikk på **Slå sammen**. Følgende skjer:

    * Personer (og relaterte saker) flyttes eller slås sammen.
    * Aktiviteter flyttes.
    * Prosjektdeltakelser og medlemskap i statiske utvalg følger målfirmaet.
    * Tomme felter oppdateres hvis du valgte **Overskriv tomme felter...**.
    * Kildefirmaet slettes.

![Dialogboksen Slå sammen firmaer som viser feltene for valg av kilde- og målfirma, alternativer for å slå sammen identiske personer og erstatte tomme felter -screenshot][img4]

> [!TIP]
> Du kan også slå sammen firmaer i dynamiske og statiske utvalg.

## Relatert innhold

* [Slå sammen personer][2]

<!-- Referenced links -->
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img4]: ../../../media/loc/en/company/merge-companies.png
