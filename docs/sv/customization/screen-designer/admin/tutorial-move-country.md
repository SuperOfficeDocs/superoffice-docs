---
uid: help-sv-tutorial-country-before-address
title: Tutorial - Flytta landfältet till toppen
description: I den här guiden lär du dig hur du flyttar landfältet på en företags- eller kontaktskärm.
keywords: landfält, skärmdesigner
date: 10.09.2025
version: 10.4
content_type: tutorial
audience: settings
audience_tooltip: Settings and maintenance
license: development-tools
category: customization
topic: screen designer
language: sv
index: true
redirect_from: /sv/customization/screen-designer/tutorial-move-country
---

# Tutorial - Flytta landfältet till toppen

## Steg 1: Syfte

I SuperOffice formateras adresser baserat på land och region. För att uppmuntra användare att välja land först ska vi flytta det fältet till toppen av **Företag**-skärmen.

När du är klar ska det se ut ungefär så här:

![Företagskort -screenshot][img1]

[!include[Krav](../../../includes/req-dev-tools.md)]

## Steg 2: Öppna Skärmdesignern

1. Gå till **Inställningar och underhåll**.
1. Välj **Skärmdesigner** från navigeringsmenyn.

![Skärmdesigner -screenshot][img2]

## Steg 3: Öppna layouten i redigeringsläge

1. Välj **Företag** högst upp.
1. Välj fliken **Huvudkort** precis nedanför.
1. Välj standardlayouten från listan.
1. Klicka på **Redigera layout** längst ner på skärmen.

![Företagslayout i redigeringsläge -screenshot][img3]

## Steg 4: Uppdatera fälten

1. Välj fliken **Företag** i förhandsgranskningen.
1. Klicka för att välja fältet **Land**.
1. Ta tag i **=** till vänster om fältetiketten, dra det till toppen av listan och släpp det i den nya positionen.

![Företagslayout i redigeringsläge -screenshot][img4]

## Steg 5: Spara, publicera och testa resultat

1. Klicka på **Spara + Publicera**.
1. Logga ut från SuperOffice i en annan webbläsarflik. Logga sedan in igen.
1. Gå till **Företag**-skärmen för att se resultatet.

Du kanske vill göra detta för **Kontakt**-skärmen också.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/tutorial-country-result.png
[img2]: ../../../../media/loc/en/customization/open-screen-designer.png
[img3]: ../../../../media/loc/en/customization/tutorial-country-layout-before.png
[img4]: ../../../../media/loc/en/customization/tutorial-country-layout-after.png
