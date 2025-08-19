---
uid: help-nl-search-freetext
title: Vrije-tekst zoekbewerking
description: Vrije-tekst zoekbewerking
keywords: vrije tekst, zoeken
author: SuperOffice RnD
date: 03.14.2025
version: 10.5.2
content_type: howto
language: nl
---

# Vrije-tekst zoekbewerking

U kunt met het tekstveld rechtsboven in SuperOffice CRM naar vrije tekst zoeken. Hiermee zoekt u in SuperOffice CRM op in elke tekst die door gebruikers is ingevoerd in de database, zoals bedrijfsnaam, afdeling, informatie over personen en vervolgactiviteiten.

![Vrije-tekst zoekbewerking -screenshot][img1]

> [!NOTE]
> Als de velden voor vrije-tekstzoekbewerking niet zichtbaar zijn in de rechterbovenhoek, is deze optie niet geactiveerd in Instellingen en onderhoud.

## Stappen

1. Typ de tekst waarnaar u wilt zoeken (minimaal drie letters).

2. Druk op **ENTER** om te beginnen met zoeken.

3. Het scherm **Zoekresultaten** wordt geopend en toont alle gegevens met de zoektekst gegroepeerd in tabbladen.

    * Klik op een tabblad om de lijst met zoekresultaten weer te geven.
    * U kunt naar een record uit de lijst met treffers gaan door op deze te dubbelklikken.

> [!TIP]
> U kunt een voorbeeld van records bekijken in het [zijpaneel][1]. Klik op de lijst boven aan het zijpaneel en selecteer **Voorbeeld**. Klik op een record in de zoekresultaten om een voorbeeld te bekijken.

## Voorbeelden van zoekopdrachten

* Zoeken naar "office" levert ook SuperOffice op.
* Als u een woord verkeerd spelt, krijgt u suggesties. Een zoekopdracht naar "ofice" (verkeerd gespeld) levert ook "SuperOffice" op. Dit is ook erg handig wanneer u zich slechts delen van de naam van een bedrijf of persoon herinnert en toch wilt kunnen zoeken.
* Zoeken naar "123" levert ook "SAP 123" op, omdat getallen ook worden geïndexeerd.
* Zoeken naar "IBM" levert ook "I.B.M." op, omdat de indexer ook aanhalingstekens, volledige punten en soortgelijke tekens in de index verwijdert.

## Beperkingen en genegeerde woorden

U kunt zoeken naar tekst in het dialoogvenster **Document**, maar u kunt de werkelijke inhoud van documenten niet doorzoeken. Een zoekbewerking wordt altijd eerst uitgevoerd op tekst in het veld **Onze ref.** in het dialoogvenster **Document**.

> [!NOTE]
> U kunt afzonderlijke woorden opgeven die moeten worden genegeerd bij een vrije-tekstzoekbewerking. Deze zijn gedefinieerd in Instellingen en onderhoud.

<!-- markdownlint-disable-next-line MD013 -->
## Waarom vind ik geen treffers voor een zoekwoord waarvan ik zeker weet dat het in de database voorkomt?

Wanneer u voor een zoekwoord dat in de SuperOffice-database voorkomt, geen treffers vindt, moet u mogelijk de index voor vrije-tekstzoekbewerking in Instellingen en onderhoud opnieuw opbouwen.

## Gerelateerde inhoud

* [Het scherm Zoeken gebruiken][2]
* [Snel zoeken][3]
* [De historielijst][4]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: find-screen.md
[3]: index.md#fastsearcher
[4]: ../../learn/basics/history.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/freetext-search-box.png
