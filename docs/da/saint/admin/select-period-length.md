---
uid: help-da-select-period-length
title: Vælg periodelængde
description: Vælg periodelængde
keywords: SAINT, statusovervågning, tæller
author: SuperOffice RnD
date: 02.22.2023
version: 9
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Angivelse af periodelængde

[!include[Requirement](../includes/note-saint-req.md)]

Du kan angive perioden (varighed i dage) for følgende tællere:

* Antal fuldførte/ikke-fuldførte aktiviteter i perioden
* Antal fuldførte/ikke-fuldførte salg i perioden
* Antal fuldførte/ikke-fuldførte sager i løbet af perioden (hvis dit firma har SuperOffice Service-licenser)

[!include[Define counter](../includes/def-counter.md)]

Du kan angive op til tre forskellige perioder, så du kan vælge mellem kortere eller længere perioder for de forskellige SAINT-kriterier. For eksempel: Hvis du indstiller **Periode 1** til 30 dage og **Periode 2** til 90 dage, kan du for eksempel vælge mellem SAINT-kriterierne "Antal salg de sidste 30 dage" OG "Antal salg de sidste 90 dage".

## Trin

1. Åbn skærmbilledet **SAINT**.

2. Vælg fanen **Tællere**.

3. Under **Tællerindstillinger på...** angiver du perioderne for firmaer, personer og projekter. **Fra dato** vises ved siden af hver periode.

    ![Rediger tællerindstillingerne på fanen Tællere -screenshot][img1]

    Ændringerne gemmes automatisk.

> [!NOTE]
> Hvis du for eksempel har angivet en periode til 30 dage, vil perioden altid være 30 dage fra sidste gang, tællerne blev genoprettet. Du bør derfor [genoprette tællerne ofte][2] (helst hver nat), så tællerne er så opdaterede som muligt.

<!-- Referenced links -->
[2]: manage-status-monitors.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-counters.png
