---
uid: help-sv-price-list-add
title: Läga till prislista
description: I den här guiden förklarar vi hur man lägger till och redigerar en prislista i SuperOffice Quote.
author: SuperOffice RnD
date: 02.23.2023
keywords: produkt, prislista
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Lägga till prislista

Det är inte ovanligt att man använder olika prislistor för olika tider på året eller för specifika kampanjer som man kanske vill genomföra.

Att anpassa prislistor hjälper dina säljare att använda rätt prisinformation utan att behöva lägga tid på att dubbelkolla den. Du som administratör kan bestämma när en viss prislista ska användas med hjälp av begränsad giltighet.

![Du kan lägga till och redigera alla dina prislistor på fliken SuperOffice-produkter -screenshot][img1]

## Steg

1. [!include[Go to products](../includes/goto-products.md)]

1. Klicka på knappen **Lägg till** högst upp på fliken. Dialogrutan **Lägg till/redigera prislista** öppnas.

1. Fyll i följande fält:

    * **Namn på prislista**: Ge prislistan ett beskrivande namn för att lättare kunna skilja den från andra prislistor.

    > [!NOTE]
    > Du kan inte ändra valutan när du har skapat prislistan. Om du vill aktivera valuta, gå till **Inställningar** > **System** > **Aktivera användning av valuta**.

    * **Beskrivning**: Skriv in en beskrivning av prislistan.

    * **Aktivt**: Kontrollera här för att aktivera prislistan och göra den tillgänglig för att skapa offerter. Du bör inte aktivera prislistan innan den är helt klar.

    * **Begränsad giltighet**: Kontrollera här om prislistan endast kommer gälla under en begränsad period. Till exempel under en tidsbegränsad försäljningskampanj. Du kan välja ett start- eller slutdatum *ELLER* bara ett slutdatum.

1. Gör något av följande:

    * Välj **Lägg till tom prislista** om du vill börja med en tom prislista och lägga in alla produkter manuellt.
    * Välj **Kopiera befintlig prislista** för att kopiera en prislista och alla produkter på denna.

    1. Välj önskad prislista i listan nedan.

    2. Välj ett av följande alternativ:

        * **Konvertera priser från originalprislistan till &lt;currency&gt;**: Välj detta alternativ för att använda de befintliga priserna i prislistan. Om du kopierar en prislista med en annan valutan än prislistan som du skapar, konverteras priserna till rätt valuta.

        * **Ange pris som noll &lt;currency&gt;**: Välj detta alternativ om du inte vill kopiera priserna från prislistan. Du måste ange priserna på alla produkter i prislistan manuellt.

1. Klicka på **OK**.

    > [!NOTE]
    > När prislistan är skapad, kan du inte längre ändra dess valuta och giltighet.

## Vad vill du göra nu?

* [Lägga till produkt i prislista][1]

<!-- Referenced links -->
[1]: add-product-to-price-list.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/quote/add-price-list.png
