---
uid: help-sv-section-tabs-filter
title: Filtrera detaljkorten
description: Så använder du filter på detaljkorten.
keywords: detaljkort, filter
author: Bergfrid Dias
date: 09.17.2024
version: 10.3.9
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Filtrera detaljkorten

Detaljkorten i SuperOffice CRM kan innehålla stora mängder data, till exempel kontakter, aktiviteter och försäljningar.

Ett bra sätt att snabbt hitta information är att använda filter. Filter minskar mängden information du tittar på, vilket gör att det går snabbare att hitta det du letar efter.

Du kan filtrera innehållet i detaljkort genom att lägga till kriterier i en eller flera kolumner.

Filter är personliga. De filter du använder visas bara för dig och du kan lägga till och ta bort filter när som helst.

Flera filter kan vara aktiva på samma gång. Om en detaljkort inte visar förväntade data kontrollerar du dina filterinställningar.

Lär dig hur du anpassar vyer genom att konfigurera kolumner med den här korta videon, eller läs instruktionerna nedan (videons längd – 2:10):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/HYYI4ZCl4S4]

## Alternativ

| Alternativ | Beskrivning |
|---|---|
| ![ikon][img2] (filterikonen) | Du kan filtrera detaljkorten aktiviteter och försäljning efter datum, användare och grupper. |
| Aktivitetsfilter (kryssrutor) | Du kan filtrera aktiviteter efter typ (fördefinierade filter). Klicka på pilen och välj vad som. |
| ![ikon][img3] (kolumnfilter) | Klicka på trattikonen i ett kolumnhuvud för att filtrera på den kolumnen. |

> [!NOTE]
> Kolumnfiltret är inte tillgängligt i alla detaljkort. Alla kolumner kan inte filtreras.

## Filtrera aktiviteter och försäljningar

1. Gå till Företag-, Kontakt-, Försäljning- eller Projekt-fönstren.

2. Välj detaljkortet **Aktiviteter** eller **Försäljning**.

3. Klicka på ![ikonen][img2] filterikon.

4. I rutan **Från** anger du datum för hur långt tillbaka i tiden aktiviteter och försäljningar ska visas.

5. I fältet **Till** anger du datum för hur långt fram i tiden aktiviteter och försäljningar ska visas.

    Klicka på pilen till höger om fältet **Till** så visas en lista över möjliga tidsintervall. Till exempel visning av alla aktiviteter eller försäljningar som har definierats för nästa kvartal.

6. Välj något av följande alternativ:

    * Om du vill visa aktiviteterna eller försäljningarna för en viss grupp markerar du den posten i listan **Grupper**. Gruppens medlemmar markeras då i listan **Medarbetare** till höger.

    * Om du vill visa aktiviteterna eller försäljningarna för en eller flera medarbetare markerar du dessa i listan **Medarbetare**. Om du vill markera flera håller du CTRL-tangenten intryckt medan du markerar kontakterna.

    * Om du vill visa dina egna aktiviteter eller försäljningar väljer du **Mina**.

    * Om du vill visa aktiviteterna eller försäljningarna för alla grupper och medarbetare väljer du **Alla**.

7. Klicka på **OK**. Flikarna visar alla aktiviteter eller försäljningar som matchar de kriterier du angav.

> [!TIP]
> Håll muspekaren över ![ikonen][img2] filterikon om du vill visa aktiva filterinställningar.
>
> Klicka på **Visa antal** nederst till höger på detaljkortet för att se hur många poster som visas. Antalet ändras beroende på aktiva filter.

## Aktivera kolumnfiltret

1. Klicka på ![ikonen][img1] till höger om kolumnrubrikerna och välj **Aktivera filter**.

    ![Klicka på knappen Inställningar i det arkiv du har valt. -screenshot][img11]

1. Klicka på **OK**.

Nu har alla kolumner i ditt arkiv en trattikon bakom sig.

## Lägg till kolumnfilter

1. Öppna detaljkortet som innehåller den information du letar efter.

1. Klicka på trattikonen för den kolumn du vill använda för att hitta den information du behöver.

    ![Du kan klicka på filterikonen i kolumnen och välja önskat filter -screenshot][img12]

1. I dialogrutan väljer du den information du letar efter. Gör något av följande beroende på typen av data i kolumnen:

    * Skriv in text och tryck på ENTER. Standardfiltertypen är "börjar med".
    * Välj en post från listan.
    * Välj ett datumintervall.

    Om du till exempel letar efter ett dokument som skapats av en av dina kollegor väljer du hans/hennes namn och vilken typ av dokument du letar efter.

    ![Klicka på Filter för att ställa in det och visa det filtrerade arkivet -screenshot][img13]

1. Klicka på **Filter**. Detaljkortet uppdateras med poster som motsvarar filtret. Filtrerade kolumner visas med fet text.

1. Upprepa föregående steg för att filtrera efter ytterligare en kolumn.

    ![Se arkivet med färre entiteter -screenshot][img14]

## Ta bort filter

1. Om du vill ta bort ett filter som du har valt klickar du på trattikonen igen och klickar på **Rensa**.

    Listan över poster i arkivet uppdateras omedelbart.

## Återställa kolumnfiltret

Klicka på ![ikon][img2] och **Återställ** för att återställa filtret.

## Relaterade ämnen

* [Gruppering av listor][1]
* [Filtrera listan över urvalsmedlemmar][2]

<!-- Referenced links -->
[1]: group.md
[2]: ../../search-options/selection/learn/screen/index.md#filter

<!-- Referenced images -->
[img1]: ../../../../common/icons/cog-wheel.png
[img2]: ../../../../common/icons/filter-icon.png
[img3]: ../../../media/icons/filter-column.png

[img11]: ../../../media/loc/en/learn/archives-enable-filter.png
[img12]: ../../../media/loc/en/learn/getstarted-archives-filteron.png
[img13]: ../../../media/loc/en/learn/getstarted-archives-filter-ownersetting.png
[img14]: ../../../media/loc/en/learn/getstarted-archives-filter-owner.png
