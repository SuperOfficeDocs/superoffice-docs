---
uid: help-sv-select-status-criteria
title: Välj statuskriterier
description: Välj statuskriterier
keywords: SAINT, statusövervakning
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Ange statuskriterier

[!include[Requirement](../includes/note-saint-req.md)]

En status är endast aktiv för företag, kontakter eller projekt som uppfyller alla kriterier som anges för statusen. Du måste ange ett eller flera kriterier för varje status som du skapar.

Lägg lite tid på att ställa in rätt statuskriterier, eftersom du måste se till att dessa kriterier korrekt filtrerar den grupp av företag (kontakter eller projekt) som du vill övervaka.

## Steg

1. [!include[Open SAINT](includes/open-saint-select-tab.md)]

1. Välj önskad status i statuslistan till vänster på skärmen.

1. Klicka på **Lägg till** i listan längst ned till höger (under fliken **Beskrivning** och fliken **Skapa händelse**). En ny rad läggs till i listan.

1. Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> bredvid det tomma fältet och [välj önskat sökkriterium][1].

1. Upprepa steg 4 och 5 för varje kriterium du vill lägga till.

    > [!NOTE]
    > Du kan bara lägga till en förekomst av varje kriterietyp för varje status. Du kan till exempel inte lägga till ett kriterium för **postnummer** två gånger.

1. Kontrollera att du har valt de kriterier du vill använda för den här statusen.

1. Klicka på <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Återskapar vald status** för att uppdatera statusen med de kriterier du har lagt till. När statusen har återskapats, visas inget rött kryss vid statusnamnet.

## Relaterat innehåll

* [Administrera statusövervakning][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: manage-status-monitors.md
