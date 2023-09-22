---
uid: help-sv-document-dialog
title: Dialogrutan Dokument
description: Dialogrutan Dokument
author: SuperOffice RnD
so.date: 06.29.2022
keywords: dokument
so.topic: concept
language: sv
---

# Dialogrutan Dokument

Många dokumentfunktioner hanteras via dialogrutan **Dokument**, som du kan öppna på flera olika sätt:

* Genom att välja **Nytt** > **Dokument**.
* Genom att öppna ett [befintligt dokument][1].

Dialogrutan består av en huvuddel med allmän information om dokumentet samt följande flikar med tilläggsinformation:

* Specifikation
* Länkar
* Mer

## Huvuddel

Huvuddelen innehåller följande grundläggande information om dokumentet:

### Dokumentmall

Om du klickar på pilen ![ikon][img1] bredvid fältet för typ högst upp i dialogrutan visas en lista över dokumentmallar du kan välja bland. [!include[SM](../../../learn/includes/are-defined-sm.md)]

> [!NOTE]
> När du [skapar ett dokument][5] öppnas mallen i det program den skapades i. DOCX-filer öppnas till exempel i Word.

### Företag

Här skriver du in namnet på den kontakt du skriver dokumentet till. Du kan söka direkt från detta fält.

### Kontaktperson

När du klickar på pilen efter detta fält visas en lista över kontakter som är registrerade för företaget.

### Projekt

Här kan du skriva in namnet på ett projekt som dokumentet är kopplat till. Du kan söka direkt från detta fält.

### Försäljning

Skriv in namnet på den försäljning som dokumentet är kopplat till (i förekommande fall). Du kan söka direkt från detta fält.

### Skriv rubriken här

Skriv in den text som ska användas som rubrik i dokumentet (den text som visas i detaljkort och rapporter där dokumentet finns med).

### Språk

Välj språk för mallen. Det här alternativet är bara tillgängligt om den valda mallen finns i översatta versioner.

### Datum

Här visas automatiskt dagens datum. Om du klickar på pilen bredvid **Datum**-fältet visas en månadsvy där du kan välja önskat datum.

> [!NOTE]
> Du kan bara ändra datum när du skapar dokumentet. Det här fältet är inte tillgängligt i redigeringsläget.

### Vår ref

Här kan du skriva in namnet på din referens. Standardvärdet för varje mall definieras under Inställningar och underhåll, men du kan också redigera fältets innehåll.

### Din ref

Här kan du skriva in namnet på företagets referens.

### Synlig för

Klicka i fältet **Synlig för** för att visa en lista där du kan välja om dokumentet ska vara synligt för alla användare, privat (bara synligt för den användare som definierats som ägare) eller synligt för alla användare i användargruppen som användaren tillhör.

> [!NOTE]
> Om du anger att dokumentet bara ska vara synligt för ägaren visas det i kursiv stil på detaljkortet **Aktiviteter**.

### Utcheckat för redigering

Om dokumentet har checkats ut för redigering visas en av följande ikoner:

![ikon][img2] Dokumentet är för tillfället utcheckat för redigering av dig.

![ikon][img3] Dokumentet är för tillfället utcheckat för redigering av en annan användare.

> [!TIP]
> Håll muspekaren över en ikon för att visa information om användaren som har checkat ut dokumentet.

### Slutförd

Som standard markeras dokumentet som slutfört (![ikon][img4]), men du kan ta bort denna markering om du vill (![ikon][img5]). Dokumentet visas då på detaljkortet **Aktiviteter** i fönstret Kalender tills det markeras som slutfört.

> [!NOTE]
> Du kan inte göra ändringar i slutförda dokument förrän du har inaktiverat deras **Slutfört**-status. [Så ändrar du Slutförd-status för en aktivitet][7].

### Användardefinierade fält

[!include[3 udef](../../../learn/includes/more-udef.md)]

> [!NOTE]
> Användargrupptillhörighet definieras i fönstret Användare under Inställningar och underhåll.

### Uppgift

När du klickar på denna knapp visas följande alternativ:

* **Ta bort**: Tar bort den aktuella posten.
* **Hjälp**: Öppnar hjälpen för den aktiva dialogrutan.
* **Kopiera genväg**: En [genväg till den aktiva posten][9] kopieras.
* **Hämta sparad version**: Välj det här alternativet om du vill [avbryta en utcheckning][4]. Till exempel om du har checkat ut dokumentet av misstag och inte kan checka in det igen.

Nedanför dessa alternativ finns det genvägar till andra relevanta uppgifter som kan utföras på den aktiva posten. Under Inställningar och underhåll kan du även definiera egna uppgifter och lägga till dem under knappen **Uppgift**.

## Fliken Detaljer

Fliken **Detaljer** innehåller detaljerad information om dokumentet.

* **Beskrivning:** Här kan du lägga in en beskrivning av dokumentet. Detta kan vara praktiskt i samband med fritextsökning.

* **Dokument:** Klicka på länken för att ladda upp dokumentet eller dra och släpp dokumentet från Utforskaren till dialogrutan **Dokument**.

    Mer information finns under [Skapa nya dokument][5] och [Redigera dokument][1].

**Publicera:** Markera det här alternativet om du vill att dokumentet ska vara synligt för externa användare i Audience (kräver separat licens).

## Fliken Länkar

Den här fliken innehåller information om aktiviteter (dokument och händelser) och försäljningar som har kopplats till det aktuella dokumentet. Om något är registrerat på den här fliken visas en knappnålssymbol bredvid **Länkar**.

[Läs mer om hur du lägger till länkar][2].

## Fliken Mer

På den här fliken visas alla [användardefinierade fält][3] som har konfigurerats under Inställningar och underhåll.

## Fliken www

[!include[About the www tab](../../../learn/includes/www-tab.md)]

<!-- Referenced links -->
[1]: ../edit.md
[4]: ../lock.md
[5]: ../create.md
[7]: ../../../diary/learn/change-completed-status.md
[9]: ../../../onsite/win-client/learn/creating-shortcuts-to-entries-in-crm.md
[2]: ../../../diary/learn/linking-documents-to-follow-ups.md
[3]: ../../../custom-objects/learn/udef/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/dropdown-icon.png
[img2]: ../../../../media/icons/document-lock-editing.png
[img3]: ../../../../media/icons/document-lock-locked.png
[img4]: ../../../../media/icons/followup-completed-small.png
[img5]: ../../../../media/icons/followup-not-completed-small.png
