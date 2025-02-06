---
uid: help-no-automation-macro-create
title: Opprette en makro – eksempel fra SuperOffice
description: Eksempel på hvordan du oppretter en makro i SuperOffice.
author: SuperOffice RnD
date: 03.16.2023
keywords: skript, makro
topic: howto
audience: settings
audience_tooltip: Settings and maintenance

language: no
---

# Opprette en makro – eksempel fra SuperOffice

Mange bedrifter mottar ofte saker relatert til fakturering. Slike saker skal rett til regnskapsavdelingen. I stedet for å redigere hver sak og endre kategori og eier, kan vi opprette en makro som utfører alle disse handlingene. Makroen kan tilordnes til **Oppgave**-knappen i skjermbildet Sak. Fakturaspørsmål kan dermed delegeres til regnskapsavdelingen med bare ett klikk.

> [!TIP]
> Du kan automatisere denne prosessen ved å opprette et e-postfilter for å søke etter ordet "faktura" i e-postemner, og deretter kjøre makroen for å tildele saken til den riktige avdelingen.

Vi skal nå opprette en makro basert på eksemplet ovenfor.

## Trinn

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Velg <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** og fanen for **Makroer og skript**. Gjør ett av følgende:
    * Slik oppretter du en ny makro: Klikk på **Ny makro**.
    * Slik redigerer du en eksisterende makro: Klikk på makronavnet.

1. I fanen **Informasjon** skriver du inn "Send sak til regnskapsavd." i feltet **Navn** og angir en beskrivelse i feltet nedenfor.

1. Velg alternativet **Ny meny** for å opprette en makro for **Oppgave**-knappen i bildet Firma, Person eller Sak, eller fanen **Melding**.

1. Gå til fanen **Handlinger**, og velg deretter **Velg handlingstype** > **Endre en sak**.

1. Merk av for **Kategori**, og velg en kategori i listen (for eksempel *Regnskap*).

1. Merk av for **Eier**, og velg en bruker.

    > [!TIP]
    > Du kan også velge **Automatisk tildelt** for å la systemet fordele saken etter gjeldende fordelingsregler.

1. Merk av for **Intern melding**, og skriv en kort standardmelding til regnskapsavdelingen om hvorfor de har mottatt denne saken.

1. Klikk på **OK** når du er ferdig.

## Aktuelt innhold

* [Lær mer om avanserte makrofunksjoner og triggere][1]

<!-- Referenced links -->
[1]: trigger.md

<!-- Referenced images -->
