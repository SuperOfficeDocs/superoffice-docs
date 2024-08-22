---
uid: help-nl-reply-template-create
title: Antwoordsjablonen maken
description: Meer informatie over het maken van een antwoordsjabloon vindt u in deze gids.
author: Bergfrid Dias
date: 03.16.2023
keywords: verzoek, beantwoorden, sjabloon
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: nl
---

# Antwoordsjabloon maken

Een antwoordsjabloon is een vooraf gedefinieerde tekst die kan worden geplakt in een bericht dat u opstelt voor een persoon. Het gebruik van antwoordsjablonen bespaart tijd en u kunt gepersonaliseerde berichten naar uw personen sturen.

Antwoordsjablonen kunnen ook een bijlage betreffen die met de sjabloon aan het bericht wordt toegevoegd. Voordat u het antwoord naar de persoon stuurt, kunt u de tekst bewerken en er bijlagen aan toevoegen of eruit verwijderen.

> [!NOTE]
> U hebt *Kennisdatabase* nodig als functioneel recht om antwoordsjablonen te maken.

## Stappen

1. Ga naar ![het pictogram][img1] **Hoofdmenu** in de bovenste balk en selecteer **Kennisdatabase** > **Antwoordsjablonen**.

1. Ga naar de map waarin u de antwoordsjabloon wilt opslaan. Als deze nog niet bestaat, kunt u [een nieuwe map maken][2].

    ![Antwoordsjablonen vinden in SuperOffice -screenshot][img3]

1. Klik op de knop **Nieuwe antwoordsjabloon**.

1. Bovenaan het tabblad **Eigenschappen** in het scherm **Eigenschappen antwoordsjabloon**moeten de volgende informatie worden ingevoerd:

    * **Naam**: een beschrijvende naam voor de antwoordsjabloon.
    * **Beschrijving**: een korte beschrijving van de inhoud van de antwoordsjabloon.
    * **Map**: standaard is dit de naam van de geselecteerde map. U kunt hier een andere map selecteren.
    * **Toegang**: hier kunt u aangeven wie toegang heeft tot de antwoordsjabloon en deze kan lezen/bewerken.

1. Selecteer het tabblad **(Niet-gespecificeerde taal)**.

1. Voer op het tabblad **Eigenschappen** de volgende informatie in:
    * **Taal**: selecteer in deze lijst de taal van de antwoordsjabloon. De keuzelijst bevat de talen die via ![pictogram][img2] &gt; **Klanttalen** zijn geregistreerd.
    * **Standaard**: Schakel deze optie in als u deze taal als standaardtaal wilt instellen voor deze antwoordsjabloon.
    * **Onderwerp**: voer hier de titel van de antwoordsjabloon in. Normaalgesproken wordt deze in het veld **Onderwerp** geplaatst wanneer de antwoordsjabloon wordt gebruikt voor een e-mailbericht.
    * **Berichtkoppen**: Hier kunt u vooraf gedefinieerde inhoud toevoegen die moet worden weergegeven in de koptekst, bijvoorbeeld de velden **Aan** en **Onderwerp**, van een e-mailbericht. Deze functie wordt alleen in speciale gevallen gebruikt.

1. Voer op het tabblad **Gewone tekst** de volgende informatie in:

    * **Inclusief gewone tekst**: wanneer u een HTML-versie maakt, is het altijd een goed idee een identieke versie met gewone tekst te maken voor e-mailclients die geen HTML ondersteunen. Het e-mailprogramma selecteert dan automatisch de juiste indeling. Als u deze optie niet inschakelt, wordt de tekst hieronder genegeerd. Deze wordt echter wel opgeslagen, zodat u die tekst later alsnog kunt opnemen.

    > [!NOTE]
    > Wanneer u zowel gewone tekst als HTML-tekst opneemt, kiest het ontvangende e-mailprogramma de 'beste' versie, wat meestal HTML is. Houd er rekening mee dat berichten die zonder versie met gewone tekst worden verzonden, alleen kunnen worden gelezen door e-mailprogramma's die HTML ondersteunen.

    * In het grote veld in het midden van het scherm voert u de inhoud van de antwoordsjabloon in. Deze tekst wordt altijd gebruikt als u [antwoordsjablonen toevoegt aan berichten][4].
    * **Spellingcontrole**: start een spellingcontrole van het bericht in de taal die in de lijst **Taal** is geselecteerd.

1. Voer op het tabblad **HTML-tekst** de volgende informatie in:

    * **Inclusief HTML-tekst**: schakel deze optie in om de tekst eronder op te nemen in een HTML-versie van het e-mailbericht. Deze wordt gebruikt voor klanten die via hun e-mailprogramma HTML kunnen lezen (zoals Outlook). Uw berichten komen vaak beter over wanneer u HTML gebruikt, omdat u afbeeldingen en kleur kunt gebruiken.
    * Voer in het grote veld in het midden van het scherm de tekst met HTML-indeling in die u in het bericht naar de persoon wilt opnemen. Afbeeldingen waarnaar in het bericht een koppeling wordt opgenomen, moeten beschikbaar zijn op een server die toegankelijk is voor ontvangers van het e-mailbericht. U kunt bijvoorbeeld afbeeldingen toevoegen die eerder zijn geüpload naar **Externe documenten**.

1. Via het tabblad **SMS-tekst** kunt u antwoordsjabloontekst toevoegen voor verzending via SMS. Voer de volgende informatie in:

    * **SMS-tekst**: hier voert u de hoofdtekst van de antwoordsjabloon in.
    * **Aantal tekens**: hier kunt u bijhouden hoeveel tekens u hebt ingevoerd.

1. Via het tabblad **Bijlagen** kunt u bijlagen toevoegen voor opname in de antwoordsjabloon:

    1. Klik op **Bestanden kiezen**.
    2. Blader in het dialoogvenster naar het gewenste document.
    3. Klik op **Toevoegen** om de bijlage toe te voegen.
    4. Herhaal deze procedure om meer bijlagen toe te voegen.

    > [!TIP]
    > U kunt een bijlage verwijderen door te klikken op **Verwijderen** rechts van de rij.

1. Klik op **OK** om de antwoordsjabloon op te slaan. Het tabblad **(niet-opgegeven taal)** wijzigt in de geselecteerde taal. Klik op **Vorige** om terug te gaan naar de mapstructuur voor antwoordsjablonen. Deze is nu beschikbaar voor gebruik wanneer u [vragen van klanten beantwoordt][4].

## Aangepaste opmaak voor antwoorden maken met behulp van categorieën

Om elke afdeling in uw bedrijf een aangepaste opmaak voor correspondentie te geven, kunt u antwoordsjablonen met verschillende opmaken maken. Elke antwoordsjabloon kan worden gekoppeld aan een [categorie][1] die een afdeling vertegenwoordigt. Alle uitgaande antwoorden van de categorieën (afdelingen) worden samengevoegd met het afdelingsspecifieke ontwerp.

Afgezien van de lay-out/opmaak van de antwoordsjabloon, moet deze de volgende sjabloonvariabelen bevatten om samengevoegd te worden met het antwoord:

```text
[[IF:message.bodyHtml!=""]]
[[message.bodyHtml]]
[[ELSE]]
[[message.body]]
[[ENDIF]]
```

## <a id="faq"></a>Automatische beantwoording van Veelgestelde vragen

SuperOffice Service wordt geleverd met een set antwoordsjablonen. Onder deze antwoordsjablonen vindt u 'Voorbeeld van een geautomatiseerd antwoord uit Veelgestelde vragen'. Deze antwoordsjabloon bevat een voorbeeld van de automatisering van de antwoorden voor de klant op het tabblad **HTML-tekst**.

Gebaseerd op het verzoek van de klant, zoekt het systeem naar overeenkomstige woorden (inclusief de belangrijkste woorden) in items in Veelgestelde vragen in SuperOffice Service. Gebaseerd op de mate van correlatie tussen deze items, worden Veelgestelde vragen die de klant verder kunnen helpen, opgenomen in de antwoordsjabloon die automatisch naar de klant wordt gestuurd als ontvangstbevestiging van het verzoek.

U kunt de mate van correlatie tussen het verzoek van de klant en de items in Veelgestelde vragen in het veld **Minimumscore voor zoekresultaten Veelgestelde vragen (percentage)** in ![pictogram][img2] **Systeeminstellingen** > **Systeem** > **Instellingen** selecteren.

## Wat wilt u nu doen?

* [Antwoordsjabloon in een nieuwe taal maken][5]
* [Antwoordsjablonen bewerken][6]
* [Antwoordsjablonen kopiëren][7]

<!-- Referenced links -->
[1]: ../../learn/category/index.md
[2]: manage-folders.md
[4]: ../../learn/howto/reply.md
[5]: new-language.md
[6]: edit.md
[7]: copy.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/main-menu.png
[img2]: ../../../../media/icons/main-menu-small.png
[img3]: ../../../../media/loc/en/request/create-a-new-reply-template.png
