---
uid: help-sv-price-list-and-products
title: Hantera prislistor och produkter
description: Lär dig hur du skapar och hanterar prislistor och produkter i SuperOffice-produktregistret för användning i offerter.
keywords: prislista, lägg till produkt, konfigurera produkt, produktbild, inaktivera produkt, produkt, offert
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from:
  - /sv/quote/learn/admin/product/add-price-list
  - /sv/quote/learn/admin/product/add-product-to-price-list
  - /sv/quote/learn/admin/product/index
  - /sv/quote/learn/admin/product/quote-delete-deactivate-price-list-or-product
  - /sv/quote/learn/admin/product/select-product-image
index: true
---

# Hantera prislistor och produkter

På fliken **SuperOffice-produkter** i skärmen **Offert/Synk** definierar du prislistor och lägger till produkter så att de kan användas i offerter i SuperOffice CRM. Detta gäller när du använder **SuperOffice Standalone-connectorn** (ingen ERP-integration).

![Du kan lägga till och redigera alla dina prislistor på fliken SuperOffice-produkter -screenshot][img2]

Använd flera prislistor för att stödja säsongspriser, kampanjer eller olika kundsegment. Ange begränsad giltighet för att styra när varje lista är tillgänglig. Lägg till produkter i prislistan så att säljarna kan inkludera dem i offerter med korrekta priser och rabatter.

## Lägg till en prislista

1. Gå till **Inställningar och underhåll** och välj <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Offert/Synk** i navigatorn.

1. Gå till fliken **SuperOffice-produkter**.

1. Klicka på **Lägg till** längst upp. Dialogrutan **Lägg till/redigera prislista** öppnas.

1. Fyll i följande fält:

    * **Namn på prislista**: Skriv ett beskrivande namn (för att lättare skilja mellan olika listor).
    * **Beskrivning**: (Valfritt) Lägg till en kort beskrivning.
    * **Aktivt**: Markera för att aktivera listan så den kan användas vid skapande av offerter. Aktivera inte förrän listan är färdig.
    * **Begränsad giltighet**: (Valfritt) Aktivera och ange ett datumintervall om listan ska vara tidsbegränsad. Du kan välja start- och slutdatum *ELLER* bara ett slutdatum.

    > [!NOTE]
    > Du kan inte ändra valuta eller giltighet efter att prislistan har skapats. För att möjliggöra flera valutor, gå till **Inställningar** > **System** > **Aktivera användning av valuta**.

1. Välj ett av följande alternativ:

    * **Lägg till tom prislista**: Börja från början.
    * **Kopiera befintlig prislista**: Duplicera en befintlig lista.
      * **Konvertera priser från originalprislista till &lt;valuta&gt;**: Använd befintliga priser och konvertera om valutan skiljer sig.
      * **Ange pris som noll &lt;valuta&gt;**: Kopiera utan priser och fyll i priserna manuellt.

1. Klicka på **OK**.

## <a id="add-product"></a>Lägg till produkter i en prislista

1. På fliken **SuperOffice-produkter**, välj en prislista.

1. Klicka på **Lägg till** längst ned. Dialogrutan **Lägg till/redigera produkt** öppnas.

1. Fyll i produktinformationen. Du kan konfigurera:

    * Textfält (namn, kod, moms och så vidare)
    * Numeriska fält (kostnad, minipris, kvantitet)
    * Listrutor (enheter, produktgrupp, produkttyp)
    * Sökbara listor (leverantörer eller relaterade artiklar): Du kan välja från senaste poster, skriva text för att starta en sökning eller klicka på sökikonen (<i class="ph ph-magnifying-glass" aria-hidden="true"></i>) för en avancerad sökning.

1. (Valfritt) Klicka på **Ändra bild** för att lägga till en produktbild.

1. (Valfritt) Lägg till en beskrivning i textfältet nere till vänster.

1. (Valfritt) Markera **Åsidosätt standardsäkerhet** för att justera säkerheten på fältnivå för denna produkt.

1. Markera **Inkludera i prislista** för att aktivera produkten. Du bör inte göra detta förrän du har angett all nödvändig information om produkten.

1. Klicka på **Spara** eller **Spara + ny** för att fortsätta lägga till produkter.

> [!TIP]
> Du kan lägga till fler alternativ till listrutorna i skärmen **Listor**.
>
> Du kan även [importera produkter från ett kalkylblad][5] istället för att lägga till dem manuellt.

## <a id="image"></a>Lägg till eller ändra produktbild

Lägg till högkvalitativa produktbilder i dina offerter för att visa kunderna produkterna de är intresserade av.

1. Välj en prislista och dubbelklicka på en produkt.

1. Klicka på **Ändra bild** längst ner i förhandsgranskningsområdet i dialogrutan **Lägg till/redigera produkt**.

1. I dialogrutan **Välj bild** väljer du en bild från databasen. Endast tillgängliga bilder visas.

1. Klicka på **OK** för att lägga till bilden i produkten.

![Du kan lägga till en bild till varje produkt du lägger till i din prislista -screenshot][img1]

[!include[Filtyp och storlek](../../../learn/includes/image-type-and-size.md)]

## <a id="deactivate"></a>Inaktivera produkter eller prislistor

Vi rekommenderar att du **inaktiverar** prislistor och produkter istället för att ta bort dem för att bevara offerthistorik och undvika fel. Inaktiverade produkter och prislistor är inte tillgängliga i nya offerter, men de finns kvar i befintliga.

### Inaktivera en prislista

1. Välj en prislista och klicka på **Redigera**.
2. Gör något av följande:
    * Avmarkera **Aktiv**.
    * Aktivera **Begränsad giltighet** och ställ in ett förfallet **Giltig till**-datum.
3. Klicka på **OK**.

### Inaktivera en produkt

1. Välj prislistan som innehåller produkten.
2. I produktlistan, avmarkera kryssrutan bredvid den produkt du vill inaktivera.

## <a id="export"></a>Exportera en prislista

1. På fliken **SuperOffice-produkter**, välj en prislista.
2. Klicka på <i class="ph ph-download-simple" aria-hidden="true"></i> **Exportera** längst ned.

Du kan exportera valda produkter eller hela listan.

> [!TIP]
> Kontrollera att du [justerar de synliga kolumnerna][4] innan du exporterar.

### Exportera inte tillgänglig?

Kontrollera att användaren har [behörigheter][7] och att [inställningen för export][8] är aktiverad.

## Relaterat innehåll

* [Konfigurera fält i Lägg till/redigera produkt-dialogen][3]
* [Importera produkter från Excel][5]
* [Ställa in ERP-koppling][1]

<!-- Referenced links -->
[1]: set-up-quote-connector.md
[3]: configure-product-fields.md
[4]: ../../../learn/section-tabs/configure-columns.md
[5]: ../../../admin/import/products-from-excel.md
[7]: ../../../admin/user-management/role/index.md
[8]: ../../../admin/preferences/index.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/sale/add-products-to-price-list.png
[img1]: ../../../../media/loc/en/sale/add-edit-product.png
