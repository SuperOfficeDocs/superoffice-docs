---
uid: help-nl-utm-setup
title: UTM-tracking instellen
description: Leer hoe je UTM-tracking inschakelt en gebruikt in SuperOffice Marketing om leadbronnen vast te leggen.
keywords: UTM inschakelen, conversietracking, leadbron
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: conversion
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# UTM-tracking instellen

UTM-tracking laat SuperOffice de bron, het medium en de campagne vastleggen die een lead hebben gegenereerd. Deze instelling zorgt ervoor dat elke formulierverzending kan worden herleid naar de marketingactiviteit die deze heeft veroorzaakt.

Je moet een **eenmalige installatie** uitvoeren (door een beheerder of webontwikkelaar) en vervolgens enkele **terugkerende stappen** uitvoeren voor elke campagne.

## Stappenoverzicht

| Stap | Wie | Frequentie | Doel |
|---|---|---|---|
| **1. UTM-gegevensoverdracht inschakelen** | Beheerder | Eenmalig | Maakt het mogelijk dat formulieren UTM-gegevens vastleggen en opslaan in CRM-velden. |
| **2. Voeg het UTM-trackingscript toe aan je website** | Webontwikkelaar | Eenmalig | Schakelt blijvende UTM-tracking in over pagina’s en sessies. |
| **3. Maak campagnekoppelingen met UTM-parameters** | Marketeer | Voor elke campagne | Identificeert waar het verkeer vandaan komt. |
| **4. Gebruik de gelabelde koppeling in campagnes** | Marketeer | Voor elke campagne | Gebruik de koppeling in advertenties, e-mails en sociale media. |
| **5. Publiceer het formulier op de juiste manier** | Marketeer | Voor elke campagne | Zorg dat het formulier UTM-gegevens correct registreert. |
| **6. Test en verifieer de installatie** | Marketeer | Na eerste installatie en vóór elke campagne | Controleer dat tracking en dataverzameling werken. |
| **7. Analyseer en visualiseer resultaten** | Marketeer | Na elke campagne | Meet campagneprestaties in dashboards en rapporten. |

## <a id="enable"></a>1. UTM-gegevensoverdracht inschakelen

**Wie:** Beheerder

**Wanneer:** Eenmalig

Het inschakelen van UTM-gegevensoverdracht laat SuperOffice vastleggen waar bezoekers vandaan komen wanneer zij een formulier verzenden.

De gegevens worden zichtbaar op zowel het **contactpersoonkaartje** als de **formulierverzending**.

1. Ga naar **Instellingen en onderhoud** > **Marketing**.
1. Schakel **UTM-gegevensoverdracht bij formulierverzendingen** in.

   ![De Marketing-instellingenpagina in SuperOffice Instellingen en onderhoud, met de optie om UTM-gegevensoverdracht in te schakelen. -screenshot][img1]

## <a id="script"></a>2. Voeg het UTM-trackingscript toe aan je website

**Wie:** Webontwikkelaar of websitebeheerder

**Wanneer:** Eenmalig

Dit script maakt permanente tracking mogelijk. Het detecteert UTM-parameters in de URL en slaat deze tijdelijk op in de browser. Zo blijven de gegevens van de eerste klik behouden, zelfs als de bezoeker meerdere pagina's bekijkt voordat hij het formulier verzendt.

1. Kopieer het onderstaande script.
1. Plak het in de code van je website, direct na de `<head>`-tag.
1. Publiceer de bijgewerkte pagina.

```html
<!-- SuperOffice UTM tag -->
<script src="https://sod2.superoffice.com/CustXXXXX/cs/javascript/utm.js"></script>
```

> [!TIP]
> Zonder het script worden UTM-gegevens alleen vastgelegd voor directe formulierlinks, niet voor bezoekers die tussen pagina’s navigeren.

## <a id="build-url"></a>3. Maak campagnekoppelingen met UTM-parameters

**Wie:** Marketeer

**Wanneer:** Voor elke campagne

UTM-parameters identificeren waar je bezoekers vandaan komen en hoe ze met je campagnes omgaan.

Je kunt de parameters handmatig toevoegen of een UTM-buildertool gebruiken.

```text
https://yourcompany.com/signup?utm_source=linkedin&utm_medium=social&utm_campaign=webinar_sept
```

Gebruik de [SuperOffice UTM-builder voor formulieren][1] of de [Google Campaign URL Builder][4] om consistente campagnekoppelingen te genereren en fouten te verminderen.

**Standaardparameters:**
utm_source, utm_medium, utm_campaign, utm_term, utm_content

Zie [UTM-parameters][2] voor uitleg en naamgevingsconventies.

## <a id="tag"></a>4. Gebruik de koppeling in campagnes

**Wie:** Marketeer

**Wanneer:** Voor elke campagne

Gebruik de gelabelde koppeling overal waar je de campagne promoot, zoals:

* Call-to-actionknoppen op blogs
* Nieuwsbrieven
* Facebook-advertenties of retargeting
* Google Ads
* LinkedIn-berichten

## <a id="publish"></a>5. Publiceer het formulier correct

**Wie:** Marketeer

**Wanneer:** Voor elke campagne

SuperOffice kan UTM-gegevens vastleggen, ongeacht of het formulier **ingesloten** op je website staat of **gehost** wordt door SuperOffice.

| Methode | Beschrijving | Registreert eerste contact? |
|---|---|---|
| **Ingesloten formulier** | Voeg het trackingscript toe aan je site en gebruik een bestemmingspagina met UTM-parameters. | <i class="ph ph-check-circle" aria-hidden="true"></i> Ja |
| **SuperOffice-gehost formulier (directe link)** | Voeg UTM-parameters toe aan de SuperOffice-formulier-URL. | <i class="ph ph-warning-circle" aria-hidden="true"></i> Nee |

> [!TIP]
> Link niet rechtstreeks vanaf je website naar een SuperOffice-gehost formulier, want UTM-tags gaan verloren tussen pagina’s.

## <a id="test"></a>6. Test en verifieer de installatie

**Wie:** Marketeer

**Wanneer:** Na eerste installatie en vóór elke nieuwe campagne

1. Klik op een van je campagnekoppelingen.
1. Vul het formulier in en verzend het.
1. Open het nieuwe contactpersoonkaartje in SuperOffice.
1. Controleer of de velden **bron**, **medium** en/of **campagne** gegevens bevatten.

Als er gegevens ontbreken, controleer dan:

* Of het trackingscript correct is geïnstalleerd.
* Of de UTM-parameters correct gespeld en geformatteerd zijn.
* Of browsercookies niet zijn geblokkeerd of verwijderd.

## <a id="analyze"></a>7. Analyseer en visualiseer resultaten

**Wie:** Marketeer

**Wanneer:** Na elke campagne

Zodra de gegevens zijn vastgelegd, kun je de prestaties meten in dashboards en rapporten.

* Bekijk nieuwe leads per **eerste contactbron** (welk kanaal genereerde verkeer).
* Bekijk nieuwe leads per **campagne** (welke campagne genereerde conversies).
* Maak een **dashboardtegel** die nieuwe leads toont per bron, medium of campagne voor het lopende jaar.

Lees meer over dashboards in [Marketingdashboards en rapporten][5].

[2]: ../learn/parameters.md
[1]: ../../forms/learn/publish.md
[4]: https://ga-dev-tools.google/campaign-url-builder
[5]: ../../../dashboard/learn/show-leads.md

[img1]: ../../../../media/loc/en/marketing/conversion-tracking.png
