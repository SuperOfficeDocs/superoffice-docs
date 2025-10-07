---
uid: help-da-tutorial-country-before-address
title: Tutorial - Flyt land-feltet frem
description: I denne tutorial lærer du, hvordan du flytter landfeltet på firma- eller personskærmen.
keywords: landfelt, skærmdesigner
date: 10.09.2025
version: 10.4
content_type: tutorial
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: da
index: true
redirect_from: /da/customization/screen-designer/tutorial-move-country
---

# Tutorial - Flyt land-feltet frem

## Trin 1: Formål

I SuperOffice formateres adresser baseret på land og region. For at opmuntre brugerne til at vælge land først, flytter vi dette felt til toppen af **Firma**-skærmen.

Når du er færdig, skulle det se nogenlunde sådan ud:

![Firmakort -screenshot][img1]

[!include[Krav](../../../includes/req-dev-tools.md)]

## Trin 2: Åbn Skærmdesigneren

1. Gå til **Indstillinger og vedligeholdelse**.
1. Vælg **Skærmdesigner** fra navigatoren.

![Skærmdesigner -screenshot][img2]

## Trin 3: Åbn layoutet i redigeringstilstand

1. Vælg **Firma** øverst.
1. Vælg fanen **Hovedkort** lige under.
1. Vælg standardlayoutet fra listen.
1. Klik på **Rediger layout** nederst på skærmen.

![Firmalayout i redigeringstilstand -screenshot][img3]

## Trin 4: Opdater felterne

1. Vælg fanen **Firma** i forhåndsvisningen.
1. Klik for at vælge feltet **Land**.
1. Grib fat i **=** til venstre for feltets etiket, træk det til toppen af listen, og slip det i den nye position.

![Firmalayout i redigeringstilstand -screenshot][img4]

## Trin 5: Gem, udgiv og test resultaterne

1. Klik på **Gem + Udgiv**.
1. Log ud af SuperOffice i en anden browserfane. Log derefter ind igen.
1. Gå til **Firma**-skærmen for at se resultatet.

Du vil måske også gøre det samme for **Person**-skærmen.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/tutorial-country-result.png
[img2]: ../../../../media/loc/en/customization/open-screen-designer.png
[img3]: ../../../../media/loc/en/customization/tutorial-country-layout-before.png
[img4]: ../../../../media/loc/en/customization/tutorial-country-layout-after.png
