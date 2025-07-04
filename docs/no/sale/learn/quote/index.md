---
uid: help-no-quote
title: Jobbe med tilbud
description: Lær hvordan du oppretter, administrerer og sender tilbud i SuperOffice CRM for å effektivisere salgsprosessen og redusere feil.
keywords: Tilbud-detaljkort, Tilbud-fane, salg, forslag, tilbudsalternativ, tilbud-til-ordre, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: concept
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from:
  - /no/quote/learn/index
  - /no/quote/learn/quote-tab
  - /no/sale/learn/screen/quote-tab
---

# Jobbe med tilbud

SuperOffice Quote hjelper deg med å opprette, administrere og sende tilbud raskt og nøyaktig. Ved å bruke en forhåndsdefinert produktdatabase og automatiske beregninger, kan du redusere manuelle feil og spare tid. Tilbud kan inneholde flere alternativer, noe som gjør det enklere for kunden å velge.

Etter at et tilbud er akseptert, kan du generere en ordre med ett klikk og sende den til behandling – enten manuelt eller automatisk via et ERP-system, avhengig av oppsettet ditt.

SuperOffice Quote støtter hele tilbud-til-ordre-prosessen. Det hjelper deg med å levere nye eller oppdaterte tilbud raskere og gir en smidig overgang fra lead til lukket salg.

> [!NOTE]
> Denne funksjonen krever brukerlisensen Sales Premium.

![Tilbud-skjermbildet viser et tilbud -screenshot][img1]

## Hvorfor bruke SuperOffice Quote?

* Lag profesjonelle forslag raskere
* Gjenbruk produkter og priser fra forhåndsdefinerte lister
* La SuperOffice gjøre beregningene
* Send flere tilbudsalternativer
* Konverter et tilbud til en ordre umiddelbart
* Sikre konsistens med tilbudsmaler
* Reduser flaskehalser i godkjenning og feil

## Oversikt over tilbudsprosessen

1. Åpne et salg og [opprett et tilbud][1].
1. [Legg til produkter i tilbudet][2].
1. [Opprett tilbudsdokumentet][3] som skal sendes til kunden. Dette er brevet som følger med produktlisten.
1. [Send tilbudet][4].
1. [Registrer ordren][5] når kunden aksepterer.

![Etter å ha klikket på knappen for å opprette et tilbud, kan du begynne å legge til produkter og tjenester i tilbudet (animert) -screenshot][img2]

### <a id="status"></a>Status for tilbud

| Ikon | Status |
|---|---|
| <i class="ph ph-pencil" aria-label="Draft"></i> <i class="ph ph-calculator" aria-label="Draft – not Calculated"></i> | Utkast / Utkast – ikke kalkulert |
| <i class="ph ph-question" aria-label="Needs approval"></i> | Trenger godkjenning |
| <i class="ph ph-check-square" aria-label="Approved"></i> <i class="ph ph-x-square" aria-label="Not approved"></i> | Godkjent / Avvist |
| <i class="ph ph-envelope-simple" aria-label="Sent"></i> | Sendt |
| <i class="ph ph-clock-counter-clockwise" aria-label="Sent – Expired"></i> | Sendt – utløpt |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-check" aria-label="Sold"></i> | Solgt |
| <i class="ph ph-currency-dollar" aria-hidden="true"></i> <i class="ph ph-x" aria-label="Lost"></i> | Tapt |
| <i class="ph ph-shopping-cart-simple" aria-label="Ordered"></i> | Bestilt |
| <i class="ph ph-folder-simple" aria-label="Archived"></i> | Arkivert |

## <a id="quote-tab"></a>Tilbud-detaljkort

I detaljkortet **Tilbud** nederst i et salg kan du opprette, vise og administrere tilbud.

### Hvis det ikke finnes et tilbud

* [Opprett et nytt tilbud][1] fra bunnen av
* [Kopier tilbud fra et annet salg][6] (må ha samme valuta)

### Hvis et tilbud finnes

* Se tilbudsnummer, versjon og [status](#status)
* [Opprett tilbudsdokument][3]
* Velg og administrer tilbudsalternativer (hvis aktivert for salgstypen)
* Klikk på **Åpne** for å vise eller redigere tilbudet
* Eksporter produktlisten til et regneark

Produktlisten: Hvis det er lagt til produkter i tilbudet, vises de i listen. Nederst i listen vises totalprisen for produktene i listen.

## <a id="alternatives"></a>Alternativer i tilbud

Et tilbud kan inneholde ett eller flere **alternativer**, slik at du kan tilby ulike kombinasjoner av produkter, mengder eller rabatter. Hvert alternativ vises som en fane i dialogboksen **Rediger tilbud** og kan gis nytt navn. Dette gir kunden valgmuligheter uten at du trenger å lage flere tilbud.

Som standard er det første alternativet markert som **favoritt**. Favoritten er markert med et stjerneikon <i class="ph ph-star" aria-label="Favorite alternative"></i> og brukes når du [sender tilbudet][4]. Det bestemmer også prognoseverdien for salget. For å endre favoritten, velg en annen fane og klikk på **Favorittalternativ** nederst i dialogen.

## Tips

For å sikre konsistens, bruk en godt utformet mal for tilbudsdokumenter. Administratorer kan tilpasse maler og sette opp produktoppsett i **Innstillinger og vedlikehold**.

## Relatert innhold

* [Legge til / redigere et produkt i tilbudet][2]
* [Opprette tilbudsdokument][3]
* [Legge til alternativer i et tilbud][7]
* [Sett opp produktene og prisene dine i Innstillinger og vedlikehold][11]

<!-- Refererte lenker -->
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
