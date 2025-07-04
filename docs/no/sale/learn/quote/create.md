---
uid: help-no-quote-create
title: Opprette tilbud
description: Lær hvordan du oppretter et tilbud i SuperOffice CRM, inkludert hvordan du legger til produkter, redigerer tilbudsdetaljer og løser vanlige problemer.
keywords: opprette tilbud, kopiere tilbud, legge til produkt, dialogboksen Legg til/rediger produkt, dialogboksen Rediger tilbud, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from:
  - /no/quote/learn/add-product
  - /no/quote/learn/copy
  - /no/quote/learn/create
  - /no/quote/learn/screen/edit-quote-dialog
---

# Opprette tilbud

I SuperOffice CRM kan du opprette et tilbud fra bunnen av eller kopiere et fra et annet salg. Når du har opprettet tilbudet, kan du legge til produkter, justere prisene og gjøre tilbudet klart til kunden.

## Opprette et nytt tilbud

1. [Registrer et nytt salg][1] eller åpne et eksisterende salg (et som ikke er merket som Solgt eller Tapt).

1. Gå til detaljkortet **Tilbud**.

1. Klikk på **Opprett nytt tilbud**.

1. Dialogboksen **Rediger tilbud for** åpnes. Herfra kan du [legge til produkter](#add-products) og redigere tilbudsdetaljene.

![Dialogboksen Rediger tilbud -screenshot][img1]

## <a id="copy"></a>Kopiere et tilbud fra et annet salg

For å spare tid kan du gjenbruke et eksisterende tilbud fra et annet salg med samme valuta.

1. Åpne et salg uten tilbud og gå til detaljkortet **Tilbud**.

1. Klikk på **Kopier tilbud fra et annet salg**.

1. I dialogboksen **Opprett nytt tilbud basert på et tidligere tilbud**:

    * Velg et salg fra listen (må inneholde et tilbud med samme valuta).
    * Eller, begynn å skrive for å søke etter salgsnavn.

1. Klikk på **OK**. Tilbudet og alle alternativene kopieres til det gjeldende salget og vises i detaljkortet **Tilbud** med statusen **Utkast**.

1. Klikk på **Åpne** for å vise eller redigere tilbudet i dialogboksen **Rediger tilbud for**.

## <a id="add-products"></a>Legge til produkter i tilbudet

### Legge til ett produkt

1. Gå til fanen **Produkter** i tilbudet og klikk på **Legg til**.
    Dialogboksen **Legg til/rediger produkt** åpnes.

1. Begynn å skrive i feltet **Produktsøk** for å finne et produkt etter navn eller kode.

1. Velg et produkt fra listen.

    Produktfeltene fylles ut automatisk basert på valgt prisliste.

1. Skriv inn **antall** (obligatorisk).

1. Eventuelt kan du justere prisen ved å bruke ett av følgende felt:

    * **Rabattprosent**
    * **Rabattbeløp**
    * **Totalpris**

    Hold musepekeren over et rabattfelt for å vise eventuelle systemrabatter (for eksempel kvantumsrabatter som legges til automatisk).

1. Gå til fanen **Detaljer** for å:

    * Vise eller justere **fortjeneste** (prosent eller beløp)
    * Eventuelt angi **mva**

    > [!NOTE]
    > Rabatt, totalpris og fortjeneste er koblet sammen. Endring av ett felt oppdaterer de andre automatisk. Det sist redigerte feltet markeres.
    >
    > Hvis du angir en rabatt som ikke er tillatt i systemet, vises et varsel eller en annen melding.

1. Valgfritt: Se produktinformasjon i fanen **Beskrivelse** eller **Bilde**.

1. Klikk på **Lagre** for å legge til produktet i tilbudet, eller klikk på **Lagre + ny** for å legge til et nytt produkt med én gang.

![Dialogboksen Legg til/rediger produkt -screenshot][img2]

### Legge til flere produkter

For å legge til flere produkter samtidig, må du bruke avansert søk.

1. Gå til fanen **Produkter** og klikk på **Legg til**.

1. Klikk på <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> for å åpne dialogboksen **Finn produkter**.

1. Bruk ett eller flere kriterier for å avgrense listen. Klikk på **Legg til kriterium** for å legge til flere filtre.

    Søket inkluderer alle aktive prislister med salgets valuta.

1. Velg produktene du vil legge til: bruk **Ctrl+klikk** (Windows) eller **Cmd+klikk** (Mac) for å velge flere produkter.

1. Klikk på **OK**. Alle valgte produkter legges til i tilbudet.

    Du returneres til dialogboksen **Rediger tilbud for**.

1. For å angi antall (og eventuelt oppdatere rabatt, pris eller fortjeneste), dobbeltklikk på hver produktlinje.

## Angi betalings- og leveringsalternativer

Før du sender tilbudet eller oppretter tilbudsdokumentet, gå til fanen **Detaljer** i tilbudet.

Her kan du angi:

* **Betalingsbetingelser** og **betalingstype**
* **Leveringsbetingelser** og **leveringstype**
* **Fakturaadresse** og **leveringsadresse**

Disse feltene vises i tilbudsdokumentet og brukes ved ordreopprettelse.

## Feilsøking

### Hvorfor vises dialogboksen "Velg ERP-kobling"?

Denne dialogboksen vises hvis:

* Det finnes ingen prisliste for valgt valuta
* Det finnes flere ERP-koblinger å velge mellom

**Løsning:** Velg en annen valuta eller sørg for at det finnes en gyldig prisliste. Deretter kan du velge riktig ERP-kobling.

> [!NOTE]
> For å aktivere valutavelging i et salg, gå til **Innstillinger og vedlikehold** > **Preferanser** og aktiver **Bruk av valuta**.

### Hvorfor finner jeg ikke salget jeg vil kopiere fra?

Når du kopierer et tilbud, viser listen **Salg** bare salg som:

* Inneholder et eksisterende tilbud
* Bruker samme valuta som det gjeldende salget

**Løsning:**

* Sjekk at salget du vil kopiere fra, faktisk inneholder et tilbud
* Bekreft at begge salg bruker samme valuta
* Hvis nødvendig, endre valuta på det gjeldende salget

Hvis listen fortsatt er tom, finnes det ingen salg som matcher for kopiering.

### Hvorfor er OK-knappen deaktivert ved kopiering?

Du har kanskje ikke tilgang til ERP-koblingen som brukes i tilbudet.
Hold musepekeren over **OK**-knappen for å se hvilken kobling som er begrenset.

## <a id="warning"></a>Hvorfor vises advarsler eller feil?

Når du legger til eller redigerer produkter i et tilbud, kan SuperOffice vise meldinger hvis noe overskrider tillatte grenser.

Vanlige årsaker kan være:

* Produkter som ikke finnes i sortimentet
* Inaktive prislister
* Rabatten er for høy
* Fortjenesten er for lav
* Prisen er for lav eller null

Systemet viser ett av følgende ikoner:

| Ikon | Meldingsnivå | Beskrivelse | Hva du bør gjøre |
|:-:|---|---|---|
| <i class="ph ph-info" aria-label="Info icon"></i> | Info | Tilbudet inneholder en melding, men kan fortsatt sendes. | Valgfritt: Les og vurder meldingen |
| <i class="ph ph-warning" aria-label="Warning icon"></i> | Varsel | Tilbudet må godkjennes før det kan sendes. | [Godkjenning er nødvendig][7] |
| <i class="ph ph-circle-wavy-warning" aria-label="Error icon"></i> | Feil | Tilbudet kan ikke sendes på grunn av en feil. | Rette feilen før sending |

Disse meldingene kan vises på følgende steder:

* I dialogboksen **Legg til/rediger produkt**
* I dialogboksen **Rediger tilbud for**
* På produktlinjene i detaljkortet **Tilbud**
* I fanen **Produkter** og eventuelle alternativfaner i tilbudet
* Når du prøver å sende eller plassere en ordre

## Relatert innhold

* [Legge til alternativer i et tilbud][5]
* [Opprette tilbudsdokument][6]
* [Sende tilbud][7]
* [Lage ordre][8]
* [Sett opp produktene og prisene dine i Innstillinger og vedlikehold][9]

<!-- Refererte lenker -->
[1]: ../create.md
[5]: add-alternative.md
[6]: create-quote-document.md
[7]: send.md
[8]: place-order.md
[9]: ../../admin/quote/price-list-and-products.md

<!-- Refererte bilder -->
[img1]: ../../../../media/loc/en/sale/edit-quote-dialog-empty.png
[img2]: ../../../../media/loc/en/sale/add-edit-product-dialog.png
