---
uid: help-da-quote
title: Arbejde med tilbud
description: Lær, hvordan du opretter, administrerer og sender tilbud i SuperOffice CRM for at strømline salgsprocessen og minimere fejl.
keywords: Tilbud-detaljekort, Tilbud-fane, salg, forslag, tilbudsalternativ, tilbud-til-ordre, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: concept
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from:
  - /da/quote/learn/index
  - /da/quote/learn/quote-tab
  - /da/sale/learn/screen/quote-tab
---

# Arbejde med tilbud

SuperOffice Quote hjælper dig med at oprette, administrere og sende tilbud hurtigt og præcist. Ved at bruge en foruddefineret produktdatabase og automatiske beregninger kan du reducere manuelle fejl og spare tid. Tilbud kan indeholde flere alternativer, hvilket gør det nemmere for kunden at vælge.

Når et tilbud er accepteret, kan du generere en ordre med ét klik og sende den til behandling – enten manuelt eller automatisk via et ERP-system afhængigt af dit setup.

SuperOffice Quote understøtter hele tilbud-til-ordre-processen. Det hjælper dig med at levere nye eller opdaterede tilbud hurtigere og fremskynder overgangen fra lead til lukket aftale.

> [!NOTE]
> Denne funktion kræver brugerplanen Sales Premium.

![Tilbud-skærmbillede, der viser et tilbud -screenshot][img1]

## Hvorfor bruge SuperOffice Quote?

* Opret professionelle forslag hurtigere
* Genbrug produkter og priser fra foruddefinerede lister
* Lad SuperOffice udføre beregningerne
* Send flere tilbudsalternativer
* Konverter et tilbud til en ordre med det samme
* Sikr ensartethed med tilbudsskabeloner
* Reducér godkendelsesflaskehalse og fejl

## Oversigt over tilbudsprocessen

1. Åbn et salg, og [opret et tilbud][1].
1. [Tilføj produkter til tilbuddet][2].
1. [Opret tilbudsdokumentet][3], som sendes til kunden. Dette er brevet, der ledsager produktlisten.
1. [Send tilbuddet][4].
1. [Afgiv ordren][5], når kunden accepterer.

![Når du klikker på knappen for at oprette et tilbud, kan du begynde at tilføje produkter og tjenester til tilbuddet (animeret) -screenshot][img2]

### <a id="status"></a>Status for tilbud

| Ikon | Status |
|---|---|
| <i class="ph ph-pencil" aria-label="Draft"></i> <i class="ph ph-calculator" aria-label="Draft – not Calculated"></i> | Udkast / Udkast – ikke beregnet |
| <i class="ph ph-question" aria-label="Needs approval"></i> | Skal godkendes |
| <i class="ph ph-check-square" aria-label="Approved"></i> <i class="ph ph-x-square" aria-label="Not approved"></i> | Godkendt / Afvist |
| <i class="ph ph-envelope-simple" aria-label="Sent"></i> | Sendt |
| <i class="ph ph-clock-counter-clockwise" aria-label="Sent – Expired"></i> | Sendt – udløbet |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-check" aria-label="Sold"></i> | Solgt |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-x" aria-label="Lost"></i> | Tabt |
| <i class="ph ph-shopping-cart-simple" aria-label="Ordered"></i> | Bestilt |
| <i class="ph ph-folder-simple" aria-label="Archived"></i> | Arkiveret |

## <a id="quote-tab"></a>Tilbud-detaljekort

I detaljekortet **Tilbud** nederst i et salg kan du oprette, få vist og administrere tilbud.

### Hvis der ikke findes et tilbud

* [Opret et nyt tilbud][1] fra bunden
* [Kopiér tilbud fra et andet salg][6] (skal have samme valuta)

### Hvis der findes et tilbud

* Se tilbudsnummer, version og [status](#status)
* [Opret tilbudsdokument][3]
* Vælg og administrer tilbudsalternativer (hvis aktiveret for salgstypen)
* Klik på **Åbn** for at se eller redigere tilbuddet
* Eksportér produktlisten til et regneark

Produktlisten: Hvis der er blevet tilføjet produkter til tilbuddet, vises de på listen. Nederst på listen vises den samlede pris for de produkter, der vises på den.

## <a id="alternatives"></a>Alternativer i tilbud

Et tilbud kan indeholde et eller flere **alternativer**, så du kan tilbyde forskellige kombinationer af produkter, mængder eller rabatter. Hvert alternativ vises som en fane i dialogboksen **Rediger tilbud** og kan omdøbes. Dette giver kunden valgmuligheder uden at kræve flere tilbud.

Som standard markeres det første alternativ som **favorit**. Favoritten er markeret med et stjerneikon <i class="ph ph-star" aria-label="Favorite alternative"></i> og bruges når du [sender tilbuddet][4]. Det bestemmer også prognoseværdien, der vises for salget. For at ændre favorit skal du vælge en anden fane og klikke på **Favoritalternativ** nederst i dialogen.

## Tips

For at sikre ensartethed bør du bruge en veldesignet tilbudsskabelon. Administratorer kan tilpasse skabeloner og konfigurere produktregler i **Indstillinger og vedligeholdelse**.

## Relateret indhold

* [Tilføj/rediger et produkt i tilbuddet][2]
* [Opret tilbudsdokument][3]
* [Tilføj alternativer til et tilbud][7]
* [Konfigurer dine produkter og priser i Indstillinger og vedligeholdelse][11]

<!-- Refererede links -->
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
