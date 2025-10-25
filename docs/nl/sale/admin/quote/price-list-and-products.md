---
uid: help-nl-price-list-and-products
title: Prijslijsten en producten beheren
description: Leer hoe u prijslijsten en producten maakt en beheert in het SuperOffice-productregister voor gebruik in offertes.
keywords: prijslijst, product toevoegen, product configureren, productafbeelding, product deactiveren, product, offerte
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from:
  - /nl/quote/learn/admin/product/add-price-list
  - /nl/quote/learn/admin/product/add-product-to-price-list
  - /nl/quote/learn/admin/product/index
  - /nl/quote/learn/admin/product/quote-delete-deactivate-price-list-or-product
  - /nl/quote/learn/admin/product/select-product-image
index: true
---

# Prijslijsten en producten beheren

Op het tabblad **SuperOffice-producten** van het scherm **Offerte/Synchroniseren** definieert u prijslijsten en voegt u producten toe om ze beschikbaar te maken voor offertes in SuperOffice CRM. Deze configuratie geldt bij gebruik van de **SuperOffice Standalone connector** (zonder ERP-integratie).

![U kunt al uw prijslijsten toevoegen en bewerken op het tabblad SuperOffice-producten -screenshot][img2]

Gebruik meerdere prijslijsten om seizoensprijzen, campagnes of verschillende klantsegmenten te ondersteunen. Stel een beperkte geldigheid in om te bepalen wanneer elke lijst beschikbaar is. Voeg producten toe aan uw prijslijst zodat verkopers ze kunnen opnemen in offertes met correcte prijzen en kortingsregels.

## Een prijslijst toevoegen

1. In Instellingen en onderhoud, kies <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Offerte/Synchroniseren** in de navigator.

1. Ga naar het tabblad **SuperOffice-producten**.

1. Klik bovenaan op **Toevoegen**. Het dialoogvenster **Prijslijst toevoegen/bewerken** wordt geopend.

1. Vul de volgende velden in:

    * **Naam prijslijst:** Geef een duidelijke naam om deze te onderscheiden van andere lijsten.
    * **Beschrijving:** (Optioneel) Voeg een korte beschrijving toe.
    * **Actief:** Vink aan om de lijst te activeren en beschikbaar te maken voor offertes. Activeer pas wanneer de lijst volledig klaar is.
    * **Beperkte geldigheid:** (Optioneel) Schakel in en stel een datumbereik in als de lijst slechts tijdelijk beschikbaar moet zijn. U kunt een start- en einddatum *OF* alleen een einddatum kiezen.

    > [!NOTE]
    > U kunt valuta of geldigheid niet meer wijzigen nadat de prijslijst is gemaakt. Om meerdere valuta's toe te staan, gaat u naar **Voorkeuren** > **Systeem** > **Gebruik van valuta inschakelen**.

1. Kies een van de volgende opties:

    * **Lege prijslijst toevoegen:** Begin vanaf nul.
    * **Bestaande prijslijst kopiëren:** Dupliceer een bestaande lijst.
      * **Prijzen converteren vanuit oorspronkelijke prijslijst naar &lt;valuta&gt;**: Gebruik bestaande prijzen en converteer indien nodig naar de juiste valuta.
      * **Prijzen instellen op nul &lt;valuta&gt;**: Kopieer geen prijzen, voer handmatig nieuwe prijzen in.

1. Klik op **OK**.

## <a id="add-product"></a>Producten toevoegen aan een prijslijst

1. Ga naar het tabblad **SuperOffice-producten** en selecteer een prijslijst.

1. Klik onderaan op **Toevoegen**. Het dialoogvenster **Product toevoegen/bewerken** wordt geopend.

1. Vul de productgegevens in. U kunt configureren:

    * Tekstvelden (naam, code, BTW, enzovoort)
    * Getalvelden (kostprijs, minimumprijs, hoeveelheid)
    * Dropdownlijsten (eenheden, productgroep, producttype)
    * Lijsten met zoekfunctie (voor leveranciers of gerelateerde items). U kunt kiezen uit recente records, tekst invoeren om te zoeken, of klikken op de zoekknop (<i class="ph ph-magnifying-glass" aria-hidden="true"></i>) voor een geavanceerde zoekopdracht.

1. (Optioneel) Klik op **Afbeelding wijzigen** om een productafbeelding toe te voegen.

1. (Optioneel) Voeg een beschrijving toe in het tekstveld linksonder.

1. (Optioneel) Vink **Standaardbeveiliging overschrijven** aan om veldbeveiliging voor dit product aan te passen.

1. Vink **Opnemen in prijslijst** aan om het product te activeren. Doe dit pas nadat u alle noodzakelijke productinformatie hebt ingevuld.

1. Klik op **Opslaan** of **Opslaan + nieuw** om door te gaan met producten toevoegen.

> [!TIP]
> U kunt meer lijstalternatieven toevoegen in het scherm **Lijsten**.
>
> U kunt ook [producten importeren vanuit een spreadsheet][5] in plaats van ze handmatig toe te voegen.

## <a id="image"></a>Productafbeelding toevoegen of wijzigen

Voeg hoogwaardige productafbeeldingen toe aan uw offertes om uw klanten de producten te laten zien waarin ze geïnteresseerd zijn.

1. Selecteer een prijslijst en dubbelklik op een product.

1. Klik op **Afbeelding wijzigen** onderaan het voorbeeldgebied in het dialoogvenster **Product toevoegen/bewerken**.

1. Selecteer in het dialoogvenster **Afbeelding selecteren** een afbeelding uit de database. Alleen beschikbare afbeeldingen worden weergegeven.

1. Klik op **OK** om de afbeelding toe te voegen aan het product.

![U kunt een afbeelding toevoegen aan elk product dat u aan uw prijslijst toevoegt -screenshot][img1]

[!include[Bestandstype en grootte](../../../learn/includes/image-type-and-size.md)]

## <a id="deactivate"></a>Producten of prijslijsten deactiveren

Wij raden aan om producten en prijslijsten **te deactiveren** in plaats van ze te verwijderen, om de offertehistorie te behouden en fouten te voorkomen. Gedeactiveerde producten en prijslijsten zijn niet beschikbaar voor nieuwe offertes, maar blijven wel zichtbaar in bestaande offertes.

### Een prijslijst deactiveren

1. Selecteer een prijslijst en klik op **Bewerken**.
2. Voer een van de volgende handelingen uit:
    * Schakel het selectievakje **Actief** uit.
    * Schakel **Beperkte geldigheid** in en stel een afgelopen **Geldig tot**-datum in.
3. Klik op **OK**.

### Een product deactiveren

1. Selecteer de prijslijst waarin het product zich bevindt.
2. In de productlijst schakelt u het selectievakje naast het product uit dat u wilt deactiveren.

## <a id="export"></a>Een prijslijst exporteren

1. Ga naar het tabblad **SuperOffice-producten** en selecteer een prijslijst.
2. Klik onderaan op <i class="ph ph-download-simple" aria-hidden="true"></i> **Exporteren**.

U kunt geselecteerde producten of de gehele lijst exporteren.

> [!TIP]
> Zorg ervoor dat u [de zichtbare kolommen aanpast][4] voordat u exporteert.

### Exporteren niet mogelijk?

Controleer of de gebruiker [toegangsrechten][7] heeft en of de export-[voorkeur][8] is ingeschakeld.

## Gerelateerde inhoud

* [Velden configureren in het dialoogvenster Product toevoegen/bewerken][3]
* [Producten importeren vanuit Excel][5]
* [ERP-verbinding instellen][1]

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
