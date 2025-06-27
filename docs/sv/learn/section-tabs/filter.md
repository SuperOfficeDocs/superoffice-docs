---
uid: help-sv-section-tabs-filter
title: Filtrera detaljkorten
description: Så använder du filter på detaljkorten.
keywords: detaljkort, filter
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
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

Lär dig hur du anpassar vyer genom att konfigurera kolumner med den här korta videon, eller läs instruktionerna nedan:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/HYYI4ZCl4S4]

(videons längd – 2:10)

## Alternativ

| Alternativ | Beskrivning |
|---|---|
| <i class="ph ph-funnel" aria-label="Filter icon"></i> | Du kan filtrera detaljkorten aktiviteter och försäljning efter datum, användare och grupper. Klicka på trattikonen i ett kolumnhuvud för att filtrera på den kolumnen. |
| Aktivitetsfilter (kryssrutor) | Du kan filtrera aktiviteter efter typ (fördefinierade filter). Klicka på pilen och välj vad som. |

> [!NOTE]
> Kolumnfiltret är inte tillgängligt i alla detaljkort. Alla kolumner kan inte filtreras.

## Filtrera aktiviteter och försäljningar

1. Gå till Företag-, Kontakt-, Försäljning- eller Projekt-fönstren.

2. Välj detaljkortet **Aktiviteter** eller **Försäljning**.

3. Klicka på <i class="ph ph-funnel" aria-label="Filter icon"></i>.

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
> Håll muspekaren över filterikon om du vill visa aktiva filterinställningar.
>
> Klicka på **Visa antal** nederst till höger på detaljkortet för att se hur många poster som visas. Antalet ändras beroende på aktiva filter.

## Aktivera kolumnfiltret

1. Klicka på <i class="ph ph-gear" aria-label="Gear"></i> till höger om kolumnrubrikerna och välj **Aktivera filter**.

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

1. Klicka på **Filter**. Detaljkortet uppdateras med poster som motsvarar filtret. Filtrerade kolumner visas med fet text.

1. Upprepa föregående steg för att filtrera efter ytterligare en kolumn.

## Ta bort filter

1. Om du vill ta bort ett filter som du har valt klickar du på trattikonen igen och klickar på **Rensa**.

    Listan över poster i arkivet uppdateras omedelbart.

## Återställa kolumnfiltret

Klicka på <i class="ph ph-funnel" aria-label="Filter icon"></i> och **Återställ** för att återställa filtret.

## Felsökning

* **Jag ser inte trattsymbolen:**
    Kontrollera att kolumnfilter är aktiverade. Klicka på <i class="ph ph-gear" aria-label="Inställningar"></i>-ikonen bredvid kolumnrubrikerna och välj **Aktivera filter**.

* **De förväntade posterna visas inte:**
    Granska dina aktiva filter genom att hovra över trattsymbolen eller kontrollera filterinställningarna för varje kolumn. Återställ filter vid behov genom att klicka på **Återställ**.

* **Jag ser inte kolumnen jag behöver:**
    Klicka på <i class="ph ph-gear" aria-label="Inställningar"></i>-ikonen bredvid kolumnrubrikerna och kontrollera **Valda kolumner**. Lägg till den saknade kolumnen genom att välja den från listan.

## Relaterat innehåll

* [Gruppering av listor][1]
* [Filtrera listan över urvalsmedlemmar][2]

<!-- Referenced links -->
[1]: group.md
[2]: ../../search-options/selection/learn/index.md#filter

<!-- Referenced images -->
[img11]: ../../../media/loc/en/learn/archives-enable-filter.png
[img12]: ../../../media/loc/en/learn/getstarted-archives-filteron.png
