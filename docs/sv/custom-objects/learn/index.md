---
title: Egendefinierade objekt
uid: help-sv-custom-objects
description: Egendefinierade objekt
author: Bergfrid Dias
so.date: 02.23.2023
keywords: anpassa objekt
so.topic: concept
language: sv
so.audience: settings
so.audience.tooltip: Settings and maintenance
---

# Egendefinierade objekt

## Användardefinierade fält

Alla företag och organisationer har sina egna krav på vilken information de behöver registrera om sina kontakter, försäljningar, projekt, avtal och så vidare. I fönstret **Fält** kan du skapa egna fält i SuperOffice CRM. På så sätt kan du anpassa vilken typ av information som kan registreras om företag, kontakter, projekt, försäljningar, dokument och händelser.

## Egendefinierade fält och tabeller

Ett bra exempel på ett egendefinierat fält som du kan använda på **kontaktkortet** är ett fält som heter "Nöjd kund" med värdet Ja eller Nej.

Du kan till exempel skicka ett utskick till dina kontakter (med länkåtgärder) där de kan ange om de är nöjda med din service. På så sätt får du värdefull information om den generella kundnöjdheten.

Naturligtvis kan du lägga till många olika tabeller och fält i SuperOffice för att spara all information som dina kundtjänstmedarbetare behöver.

![I fönstret Tabeller kan du välja att (a) skapa ett extrafält eller (b) skapa en ny tabell -screenshot][img1]

### Extratabeller

* [Introduktion till extratabeller][3]
* [Definiera en tabell][4]

### Anpassa fält

Alla företag och organisationer har sina egna krav på vilken information de behöver registrera. Informationen kan gälla företag, kontakter, försäljningar, projekt och så vidare. Som administratör kan du lägga till egna fält under Inställningar och underhåll.

* [Användardefinierade fält][1]
* [Tilläggsfält][2]

#### Fördelar med att lägga till fält

Med sökfunktionen kan du söka efter den information du lägger in i de här fälten och göra urval.

Om du till exempel registrerar förfallodatumet för underhållsavtalet du tecknar med dina kontakter kan du skapa ett dynamiskt urval som visar alla kontakter vars avtal löper ut om mindre än en månad.

Du kan återanvända informationen från de här fälten i dokument och e-postmeddelanden med hjälp av mallvariabler. Varje fält som du lägger till får ett unikt ID (Program-ID), som kan användas i dokument för att slå ihop kontaktspecifik information.

Om du vill skicka ett e-postmeddelande till dina kontakter som informerar dem om att deras underhållsavtal snart löper ut kan du alltså använda mallvariabeln för förfallodatum för att visa rätt förfallodatum för deras avtal i meddelandet.

#### Placering

Alla anpassade sidolayouter (skapade i Skärmdesigner) som använder Skärmdesigner kan åsidosätta inställningarna för fälten.

Om du inte har licens för konfigurerbara skärmbilder använder du rangordningen för de olika fälten.

## Relaterat innehåll

* [Skärmdesigner][5]

<!-- Referenced links -->
[1]: udef/index.md
[2]: extra-field/create.md
[3]: extra-table/index.md
[4]: extra-table/create.md
[5]: ../../ui/screen-designer/learn/index.md

<!-- Referenced images -->
[img1]: media/create-extra-tables-and-fields.png
