---
uid: help-da-price-list-and-products
title: Administrer prislister og produkter
description: Lær hvordan du opretter og administrerer prislister og produkter i SuperOffice-produktregisteret til brug i tilbud.
keywords: prisliste, tilføj produkt, konfigurer produkt, produktbillede, deaktivér produkt, produkt, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
language: da
redirect_from:
  - /da/quote/learn/admin/product/add-price-list
  - /da/quote/learn/admin/product/add-product-to-price-list
  - /da/quote/learn/admin/product/index
  - /da/quote/learn/admin/product/quote-delete-deactivate-price-list-or-product
  - /da/quote/learn/admin/product/select-product-image
index: true
---

# Administrer prislister og produkter

I fanen **SuperOffice produkter** på skærmbilledet **Tilbud/synkronisering** definerer du prislister og tilføjer produkter, så de kan bruges i tilbud i SuperOffice CRM. Denne opsætning gælder, når du bruger **SuperOffice Standalone connector** (uden ERP-integration).

![Du kan tilføje og redigere alle dine prislister i fanen SuperOffice produkter -screenshot][img2]

Brug flere prislister til at understøtte sæsonpriser, kampagner eller forskellige kundesegmenter. Angiv en begrænset gyldighedsperiode for at styre, hvornår hver liste er tilgængelig. Tilføj produkter til dine prislister, så sælgere kan inkludere dem i tilbud med korrekte priser og rabatregler.

## Tilføj en prisliste

1. I **Indstillinger og vedligeholdelse**, vælg <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Tilbud/Sync** i navigatoren.

1. Gå til fanen **SuperOffice produkter**.

1. Klik på **Tilføj** øverst. Dialogboksen **Tilføj/rediger prisliste** åbnes.

1. Udfyld følgende felter:

    * **Prislistenavn:** Indtast et beskrivende navn, så det er nemt at skelne mellem listerne.
    * **Beskrivelse:** (Valgfrit) Tilføj en kort beskrivelse.
    * **Aktiv:** Markér for at aktivere prislisten og gøre den tilgængelig til tilbud. Du bør ikke aktivere listen, før den er helt klar.
    * **Begrænset gyldighed:** (Valgfrit) Aktiver og angiv en datoperiode, hvis listen skal være tidsbegrænset. Du kan vælge start- og slutdato *ELLER* kun en slutdato.

    > [!NOTE]
    > Du kan ikke ændre valuta eller gyldighed, efter prislisten er oprettet. For at aktivere flere valutaer, gå til **Præferencer** > **System** > **Aktivér brug af valuta**.

1. Vælg en af følgende muligheder:

    * **Tilføj tom prisliste:** Start fra bunden.
    * **Kopiér eksisterende prisliste:** Dupliker en eksisterende liste.
      * **Konverter priser fra oprindelig prisliste til &lt;valuta&gt;**: Brug eksisterende priser og konverter dem til korrekt valuta, hvis nødvendigt.
      * **Angiv priser til nul &lt;valuta&gt;**: Hvis du ikke ønsker at kopiere priser, og vil indtaste dem manuelt.

1. Klik på **OK**.

## <a id="add-product"></a>Tilføj produkter til en prisliste

1. I fanen **SuperOffice produkter**, vælg en prisliste.

1. Klik på **Tilføj** nederst. Dialogboksen **Tilføj/rediger produkt** åbnes.

1. Udfyld produktoplysninger. Du kan konfigurere:

    * Tekstfelter (navn, kode, moms osv.)
    * Tal (kostpris, minimumspris, antal)
    * Rullelister (enhed, produktgruppe, produkttype)
    * Søgbar liste (leverandører eller relaterede produkter): Brug liste over seneste poster, indtast tekst for søgning, eller klik på søgeikonet (<i class="ph ph-magnifying-glass" aria-hidden="true"></i>) for avanceret søgning.

1. (Valgfrit) Klik på **Skift billede** for at tilføje et produktbillede.

1. (Valgfrit) Indtast en beskrivelse i tekstfeltet nederst til venstre.

1. (Valgfrit) Markér **Tilsidesæt standard sikkerhed** for at tilpasse feltsikkerhed for dette produkt.

1. Markér **Medtag i prisliste** for at aktivere produktet. Du bør ikke gøre dette, før du har indtastet alle de nødvendige oplysninger om produktet.

1. Klik på **Gem** eller **Gem + ny** for at fortsætte med at tilføje produkter.

> [!TIP]
> Du kan tilføje flere alternativer til rullelister via **Lister**-skærmen.
>
> Du kan [importere produkter fra et regneark][5] i stedet for at tilføje dem manuelt.

## <a id="image"></a>Tilføj eller skift produktbillede

Tilføj produktbilleder i høj kvalitet til dine tilbud, så kunderne kan se de produkter, de er interesserede i.

1. Vælg en prisliste, og dobbeltklik på et produkt.

1. Klik på **Skift billede** nederst i forhåndsvisningsområdet i dialogboksen **Tilføj/rediger produkt**.

1. I dialogboksen **Vælg billede** vælger du et billede fra databasen. Kun tilgængelige billeder vises.

1. Klik på **OK** for at tilføje det til produktet.

![Du kan føje et billede til hvert produkt, du tilføjer til din prisliste -screenshot][img1]

[!include[Filtype og størrelse](../../../learn/includes/image-type-and-size.md)]

## <a id="deactivate"></a>Deaktiver produkter eller prislister

Vi anbefaler, at du **deaktiverer** elementer i stedet for at slette dem permanent, for at bevare tilbudshistorik og undgå fejl. Deaktiverede produkter og prislister kan ikke bruges i nye tilbud, men forbliver i eksisterende.

### Deaktiver en prisliste

1. Vælg en prisliste, og klik på **Rediger**.
2. Gør ét af følgende:
    * Fjern markeringen i **Aktiv**.
    * Aktivér **Begrænset gyldighed**, og angiv en forældet **Gyldig til**-dato.
3. Klik på **OK**.

### Deaktiver et produkt

1. Vælg prislisten, der indeholder produktet.
2. Fjern markeringen i afkrydsningsfeltet ud for det produkt, du vil deaktivere.

## <a id="export"></a>Eksporter en prisliste

1. I fanen **SuperOffice produkter** skal du vælge en prisliste.
2. Klik på <i class="ph ph-download-simple" aria-hidden="true"></i> **Eksportér** nederst på skærmen.

Du kan eksportere enten valgte produkter eller hele listen.

> [!TIP]
> Sørg for at [justere de viste kolonner][4], før du eksporterer.

### Kan du ikke eksportere?

Tjek, om brugeren har [adgangsrettigheder][7], og om eksport er aktiveret i [præferencerne][8].

## Relateret indhold

* [Konfigurér felter i Tilføj/rediger produkt-dialogboksen][3]
* [Importer produkter fra Excel][5]
* [Konfigurer ERP-link][1]

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
