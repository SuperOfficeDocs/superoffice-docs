---
uid: help-da-quote-create
title: Opret et tilbud
description: Lær, hvordan du opretter et tilbud i SuperOffice CRM, herunder hvordan du tilføjer produkter, redigerer tilbudsdetaljer og løser almindelige problemer.
keywords: opret tilbud, kopiér tilbud, tilføj produkt, Tilføj/rediger produkt-dialog, dialogboksen Rediger tilbud, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from:
  - /da/quote/learn/add-product
  - /da/quote/learn/copy
  - /da/quote/learn/create
  - /da/quote/learn/screen/edit-quote-dialog
---

# Opret et tilbud

I SuperOffice CRM kan du oprette et tilbud fra bunden eller kopiere et fra et andet salg. Når tilbuddet er oprettet, kan du tilføje produkter, justere priser og gøre forslaget klar til kunden.

## Opret et nyt tilbud

1. [Opret et nyt salg][1], eller åbn et eksisterende salg (et, der ikke er markeret som Solgt eller Tabt).

1. Gå til detaljekortet **Tilbud**.

1. Klik på **Opret et nyt tilbud**.

1. Dialogboksen **Rediger tilbud** åbnes. Herfra kan du [tilføje produkter](#add-products) og redigere oplysningerne i tilbuddet.

![Dialogboksen Rediger tilbud -screenshot][img1]

## <a id="copy"></a>Kopiér et tilbud fra et andet salg

For at spare tid kan du genbruge et eksisterende tilbud fra et andet salg, der bruger samme valuta.

1. Åbn et salg uden tilbud, og gå til detaljekortet **Tilbud**.

1. Klik på **Kopiér tilbud fra et andet salg**.

1. I dialogboksen **Opret nyt tilbud baseret på et tidligere tilbud**:

    * Vælg et salg fra listen (skal indeholde et tilbud med samme valuta).
    * Eller, begynd at skrive for at søge efter salgsnavn.

1. Klik på **OK**. Tilbuddet og alle dets alternativer kopieres til det aktuelle salg og vises i detaljekortet **Tilbud** med status **Udkast**.

1. Klik på **Åbn** for at se eller redigere tilbuddet i dialogboksen **Rediger tilbud**.

## <a id="add-products"></a>Tilføj produkter til tilbuddet

### Tilføj ét produkt

1. Gå til fanen **Produkter** i tilbuddet, og klik på **Tilføj**.
    Dialogboksen **Tilføj/rediger produkt** åbnes.

1. Begynd at skrive i feltet **Produktsøgning** for at finde et produkt efter navn eller kode.

1. Vælg et produkt fra listen.

    Produktfelterne udfyldes automatisk baseret på den valgte prisliste.

1. Indtast **antal** (obligatorisk).

1. Du kan eventuelt justere prisen ved hjælp af ét af følgende felter:

    * **Rabat i procent**
    * **Rabatbeløb**
    * **Samlet pris**

    Hold musemarkøren over et rabatfelt for at få vist eventuelle systemrabatter (f.eks. mængderabatter, der tilføjes automatisk).

1. Gå til fanen **Detaljer** for at:

    * Se eller justere **indtjening** (procent eller beløb)
    * Eventuelt angive **moms**

    > [!NOTE]
    > Rabat, samlet pris og indtjening er forbundne felter. Når du ændrer ét felt, opdateres de andre automatisk. Det sidst redigerede felt fremhæves.
    >
    > Hvis du angiver en rabat, der ikke er tilladt af systemet, vises der en advarsel eller anden meddelelse.

1. Valgfrit: Se produktinfo under fanen **Beskrivelse** eller **Billede**.

1. Klik på **Gem** for at tilføje produktet til tilbuddet, eller klik på **Gem + ny** for straks at tilføje endnu et produkt.

![Dialogboksen Tilføj/rediger produkt -screenshot][img2]

### Tilføj flere produkter

Hvis du vil tilføje flere produkter på én gang, skal du bruge avanceret søgning.

1. Klik på **Tilføj** i fanen **Produkter**.

1. Klik på <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> for at åbne dialogboksen **Find produkter**.

1. Brug ét eller flere kriterier til at indsnævre listen. Klik på **Tilføj kriterium** for at tilføje flere filtre.

    Søgningen inkluderer alle aktive prislister med salgets valuta.

1. Vælg de produkter, du vil tilføje: brug **Ctrl+klik** (Windows) eller **Cmd+klik** (Mac) for at vælge flere produkter.

1. Klik på **OK**. Alle valgte produkter føjes til tilbuddet.

    Du kommer tilbage til dialogboksen **Rediger tilbud**.

1. Hvis du vil angive antal (og eventuelt justere rabat, pris eller indtjening), dobbeltklik på hver produktlinje.

## Angiv betalings- og leveringsoplysninger

Før du sender tilbuddet eller opretter tilbudsdokumentet, skal du gå til fanen **Detaljer** i tilbuddet.

Her kan du angive:

* **Betalingsbetingelser** og **betalingstype**
* **Leveringsbetingelser** og **leveringstype**
* **Fakturaadresse** og **leveringsadresse**

Disse oplysninger vises i tilbudsdokumentet og bruges ved oprettelse af en ordre.

## Fejlfinding

### Hvorfor vises dialogboksen "Vælg ERP-link"?

Denne dialogboks vises, hvis:

* Der ikke findes nogen prisliste for den valgte valuta
* Der findes flere tilgængelige ERP-link

**Løsning:** Vælg en anden valuta, eller sørg for at der findes en gyldig prisliste. Vælg derefter det passende ERP-link.

> [!NOTE]
> Hvis du vil aktivere valutavalg i et salg, skal du gå til **Indstillinger og vedligeholdelse** > **Præferencer** og aktivere **Brug af valuta**.

### Hvorfor kan jeg ikke finde det salg, jeg vil kopiere fra?

Når du kopierer et tilbud, viser listen **Salg** kun de salg, som:

* Indeholder et eksisterende tilbud
* Bruger samme valuta som det aktuelle salg

**Løsning:**

* Tjek, at det salg, du vil kopiere fra, faktisk indeholder et tilbud.
* Bekræft, at begge salg bruger samme valuta.
* Hvis nødvendigt, skal du ændre valutaen på det aktuelle salg, så den passer.

Hvis listen stadig er tom, findes der ingen matchende salg, som kan kopieres fra.

### Hvorfor er OK-knappen deaktiveret ved kopiering?

Du har muligvis ikke adgang til det ERP-link, som bruges i tilbuddet.
Hold musemarkøren over **OK**-knappen for at se, hvilket link der er begrænset.

## <a id="warning"></a>Hvorfor vises der advarsler eller fejl?

Når du tilføjer eller redigerer produkter i et tilbud, kan SuperOffice vise en meddelelse, hvis noget overskrider de tilladte grænser.

Typiske årsager kan være:

* Produkter, der ikke findes i sortimentet
* Inaktive prislister
* Rabatten er for høj
* Indtjeningen er for lav
* Prisen er for lav eller nul

Systemet viser et af følgende ikoner:

| Ikon | Meddelelsestype | Beskrivelse | Hvad skal du gøre |
|:-:|---|---|---|
| <i class="ph ph-info" aria-label="Info icon"></i> | Info | Der vises en meddelelse for tilbuddet, men tilbuddet kan sendes, som det er. | Valgfrit: Læs og håndter meddelelsen, hvis det er nødvendigt |
| <i class="ph ph-warning" aria-label="Warning icon"></i> | Advarsel | Tilbuddet skal godkendes, før det kan sendes. | [Godkendelse kræves][7] |
| <i class="ph ph-circle-wavy-warning" aria-label="Error icon"></i> | Fejl | Tilbuddet kan ikke sendes på grund af en fejl. | Ret fejlen, før du sender tilbuddet |

Disse meddelelser kan vises følgende steder:

* I dialogboksen **Tilføj/rediger produkt**
* I dialogboksen **Rediger tilbud**
* På produktlinjer i detaljekortet **Tilbud**
* I fanen **Produkter** og alternativ-faner i tilbuddet
* Når du forsøger at sende eller afgive en ordre

## Relateret indhold

* [Tilføj alternativer i et tilbud][5]
* [Opret et tilbudsdokument][6]
* [Send et tilbud][7]
* [Opret en ordre][8]
* [Konfigurer dine produkter og priser i Indstillinger og vedligeholdelse][9]

<!-- Refererede links -->
[1]: ../create.md
[5]: add-alternative.md
[6]: create-quote-document.md
[7]: send.md
[8]: place-order.md
[9]: ../../admin/quote/price-list-and-products.md

<!-- Refererede billeder -->
[img1]: ../../../../media/loc/en/sale/edit-quote-dialog-empty.png
[img2]: ../../../../media/loc/en/sale/add-edit-product-dialog.png
