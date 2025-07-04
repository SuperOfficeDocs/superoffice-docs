---
uid: help-nl-quote-create-document
title: Een offertedocument maken
description: Maak een offertedocument voor uw SuperOffice-offertevoorstel dat u naar de klant kunt sturen.
keywords: offertedocument maken, offertedocument wijzigen, offertedocument, offerte
author: Bergfrid Dias
date: 04.25.2025
version: 10.5.2
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from: /nl/quote/learn/create-quote-document
---

# Een offertedocument maken

Nadat u de offerte hebt gemaakt en producten hebt toegevoegd, kunt u het offertedocument genereren. Dit is de "brief" die naar de klant wordt gestuurd. De lijst met aangeboden producten wordt toegevoegd zodra u de offerte verzendt.

U kunt het document maken vanuit het sectietabblad **Offerte** van een verkoop of vanuit het dialoogvenster **Offerte bewerken**.

> [!TIP]
> Gebruik [een sjabloon met offerte-specifieke samenvoegvelden][3] om offertetekst in het document op te nemen.

## Het offertedocument maken

1. Als u de offerte al bewerkt, klikt u bovenin het dialoogvenster **Offerte bewerken** op **Klikken om offertedocument te maken**.

    *Of* ga naar het sectietabblad **Offerte** van de verkoop en klik op **Klikken om offertedocument te maken**.

    > [!NOTE]
    > De offerte moet de status **Concept** hebben. Als deze al verzonden is, [maak eerst een nieuwe versie][1].

2. Vul in het dialoogvenster **Document** de [verplichte velden][2] in.

3. Klik op **Maken** om een nieuw document te genereren op basis van de gekozen sjabloon.

4. Bewerk de inhoud in Word (of uw standaardeditor), sla het bestand op en sluit het.

    Het document verschijnt op het tabblad **Offerte** en is gekoppeld aan de offerte. Het wordt ook weergegeven op het tabblad **Activiteiten** van de verkoop (en op de schermen Bedrijf en Agenda).

## <a id="replace"></a>Het offertedocument vervangen

Als u de inhoud of sjabloon van een offertedocument wilt wijzigen, kiest u een van de volgende methoden:

### Optie 1: Alleen het bestand vervangen

Gebruik deze methode als u de documentgegevens wilt behouden, maar een bijgewerkte versie van het bestand wilt uploaden.

1. Klik op het document op het tabblad **Offerte**.

2. Schakel het selectievakje **Voltooid** uit.

3. Klik op **Vervangen**, kies het nieuwe bestand en upload het.

4. Klik op **Opslaan**.

### Optie 2: Document verwijderen en opnieuw maken

Gebruik deze methode als u het oude document wilt verwijderen en helemaal opnieuw wilt beginnen.

1. Klik op het bestaande document op het tabblad **Offerte**.

2. Klik op <i class="ph ph-dots-three-circle-vertical" aria-label="Taak"></i> en kies **Verwijderen** in het menu **Taak**.

3. Klik opnieuw op **Klikken om offertedocument te maken** om een nieuw document te genereren.

### Optie 3: Een nieuw document maken en koppelen

Gebruik deze methode om handmatig een nieuw document met uw offertesjablonen te maken en dit vervolgens aan de offerte te koppelen. Het bestaande document blijft behouden.

1. Klik bovenaan op **Nieuw** en kies **Document**.

2. Kies in het dialoogvenster **Document** een offertesjabloon, selecteer de verkoop om aan te koppelen en klik op **Maken**.

3. Open het tabblad **Offerte** in de verkoop en klik op **Openen**.

4. Klik op <i class="ph ph-dots-three-circle-vertical" aria-label="Taak"></i> en selecteer **Offertedocument aanpassen** in het menu **Taak**.

5. Selecteer het nieuwe document in de lijst.

    De lijst toont alle offertedocumenten die zijn geregistreerd voor de huidige verkoop.

> [!TIP]
> Voor kleine aanpassingen kunt u het bestaande document openen, bewerken en opslaan. Vervangen of verwijderen is dan niet nodig.

## Hoe offertesjablonen werken

Sjablonen voor offertedocumenten, offertetekst en orderbevestigingen verschillen van standaarddocumenten. Ze gebruiken **samenvoegvelden** naast gewone sjabloonvariabelen.

* Als het samenvoegveld `<<QuoteDetails>>` voorkomt in het hoofddocument, worden de offerteteksten op die plek ingevoegd.
* Als het veld niet aanwezig is, worden de offertegegevens onderaan het document toegevoegd.

## Gerelateerde inhoud

* [Een offerte verzenden][4]
* [Een order plaatsen][5]
* [Een document bewerken][2]
* [Offertesjablonen][6]
* [Sjabloonvariabelen en samenvoegvelden][3]

<!-- Referenced links -->
[1]: send.md#versions
[2]: ../../../document/learn/edit.md
[3]: ../../../document/templates/merge-fields/quote.md
[4]: send.md
[5]: place-order.md
[6]: ../../../document/templates/learn/quote-templates.md
