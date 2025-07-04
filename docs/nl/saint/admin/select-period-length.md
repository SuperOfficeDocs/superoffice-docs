---
uid: help-nl-select-period-length
title: Periodeduur selecteren
description: Periodeduur selecteren
keywords: SAINT, statuscontroles, teller
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/sale/saint/learn/admin/select-period-length
---

# Een periodeduur opgeven

[!include[Requirement](../includes/note-saint-req.md)]

U kunt de periode opgeven (duur in dagen) voor de volgende tellers:

* Aantal voltooide/niet-voltooide activiteiten gedurende periode
* Aantal voltooide/niet-voltooide verkopen gedurende periode
* Aantal voltooide/niet-voltooide verzoeken gedurende periode (als uw bedrijf SuperOffice Service licenties heeft)

[!include[Define counter](../includes/def-counter.md)]

U kunt maximaal drie verschillende perioden opgeven, zodat u kunt kiezen tussen kortere en langere perioden voor de verschillende SAINT-criteria. Bijvoorbeeld: Als u **Periode 1** op 30 dagen instelt, en **Periode 2** op 90 dagen, kunt u bijvoorbeeld kiezen tussen SAINT-criteria "Aantal verkopen in de afgelopen 30 dagen" EN "Aantal verkopen in de afgelopen 90 dagen".

## Stappen

1. Open het scherm **SAINT**.

2. Selecteer het tabblad **Tellers**.

3. Onder **Tellerinstellingen voor...** geeft u de perioden op voor bedrijven, personen en projecten. De Datum **vanaf** staat naast elke periode.

    ![Bewerk de tellerinstellingen op het tabblad Tellers -screenshot][img1]

    De wijzigingen worden automatisch opgeslagen.

> [!NOTE]
> Als u bijvoorbeeld de periode op 30 dagen hebt ingesteld, is de periode altijd 30 dagen vanaf de laatste keer dat de tellers opnieuw zijn gegenereerd. U moet de [tellers daarom regelmatig opnieuw genereren][2] (liefst elke avond), zodat de tellers zo actueel mogelijk zijn.

<!-- Referenced links -->
[2]: manage-status-monitors.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-counters.png
