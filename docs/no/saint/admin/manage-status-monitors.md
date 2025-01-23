---
uid: help-no-manage-status-monitors
title: Administrer statusovervåking
description: Administrer statusovervåking
keywords: SAINT, statusovervåking
author: SuperOffice RnD
date: 02.22.2023
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Administrer statusovervåking

[!include[Requirement](../includes/note-saint-req.md)]

Når du konfigurerer flere statusovervåkinger og ulike perioder/tellere, er det viktig å ha regelmessig kontroll av dem for å sikre at tellerne og statusene genereres på nytt og oppdateres, og at [kriteriene][1] er riktige for de ulike statusene.

Delene nedenfor inneholder informasjon om hvordan du aktiverer og deaktiverer statusovervåking og hvordan du genererer statuser og tellere på nytt. [!include[Define counter](../includes/def-counter.md)]

## Generell informasjon om oppdatering og regenerering av statuser og tellere

Nederst i fanen **Statusovervåking** vises indikatorer (tekst som viser datoen for den nyeste genereringen, hvis den valgte statusen eller telleren aldri har blitt generert, eller hvis den valgte statusen skal genereres på nytt på grunn av endringer) for regenerering av statuser eller tellere.

Du bør generere statuser og/eller tellere på nytt hvis indikatorene viser at den siste genereringen var for lenge siden, eller at statusene og/eller tellerne aldri har blitt generert. Det samme gjelder dersom statuser er blitt endret. Statuser og tellere som ikke oppdateres, vil fortsatt være aktiverte og brukbare i SuperOffice CRM, men datoene som returneres, vil ikke nødvendigvis være korrekte. I delene nedenfor kan du lese om hvordan du regenererer statuser og tellere.

### Slik vet du om den er oppdatert

Hvis et element ikke oppdateres, vises det som nedtonet i SuperOffice CRM.

## Regenerer statuser <i class="ph ph-arrow-circle-right" aria-label="Arrow right"></i>

Når du har [lagt til, redigert eller slettet et kriterium][2], eller hvis du for eksempel har redigert en intensjon om en oppgave i SuperOffice CRM, vises et rødt kryss i statuslisten til venstre for de(n) aktuelle statusen(e). Statuser som er merket med et rødt kryss, er ikke aktive.

Deretter må du generere disse statusene på nytt ved å klikke på en av disse knappene:

| Navn | Beskrivelse | Sted |
|---|---|---|
| Generer valgt statusovervåking på nytt | Velg for å generere den valgte statusen på nytt | Nederst i fanen **Firma**, **Person** eller **Prosjekt** |
| Generer alle statusovervåkinger på nytt | Velg dette alternativet hvis du vil generere alle statuser på nytt | Nederst på fanen **Status** |

## Regenerer tellerverdier

| Navn | Beskrivelse |
|---|---|
| Generer alle tellere på nytt | Merk av for å generere alle tellere på nytt |

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: select-status-criteria.md
