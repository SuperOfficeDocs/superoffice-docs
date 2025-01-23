---
uid: help-no-automation-trigger
title: Triggere
description: Triggere
author: SuperOffice RnD
date: 06.29.2022
keywords: CRMScript, trigger
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Triggere

[!include[Requirement](../../../learn/includes/req-expander-services.md)]

Triggere er skript som kjøres for bestemte hendelser i systemet, for eksempel når et nytt salg opprettes eller når en sak lukkes. Triggere kan reagere stille på hva som skjer, eller blokkere operasjonen og vise en forklaring for brukeren.

CRMScript kan effektivisere hverdagen din ved å automatisere ulike arbeidsoppgaver. Du kan definere at en bestemt hendelse i systemet skal sette i gang (utløse) én eller flere forhåndsdefinerte handlinger. Det kreves ikke kunnskap om skripting for å få dette til å virke.

**Eksempel fra SuperOffice**: Når en sak avsluttes, må kunden bli varslet om dette på e-post. Vi kan opprette en makro som inneholder en serie med handlinger for å opprette og sende denne e-postvarslingen. Denne makroen kjøres automatisk når en sak avsluttes. Handlingene i makroen laster inn den aktuelle saken, henter inn riktig svarmal, og sender e-postmelding til kunden om at saken er avsluttet.

Dette er et eksempel på en svært enkel trigger. Du kan for eksempel legge til betingelser for handlingene i en trigger ved å endre standardinnstillingen **Alltid**.

## Opprette en trigger

Vi skal nå lage en serie med handlinger basert på eksemplet ovenfor.

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Klikk på <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript**, og velg deretter fanen **Triggere**.
1. Klikk på knappen **Ny trigger (makro)**. Bildet **Velg trigger** viser de tilgjengelige triggerne. Dette er hendelser i systemet som kan brukes til å sette i gang handlinger/makroer. I vårt eksempel velger vi **Sak avsluttet**, slik at makroen kjøres når en sak avsluttes i SuperOffice.
1. Skriv "sak" i søkefeltet og velg triggeren med navnet **Sak avsluttet**.
1. Angi en beskrivelse av triggeren i feltet **Beskrivelse**.
1. Velg **Aktivert**.
1. Velg **Endre en sak** under **Velg handlingstype** nedenfor. Du kommer til fanen **Endre en sak**.
    Dette er den første handlingen i makroen. Den henter saken, slik at de forskjellige verdiene (ID, tittel, navn på person og så videre) kan brukes i de neste handlingene vi lager.
1. Valgfritt: Merk av for **Intern melding**, og skriv for eksempel: "Sak avsluttet, og bekreftelse sendt til kunde."
1. Klikk på **Bruk**.
1. Klikk på **Ny handling** ved siden av fanen **Endre en sak**.
1. Velg **Last inn en svarmal for fletting**. Vi skal nå hente inn svarmalen som skal brukes.
1. Klikk på feltet **Svarmal**, og velg en eksisterende svarmal i listen som vises, for eksempel "Sak avsluttet".
1. Klikk på **Bruk**.
1. Klikk på **Ny handling** og velg deretter **Send en e-post eller SMS**. Vi skal nå tilpasse e-postmeldingen som skal sendes til kunden.
1. Merk av for **Emne**.
1. Klikk på <i class="ph ph-gear" aria-label="Gear"></i> til høyre, og klikk deretter på feltet **Velg parameter**.
1. Velg **Endre en sak** > **Tittel**. Sakstittelen settes da inn i emnet for e-posten.
1. Merk av for **Fra**, og velg **Endre en sak** > **Eier**.
1. Merk av for **Til**, og velg **Endre en sak** > **Person: E-postadresse**.
1. Merk av for **HTML-melding**, og velg **Last inn en svarmal for fletting** > **HTML-tekst**.
1. Klikk på **Bruk**.

Du har nå laget en makro som sender en e-post med "Sak avsluttet" til kunden når en sak blir avsluttet. Denne triggeren aktiveres umiddelbart hvis du merket av for **Aktivert** øverst.
