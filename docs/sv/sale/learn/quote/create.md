---
uid: help-sv-quote-create
title: Skapa en offert
description: Lär dig hur du skapar en offert i SuperOffice CRM, inklusive hur du lägger till produkter, redigerar offerten och löser vanliga problem.
keywords: skapa offert, kopiera offert, lägg till produkt, Lägg till/redigera produkt-dialogruta, dialogrutan Redigera offert, offert
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/quote/learn/add-product
  - /sv/quote/learn/copy
  - /sv/quote/learn/create
  - /sv/quote/learn/screen/edit-quote-dialog
---

# Skapa en offert

I SuperOffice CRM kan du skapa en offert från början eller kopiera en från en annan försäljning. När offerten är skapad kan du lägga till produkter, justera priser och förbereda förslaget till kunden.

## Skapa en ny offert

1. [Skapa en ny försäljning][1] eller öppna en befintlig försäljning (en som inte är markerad som Såld eller Förlorad).

1. Gå till detaljkortet **Offert**.

1. Klicka på **Skapa en ny offert**.

1. Dialogrutan **Redigera offert** öppnas. Härifrån kan du [lägga till produkter](#add-products) och redigera offertdetaljerna.

![Dialogrutan Redigera offert -screenshot][img1]

## <a id="copy"></a>Kopiera en offert från en annan försäljning

För att spara tid kan du återanvända en befintlig offert från en annan försäljning som använder samma valuta.

1. Öppna en försäljning utan offert och gå till detaljkortet **Offert**.

1. Klicka på **Kopiera offert från en annan försäljning**.

1. I dialogrutan **Skapa ny offert som baseras på en tidigare offert**:

    * Välj en försäljning från listan (måste innehålla en offert i samma valuta).
    * Eller, börja skriva för att söka efter försäljningsnamn.

1. Klicka på **OK**. Offerten och alla dess alternativ kopieras till den aktuella försäljningen och visas i detaljkortet **Offert** med status **Utkast**.

1. Klicka på **Öppna** för att visa eller redigera offerten i dialogrutan **Redigera offert**.

## <a id="add-products"></a>Lägg till produkter i offerten

### Lägg till en produkt

1. Gå till fliken **Produkter** i offerten och klicka på **Lägg till**.
    Dialogrutan **Lägg till/redigera produkt** öppnas.

1. Börja skriva i fältet **Produktsökning** för att hitta en produkt efter namn eller kod.

1. Välj en produkt från listan.

    Produktfälten fylls i automatiskt baserat på vald prislista.

1. Ange **antal** (obligatoriskt).

1. Du kan även justera priset med något av följande fält:

    * **Rabatt i procent**
    * **Rabattbelopp**
    * **Totalpris**

    Håll muspekaren över ett rabattfält för att visa eventuella systemrabatter (t.ex. volymrabatter som läggs till automatiskt).

1. Gå till fliken **Detaljer** för att:

    * Visa eller justera **bruttovinst** (procent eller belopp)
    * Eventuellt ange **moms**

    > [!NOTE]
    > Rabatt, totalpris och bruttovinst är sammankopplade. Om du ändrar ett fält uppdateras de andra automatiskt. Det senast redigerade fältet markeras.
    >
    > Om du anger en rabatt som inte är tillåten av systemet visas en varning eller ett annat meddelande.

1. Valfritt: Visa produktinformation under fliken **Beskrivning** eller **Bild**.

1. Klicka på **Spara** för att lägga till produkten i offerten, eller klicka på **Spara + ny** för att omedelbart lägga till ytterligare en produkt.

![Dialogrutan Lägg till/redigera produkt -screenshot][img2]

### Lägg till flera produkter

För att lägga till flera produkter samtidigt använder du avancerad sökning.

1. På fliken **Produkter**, klicka på **Lägg till**.

1. Klicka på <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> för att öppna dialogrutan **Hitta produkter**.

1. Använd ett eller flera kriterier för att begränsa listan. Klicka på **Lägg till kriterium** för att lägga till fler filter.

    Sökningen inkluderar alla aktiva prislistor med försäljningens valuta.

1. Välj de produkter du vill lägga till: **Ctrl+klick** (Windows) eller **Cmd+klick** (Mac) för att markera flera.

1. Klicka på **OK**. Alla markerade produkter läggs till i offerten.

    Du kommer tillbaka till dialogrutan **Redigera offert**.

1. För att ange antal (och eventuellt uppdatera rabatt, pris eller bruttovinst), dubbelklicka på varje produktlinje.

## Ange betalnings- och leveransalternativ

Innan du skickar offerten eller skapar offertdokumentet, gå till fliken **Detaljer** i offerten.

Här kan du ange:

* **Betalningsvillkor** och **betalningstyp**
* **Leveransvillkor** och **leveranstyp**
* **Fakturaadress** och **leveransadress**

Dessa fält inkluderas i offertdokumentet och används vid orderläggning.

## Felsökning

### Varför visas dialogrutan "Välj ERP-koppling"?

Denna dialogruta visas om:

* Det inte finns någon prislista för vald valuta
* Det finns flera ERP-kopplingar tillgängliga

**Lösning:** Välj en annan valuta eller kontrollera att en giltig prislista finns. Välj sedan rätt ERP-koppling.

> [!NOTE]
> För att aktivera valutaval i en försäljning, gå till **Inställningar och underhåll** > **Inställningar** och aktivera **Användning av valuta**.

### Varför hittar jag inte den försäljning jag vill kopiera från?

När du kopierar en offert visar listan **Försäljningar** endast de försäljningar som:

* Innehåller en befintlig offert
* Använder samma valuta som aktuell försäljning

**Lösning:**

* Kontrollera att försäljningen du vill kopiera från innehåller en offert
* Kontrollera att båda försäljningarna använder samma valuta
* Ändra vid behov valutan på aktuell försäljning

Om listan fortfarande är tom finns det inga matchande försäljningar att kopiera från.

### Varför är OK-knappen inaktiverad vid kopiering?

Du kanske inte har åtkomst till den ERP-koppling som används i offerten.
Håll muspekaren över **OK**-knappen för att se vilken koppling som är begränsad.

## <a id="warning"></a>Varför visas varningar eller fel?

När du lägger till eller redigerar produkter i en offert kan SuperOffice visa ett meddelande om något överskrider de tillåtna gränserna.

Vanliga orsaker kan vara:

* Produkter som inte finns i sortimentet
* Inaktiva prislistor
* Rabatten är för hög
* Bruttovinsten är för låg
* Priset är för lågt eller noll

Systemet visar ett av följande ikoner:

| Ikon | Meddelandetyp | Beskrivning | Vad du ska göra |
|:-:|---|---|---|
| <i class="ph ph-info" aria-label="Info icon"></i> | Information | Ett meddelande visas för offerten, men offerten kan fortfarande skickas. | Valfritt: Läs och åtgärda vid behov |
| <i class="ph ph-warning" aria-label="Warning icon"></i> | Varning | Offerten måste godkännas innan den kan skickas. | [Godkännande krävs][7] |
| <i class="ph ph-circle-wavy-warning" aria-label="Error icon"></i> | Fel | Offerten kan inte skickas på grund av ett fel. | Åtgärda felet innan du skickar |

Dessa meddelanden kan visas på följande platser:

* I dialogrutan **Lägg till/redigera produkt**
* I dialogrutan **Redigera offert**
* På produktrader i detaljkortet **Offert**
* I fliken **Produkter** och i alternativflikar i offerten
* När du försöker skicka eller lägga en order

## Relaterat innehåll

* [Lägga till alternativ i en offert][5]
* [Skapa ett offertdokument][6]
* [Skicka en offert][7]
* [Skapa en order][8]
* [Konfigurera dina produkter och priser i Inställningar och underhåll][9]

<!-- Refererade länkar -->
[1]: ../create.md
[5]: add-alternative.md
[6]: create-quote-document.md
[7]: send.md
[8]: place-order.md
[9]: ../../admin/quote/price-list-and-products.md

<!-- Refererade bilder -->
[img1]: ../../../../media/loc/en/sale/edit-quote-dialog-empty.png
[img2]: ../../../../media/loc/en/sale/add-edit-product-dialog.png
