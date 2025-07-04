---
uid: help-sv-quote
title: Arbeta med offerter
description: Lär dig hur du skapar, hanterar och skickar offerter i SuperOffice CRM för att effektivisera din försäljningsprocess och minimera fel.
keywords: Offert-detaljkort, Offert-flik, försäljning, förslag, offertalternativ, offert-till-order, offert
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: concept
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/quote/learn/index
  - /sv/quote/learn/quote-tab
  - /sv/sale/learn/screen/quote-tab
---

# Arbeta med offerter

SuperOffice Quote hjälper dig att skapa, hantera och skicka offerter snabbt och korrekt. Genom att använda en fördefinierad produktdatabas och automatiska beräkningar kan du minska manuella fel och spara tid. Offerten kan innehålla flera alternativ, vilket gör det enklare för kunden att välja.

När en offert har godkänts kan du generera en order med ett klick och skicka den vidare för behandling – antingen manuellt eller automatiskt via ett ERP-system, beroende på din inställning.

SuperOffice Quote stöder hela processen från offert till order. Det hjälper dig att leverera nya eller uppdaterade offerter snabbare och snabbar på övergången från lead till affär.

> [!NOTE]
> Denna funktion kräver användarplanen Sales Premium.

![Offert-skärmbild som visar en offert -screenshot][img1]

## Varför använda SuperOffice Quote?

* Skapa professionella offerter snabbare
* Återanvänd produkter och priser från fördefinierade listor
* Låt SuperOffice sköta beräkningarna
* Skicka flera offertalternativ
* Konvertera en offert till en order direkt
* Säkerställ konsekvens med offertmallar
* Minska godkännandeförseningar och fel

## Översikt över offertprocessen

1. Öppna en försäljning och [skapa en offert][1].
1. [Lägg till produkter i offerten][2].
1. [Skapa offertdokumentet][3] som skickas till kunden. Det är det brev som bifogas produktlistan.
1. [Skicka offerten][4].
1. [Registrera ordern][5] när kunden accepterar.

![När du klickar på knappen för att skapa en offert kan du börja lägga till produkter och tjänster i offerten (animerat) -screenshot][img2]

### <a id="status"></a>Status för offert

| Ikon | Status |
|---|---|
| <i class="ph ph-pencil" aria-label="Draft"></i> <i class="ph ph-calculator" aria-label="Draft – not Calculated"></i> | Utkast / Utkast – inte beräknad |
| <i class="ph ph-question" aria-label="Needs approval"></i> | Behöver godkännas |
| <i class="ph ph-check-square" aria-label="Approved"></i> <i class="ph ph-x-square" aria-label="Not approved"></i> | Godkänd / Avvisad |
| <i class="ph ph-envelope-simple" aria-label="Sent"></i> | Skickat |
| <i class="ph ph-clock-counter-clockwise" aria-label="Sent – Expired"></i> | Skickad – utgången |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-check" aria-label="Sold"></i> | Sålt |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-x" aria-label="Lost"></i> | Förlorat |
| <i class="ph ph-shopping-cart-simple" aria-label="Ordered"></i> | Beställd |
| <i class="ph ph-folder-simple" aria-label="Archived"></i> | Arkiverad |

## <a id="quote-tab"></a>Offert-detaljkort

I detaljkortet **Offert** längst ner i en försäljning kan du skapa, visa och hantera offerter.

### Om ingen offert finns

* [Skapa en ny offert][1] från grunden
* [Kopiera offert från en annan försäljning][6] (måste ha samma valuta)

### Om en offert finns

* Visa offertnummer, version och [status](#status)
* [Skapa offertdokument][3]
* Välj och hantera offertalternativ (om aktiverat för försäljningstypen)
* Klicka på **Öppna** för att visa eller redigera offerten
* Exportera produktlistan till ett kalkylark

Produktlistan: Om produkter har lagts till i offerten, visas de i listan. Längst ner i listan visas det totala priset för produkterna i den.

## <a id="alternatives"></a>Alternativ i offerter

En offert kan innehålla ett eller flera **alternativ** så att du kan erbjuda olika kombinationer av produkter, kvantiteter eller rabatter. Varje alternativ visas som en flik i dialogrutan **Redigera offert** och kan ges ett eget namn. Detta ger kunden valmöjligheter utan att du behöver skapa flera offerter.

Som standard markeras det första alternativet som **favorit**. Favoriten markeras med en stjärnikon <i class="ph ph-star" aria-label="Favorite alternative"></i> och inkluderas när du [skickar offerten][4]. Det avgör också prognosvärdet som visas för försäljningen. För att ändra favorit, välj en annan flik och klicka på **Favoritalternativ** längst ner i dialogrutan.

## Tips

För att säkerställa konsekvens, använd en väl utformad offertmall. Administratörer kan anpassa mallar och skapa produktregler i **Inställningar och underhåll**.

## Relaterat innehåll

* [Lägga till/redigera en produkt i offerten][2]
* [Skapa offertdokument][3]
* [Lägga till alternativ i en offert][7]
* [Konfigurera dina produkter och priser i Inställningar och underhåll][11]

<!-- Refererade länkar -->
[1]: create.md
[2]: create.md#add-products
[6]: create.md#copy
[3]: create-quote-document.md
[4]: send.md
[5]: place-order.md
[7]: add-alternative.md
[11]: ../../admin/quote/price-list-and-products.md

[img1]: ../../../../media/loc/en/sale/quote-management.png
[img2]: ../../../../media/loc/en/sale/quote-create-send.gif
