---
uid: help-sv-sales-guide
title: Säljguide
description: Introduktion till säljguider i SuperOffice.
keywords: säljguide, guide, arbetsflöde, detaljkortet Säljguide, försäljningsprocessen, försäljningspipeline, försäljning, fas, föreslagna händelser, föreslagna dokument
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/sale/learn/sales-guide/index
  - /sv/sale/learn/sales-guide/sales-guide-tab
  - /sv/sale/learn/sales-guide/working-with-sales-guide
  - /sv/sale/learn/screen/sales-guide-admin
  - /sv/sale/learn/screen/sales-guide-tab
---

# Säljguider

Säljguider i SuperOffice CRM är kraftfulla verktyg som hjälper till att förenkla och standardisera försäljningsprocessen genom att koppla försäljningstyper till fördefinierade faser. Varje fas innehåller föreslagna händelser och dokument som guidar säljarna genom en strukturerad försäljningspipeline. Detta säkerställer att inga affärsmöjligheter missas och att hela teamet arbetar enhetligt.

> [!NOTE]
> Den här funktionen kräver licensen Sales Premium.

## Vad är en säljguide?

En säljguide består av:

* **Faser:** Fördefinierade steg i försäljningsprocessen, såsom "Första mötet", "Offert" eller "Kontraktsunderskrift". Varje fas har ett namn, en sannolikhetsprocent och en beskrivning.
* **Händelser:** Aktiviteter såsom samtal eller möten som är kopplade till varje fas.
* **Dokument:** Mallar för offerter, avtal eller e-postmeddelanden som är relevanta för försäljningsprocessen.

När du skapar en försäljning eller ändrar dess typ till en som är kopplad till en säljguide, aktiveras guiden automatiskt på detaljkortet **Säljguide**. Detta kort ger en översikt över faser, händelser och dokument för försäljningen.

**Exempel:**

En försäljningstyp för att vinna nya kunder kan innehålla:

* **Första mötet:** Kundmöte och introduktionsmejl.
* **Offert:** Förbered och skicka offerten.
* **Kontraktsunderskrift:** Underteckna kontraktet och planera uppföljning.

Säljguider konfigureras i **Inställningar och underhåll** och kan anpassas efter din organisations arbetsflöden.

## Hur fungerar en säljguide?

Titta på den här videon för att se hur enkelt det är att arbeta med säljguider:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IyETjAtn3po]

(videolängd – 1:24)

### Steg

1. **Börja med en fas:** När du skapar eller ändrar en försäljning med en kopplad säljguide, sätts den första fasen automatiskt. Detaljkortet **Säljguide** visar de händelser och dokument som hör till fasen.

2. **Skapa aktiviteter:** Händelser och dokument kan skapas direkt från detaljkortet **Säljguide**:
    * Klicka på **Skapa** bredvid händelsen eller dokumentet.
    * Många av fälten är redan ifyllda, men du kan ändra informationen eller lägga till mer information. Fyll i de återstående fälten i dialogrutan och spara.

    > [!TIP]
    > Tilldela händelser till specifika teammedlemmar för bättre samarbete.

3. **Markera händelser som slutförda:** När du har genomfört en händelse, markera kryssrutan bredvid dess namn i detaljkortet **Säljguide**. Dokument markeras automatiskt som slutförda när de skapas.

    Slutförda aktiviteter visas även på detaljkortet **Aktiviteter**.

4. **Gå till nästa fas:** När alla aktiviteter för en fas är klara, eller om det behövs:
    * Flytta försäljningen manuellt till nästa fas eller låt det ske automatiskt (om det är konfigurerat).
    * Säljguiden uppdateras och visar de föreslagna händelserna och dokumenten för nästa fas.

5. **Fortsätt till försäljningen är klar:** Arbeta dig igenom faserna tills försäljningen markeras som **Såld** eller **Förlorad**.

> [!NOTE]
> Du kan gå vidare till nästa fas utan att ha slutfört alla händelser för den aktuella fasen.

## <a id="sales-guide-tab"></a>Detaljkortet Säljguide

Detaljkortet **Säljguide** ger en visuell och funktionell översikt över försäljningsprocessen, vilket hjälper säljare att hålla koll på sina affärer och hantera uppgifter effektivt.

![Detaljkortet Säljguide som visar status för Första mötet -screenshot][img1]

### Viktiga komponenter

* **Fasknappar:** Längst upp visas knappar som representerar de fördefinierade faserna, såsom **Första mötet**, **Offert** och **Kontraktsunderskrift**.

    ![Faser i säljguiden -screenshot][img2]

  * **Aktuell fas:** Markeras med en fylld cirkel (<i class="ph ph-fill ph-circle" aria-hidden="true"></i>).
  * **Framtida faser:** Markeras med en tom cirkel (<i class="ph ph-circle" aria-hidden="true"></i>).
  * **Slutförda faser:** Markeras med en bock (<i class="ph ph-check" aria-hidden="true"></i>).

* **Aktiviteter:** Kortet är indelat i två kolumner: **Händelser** och **Dokument**. Varje rad innehåller en **Skapa**-länk som gör det möjligt att generera den aktuella händelsen eller dokumentet direkt från detaljkortet.

    > [!TIP]
    > Använd kryssrutan **Visa alla faser** för att se alla aktiviteter och dokument för samtliga faser.

## Skapa en händelse eller ett dokument

För att skapa en händelse eller ett dokument som är kopplat till en säljguide:

1. Gå till detaljkortet **Säljguide**.
2. Leta upp händelsen eller dokumentet under den aktuella fasen.
3. Klicka på **Skapa** bredvid objektet.

    * För händelser öppnas [dialogrutan Händelse][6] med förifyllda fält baserat på inställningarna i säljguiden. Justera vid behov och klicka på **Spara**.

    * För dokument öppnas [dialogrutan Dokument][7] med en förvald mall. Fyll i de obligatoriska fälten och klicka på **Spara**.

> [!TIP]
> Du kan skapa flera händelser eller dokument av samma typ genom att högerklicka på ett objekt och välja **Skapa en till**.

## Markera en händelse som slutförd

1. På detaljkortet **Säljguide**, leta upp händelsen.
2. Markera kryssrutan bredvid händelsens namn. Händelsen markeras nu som slutförd och visas som en avslutad aktivitet på detaljkortet **Aktiviteter**.

Dokument markeras automatiskt som slutförda när de skapas.

### Varför öppnas dialogrutan Säljguide när jag markerar en händelse som slutförd?

I Inställningar och underhåll kan du ange att en händelse i en säljguide ska föreslås automatiskt när föregående händelse markeras som slutförd. Då öppnas dialogrutan **Säljguide** när du markerar föregående händelse som slutförd.

I dialogrutan **Säljguide** har du tre alternativ:

* Klicka på **Skapa** för att skapa nästa händelse i säljguiden. Du kommer då direkt till dialogrutan för händelsen.

* Klicka på **Avbryt** om du inte vill skapa händelsen nu. Dialogrutan **Säljguide** stängs och du måste komma ihåg att skapa händelsen senare.

* Markera **Skapa alltid händelse? Visa inte den här dialogrutan igen** om du i framtiden alltid vill skapa den föreslagna händelsen. Då öppnas dialogrutan för händelser automatiskt nästa gång.

> [!TIP]
> För att återställa det här alternativet, så att dialogrutan **Säljguide** öppnas, gå till <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** > **Inställningar** > **Försäljning** och välj **Ja** för alternativet **Bekräfta skapande av föreslagen händelse**.

## <a id="change-stage"></a>Flytta till nästa fas

Säljguider stöder både manuell och automatisk övergång mellan faser.

### Automatisk fasövergång

Om funktionen är aktiverad föreslås nästa fas automatiskt när alla obligatoriska händelser och dokument i den aktuella fasen är slutförda. Du kan välja att gå vidare eller stanna kvar i den aktuella fasen.

![Dialogruta för automatisk fasövergång -screenshot][img3]

1. Slutför alla obligatoriska händelser och dokument för den aktuella fasen.
2. När dialogrutan visas klickar du på **Ja** för att gå vidare till nästa fas eller **Nej** för att stanna i den aktuella fasen.

> [!NOTE]
> Automatisk fasövergång måste vara aktiverad i **Inställningar och underhåll** för att den här funktionen ska fungera.

### Manuell fasövergång

Du kan flytta försäljningen till nästa fas manuellt, även om inte alla händelser och dokument i den aktuella fasen har slutförts.

1. Högerklicka på knappen för önskad fas på detaljkortet **Säljguide**.
2. Välj **Gå till denna fas** i menyn.

Alternativt:

1. Klicka på **Redigera** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) på försäljningskortet.
2. Använd listrutan **Fas** för att välja nästa fas.
3. Klicka på **Spara**.

> [!TIP]
> Du kan också gå tillbaka till en tidigare fas genom att följa samma steg.

## Fördelar med säljguider

* **Konsekvens:** Standardiserar försäljningsprocesser i hela organisationen.
* **Effektivitet:** Ger tydliga steg, mallar och uppgifter för varje fas.
* **Synlighet:** Hjälper säljare att fokusera på den aktuella fasen och kommande uppgifter.

## Relaterat innehåll

* [Introduktion till försäljning][1]
* [Skapa en försäljning][2]
* [Säljguide - handledning][3]
* [Skapa en ny säljguide][4]
* [Redigera eller inaktivera en säljguide][5]

<!-- Referenced links -->
[1]: index.md
[2]: create.md
[3]: tutorial.md
[4]: ../admin/create-sales-guide.md
[5]: ../admin/edit-sales-guide.md
[6]: ../../diary/learn/create-follow-up.md
[7]: ../../document/learn/edit.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/sales-guide-tab.png
[img2]: ../../../media/loc/en/sale/guide-stages.png
[img3]: ../../../media/loc/en/sale/goto-next-stage.png
