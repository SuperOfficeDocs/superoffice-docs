---
uid: help-sv-sales-target-types
title: Ställ in en typ av försäljningsmål med undertyper
description: Att hålla koll på dina försäljningsmål kan vara stressande. Men om du definierar parametrar och dimensioner för dina försäljningsmål blir det mycket lättare att hantera dem.
author: SuperOffice RnD
date: 02.16.2023
keywords: försäljning
content_type: howto
language: sv
---

# Ställ in en typ av försäljningsmål med undertyper

Att hålla koll på dina försäljningsmål kan vara stressande. Men om du definierar parametrar och dimensioner för dina försäljningsmål blir det mycket lättare att hantera dem.

Du kan lägga till nya måltyper (dimensioner) utöver standardmåltypen **All försäljning - Belopp**.

> [!NOTE]
> Du behöver en Sales Premium-licens tillsammans med licensen Unlimited sales targets för att lägga till fler än en användargrupp och måltyp. Om du bara har Sales Premium-licens kan du lägga till en grupp för måltypen Alla försäljningar - belopp.

Du måste ha funktionsrättigheten måladministratör för din roll för att kunna lägga till, redigera och ta bort måltyper.

## Ange måltyp

För att definiera parametrar och dimensioner måste du först ange en måltyp.

Du kan ange en måltyp för både användare och grupper, samt ställa in andra målparametrar: Måltyp, Måttenhet, Separata mål. Du kan också definiera om det bara ska vara tillgängligt på företags- och gruppnivå (och inte på användarnivå).

![Översikt över de olika måltyperna och undertyperna för ett försäljningsmål -screenshot][img1]

## Lägg till ny måltyp

1. Klicka på **Lägg till ny måltyp**. Eller klicka på <i class="ph ph-gear" aria-label="Gear"></i> (**Konfigurera mål**) på fliken för att redigera en befintlig måltyp.

2. Klicka på **Typ av mål** för att välja måltypen (dimension) som du vill använda.

3. Klicka på **Måttenhet** för att välja relevant enhet. Vilka enheter som kan väljas beror på den valda måltypen. Om du valde **Kategori** som måltyp, kan du till exempel välja att mäta efter belopp eller antal (antal försäljningar i en kategori).

4. I nästa lista kan du välja specifika element för den måltyp som du har valt. Om du inte väljer något element kommer alla att inkluderas. Exempel: Om du har valt **Kategori** som måltyp kan du välja företagskategorier som du vill skapa mål för.

5. Välj **Endast tillgängligt på företagsnivå och gruppnivå** om denna måltyp inte ska vara tillgänglig på användarnivå, utan endast på grupp-/teamnivå och företagsnivå.

6. Klicka på **Spara**. Den nya måltypen läggs till som en flik. Du kan nu lägga till mål enligt beskrivningen ovan.

> [!NOTE]
> Måltyp och måttenhet kan inte ändras för en befintlig måltyp. Alternativt kan du skapa en ny måltyp med de inställningar som krävs och därefter ta bort den gamla.

### Måltyper (parametrar)

* All försäljning
* Försäljningstyp
* Försäljningskälla
* Försäljning krediterad
* Försäljningskonkurrent
* Företagskategori
* Företagsbransch
* Företagsland

Du kan också ange mål för något av dina egna användardefinierade fält som innehåller listor. När en måltyp har valts, går det inte att välja den typen av mål igen för att undvika att dubbletter skapas.

### Måttenhet

Du kan mäta en försäljning på olika sätt. Välj önskad enhet beroende på vilka enheter ditt företag använder.

* Belopp
* Antal
* Vinst

### Separata målundertyper (dimensioner)

Den lista som är tillgänglig beror på måltypen som valts. Till exempel:

* Om måltypen är inställd på försäljningstyp, visar målundertyperna listan över försäljningstyper som definierats av ditt företag.
* Om måltypen är inställd på källa, visar målundertyperna listan över försäljningskällor som definierats av ditt företag.

Längst ner i dialogrutan finns en kryssruta för Endast tillgängligt på företagsnivå och gruppnivå. När du markerar den här kryssrutan, läggs måltypen bara till på företags- och gruppnivå, och de olika användarna visas inte i din mållista.

> [!NOTE]
> När du har sparat ditt nya mål, kan du fortfarande gå till Inställningar och ändra listan Separata mål och kryssrutan för Endast tillgängligt på företagsnivå och gruppnivå. Tänk på att om du väljer Endast tillgängligt på företagsnivå och gruppnivå först efter att du har lagt till siffror på användarnivå, får du en varning om att användarsiffrorna kommer raderas när de sparas.

När den nya måltypen är sparad, är det dags att [lägga till grupper och användare till ditt försäljningsmål][3].

![Du hittar knappen Lägg till grupper och användare i översikten över försäljningsmål -screenshot][img2]

## Filtrera måltyper

När det gäller måltyperna med målundertypslistan kan du klicka på Filter-knappen och filtrera på de olika listposterna.

![Klicka på filterknappen för att filtrera efter målundertyp -screenshot][img3]

## Ta bort måltyper

För att ta bort en måltyp, klicka på Målinställningar och sedan på knappen Ta bort. Tänk på att borttagning av en måltyp är en åtgärd som inte kan ångras, och den kommer att ta bort alla data för måltypen under tidigare, nuvarande och framtida år. Standardmåltypen Alla försäljningar - belopp går inte att ta bort.

## Relaterat innehåll

* [Använda försäljningsmål i figurer på dashboard][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/user-targets-new-target-type.png
[img2]: ../../../../media/loc/en/sale/user-targets-add-groups-users.png
[img3]: ../../../../media/loc/en/sale/user-targets-filter-type.png
