---
uid: help-no-price-list-and-products
title: Administrere prislister og produkter
description: Lær hvordan du oppretter og administrerer prislister og produkter i produktregisteret i SuperOffice for bruk i tilbud.
keywords: prisliste, legge til produkt, konfigurere produkt, produktbilde, deaktivere produkt, produkt, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
language: no
redirect_from:
  - /no/quote/learn/admin/product/add-price-list
  - /no/quote/learn/admin/product/add-product-to-price-list
  - /no/quote/learn/admin/product/index
  - /no/quote/learn/admin/product/quote-delete-deactivate-price-list-or-product
  - /no/quote/learn/admin/product/select-product-image
index: true
---

# Administrere prislister og produkter

I fanen **SuperOffice-produkter** i bildet **Tilbud/Sync** definerer du prislister og legger til produkter slik at de blir tilgjengelige for bruk i tilbud i SuperOffice CRM. Dette gjelder når du bruker **SuperOffice Standalone-connector** (ingen ERP-integrasjon).

![Du kan legge til og redigere alle prislistene dine i fanen SuperOffice-produkter -screenshot][img2]

Bruk flere prislister for å støtte sesongpriser, kampanjer eller forskjellige kundesegmenter. Sett begrenset gyldighet for å styre når hver liste er tilgjengelig. Legg til produkter i prislisten slik at selgerne kan bruke dem i tilbud med riktige priser og rabattregler.

## Legge til en prisliste

1. Gå til **Innstillinger og vedlikehold**, og velg <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Tilbud/Sync** i navigatoren.

1. Gå til fanen **SuperOffice-produkter**.

1. Klikk på **Legg til** øverst. Dialogboksen **Legg til/rediger prisliste** åpnes.

1. Fyll ut følgende felt:

    * **Prislistenavn:** Skriv inn et beskrivende navn (slik at det er lettere å skille mellom prislister).
    * **Beskrivelse:** (Valgfritt) Legg til en kort beskrivelse.
    * **Aktiv:** Merk av for å aktivere prislisten slik at den kan brukes i tilbud. Du bør ikke aktivere prislisten før den er helt klar.
    * **Begrenset gyldighet:** (Valgfritt) Aktiver og angi en datoperiode hvis prislisten skal være tidsbegrensede. Du kan velge en start- og sluttdato *ELLER* bare en sluttdato.

    > [!NOTE]
    > Du kan ikke endre valuta eller gyldighet etter at prislisten er opprettet. For å aktivere flere valutaer, gå til **Preferanser** > **System** > **Aktiver bruk av valuta**.

1. Velg ett av følgende alternativer:

    * **Legg til tom prisliste:** Start med en tom liste.
    * **Kopier eksisterende prisliste:** Kopier en eksisterende liste.
      * **Konverter priser fra opprinnelig prisliste til &lt;valuta&gt;**: Bruk eksisterende priser i den nye listen. Hvis du kopierer fra en prisliste med annen valuta, konverteres prisene automatisk.
      * **Sett priser til null &lt;valuta&gt;**: Priser kopieres ikke, og du må angi dem manuelt.

1. Klikk på **OK**.

## <a id="add-product"></a>Legge til produkter i en prisliste

1. I fanen **SuperOffice-produkter**, velg en prisliste.

1. Klikk på **Legg til** nederst. Dialogboksen **Legg til/rediger produkt** åpnes.

1. Fyll ut produktdetaljene. Du kan konfigurere:

    * Tekstfelt (navn, kode, MVA, osv.)
    * Tallfelt (kostpris, minstepris, antall)
    * Nedtrekkslister (enhet, produktgruppe, produkttype)
    * Søkbare lister (for leverandører eller relaterte elementer). Du kan velge fra nylige poster, skrive for å starte et søk, eller klikke på søkeikonet (<i class="ph ph-magnifying-glass" aria-hidden="true"></i>) for avansert søk.

1. (Valgfritt) Klikk på **Endre bilde** for å legge til et produktbilde.

1. (Valgfritt) Legg til en beskrivelse i tekstfeltet nederst til venstre.

1. (Valgfritt) Merk av for **Overstyr standard sikkerhet** for å justere feltbeskyttelse for dette produktet.

1. Merk av for **Inkluder i prisliste** for å aktivere produktet. Du bør ikke gjøre dette før du har lagt inn all nødvendig informasjon om produktet.

1. Klikk på **Lagre** eller **Lagre + ny** for å fortsette å legge til produkter.

> [!TIP]
> Du kan legge til flere alternativer i listene i bildet **Lister**.
>
> Du kan også [importere produkter fra et regneark][5] i stedet for å legge dem til manuelt.

## <a id="image"></a>Legge til eller endre produktbilde

Legg til produktbilder av høy kvalitet i tilbudene for å vise kundene hvilke produkter de er interessert i.

1. Velg en prisliste og dobbeltklikk på et produkt.

1. Klikk på **Endre bilde** nederst i forhåndsvisningsområdet i dialogboksen **Legg til/rediger produkt**.

1. I dialogboksen **Velg bilde**, velger du et bilde fra databasen. Kun tilgjengelige bilder vises.

1. Klikk på **OK** for å legge bildet til produktet.

![Du kan legge til et bilde til hvert produkt i prislisten -screenshot][img1]

[!include[File type and size](../../../learn/includes/image-type-and-size.md)]

## <a id="deactivate"></a>Deaktivere produkter eller prislister

Vi anbefaler å **deaktivere** produkter og prislister i stedet for å slette dem, for å bevare tilbudshistorikk og unngå feil. Deaktiverte produkter og prislister er ikke tilgjengelige for nye tilbud, men forblir synlige i eksisterende tilbud.

### Deaktivere en prisliste

1. Velg en prisliste og klikk på **Rediger**.
2. Gjør ett av følgende:
    * Fjern avmerkingen for **Aktiv**
    * Aktiver **Begrenset gyldighet** og angi en tidligere dato i **Gyldig til**
3. Klikk på **OK**.

### Deaktivere et produkt

1. Velg prislisten som inneholder produktet.
2. Fjern avmerkingen ved produktet du vil deaktivere i produktlisten.

## <a id="export"></a>Eksportere en prisliste

1. I fanen **SuperOffice-produkter**, velg en prisliste.
2. Klikk på <i class="ph ph-download-simple" aria-hidden="true"></i> **Eksporter** nederst.

Du kan eksportere valgte produkter eller hele listen.

> [!TIP]
> Sørg for å [justere hvilke kolonner som er synlige][4] før du eksporterer.

### Eksport ikke tilgjengelig?

Sjekk om brukeren har [tilgangsrettigheter][7] og at eksport [preferansen][8] er aktivert.

## Relatert innhold

* [Konfigurere felt i Legg til/rediger produkt-dialogen][3]
* [Importere produkter fra Excel][5]
* [Sette opp ERP-tilkobling][1]

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
