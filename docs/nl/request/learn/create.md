---
uid: help-nl-request-create
title: Een verzoek maken
description: Een verzoek maken
keywords: verzoek aanmaken, verzoek toevoegen, nieuw verzoek, verzoek eigenschappen, verzoekdetails, bericht
author: Bergfrid Dias
date: 07.01.2025
version: 11.2
content_type: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: nl
redirect_from: /nl/request/learn/howto/create
---

# Een verzoek maken

Een verzoek kan in het systeem worden ontvangen via een e-mail van de klant, of u kunt het handmatig registreren via het scherm **Nieuw verzoek**. Dit is bijvoorbeeld relevant als een klant telefonisch een verzoek indient.

## Stappen

1. Klik op **Nieuw** in de bovenste balk en selecteer **Verzoek**.

    Als alternatief, als u zich in het sectietabblad **Verzoeken** bij een contact bevindt, klik dan op **Toevoegen** om een verzoek aan te maken met de contactpersoon vooraf ingevuld.

1. Geef in het veld **Titel** een beschrijvende naam aan het verzoek.

1. Voeg een persoon toe in het veld **Persoon zoeken** (als niet vooraf ingevuld). Begin met het typen van de naam (of het telefoonnummer) en kies uit de resultaten.
    * Optioneel kunt u deze stap overslaan en later een contactpersoon toevoegen.

1. Gebruik het paneel **Verzoekeigenschappen** aan de rechterkant om het verzoek toe te wijzen en te prioriteren.

    * Selecteer **Verzoektype**, **Status**, **Eigenaar**, **Categorie**, **Prioriteit** en andere eigenschappen.

    > [!NOTE]
    > Het verzoektype bepaalt de standaardwaarden en beschikbare statussen en prioriteiten.

1. Ga naar het tabblad **Berichten** om het verzoekbericht op te stellen:

    * Voeg ontvangers toe in het veld **Aan**. Begin met het typen van de naam of het e-mailadres van de contactpersoon en selecteer deze uit de lijst.
    * Optioneel: klik op **Cc/Bcc** om extra ontvangers toe te voegen als kopie of blinde kopie.
    * Voer de berichttekst in, voeg bijlagen toe of gebruik antwoordsjablonen.

    > [!NOTE]
    > De standaardhandtekening van het verzoek wordt aan het bericht toegevoegd. U kunt de handtekening rechtstreeks in het bericht bewerken of uw standaard [e-mailhandtekening][11] bewerken.

1. Ga naar het tabblad **Details** om het verzoek optioneel te koppelen aan een bestaande verkoop of project.

1. Klik op **Verzenden** om het verzoek op te slaan en te verzenden.

![Eigenschappen en bericht van een nieuw verzoek -screenshot][img1]

## <a id="fields"></a>Belangrijke velden uitgelegd

<a id="message"></a><a id="details"></a>
De volgende velden zijn beschikbaar in het scherm Verzoek. Sommige velden worden automatisch ingevuld, terwijl andere handmatig moeten worden ingevoerd.

> [!NOTE]
> Velden en lay-out kunnen variëren op basis van [Schermontwerper][10]-configuraties en andere UI-aanpassingen.

<!-- markdownlint-disable-file MD051 -->
### [Tabblad Berichten](#tab/messages)

Dit tabblad is waar u het verzoekbericht opstelt en beheert.

* Voeg ontvangers toe in het veld **Aan**.
  * Ontvangers worden automatisch als contactpersoon aan het verzoek toegevoegd. De eerste ontvanger wordt de hoofdcontactpersoon.
  * Voeg meerdere ontvangers toe en wijzig de volgorde door te slepen.
  * Om een ontvanger toe te voegen zonder deze als contactpersoon te registreren, voer een e-mailadres in. De ontvanger krijgt het bericht, maar wordt niet als contactpersoon weergegeven.
  * Laat het veld leeg als u het bericht niet wilt verzenden.
* Klik op **Cc/Bcc** om extra ontvangers als kopie of blinde kopie toe te voegen.
* Voeg een berichttekst, bijlagen, [antwoordsjablonen][2] of FAQ-items toe.
* Gebruik **Intern/Extern** om te bepalen of de contactpersoon het bericht in het Klantportaal kan zien.
* Gebruik de timer om de bestede tijd aan het verzoek bij te houden.

De berichteditor werkt als een tekstverwerker en biedt verschillende tools voor het opstellen en opmaken van uw berichten:

| Pictogram | Actie | Beschrijving |
|:-:|---|---|
| <i class="ph ph-text-a-underline" aria-label="Werkbalk tonen/verbergen"></i> | Werkbalk | Tekstopmaakopties weergeven of verbergen. |
| <i class="ph ph-paperclip" aria-label="Bijlagen"></i> | Bijlagen | Voeg bestanden of CRM-documenten toe aan het bericht. |

#### Bijlagen

Om bestanden of CRM-documenten toe te voegen:

1. Klik op <i class="ph ph-paperclip" aria-label="Bijlagen"></i>. Een **Bijlagen**-veld verschijnt onder het veld **Aan**.
1. Voeg bijlagen toe op een van de volgende manieren:
    * Klik op **Bestanden uploaden (of hierheen slepen)** om een bestand te selecteren van uw computer.
    * Sleep bestanden naar het **Bijlagen**-veld.
    * Klik op **Een CRM-document kiezen** om een bestand uit SuperOffice CRM te selecteren.

#### Invoegen

Om uw bericht te verrijken met extra inhoud:

1. In het rechterpaneel **Eigenschappen** klik op <i class="ph ph-article" aria-label="Invoegen"></i>.
1. Kies wat u wilt toevoegen:
    * **Antwoordsjabloon:** Voeg vooraf geschreven tekst in.
    * **FAQ-item:** Voeg een kennisbankartikel toe.
1. Als antwoordsjablonen in meerdere talen beschikbaar zijn, kunt u een taal selecteren.

#### Tijdregistratie

De klok start automatisch bij het aanmaken van het verzoek. U kunt de klok stoppen door op <i class="ph ph-pause" aria-label="Pauze"></i> te klikken en opnieuw starten met <i class="ph ph-play" aria-label="Afspelen"></i>. Voor meer informatie over tijdregistratie, zie [Bestede tijd registreren][3].

### [Tabblad Details](#tab/details)

Het tabblad **Details** bevat meer details over het verzoek. Hier vindt u informatie zoals wanneer het verzoek is gemaakt, wanneer het voor het laatst is gewijzigd, gesloten of beantwoord, wanneer het is gelezen door de eigenaar of contactpersoon en extra velden. Deze informatie wordt automatisch bijgewerkt tijdens de levensduur van het verzoek, maar er zijn enkele velden die kunnen worden bewerkt wanneer het verzoek wordt gemaakt:

* **Relatie**: Hier kunt u ervoor kiezen om het verzoek te koppelen aan een ander verzoek, als het nieuwe verzoek gerelateerd is aan een ander bestaand verzoek.
* **Toegangsniveau**: Dit is een andere manier om het toegangsniveau voor het verzoek in te stellen. Dit kan ook worden gedaan in het **Eigenschappenvenster**. Als u het toegangsniveau hier wijzigt, wordt dit ook automatisch gewijzigd in het **Eigenschappenvenster**.
* **Verkoop/Project**: Koppel het verzoek aan een bestaande verkoop of een bestaand project.
* **Extra velden:** Aanvullende [aangepaste velden][16] op basis van de instellingen van uw organisatie.

### [Eigenschappenvenster](#tab/properties)

Het **Eigenschappenvenster** stelt u in staat het verzoek te categoriseren en toe te wijzen.

* **Verzoektype:** Bepaalt standaardwaarden en statusopties.
* **Status:** Stel in op **Open** (in behandeling), **Gesloten** (afgehandeld), of **Uitgesteld** (met een specifieke heropeningsdatum).
* **Eigenaar:** Wijs het verzoek toe aan uzelf, een andere gebruiker, of laat het niet-toegewezen.
  * **(Automatisch toegewezen):** Het systeem wijst het verzoek toe op basis van toewijzingsregels.
  * **(Niet-toegewezen):** Leden van de relevante categorie delen de verantwoordelijkheid voor het verzoek.
* **Categorie:** Selecteer de relevante categorie voor het verzoek.
* **Prioriteit:** Wijs **Laag**, **Gemiddeld**, of **Hoog** toe, of laat het systeem dit bepalen (bijvoorbeeld op basis van [escalatieniveaus][9]).
* **Toegangsniveau:** Stel in als **Extern** (zichtbaar voor de contactpersoon) of **Intern** (verborgen voor de contactpersoon).
* **Labels:** [Voeg relevante labels toe][4] om het verzoek later gemakkelijker te organiseren en terug te vinden.

> [!TIP]
> Als het paneel geen eigenschappen toont zoals in de voorgaande schermafbeelding, klik dan op <i class="ph ph-list-bullets" aria-hidden="true"></i> om de weergave te wijzigen.

***

## Automatisch opslaan

Wanneer u aan een verzoek werkt en plotseling een dringender verzoek ontvangt, moet u het verzoek waar u aan werkt verlaten om het geprioriteerde verzoek op te lossen.

De functie Automatisch opslaan slaat uw wijzigingen automatisch op totdat u op **Opslaan** klikt om de wijzigingen in uw verzoek te verzenden of te annuleren.
Automatisch opgeslagen informatie wordt in de lokale opslag van uw browser geplaatst, zodat uw gegevens zelfs een crash van uw browser, herstart, afmelding en aanmelding overleven.

De functie Automatisch opslaan is standaard geactiveerd wanneer u verzoeken bekijkt en bewerkt en bij beantwoorden/allen beantwoorden.

### Beperkingen

* Automatisch opgeslagen gegevens worden niet van de ene computer naar de andere overgedragen. Dit betekent dat u niet kunt beginnen met het beantwoorden van een verzoek op het werk en thuis verder kunt gaan.
* Automatisch opgeslagen gegevens worden niet gedeeld tussen twee verschillende browsers.
* De functie Automatisch opslaan is een handige functie, maar is geen vervanging van een normale, correcte opslag van uw werk.

## Gerelateerde inhoud

* [E-mail-handtekening bewerken][11]
* [Labels gebruiken in verzoeken][4]
* [Sjabloonvariabelen voor antwoordsjablonen][18]
* [Antwoordsjabloon maken][19]

<!-- Referenced links -->
[2]: reply.md#reply-templ
[3]: reply.md#time-spent
[4]: tags.md
[9]: ../admin/priority/escalation-levels.md
[10]: ../../customization/screen-designer/admin/index.md
[11]: ../../learn/getting-started/edit-email-signature.md
[16]: ../../custom-objects/admin/create-extra-field.md
[18]: ../../knowledge-base/learn/reply-templates/template-variables.md
[19]: ../../knowledge-base/learn/reply-templates/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/create-request.png
