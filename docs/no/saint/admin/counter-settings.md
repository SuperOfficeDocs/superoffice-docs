---
uid: help-no-saint-counters
title: Tellere og tellerinnstillinger
description: Definer og konfigurer tellere for SAINT
keywords: SAINT, statusovervåking, teller, periode
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
index: true
redirect_from:
  - /no/sale/saint/learn/admin/select-period-length
  - /no/saint/admin/select-period-length
---

# Tellere og tellerinnstillinger

[!include[Requirement](../includes/note-saint-req.md)]

En **teller** er en verdi som for eksempel antall salg i en periode eller datoen for siste fullførte salg. Tellere kan brukes som søkekriterier for å finne firmaer, personer eller prosjekter.

Du kan angi perioden (varighet i dager) for følgende tellere:

* Aktiviteter (fullførte eller åpne)
* Salg (fullførte eller åpne)
* Saker (fullførte eller åpne, hvis firmaet ditt har SuperOffice Service)

Du kan angi inntil tre ulike perioder. Dette lar deg opprette SAINT-kriterier for kortere eller lengre tidsperioder. For eksempel: Hvis du angir **periode 1** til 30 dager og **periode 2** til 90 dager, kan du bruke kriteriene *Antall salg siste 30 dager* eller *Antall salg siste 90 dager*.

## Trinn

1. Åpne **SAINT**-skjermbildet i Innstillinger og vedlikehold.

1. Velg fanen **Tellere**.

1. Under **Tellerinnstillinger for ...** angir du periodeverdier for firmaer, personer og prosjekter. **Fra**-datoen vises ved siden av hver periode.

    ![Rediger SAINT-tellerinnstillingene i fanen Tellere -screenshot][img1]

    Endringene lagres automatisk.

> [!NOTE]
> En periode beregnes alltid fra siste gang tellerne ble regenerert. For å holde resultatene nøyaktige, [regenerer tellere ofte][2] (helst hver natt).

<!-- Referenced links -->
[2]: update.md#regen

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/counter-settings.png
