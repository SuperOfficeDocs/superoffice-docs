---
uid: help-da-saint-counters
title: Tællere og tællerindstillinger
description: Definer og konfigurer tællere for SAINT
keywords: SAINT, statusovervågning, tæller, periode
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
index: true
redirect_from:
  - /da/sale/saint/learn/admin/select-period-length
  - /da/saint/admin/select-period-length
---

# Tællere og tællerindstillinger

[!include[Requirement](../includes/note-saint-req.md)]

En **tæller** er en værdi såsom antallet af salg i en periode eller datoen for det senest fuldførte salg. Tællere kan bruges som søgekriterier til at finde firmaer, personer eller projekter.

Du kan angive perioden (varighed i dage) for følgende tællere:

* Aktiviteter (fuldførte eller åbne)
* Salg (fuldførte eller åbne)
* Sager (fuldførte eller åbne, hvis dit firma har SuperOffice Service)

Du kan definere op til tre forskellige perioder. Dette giver dig mulighed for at oprette SAINT-kriterier for kortere eller længere tidsperioder. For eksempel: Hvis du indstiller **Periode 1** til 30 dage og **Periode 2** til 90 dage, kan du bruge kriterierne *Antal salg de sidste 30 dage* eller *Antal salg de sidste 90 dage*.

## Trin

1. Åbn skærmbilledet **SAINT** i Indstillinger og vedligeholdelse.

1. Vælg fanen **Tællere**.

1. Under **Tællerindstillinger på...** angiver du periodeværdier for firmaer, personer og projekter. **Fra dato** vises ved siden af hver periode.

    ![Rediger SAINT-tællerindstillingerne på fanen Tællere -screenshot][img1]

    Ændringerne gemmes automatisk.

> [!NOTE]
> En periode beregnes altid fra sidste gang, tællerne blev regenereret. For at holde resultaterne nøjagtige skal du [regenerere tællere ofte][2] (helst hver nat).

<!-- Referenced links -->
[2]: update.md#regen

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/counter-settings.png
