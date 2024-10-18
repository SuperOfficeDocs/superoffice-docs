---
uid: help-no-select-period-length
title: Velg periodelengde
description: Velg periodelengde
keywords: SAINT, statusovervåking
author: SuperOffice RnD
date: 02.22.2023
version: 9, teller
topic: howto
audience: settings
audience_tooltip: Settings and maintenance

language: no
---

# Angi periodelengde

[!include[Requirement](../includes/note-saint-req.md)]

Du kan angi perioden (varighet i dager) for følgende tellere:

* Antall fullførte / ikke fullførte aktiviteter i periode
* Antall fullførte / ikke fullførte salg i periode
* Antall fullførte/ikke fullførte forespørsler i løpet av perioden (hvis firmaet ditt har SuperOffice-tjenestelisenser)

[!include[Define counter](../includes/def-counter.md)]

Du kan angi inntil tre ulike perioder, slik at du kan velge mellom kortere eller lengre perioder for de ulike SAINT-kriteriene. For eksempel: Hvis du angir **periode 1** til 30 dager og **periode 2** til 90 dager, kan du for eksempel velge mellom SAINT-kriteriene "Antall salg siste 30 dager" OG "Antall salg siste 90 dager".

## Trinn

1. Åpne **SAINT**-skjermbildet.

2. Velg fanen **Tellere**.

3. Under **Tellerinnstillinger for ...** kan du angi perioder for firmaer, personer og prosjekter. **Fra**-datoen vises ved siden av hver periode.

    ![Rediger tellerinnstillingene i fanen Tellere -screenshot][img1]

    Endringene lagres automatisk.

> [!NOTE]
> Hvis du for eksempel har satt en periode til 30 dager, vil perioden alltid være 30 dager fra forrige gang tellerne ble generert på nytt. Du bør derfor [genere tellerne på nytt ofte][2] (helst hver natt), slik at tellerne er så oppdaterte som mulig.

<!-- Referenced links -->
[2]: manage-status-monitors.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-counters.png
