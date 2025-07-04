---
uid: help-nl-quote
title: Werken met offerten
description: Leer hoe u offertes maakt, beheert en verzendt in SuperOffice CRM om uw verkoopproces te stroomlijnen en fouten te minimaliseren.
keywords: Offerte-sectietabblad, Offerte-tabblad, verkoop, voorstel, offertealternatief, offerte-naar-order, offerte
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: concept
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from:
  - /nl/quote/learn/index
  - /nl/quote/learn/quote-tab
  - /nl/sale/learn/screen/quote-tab
---

# Werken met offerten

SuperOffice Quote helpt u om snel en nauwkeurig offertes te maken, te beheren en te verzenden. Door gebruik te maken van een vooraf gedefinieerde productdatabase en automatische berekeningen, kunt u handmatige fouten verminderen en tijd besparen. Offerten kunnen meerdere alternatieven bevatten, zodat het voor de klant eenvoudiger is om te kiezen.

Nadat een offerte is geaccepteerd, kunt u met één klik een order genereren en deze verzenden voor verwerking – handmatig of automatisch via een ERP-systeem, afhankelijk van uw configuratie.

SuperOffice Quote ondersteunt de volledige offerte-naar-order-cyclus. Het helpt u om sneller nieuwe of bijgewerkte offertes op te stellen en versnelt de overgang van lead naar gesloten verkoop.

> [!NOTE]
> Deze functie vereist het Sales Premium-gebruikersplan.

![Offertescherm met een offerte voor John Smith -screenshot][img1]

## Waarom SuperOffice Quote gebruiken?

* Maak sneller professionele voorstellen
* Hergebruik producten en prijzen uit vooraf gedefinieerde lijsten
* Laat SuperOffice de berekeningen uitvoeren
* Verstuur meerdere offertealternatieven
* Converteer een offerte direct naar een order
* Zorg voor consistentie met offertetemplates
* Verminder goedkeuringsvertragingen en fouten

## Overzicht van het offerteproces

1. Open een verkoop en [maak een offerte][1].
1. [Voeg producten toe aan de offerte][2].
1. [Maak het offertedocument aan][3] dat naar de klant wordt verzonden. Dit is de begeleidende brief bij de productlijst.
1. [Verzend de offerte][4].
1. [Plaats de order][5] zodra de klant akkoord gaat.

![Na het klikken op de knop om een offerte te maken, kunt u producten en diensten aan de offerte toevoegen (geanimeerd) -screenshot][img2]

### <a id="status"></a>Offertestatussen

| Pictogram | Status |
|---|---|
| <i class="ph ph-pencil" aria-label="Draft"></i> <i class="ph ph-calculator" aria-label="Draft – not Calculated"></i> | Concept / Concept – zonder berekening |
| <i class="ph ph-question" aria-label="Needs approval"></i> | Goedkeuring noodzakelijk |
| <i class="ph ph-check-square" aria-label="Approved"></i> <i class="ph ph-x-square" aria-label="Not approved"></i> | Goedgekeurd / Afgewezen |
| <i class="ph ph-envelope-simple" aria-label="Sent"></i> | Verzonden |
| <i class="ph ph-clock-counter-clockwise" aria-label="Sent – Expired"></i> | Verzonden – vervallen |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-check" aria-label="Sold"></i> | Verkocht |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-x" aria-label="Lost"></i> | Verloren |
| <i class="ph ph-shopping-cart-simple" aria-label="Ordered"></i> | Order geplaatst |
| <i class="ph ph-folder-simple" aria-label="Archived"></i> | Gearchiveerd |

## <a id="quote-tab"></a>Offerte-sectietabblad

Op het sectietabblad **Offerte** onder aan een verkoop kunt u offerten maken, weergeven en beheren.

### Als er geen offerte bestaat

* [Maak een nieuwe offerte][1] vanaf nul
* [Kopieer een offerte van een andere verkoop][6] (dezelfde valuta vereist)

### Als er een offerte bestaat

* Bekijk het offertenummer, de versie en de [status](#status)
* [Maak het offertedocument][3]
* Selecteer en beheer offertealternatieven (indien geactiveerd voor het verkooptype)
* Klik op **Openen** om de offerte te bekijken of te bewerken
* Exporteer de productenlijst naar een spreadsheet

De productenlijst: Als er producten waren toegevoegd aan de offerte, worden ze in de lijst weergegeven. Onder aan de lijst wordt de totaalprijs van producten weergegeven.

## <a id="alternatives"></a>Alternatieven in offerten

Een offerte kan een of meer **alternatieven** bevatten, waarmee u verschillende combinaties van producten, aantallen of kortingen kunt aanbieden. Elk alternatief verschijnt als een tabblad in het dialoogvenster **Offerte bewerken** en kan hernoemd worden. Zo biedt u de klant keuzes zonder meerdere offerten te hoeven maken.

Standaard is het eerste alternatief gemarkeerd als **favoriet**. Het favoriet wordt aangeduid met een sterpictogram <i class="ph ph-star" aria-label="Favorite alternative"></i> en wordt gebruikt bij het [verzenden van de offerte][4]. Het bepaalt ook de prognosewaarde die voor de verkoop wordt weergegeven. Om de favoriet te wijzigen, selecteert u een ander tabblad en klikt u onderaan in het dialoogvenster op **Favoriete alternatief**.

## Tips

Gebruik een goed ontworpen offertetemplate om consistentie te waarborgen. Beheerders kunnen templates aanpassen en productregels instellen in **Instellingen en onderhoud**.

## Gerelateerde inhoud

* [Een product aan de offerte toevoegen/bewerken][2]
* [Een offertedocument maken][3]
* [Alternatieven aan een offerte toevoegen][7]
* [Uw producten en prijzen instellen in Instellingen en onderhoud][11]

<!-- Gerefereerde links -->
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
