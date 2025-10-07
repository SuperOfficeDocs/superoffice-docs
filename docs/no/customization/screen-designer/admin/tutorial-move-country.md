---
uid: help-no-tutorial-country-before-address
title: Tutorial - Flytt landfeltet til toppen
description: I denne veiledningen vil du lære hvordan du flytter landfeltet på en firma- eller personskjerm.
keywords: landfelt, skjermdesigner
date: 10.09.2025
version: 10.4
content_type: tutorial
audience: settings
audience_tooltip: Settings and maintenance
license: development-tools
category: customization
topic: screen designer
language: no
index: true
redirect_from: /no/customization/screen-designer/tutorial-move-country
---

# Tutorial - Flytt landfeltet til toppen

## Trinn 1: Formål

I SuperOffice formateres adresser basert på land og region. For å oppmuntre brukerne til å velge land først, skal vi flytte dette feltet til toppen av **Firma**-skjermen.

Når du er ferdig, bør det se slik ut:

![Firmakort -screenshot][img1]

[!include[Krav](../../../includes/req-dev-tools.md)]

## Trinn 2: Åpne Skjermdesigneren

1. Gå til **Innstillinger og vedlikehold**.
1. Velg **Skjermdesigner** fra navigasjonsfeltet.

![Skjermdesigner -screenshot][img2]

## Trinn 3: Åpne layouten i redigeringsmodus

1. Velg **Firma** øverst.
1. Velg fanen **Hovedkort** rett under.
1. Velg standardlayouten fra listen.
1. Klikk på **Rediger layout** nederst på skjermen.

![Firmalayout i redigeringsmodus -screenshot][img3]

## Trinn 4: Oppdater feltene

1. Velg fanen **Firma** i forhåndsvisningen.
1. Klikk for å velge feltet **Land**.
1. Ta tak i **=** til venstre for feltetiketten, dra den til toppen av listen og slipp den i den nye posisjonen.

![Firmalayout i redigeringsmodus -screenshot][img4]

## Trinn 5: Lagre, publiser og test resultatene

1. Klikk på **Lagre + Publiser**.
1. Logg ut av SuperOffice i en annen nettleserfane. Logg deretter inn igjen.
1. Gå til **Firma**-skjermen for å se resultatet.

Du vil kanskje gjøre det samme for **Person**-skjermen.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/tutorial-country-result.png
[img2]: ../../../../media/loc/en/customization/open-screen-designer.png
[img3]: ../../../../media/loc/en/customization/tutorial-country-layout-before.png
[img4]: ../../../../media/loc/en/customization/tutorial-country-layout-after.png
