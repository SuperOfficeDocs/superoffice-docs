---
uid: help-da-select-status-criteria
title: Vælg statuskriterier
description: Vælg statuskriterier
keywords: SAINT, statusovervågning
author: SuperOffice RnD
date: 02.22.2023
version: 9
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Angivelse af statuskriterier

[!include[Requirement](../includes/note-saint-req.md)]

En status er kun aktiv for firmaer, personer eller projekter, der opfylder alle de kriterier, der er angivet for statussen. Du skal angive et eller flere kriterier for hver status, du opretter.

Brug lidt tid på at konfigurere de korrekte statuskriterier, da du skal sikre, at disse kriterier nøjagtigt filtrerer den gruppe af firmaer der (personer eller projekter), du vil overvåge.

## Trin

1. [!include[Open SAINT](includes/open-saint-select-tab.md)]

1. Vælg den ønskede status på statuslisten til venstre i skærmbilledet.

1. Klik på **Tilføj** på listen nederst til højre (under fanen **Beskrivelse** og fanen **Opret opfølgning**). En ny linje føjes til listen.

1. Klik på <i class="ph ph-caret-down" aria-label="Chevron"></i> ved siden af det tomme felt, og [vælg det ønskede søgekriterium][1].

1. Gentag trin 4 og 5 for hvert kriterium, du vil tilføje.

    > [!NOTE]
    > Du kan kun tilføje én forekomst af hver kriterietype for hver status. Du kan for eksempel ikke tilføje kriteriet **Postnr.** to gange.

1. Kontrollér, at du har valgt de kriterier, du vil bruge til denne status.

1. Klik på <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Genopretter valgt statusovervågning** for at opdatere status med de kriterier, du tilføjede. Når status er genoprettet, vises der ikke noget rødt kryds ved statusnavnet.

## Relateret indhold

* [Administration af statusovervågning][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: manage-status-monitors.md
