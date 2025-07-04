---
uid: help-nl-quote-template-tutorial
title: Opdrachtbevestigingssjabloon aanpassen
description: Opdrachtbevestigingssjabloon aanpassen
keywords: sjabloondocument, sjabloon, offerte, opdrachtbevestiging
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: tutorial
audience: settings
audience_tooltip: Settings and maintenance
language: nl
index: true
---

# Opdrachtbevestigingssjabloon aanpassen

In deze tutorial zullen we een opdrachtbevestigingssjabloon als basis gebruiken om een nieuw sjabloon te maken.

We zullen:

* De naam van het optie toevoegen (uit de offerte gehaald).
* Het aantal regels in het optie toevoegen.
* Een thumbnail van het product toevoegen.
* De producten sorteren op productnaam.
* De producten in het sjabloondocument groeperen per productfamilie. Een productfamilie kan bijvoorbeeld "hardware", "software" of "accessoire" zijn.
* Een totaalsom voor de producten in elke groep invoeren, maar de totaalsom voor het optie dat al in het sjabloondocument bestaat behouden.

## Voorbereidingen

### Maak een verkoop aan om het sjabloon te testen

1. Maak in SuperOffice CRM een [offerte][5] met verschillende producten uit verschillende productfamilies om de groeperingsfunctie te testen.

2. Zorg ervoor dat de verkoop hetzelfde type heeft als degene waaraan je het sjabloon later in deze tutorial koppelt.

3. Klik in de offerte op **Bestelling plaatsen** om de knop **Bevestiging weergeven** te activeren.

### Selecteer de velden die worden weergegeven

1. Controleer of de vereiste productvelden zichtbaar zijn in het dialoogvenster **Product configureren**.

* Alleen velden die in Instellingen en onderhoud [als zichtbaar zijn gemarkeerd][4], verschijnen in het sjabloon.

### Kopieer het sjabloon om te wijzigen

1. Selecteer in Instellingen en onderhoud **Lijsten** uit de Navigator.
2. Klik op de pijl en selecteer **Document - Template**.
3. Dubbelklik op het *Opdrachtbevestiging* sjabloon en klik op **Bewerken** om het in Microsoft Word te openen.
4. Sla het document op onder een nieuwe naam op een gemakkelijk toegankelijke locatie.
5. [Voeg het sjabloondocument toe][1].
6. Geef het document een logische naam, zoals *Opdrachtbevestiging – Gegroepeerd*.
7. Vink de optie **Offertedocument type** aan om het beschikbaar te maken voor offertes in SuperOffice CRM.
8. Selecteer het **Sjabloon voor opdrachtbevestigingen**.

### Koppel het sjabloondocument aan een verkooptype

1. Dubbelklik op het scherm **Lijsten** op **Sale – Type, Stages, Quote**.
2. Dubbelklik in het overzicht **Items** op een verkooptype om het dialoogvenster **Item bewerken** te openen.
3. Ga naar het tabblad **Standaardwaarden**, open de lijst **Opdrachtbevestigingssjabloon** en selecteer je nieuwe sjabloon.
4. Klik op **OK** om je wijzigingen op te slaan.

## Het sjabloon wijzigen

In dit gedeelte leer je hoe je het sjabloondocument wijzigt door velden in te voegen, productafbeeldingen toe te voegen, producten te groeperen en sorteervolgorden te kiezen.

### Velden in Word invoegen

1. Open het sjabloondocument uit de lijst **Document - Template**.

1. **Kopieer** een bestaand veld uit het sjabloon. Zorg ervoor dat je het hele veld, inclusief de «»-haakjes, kopieert.

1. **Plak** het veld in je sjabloon na de titel ("Details").

1. Klik met de rechtermuisknop op het geplakte veld en selecteer **Velden bewerken**. Voer in het veld **Veldnaam** onder **Veldeigenschappen** *alternative/name* in (zonder «»-haakjes). Klik op **OK**.

    > [!NOTE]
    > Het is belangrijk dat je onderscheid maakt tussen hoofdletters en kleine letters bij het invoeren van de veldnamen.

1. Kopieer opnieuw een bestaand veld en plak het onder de producttabel (links uitgelijnd op dezelfde rij als de totaalsom voor het optie).

1. Voer *alternative/numLines* in als veldnaam en klik op **OK**.

1. Voer het label *Regels:* in links van het numLines-veld.

1. Voeg een nieuwe kolom toe met de titel "Afbeelding" (`Image:line/quoteLineThumbnail`.)

1. Je sjabloon moet er nu zo uitzien:

    ![Opdrachtbevestiging met nieuwe velden -screenshot][img1]

1. Sla het sjabloondocument op, maar sluit het niet.

### Bekijk de opdrachtbevestiging in SuperOffice CRM (optioneel)

Om ervoor te zorgen dat je wijzigingen correct worden weergegeven, volg je deze stappen om de opdrachtbevestiging te bekijken:

1. **Open een verkoop** van hetzelfde type waaraan je sjabloon is gekoppeld.
2. Ga naar het tabblad **Offerte** binnen de verkoop en klik op **Open**.
3. Klik op **Bestelling plaatsen** als je dit nog niet hebt gedaan.
4. Klik in het dialoogvenster **Offerte bewerken** op **Bevestiging weergeven**. De opdrachtbevestiging wordt geopend als een PDF-bestand.
5. Controleer de opdrachtbevestiging:
    * Zorg ervoor dat alle inhoud van de tabel correct wordt weergegeven, zonder dat getallen over twee regels worden gesplitst.
    * Controleer of er geen veldnamen in het document worden weergegeven; als dat wel het geval is, heb je mogelijk onjuiste veldnamen gebruikt.
    * Bevestig dat alle ingevoegde velden aanwezig zijn. Ontbrekende velden kunnen erop wijzen dat de vereiste gegevens niet beschikbaar zijn in de offerte of het product.
6. Breng indien nodig de nodige aanpassingen aan in het sjabloon en sla deze op.
7. Bekijk de opdrachtbevestiging opnieuw om ervoor te zorgen dat alle wijzigingen correct worden weergegeven.

### Sorteervolgorde specificeren

1. Voeg het **OrderBy**-veld in het sjabloondocument in.

    `«TableStart:alternative»«OrderBy:name»`

Producten worden nu gesorteerd op productnaam binnen elk optie.
Na het definiëren van het groeperingsgebied worden de producten ook binnen elke groep gesorteerd.

### Groeperingsgebied en sleutel specificeren

1. Voeg `«TableStart:group»` in vóór TableStart:regel.
1. Voeg `«TableEnd:group»` in na TableEnd:regel.
1. Voeg `«GroupBy:productFamilyKey»` overal in het document in om de groeperingssleutel te definiëren.

### Groepsspecifieke velden toevoegen

1. Verplaats de tabel met de totaalsom voor het optie (inclusief het totale aantal regels) een paar regels naar beneden, zodat je ruimte hebt om de groepsvelden tussen TableStart:groep en TableEnd:groep in te voegen.

1. Voeg tussen de titel en de tabel met de producten `«group/groupField»` in. Geef het veld een kopstijl.

    Dit is de titel van de groep (de naam van het veld waarnaar de producten zijn gegroepeerd).

1. Voeg onderaan de kolom met prijzen `«group/sumtotalPrice»` in.

    Dit is de totaalsom voor de hele groep.

1. Voeg in de cel links van de totaalsom voor de hele groep `«group/groupField»` in. Typ het label *Totaal* links van het veld.

### Opslaan en verifiëren

1. Je sjabloon moet er nu zo uitzien:

    ![Opdrachtbevestiging resultaat -screenshot][img2]

1. Sla het sjabloondocument op en verifieer zoals hierboven beschreven.

## Gerelateerde inhoud

* [Maak een sjabloondocument][2]
* [Sjabloonvariabelenreferentie][3]

<!-- Referenced links -->
[1]: link-template.md
[2]: ../learn/create.md
[3]: ../variables/index.md
[4]: ../../../sale/admin/quote/configure-product-fields.md
[5]: ../../../sale/learn/create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/tutorial-insert-fields.png
[img2]: ../../../../media/loc/en/document/tutorial-grouped.png
