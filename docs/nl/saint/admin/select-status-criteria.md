---
uid: help-nl-select-status-criteria
title: Statuscriteria selecteren
description: Statuscriteria selecteren
keywords: SAINT, statuscontroles
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/sale/saint/learn/admin/select-status-criteria
index: true
---

# Statuscriteria opgeven

[!include[Requirement](../includes/note-saint-req.md)]

Een status is alleen actief voor bedrijven, personen of projecten die voldoen aan alle criteria van die status. U moet voor elke status die u maakt een of meer criteria opgeven.

Besteed wat tijd aan het instellen van de juiste statuscriteria, omdat u ervoor moet zorgen dat deze criteria nauwkeurig de groep bedrijven (personen of projecten) filteren die u wilt bewaken.

## Stappen

1. [!include[Open SAINT](includes/open-saint-select-tab.md)]

1. Selecteer de gewenste status in de statuslijst links van het scherm.

1. Klik op **Toevoegen** in de lijst rechts onderin (onder het tabblad **Beschrijving** en het tabblad **Vervolgactiviteit maken**). Er wordt een nieuwe regel aan de lijst toegevoegd.

1. Klik op <i class="ph ph-caret-down" aria-label="Chevron"></i> naast het lege veld en [selecteer het vereiste zoekcriterium][1].

1. Herhaal stap 4 en 5 voor elk criterium dat u wilt toevoegen.

    > [!NOTE]
    > U kunt slechts één exemplaar van elk criteriumtype voor een bepaalde status toevoegen. Zo kunt u het criterium **Postcode** bijvoorbeeld niet twee maal toevoegen.

1. Controleer of u de criteria hebt ingeschakeld die u voor deze status wilt gebruiken.

1. Klik op <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Geselecteerde statuscontrole opnieuw genereren** om de status bij te werken met de criteria die u hebt toegevoegd. Nadat de status opnieuw is gegenereerd, staat er geen rood kruis bij de statusnaam.

## Gerelateerde inhoud

* [Statuscontroles beheren][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: manage-status-monitors.md
