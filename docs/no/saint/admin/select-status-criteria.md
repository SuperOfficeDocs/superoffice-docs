---
uid: help-no-select-status-criteria
title: Velg statuskriterier
description: Velg statuskriterier
keywords: SAINT, statusovervåking
author: SuperOffice RnD
date: 02.22.2023
version: 9
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Angi statuskriterier

[!include[Requirement](../includes/note-saint-req.md)]

En status er bare aktiv for firmaer, personer eller prosjekter som oppfyller alle kriteriene som er angitt for statusen. Du må angi ett eller flere kriterier for hver status du oppretter.

Bruk litt tid på å definere riktige statuskriterier, fordi du må sørge for at disse kriteriene filtrerer gruppen av firmaer (personer eller prosjekter) du vil overvåke på en nøyaktig måte.

## Trinn

1. [!include[Open SAINT](includes/open-saint-select-tab.md)]

1. Velg ønsket status i statuslisten til venstre i skjermbildet.

1. Klikk på **Legg til** i listen nederst til høyre (under fanen **Beskrivelse** og **Opprett oppfølging**). En ny linje legges til i listen.

1. Klikk på <i class="ph ph-caret-down" aria-label="Chevron"></i> ved siden av det tomme feltet, og [velg ønsket søkekriterium][1].

1. Gjenta trinn 4 og 5 for hvert kriterium du vil legge til.

    > [!NOTE]
    > Du kan bare legge til ett element av hver kriterietype for hver status. Du kan for eksempel ikke legge til kriteriet **Postnummer** to ganger.

1. Kontroller at du har valgt kriteriene du vil bruke for denne statusen.

1. Klikk på <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Generer valgt statusovervåking på nytt** for å oppdatere statusen med kriteriene du la til. Når statusen er generert på nytt, vises det ikke noe rødt kryss ved siden av statusnavnet.

## Aktuelt innhold

* [Administrer statusovervåking][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: manage-status-monitors.md
