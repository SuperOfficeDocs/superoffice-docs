---
uid: help-nl-saint-counters
title: Tellers en tellerinstellingen
description: Tellers voor SAINT definiëren en configureren
keywords: SAINT, statuscontroles, teller, periode
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
index: true
redirect_from:
  - /nl/sale/saint/learn/admin/select-period-length
  - /nl/saint/admin/select-period-length
---

# Tellers en tellerinstellingen

[!include[Requirement](../includes/note-saint-req.md)]

Een **teller** is een waarde zoals het aantal verkopen in een periode of de datum van de laatst voltooide verkoop. Tellers kunnen worden gebruikt als zoekcriteria om bedrijven, personen of projecten te vinden.

U kunt de periode opgeven (duur in dagen) voor de volgende tellers:

* Activiteiten (voltooid of open)
* Verkopen (voltooid of open)
* Verzoeken (voltooid of open, als uw bedrijf SuperOffice Service heeft)

U kunt maximaal drie verschillende perioden definiëren. Hiermee kunt u SAINT-criteria maken voor kortere of langere tijdsperioden. Bijvoorbeeld: Als u **Periode 1** op 30 dagen instelt en **Periode 2** op 90 dagen, kunt u de criteria *Aantal verkopen laatste 30 dagen* of *Aantal verkopen laatste 90 dagen* gebruiken.

## Stappen

1. Open het scherm **SAINT** in Instellingen en onderhoud.

1. Selecteer het tabblad **Tellers**.

1. Onder **Tellerinstellingen voor...** voert u periodewaarden in voor bedrijven, personen en projecten. De **Vanaf**-datum wordt naast elke periode weergegeven.

    ![Bewerk de SAINT-tellerinstellingen op het tabblad Tellers -screenshot][img1]

    De wijzigingen worden automatisch opgeslagen.

> [!NOTE]
> Een periode wordt altijd berekend vanaf de laatste keer dat de tellers zijn geregeneerd. Om de resultaten nauwkeurig te houden, [regenereer tellers regelmatig][2] (bij voorkeur elke nacht).

<!-- Referenced links -->
[2]: update.md#regen

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/counter-settings.png
