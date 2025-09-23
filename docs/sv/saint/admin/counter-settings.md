---
uid: help-sv-saint-counters
title: Räknare och räknarinställningar
description: Definiera och konfigurera räknare för SAINT
keywords: SAINT, statusövervakning, räknare, period
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
index: true
redirect_from:
  - /sv/sale/saint/learn/admin/select-period-length
  - /sv/saint/admin/select-period-length
---

# Räknare och räknarinställningar

[!include[Requirement](../includes/note-saint-req.md)]

En **räknare** är ett värde som till exempel antalet försäljningar under en period eller datumet för den senast slutförda försäljningen. Räknare kan användas som sökkriterier för att hitta företag, kontakter eller projekt.

Du kan ange perioden (varaktighet i dagar) för följande räknare:

* Aktiviteter (slutförda eller öppna)
* Försäljningar (slutförda eller öppna)
* Ärenden (slutförda eller öppna, om ditt företag har SuperOffice Service)

Du kan definiera upp till tre olika perioder. Detta låter dig skapa SAINT-kriterier för kortare eller längre tidsperioder. Till exempel: Om du ställer in **Period 1** på 30 dagar och **Period 2** på 90 dagar kan du använda kriterierna *Antal försäljningar under de senaste 30 dagarna* eller *Antal försäljningar under de senaste 90 dagarna*.

## Steg

1. Öppna **SAINT**-skärmen i Inställningar och underhåll.

1. Välj fliken **Räknare**.

1. Under **Räknarinställningar för...** anger du periodvärden för företag, kontakter och projekt. **Från**-datumet visas bredvid varje period.

    ![Redigera SAINT-räknarinställningarna på fliken Räknare -screenshot][img1]

    Ändringarna sparas automatiskt.

> [!NOTE]
> En period beräknas alltid från den senaste gången räknarna regenererades. För att hålla resultaten korrekta, [regenerera räknare ofta][2] (helst varje natt).

<!-- Referenced links -->
[2]: update.md#regen

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/counter-settings.png
