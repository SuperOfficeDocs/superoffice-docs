---
uid: help-nl-document-template-create
title: Een sjabloondocument maken
description: Een sjabloondocument maken
keywords: documentsjabloon, document, sjabloon
author: Bergfrid Dias, Terje Nøstdahl, samuelholmstroem
date: 02.25.2025
version: 10.5.2
content_type: howto
language: nl
redirect_from: /nl/admin/lists/learn/creating-template-document
---

# Een sjabloondocument maken

Om ervoor te zorgen dat iedereen in uw bedrijf dezelfde documenten gebruikt, kunt u uw eigen documentsjablonen voor verschillende bestandstypen maken en toevoegen. Gebruik de beschikbare sjabloonvariabelen om de invoer van klantgegevens in uw documenten te personaliseren en te automatiseren.

U maakt een sjabloon als een document in een toepassing die is gekoppeld met SuperOffice CRM, bijvoorbeeld een tekstverwerkingsprogramma. Als u de sjabloon maakt in Word, moet u de sjabloon opslaan als een normaal document (bestandstype **DOC** of **DOCX**) en niet als sjabloondocument (bestandstype **DOT** of **DOTX**).

U kunt ook sjablonen maken met een HTML-indeling en de HTML-editor van SuperOffice gebruiken om de sjabloon te bewerken.

> [!TIP]
> Als u nieuwe sjablonen wilt toevoegen, kunt u eenvoudig een bestaand documentsjabloonbestand kopiëren en dit aanpassen aan uw wensen.

## Stappen

1. Start de benodigde toepassing.
2. Maak een nieuw document.
3. Voeg de gewenste [sjabloonvariabelen][1] toe die u wilt gebruiken in de sjabloon, bijvoorbeeld variabelen voor naam, adres en telefoonnummer.
4. Sla het sjabloondocument op een plaats op die u gemakkelijk weer kunt vinden.

Nadat u een sjabloon hebt gedefinieerd en opgeslagen in de sjabloonmap, moet u [de sjabloon koppelen aan SuperOffice CRM][2] om er documenten van te maken.

## Samenvoegveld toevoegen aan offerte sjabloon

Velden in de offertelijn die niet zijn ingeschakeld, hebben lege waarden voor hun tags – zelfs als u handmatig gegevens aan de database toevoegt. Om alle tags te gebruiken, gaat u naar de offerte-instellingen in Instellingen en onderhoud en schakelt u alle velden in.

Om velden in uw sjabloon in te voegen, kunt u een van de volgende methoden gebruiken:

### Methode 1: Gebruik de Veldendialoog

1. Plaats de cursor waar u het veld wilt invoegen.

1. Klik op **Invoegen** > **Snelonderdelen** > **Veld**.

    ![Snelonderdelen -screenshot][img1]

1. Typ in de lijst **Veldnamen** "merge" om MergeField te markeren.

1. Typ in **Veldeigenschappen** uw [veldnaam][3] (zonder «»):

    ![Veldeigenschappen in Microsoft Word -screenshot][img2]

1. Klik op **OK** en de variabele wordt in uw document ingevoegd:

    ![MergeField invoegen -screenshot][img3]

### Methode 2: Kopieer en plak bestaande velden (het snelst)

1. **Kopieer** een bestaand veld uit de sjabloon. Zorg ervoor dat u het hele veld inclusief de «»-haakjes kopieert.

1. **Plak** het veld in uw sjabloon waar nodig.

1. Klik met de rechtermuisknop op het geplakte veld en selecteer **Velden bewerken**.

1. Typ of plak in het vak **Veldnaam** onder **Veldeigenschappen** de nieuwe veldnaam (zonder «»).

1. Klik op **OK**.

## Berekeningen

U kunt berekeningen uitvoeren met de samenvoegvelden.

### Netto prijs per eenheid

Om de prijs per eenheid na kortingen weer te geven, kunt u een samenvoegveld zoals dit toevoegen:

```text
{= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}
```

**Stappen:**

1. Druk op Ctrl + F9 om een nieuw samenvoegveld toe te voegen. U ziet twee accolades { }.

1. Binnen de accolades:

    1. Voeg "= " toe en druk opnieuw op Ctrl + F9.
    1. Voeg "MERGEFIELD line/totalPrice" toe in een nieuwe set accolades.
    1. Typ "/" en druk vervolgens op Ctrl + F9.
    1. Voeg “MERGEFIELD line/quantity" toe in de laatste set accolades.

1. Nu zou u een veld moeten hebben dat er zo uitziet: {= {MERGEFIELD line/totalPrice} / {MERGEFIELD line/quantity}}

## Gerelateerde inhoud

* [Hoe te werken met velden in Aspose Words][9]
* [Offertesjablonen en samenvoegvelden][4]
* [Referentie voor samenvoegvelden][3]
* [Referentie voor sjabloonvariabelen][6]

<!-- Referenced links -->
[1]: template-variables.md
[4]: quote-templates.md
[2]: ../admin/link-template.md
[3]: ../merge-fields/index.md
[6]: ../variables/for-quote-line.md
[9]: https://docs.aspose.com/words/net/fields-overview/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/word-insert-quick-parts.png
[img2]: ../../../../media/loc/en/document/word-field-dialog.png
[img3]: ../../../../media/loc/en/document/6764-11541.jpg
