---
uid: help-sv-product-fields-configure
title: Konfigurera fält i dialogrutan Lägg till/redigera produkt
description: Lär dig hur du styr vilka fält som visas i dialogrutan Lägg till/redigera produkt och hur de beter sig.
keywords: Konfigurera produktdialog, Lägg till/redigera produktdialog, konfigurera produkt, produktdialog, produktfält, ledtext, produkt, offert
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/quote/learn/admin/product/configure
index: true
---

# Konfigurera fält i dialogrutan Lägg till/redigera produkt

Använd dialogrutan **Konfigurera produkt** för att styra vilka fält som visas när användare lägger till eller redigerar en produkt i en offert. Du kan visa eller dölja fält, ändra ledtexter, definiera hjälptexter och göra fält redigerbara och/eller obligatoriska.

Dessa inställningar gäller globalt för alla ERP-kopplingar via Quote Connector och påverkar två dialogrutor:

* **Dialogrutan Lägg till/redigera produkt (användare):** Visas när användare lägger till en produkt i en offertlinje.
* **Dialogrutan Lägg till/redigera produkt (admin):** Används i fliken **SuperOffice-produkter** när admins lägger till produkter i en prislista.

## Steg

1. I Inställningar och underhåll väljer du <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Offert/Synk** i navigeringsmenyn.

1. Gå till fliken **Inställningar**.

1. Klicka på **Konfigurera produkt**.

    ![Dialogrutan Konfigurera produkt -screenshot][img1]

1. Välj språket du vill konfigurera i dialogrutan. Du kan anpassa ledtexter och hjälptexter per språk.

1. För varje fält i listan:

    * **Visa fält:** Styr synligheten i dialogrutan **Lägg till/redigera produkt** för offerter. Fält visas alltid i Inställningar och underhåll. Vissa fält är nedtonade och kan inte döljas.

        Använd **Aktivera alla** eller **Avaktivera alla** för att snabbt ändra synligheten.

    * **Ledtext:** Ange ett användarvänligt namn för fältet. Lämna tomt för att använda standardtexten.
    * **Hjälptext:** Lägg till en kort hjälptext som visas när användaren håller muspekaren över fältet. Använd rullningslisten om texten är lång.
    * **Redigerbar:** Tillåt användare att ändra värdet.
    * **Obligatorisk:** Kräv att användare fyller i fältet i offertlinjen. Aktiverar automatiskt **Redigerbar**.

        Du kan åsidosätta inställningarna för redigerbarhet och obligatorisk ifyllnad per produkt. För systemstyrda fält är dessa inställningar dock inaktiverade både i dialogrutan **Konfigurera produkt** och i dialogrutan **Lägg till/redigera produkt**.

    * **Ordning:** Använd pilarna <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i> för att ändra ordningen på fälten i dialogrutan.

        Fältordningen påverkar båda dialogrutorna. Vissa fält har dock fasta positioner i dialogrutan **Lägg till/redigera produkt** för offerter och kan inte flyttas.

1. Klicka på **OK** för att spara dina ändringar.

1. Upprepa vid behov proceduren för ytterligare språk.

## Tips

* Alla fält behöver inte visas. Du kan dölja fält som inte behöver fyllas i, till exempel leverantörskod.
* Ange tydliga ledtexter och hjälptexter för eventuella extrafält.
* Ledtextändringar träder i kraft vid nästa inloggning.

## Relaterat innehåll

* [Lägg till produkt i en prislista][1]
* [Lägg till/redigera produkt i offert][2]

<!-- Referenced links -->
[1]: price-list-and-products.md
[2]: ../../learn/quote/create.md#add-products

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/configure-product-dialog.png
