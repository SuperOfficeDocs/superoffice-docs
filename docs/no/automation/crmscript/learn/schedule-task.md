---
uid: help-no-automation-schedule-task
title:  Planlagte oppgaver
description: Planlagte oppgaver
author: SuperOffice RnD
date: 06.29.2022
keywords: makro, skript, timeplan
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Planlagte oppgaver

I fanen **Planlagte oppgaver** kan du angi at et skript eller en makro skal kjøres på bestemte tidspunkter.

> [!TIP]
> Tidkrevende oppgaver bør planlegges på tidspunkter når få personer bruker SuperOffice.

Klikk på en oppgave i listen for å redigere egenskapene, for eksempel når den sist ble kjørt, kjøretid og sendte/mottatte objekter.

## Opprette en ny planlagt oppgave

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klikk på **CRMScript**, og velg deretter fanen **Planlagte oppgaver**.

1. Klikk på **Ny oppgave**.

1. Velg hvor ofte oppgaven skal utføres, i listen **Frekvens**. **Kjør etter en annen tidsplan** kan brukes til å starte en oppgave etter at en annen oppgave er fullført. Du kan bruke dette alternativet til å koble sammen oppgaver.

1. Klikk på **OK**.

1. Fyll ut følgende felt i fanen **Egenskaper**:
    * **Navn**: Angi et navn for oppgaven.
    * **ejScript/CRMScript**: Velg skriptet eller makroen som skal brukes i oppgaven.

1. Klikk på **Bruk**, og gå til fanen **Tidsplan**.

1. Velg **Start nå** for å kjøre oppgaven neste gang systemet ser etter planlagte oppgaver (vanligvis innen 1 minutt).

1. Velg **Deaktiver** hvis oppgaven skal være inaktiv for øyeblikket.

1. Rediger tidsplanen. De tilgjengelige feltene avhenger av den valgte frekvensen:

    * **Aldri**: Oppgaven kjøres ikke med mindre du velger **Start nå**.
    * **Minuttintervall**: Oppgaven kjøres med det valgte intervallet (i minutter). Pass på at intervallet er lengre enn tiden det tar å kjøre oppgaven.
    * **Timesintervall**: Oppgaven kjøres hver time, ved X minutter over timen.
    * **Ukesintervall**: Oppgaven kjøres ukentlig. Angi klokkeslettet og på hvilke dager oppgaven skal kjøres.
    * **Månedsintervall**: Aktiviteten kjøres månedlig. Angi klokkeslettet, på hvilken dag i måneden og i hvilke måneder.
    * **Etter**: Oppgaven kjøres på den angitte datoen og det angitte klokkeslettet.
    * **Kjør etter tidsplan**: Oppgaven kjøres når den valgte planlagte oppgaven er fullført. Du kan bruke dette alternativet til å koble sammen oppgaver.

1. Angi **Låsetid i minutter** for å hindre at flere aktiviteter fra samme tidsplan kjøres samtidig. Du bør angi denne verdien høyere enn forventet kjøretid for oppgaven. Hvis oppgaven tar lengre tid enn angitt her, anses den som mislykket, og en ny oppgave fra samme tidsplan kan kjøres.

1. Angi **Minutter til omstart etter feil**. Denne innstillingen angir tiden før en mislykket oppgave (en oppgave som har krasjet) kjøres på nytt.

1. Klikk på **OK**. Oppgaven legges til i listen, og du kan se statusen og tidspunktet for neste kjøring av oppgaven.

## Aktuelt innhold

* [Beste praksis for CRMScript][1]

<!-- Referenced links -->
[1]: ../../../../en/automation/crmscript/code-quality/best-practices.md
