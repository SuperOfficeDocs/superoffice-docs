---
uid: help-no-crmscript
title: CRMScript
description: CRMScript er en funksjon som lar deg automatisere oppgaver i eller endre atferden til SuperOffice.
author: SuperOffice RnD
date: 02.22.2023
keywords: CRMScript
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance

language: no
redirect_from:
  - /no/automation/crmscript/learn/macro-script
---

# CRMScript

CRMScript er en funksjon som lar deg automatisere oppgaver i eller endre atferden til SuperOffice. Ved å automatisere oppgaver og prosesser sparer du tid samtidig som du og kollegaen din blir mer produktive.

De forskjellige verktøyene, makroene og skriptene, utløsere og planlagte oppgaver har forskjellige funksjoner og brukes til forskjellige formål. Her kommer en introduksjon til det fleksible og kraftige innebygde skriptverktøyet CRMScript.

## Få tilgang til CRMScript

For å få tilgang til funksjonene i CRMScript åpner du Innstillinger og vedlikehold i SuperOffice, og deretter klikker du på <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** i navigatoren.

Triggere er skript som kjøres for bestemte hendelser i systemet, for eksempel når et nytt salg opprettes eller når en sak lukkes. Triggere kan reagere stille på hva som skjer, eller blokkere operasjonen og vise en forklaring for brukeren.

## Makroer og skript

I fanen **Makroer og skript** for **CRMScript** finner du en oversikt over skriptene og makroene i systemet, gruppert i mapper. Klikk på et skript eller en makro i listen for å [vise, redigere eller kjøre det/den][1].

### Om makroer

Makroer er den brukervennlige versjonen av skript: Du trenger ikke omfattende kunnskap om skripting eller CRMScript for å kunne lage makroer.

Med makroer kan du tilpasse og automatisere handlinger i SuperOffice. Den leveres med en enkel brukerveiledning som hjelper deg med å sette opp makroen.

Makroer har flere funksjoner i SuperOffice. De kan knyttes til bestemte [triggere][2] i systemet (for eksempel eskaleringer eller nye meldinger eller saker i SuperOffice), eller de kan tilordnes knapper i bestemte skjermbilder, slik at saksbehandlerne kan klikke på én knapp for å utføre et sett med handlinger de gjentar ofte. Da går saksbehandlingen raskere, og brukerne slipper unødvendig klikking.

Du kan for eksempel bruke makroer til følgende:

* Som en oppgave/funksjon i et menypunkt (for eksempel i **Oppgave** i bildet Sak).
* Når en sak eskaleres via varslingsnivåene for prioritet.
* Som en planlagt oppgave.
* Når de aktiveres av et e-postfilter.
* Når en mottaker klikker på en sporet kobling i en utsendelse.

### Hva er forskjellen på et skript og en makro?

En makro er et sett med forhåndsdefinerte handlinger som kjøres i en bestemt rekkefølge, og som du kan sette opp uten programmeringsferdigheter.

Et skript er et lite program som er skrevet for å utføre bestemte oppgaver, og som krever programmeringsferdigheter.

## Faner

* [Makroer og skript][8] – Opprett makroer og skript for å automatisere og planlegge oppgaver i SuperOffice.
* [Triggere][2] – Definer at en bestemt hendelse i systemet skal utløse én eller flere forhåndsdefinerte handlinger.
* [Planlagte oppgaver][3] – Angi at et skript eller en makro skal kjøres på bestemte tidspunkter.
* [Feilsøkingssesjoner][4] – Finn og løs feil i skript og makroer.
* [Sporing][5] – Registrer alle detaljer under kjøringen av skript eller makroer og lagre dem i en logg.

## Relatert innhold

* [Vise skript/makro][1]
* [Opprette et skript][8]
* [Opprette en makro][9]
* [Opprette mappe][10]
* [Lær CRMScript-språket][6]
* [CRMScript API-referanse][7]

<!-- Referenced links -->
[1]: screen/index.md
[2]: trigger.md
[3]: schedule-task.md
[4]: debug.md
[5]: tracing.md
[6]: ../../../../en/automation/crmscript/overview/index.md
[7]: ../../../../en/automation/crmscript/reference/index.md
[8]: create-script.md
[9]: create-macro.md
[10]: create-script.md#folder
