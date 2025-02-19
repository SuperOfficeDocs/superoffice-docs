---
uid: help-sv-quote-add-products
title: Lägg till produkter i offert
description: Lägg till produkter i offert
author: SuperOffice RnD
date: 07.04.2022
keywords: offert
topic: howto
language: sv
---

# Lägg till produkter

I dialogrutan **Lägg till/redigera produkt** kan du lägga till en produkt och ange antal, rabatter och annan produktinformation.

## Lägg till en produkt

1. Öppna en offert och klicka på **Lägg till** längst ned på fliken **Produkter** (eller ett alternativ som du har skapat).

1. Dubbelklicka på en produkt i offerten.

1. Om du vill söka i en viss prislista kan du välja den i listan bredvid fältet **Produktsökning**.

1. Börja skriva namnet på produkten eller produktkoden i fältet **Produktsökning**. Träfflistan uppdateras automatiskt. Du kan söka på hela eller delar av både produktnamn och produktkod.

    > [!TIP]
    > Om avancerad sökning stöds, kan du klicka på <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> i fältet **Produktsökning** för att söka efter och [lägga till flera produkter samtidigt](#add-multiple).

1. Klicka på den produkt du vill ha i listan. Dialogrutan uppdateras med produktinformation.

1. Redigera produktantal, rabatt och totalpris, om det behövs. Läs mer nedan.

1. Läs och redigera all produktinformation på flikarna **Beskrivning** och **Detaljer** .

1. Klicka på **Spara + ny** för att spara denna produkt och lägga till en ny produkt
    eller
    Klicka på **Spara** för att spara och återgå till offerten.

## <a id="add-multiple"></a>Lägga till flera produkter i en offert

1. Klicka på **Lägg till** längst ned på fliken **Produkter** i dialogrutan **Redigera offert för**.

2. Börja skriva ett produktnamn i fältet **Produktsökning** för att söka efter en produkt. Klicka på <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> för att söka efter produkter med hjälp av många olika kriterier, till exempel sortiment, produktgrupper/kategorier, namn och varukoder. Sökningen omfattar alla aktiva prislistor med den aktuella valutan.

3. När du har hittat produkterna som du vill lägga till i offerten markerar du dem (**Ctrl+klick**) och klickar på **OK**. Produkterna visas på fliken **Produkter** (eller på fliken för alternativet du har skapat).

4. Dubbelklicka på en produkt för att ändra antal, rabatter och så vidare.

## Redigera antal, rabatter och priser för en produkt

I området till vänster i dialogrutan **Lägg till/redigera produkt** visas produktnamnet/koden och här kan du ange ett antal och eventuella rabatter för den valda produkten.

> [!TIP]
> Du kan visa mer information om de olika fälten (fältnamn, redigerbart fält och beräkningar) genom att hålla muspekaren över dem.

* Figurer som visas i svart kan redigeras.
* Det totala beloppet och rabatterna uppdateras när du redigerar de olika fälten.
* En rabatt kan anges antingen som en procentsats, ett rabattbelopp eller ett totalbelopp.
  * Rabattfältet som du redigerade visas *understruket*.
  * De andra fälten uppdateras så att de motsvarar den rabatt du har definierat.
  * Håll muspekaren över ett rabattfält för att visa eventuella systemrabatter (t.ex. volymrabatter som läggs till automatiskt).
* Om du har angett rabatter som inte är tillåtna av systemet, visas en varning eller annat meddelande.

## Fliken Bild

Här visas en bild av produkten, om detta är definierat i Inställningar och underhåll.

## Fliken Beskrivning

Här visas detaljerad produktinformation, om detta är definierat i Inställningar och underhåll.

## Fliken Detaljer

Här visas prisberäkningar. Innehållet på denna flik definieras i Inställningar och underhåll.

## <a id="warning"></a>Varningar och hur man hanterar dem

I Inställningar och underhåll kan olika regler definieras för vad som är tillåtet och inte tillåtet när du lägger till produkter i en offert. Beroende på hur dessa regler definieras, kan olika ikoner/varningar visas när du lägger till produkter i en offert. I vissa fall måste offerten [godkännas innan den skickas][1].

> [!NOTE]
> Produkter läggs till och sparas i en offert även om varningar och andra meddelanden visas, men du kan inte skicka offerten om den innehåller fel och varningar. Du måste antingen korrigera felet eller få offerten godkänd.

[!include[Table showing quote icons](includes/table-quote-icons.md)]

### Var visas dessa varningar och meddelanden?

* I dialogrutan **Lägg till/redigera produkt**
* I dialogrutan **Redigera offert**
* På produktrader i detaljkortet **Offert** och fliken **Produkter** (och alternativ) i en offert

### Vad orsakar dessa varningar och meddelanden?

Varningar och meddelanden kan till exempel bero på:

* Produkter som inte finns i sortimentet
* Inaktiva prislistor
* Produktpriset är lägre än minimipriset eller självkostnadspriset
* Totalt pris är noll eller negativt
* Totalrabatten är för hög
* Den totala bruttovinsten är för låg

<!-- Referenced links -->
[1]: approve.md
