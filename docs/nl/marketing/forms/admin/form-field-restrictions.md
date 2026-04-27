---
uid: help-nl-marketing-forms-field-restrictions
title: Restricties voor formuliervelden
description: Leer hoe u kunt bepalen welke velden beschikbaar zijn in formulieren en of formulierverzendingen bestaande gegevens in die velden kunnen overschrijven.
keywords: restricties voor formuliervelden, formulier, veld, overschrijven niet toestaan, overschrijven, niet weergeven in formulieren
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: nl
---

# Restricties voor formuliervelden

Met restricties voor formuliervelden kunt u bepalen welke velden beschikbaar zijn in formulieren en of een formulierverzending bestaande gegevens in die velden kan overschrijven.

Standaard overschrijven formulierverzendingen geen bestaande gegevens. De persoon die het formulier maakt, kan kiezen om overschrijven voor afzonderlijke velden in te schakelen. Gebruik veldrestricties om die optie van gevoelige velden te verwijderen of om te voorkomen dat een veld helemaal in de formulierbuilder verschijnt.

> [!CAUTION]
> Formulieren op een website kunnen door iedereen worden ingevuld. Het toestaan van overschrijvingen brengt risico's met zich mee, waaronder onbedoeld gegevensverlies, ongeautoriseerde wijzigingen van gevoelige velden en aangetaste gegevensintegriteit door onjuiste invoer. Ga zorgvuldig om met gevoelige velden.

## Restricties voor velden beheren

Veldrestricties worden geconfigureerd in **Instellingen en onderhoud** en vereisen beheerdersrechten.

1. Ga naar **Instellingen en onderhoud**.
1. Selecteer <i class="ph ph-bullseye" aria-hidden="true"></i> **Marketing** in de navigator.
1. Selecteer het tabblad **Restricties voor formuliervelden**.

![Admin Marketing - Restricties instellen voor in Marketing-formulieren zichtbare velden -screenshot][img1]

## Veldrestrictie toevoegen

1. Selecteer een veld in de vervolgkeuzelijst in de sectie **Velden met restricties**.
1. Selecteer het restrictietype voor dat veld.
1. Selecteer **Opslaan**.

Herhaal dit om restricties toe te voegen voor meer velden.

## Restrictieopties

* **Overschrijven niet toestaan:** De overschrijfoptie wordt verwijderd uit dit veld in alle formulieren, inclusief formulieren die al zijn gepubliceerd. Het veld blijft beschikbaar in de formulierbuilder en kan nog steeds worden toegevoegd aan formulieren, maar ingediende gegevens zullen bestaande waarden nooit overschrijven.

* **Niet weergeven in formulieren:** Het veld wordt volledig verwijderd uit de formulierbuilder en kan niet worden toegevoegd aan nieuwe formulieren. Bestaande gepubliceerde formulieren die het veld al bevatten, worden niet beïnvloed.

## Veldrestrictie verwijderen

1. Zoek het veld in de lijst **Velden met restricties**.
1. Selecteer het pictogram Verwijderen (<i class="ph ph-x-circle" aria-hidden="true"></i>) naast het veld.
1. Selecteer **Opslaan**.

Als u een restrictie verwijdert, wordt het standaardgedrag hersteld. Het veld is weer beschikbaar in de formulierbuilder en de formuliereigenaar kan kiezen of overschrijven is toegestaan.

## Gerelateerde inhoud

* [Veldopties][1]
* [Een nieuw formulier maken][2]
* [Lettertypen voor formulieren beheren][3]

<!-- Referenced links -->
[1]: ../learn/field-options.md
[2]: ../learn/create.md
[3]: manage-fonts.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/admin-marketing-form-field-restrictions.png
