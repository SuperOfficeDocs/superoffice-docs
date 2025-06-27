---
uid: help-sv-sale-create
title: Registrera en försäljning
description: Registrera försäljningar i SuperOffice Sales för att samla alla affärsmöjligheter och kunduppgifter på ett ställe. Den här guiden visar hur du registrerar en försäljning.
keywords: skapa försäljning, ny försäljning, lägg till försäljning, registrera försäljning, försäljning
author: Bergfrid Dias
date: 06.26.2025
version: 10.5.5
content_type: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Registrera en försäljning

Du kan skapa en försäljning i SuperOffice CRM med hjälp av knappen **Nytt** i toppraden.

## Steg

1. Klicka på **Nytt** i toppraden och välj **Försäljning**.

1. Ange en **försäljningstitel** (obligatoriskt, markeras i rött). Detta är den primära identifieraren för försäljningen.

    ![Fliken Försäljning visar grundläggande fält i försäljningskortet -screenshot][img1]

1. Ange **belopp och valuta** för att uppskatta försäljningens värde.

1. Välj **Försäljningstyp** i rullgardinsmenyn (obligatoriskt). Försäljningstyper definierar processen och kan inkludera faser eller guider. Värdena är fördefinierade i **Inställningar och underhåll**.

1. *(Valfritt)* Lägg till mer information på fliken **Försäljning**, såsom:
    * Koppla försäljningen till ett **Företag**.
    * Associera försäljningen med ett pågående **Projekt**.
    * Justera förväntat avslutsdatum för försäljningen.
    * Använd den stora textrutan för att ge en valfri beskrivning av försäljningen.
    * Välj aktuell **Fas** för försäljningen (om tillämpligt). Faser spårar försäljningens framsteg.

    > [!NOTE]
    > Om försäljningstypen inte har några kopplade faser har försäljningen statusen **Öppen**.

1. Välj fliken **Detaljer** för att lägga till finansiell information, såsom kostnad, vinst och konkurrenter.

1. **Lägg till fler detaljer:**
    * Gå till fliken **Mer** för att [ange anpassade fält][12].
    * Gå till fliken **Anteckning** för att [lägga till anteckningar][11].
    * Gå till fliken **Länkar** för att [koppla aktiviteter, dokument eller webbplatser][10] till försäljningen.

1. Klicka på **Spara** för att lagra försäljningen. Försäljningskortet är nu skapat.

## <a id="fields"></a>Viktiga fält förklarade

Följande fält är tillgängliga i fönstret Försäljning. Vissa fält fylls i automatiskt, medan andra kräver manuell inmatning.

> [!NOTE]
> Vilka fält som visas kan variera beroende på inställningar i **Skärmdesignern** och andra UI-anpassningar.

<!-- markdownlint-disable MD051 -->
### [Fliken Försäljning](#tab/sale)

* **Titel:** Ett obligatoriskt fält för att identifiera försäljningen.
* **Beskrivning:** Valfritt textfält för att sammanfatta försäljningen.
* **Försäljningstyp:** Fördefinierade typer som styr processen och kan vara kopplade till faser eller säljguider. Definieras i **Inställningar och underhåll**.
* **Fas:** Spårar försäljningens framsteg. Tillgängliga faser beror på vald försäljningstyp.
* **Belopp och valuta:** Uppskattat värde av försäljningen. *(Valuta måste vara aktiverat i Inställningar och underhåll för att använda detta alternativ.)*
* **Sannolikhet:** Sannolikheten för att försäljningen lyckas (ett procenttal). Baserad på aktuell fas men kan uppdateras manuellt.
* **Företag:** Det företag som försäljningen är kopplad till.
* **Kontakt:** Kontaktpersonen på företaget som är kopplad till försäljningen.
* **Projekt:** Kopplar försäljningen till ett pågående projekt.
* **Ägare:** Den användare som ansvarar för försäljningen. Standard är den inloggade användaren men kan ändras.
* **Försäljningsdatum:** Förväntat avslutsdatum för försäljningen.
* **Nästa aktivitet:** Fylls automatiskt med den äldsta oavslutade händelsen. Datum före dagens datum markeras i rött.
* **Kryssruta för uppskjuten försäljning:** Markerar försäljningen som pausad och aktiverar fält för **Återöppningsdatum** och **Orsak (uppskjuten)**.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Fliken Detaljer](#tab/details)

Fliken **Detaljer** fokuserar på försäljningens finansiella uppgifter.

* **Nummer:** Automatiskt genererat försäljnings-ID.
* **Källa:** Visar försäljningens källa.
* **Konkurrent:** Välj en fördefinierad konkurrent kopplad till försäljningen. Du kan bara välja en konkurrent.
* **Total kostnad:** Kostnad kopplad till försäljningen. Uppdaterar automatiskt vinsten.
* **Vinst:** Vinst beräknad baserat på försäljningsbelopp och kostnad.
* **Tillfaller:** Anger vilken avdelning som ansvarar för försäljningen.

Värden för *Konkurrent* och *Tillfaller* definieras i Inställningar och underhåll.

### [Flikarna Länkar och Anteckning](#tab/other)

* **Fliken Länkar**: Bifoga relevanta aktiviteter, dokument eller andra försäljningar.
* **Fliken Anteckning**: Lägg till fritextanteckningar för att spåra ytterligare information.

***
<!-- markdownlint-enable MD051 -->

## Relaterat innehåll

* [Skapa en offert][4]
* [Uppdatera en försäljning][1]
* [Arbeta med säljguider][2]

<!-- Referenced links -->
[1]: update.md
[2]: sales-guides.md
[4]: quote/create.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/create-sale.png
