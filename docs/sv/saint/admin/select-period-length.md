---
uid: help-sv-select-period-length
title: Välj periodlängd
description: Välj periodlängd
keywords: SAINT, statusövervakning, räknare
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/sale/saint/learn/admin/select-period-length
---

# Ange periodlängd

[!include[Requirement](../includes/note-saint-req.md)]

Du kan ange perioden (varaktighet i dagar) för följande räknare:

* Antal slutförda/ej slutförda aktiviteter under perioden
* Antal slutförda/ej slutförda försäljningar under perioden
* Antal slutförda/ej slutförda ärenden under perioden (om ditt företag har några SuperOffice Service-licenser)

[!include[Define counter](../includes/def-counter.md)]

Du kan ange upp till tre olika perioder, så att du kan välja mellan kortare eller längre perioder för de olika SAINT-kriterierna. Till exempel: Om du ställer in **Period 1** på 30 dagar och **Period 2** på 90 dagar, kan du till exempel välja mellan SAINT-kriteriet "Antal försäljningar under de senaste 30 dagarna" OCH "Antal försäljningar under de senaste 90 dagarna".

## Steg

1. Öppna **SAINT**-skärmen.

2. Välj fliken **Räknare**.

3. Under **Räknarinställningar för...** kan du ange perioder för företag, kontakter och projekt. **Från**-datumet visas bredvid varje period.

    ![Redigera räknarinställningarna på fliken Räknare -screenshot][img1]

    Ändringarna sparas automatiskt.

> [!NOTE]
> Om du till exempel har ställt in en period på 30 dagar, kommer perioden alltid att vara 30 dagar från den senaste gången räknarna återskapades. Du bör därför [återskapa räknarna ofta][2] (helst varje natt), så att räknarna är så uppdaterade som möjligt.

<!-- Referenced links -->
[2]: manage-status-monitors.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-counters.png
