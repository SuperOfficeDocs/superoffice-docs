---
uid: help-sv-product-add-to-price-list
title: Lägg till produkt i prislistan
description: Så här lägger du till en produkt i prislistan
author: SuperOffice RnD
date: 02.23.2023
keywords: produkt, prislista
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Lägg till produkt i prislistan

När du har lagt till din prislista i SuperOffice Quote, vill du fylla den med dina produkter, så att dina säljare kan använda dem när de skapar ett nytt försäljningsförslag.

När dina produkter och produktinformationen har lagts till, kan dina säljare använda samma prisinformation och följa de rabattriktlinjer som du har konfigurerat.

![Du kan lägga till så många produkter och tjänster i din prislista som du behöver -screenshot][img2]

## Steg

I dialogrutan **Lägg till/redigera produkt** anger du all information om en produkt, inklusive en bild.

1. [!include[Go to products](../includes/goto-products.md)]

1. I listan **Prislista** väljer du den prislista du vill lägga till produkter i.

    [Hur lägger jag till en prislista?][1]

1. Klicka på **Lägg till** längst ned på fliken. Dialogrutan **Lägg till/redigera produkt** visas.

1. Ange information om produkten och lägg till en bild enligt beskrivningen nedan.

1. Markera **Inkludera i prislista** för att göra produkten tillgänglig i prislistan. Du bör inte göra detta förrän du har angett all nödvändig information om produkten.

1. Klicka på **Spara + ny** för att spara denna produkt och lägga till ytterligare en produkt.
    Klicka på **Spara** för att spara och stänga dialogrutan.
    Produkten läggs till i prislistan.

> [!NOTE]
> Du kan också [importera produkter från ett kalkylark][5].

## Lägg till bild

Se [Välja en produktbild][2].

## Lägg till beskrivning

I fältet nere till vänster kan du skriva in en beskrivning av den aktuella produkten.

## Lägg till produktinformation

I listan till höger kan du lägga till produktinformation. Denna kan inkludera:

* Textfält: Här anger du text och siffror, till exempel produktnamn, produktkod och momsinformation.

* Sifferfält: Här anger du en siffra, till exempel självkostnadspris, minimipris och antal.

* Listor: Här väljer du alternativ från listan, som enheter, produkttyp och produktgrupp. Du kan lägga till fler alternativ i dessa listor i fönstret **Listor** [Lägg till poster i en lista][4].

* Lista med sökfunktioner: Här kan du välja från listan över senaste poster, ange text för att starta en sökning eller klicka på sökknappen (<i class="ph ph-magnifying-glass" aria-hidden="true"></i>) för att starta en avancerad sökning.

### Hur man ändrar namn och ordning och gör fält redigerbara och/eller obligatoriska

I [dialogrutan Konfigurera produkt][3] definierar du ordningen och namnet på fältet som visas här och om de är redigerbara eller obligatoriska.

Du kan åsidosätta inställningarna för redigerbart och obligatoriskt genom att markera **Åsidosätt standardsäkerhet** längst ned i dialogrutan **Lägg till/redigera produkt**. Ändringarna gäller endast för den här produkten.

### Visas alla dessa fält i SuperOffice CRM?

[!include[Why set all fields when creating product](../includes/quote-config-product.md)]

För att ta reda på vilka fält som visas, gå till fliken **Inställningar** och klicka på **Konfigurera produkt** (se [Konfigurera produkter][3]).

<!-- Referenced links -->
[1]: add-price-list.md
[2]: select-product-image.md
[3]: configure.md
[4]: ../../../../admin/lists/learn/adding-items.md
[5]: ../../../../admin/import/learn/import-products-from-excel.md

<!-- Referenced images -->
[img2]: ../../../../../media/loc/en/quote/add-products-to-price-list.png
