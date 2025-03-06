---
uid: help-nl-request-create
title: Een verzoek maken
description: Een verzoek maken
author: Hanne Gunnarsson
date: 03.11.2025
version: 10.5.3
keywords: verzoek
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: nl
---

# Een verzoek maken

Een verzoek kan in het systeem worden ontvangen via een e-mailbericht van de klant. U kunt een verzoek ook handmatig registreren via het scherm **Nieuw verzoek**. Bijvoorbeeld wanneer een klant een telefonisch een verzoek indient.

## Workflow

1. Selecteer **Nieuw** > **Verzoek**.

1. Geef in het veld **Titel** een beschrijvende naam aan het verzoek.

    Als alternatief, als je je in het sectietabblad **Verzoeken** bij een contact bevindt, klik dan op **Toevoegen** om een verzoek aan te maken met de persoon vooraf ingevuld.

1. Voeg een persoon toe in het veld **Persoon zoeken** (als niet vooraf ingevuld).
   Wilt u geen persoon toevoegen? Als u weinig tijd hebt kunt u een ticket maken zonder een persoon toe te voegen en dit later doen.

1. Wanneer u een nieuw verzoek maakt, heeft het veld **Aan** de volgende doeleinden:

    * Standaard zijn de personen die hier worden ingevoerd, ook de contactpersonen voor het nieuwe verzoek.
    * Als u meer dan een persoon invoert, is de eerste persoon de hoofdcontactpersoon voor het verzoek. U kunt ook op de personen klikken en deze slepen om de volgorde te wijzigen.

    Begin in het veld **Persoon** (Persoon zoeken) met het invoeren van de naam (of het telefoonnummer) van de persoon. Gebruik in de lijst met zoekresultaten de pijl-omhoog en pijl-omlaag op uw toetsenbord om een persoon te selecteren en druk op **ENTER**. Of gebruik uw muiscursor om de persoon te selecteren.

    Voer optioneel een e-mailadres in om een ontvanger toe te voegen zonder deze te registreren in het systeem. In dit geval wordt deze persoon niet toegevoegd als contactpersoon voor het verzoek.

    > [!NOTE]
    > U kunt dit veld leeg laten als u het bericht naar niemand wilt versturen.

1. Optioneel: klik op de knop **Cc/Bcc** uiterst rechts om personen toe te voegen voor een kopie of blinde kopie.

1. Ga naar het **Eigenschappenvenster** aan de rechterkant van het scherm en voer informatie in om de aanvraag correct toe te wijzen en te prioriteren.

    * Selecteer in de keuzelijst **Verzoektyp** een type dat van invloed zal zijn op standaardwaarden en beschikbare statussen en prioriteiten.

    * Selecteer in de keuzelijst **Status** een van de volgende opties:
      * **Openen**: selecteer deze optie als het verzoek actief is.
      * **Gesloten**: Selecteer deze optie als het verzoek voltooid is.
      * **Uitgesteld**: om de afhandeling van het verzoek uit te stellen, selecteert u deze optie en geeft u in het veld **Opgegeven** een datum en tijd op, of een vooringestelde tijd uit de onderstaande lijst. De status van het verzoek wordt op de opgegeven datum en tijd teruggezet naar **Openstaand**.

    * Selecteer in het veld **Eigenaar** een van de volgende opties:
      * Om een verzoek toe te wijzen aan een specifiek persoon, selecteert u de gewenste naam. Selecteer uw eigen naam om het ticket aan uzelf toe te wijzen.
      * **(Automatisch toegewezen)**: als u deze optie selecteert, wordt het verzoek toegewezen in overeenstemming met de toewijzingsregels die van toepassing zijn.
      * **(Niet-toegewezen)**: u kunt er ook voor kiezen het verzoek niet toe te wijzen. De leden van de relevante categorie worden dan verantwoordelijk voor het beheer van het verzoek.

    * Selecteer in het veld **Categorie** de gewenste categorie in de lijst die wordt weergegeven.

    * In de keuzelijst **Prioriteit** kunt u kiezen uit **Laag**, **Gemiddeld** en **Hoog**. U kunt er ook voor kiezen de prioriteit automatisch te laten toekennen. Dit kan bijvoorbeeld op basis van [escalatieniveaus][3] die voor verschillende personen en bedrijven zijn ingesteld.

    * Selecteer in de keuzelijst **Toegangsniveau voor verzoek** een van de volgende opties:
      * **Extern**: selecteer deze optie als de persoon toegang moet krijgen tot het verzoek via SuperOffice Customer Centre.
      * **Intern**: selecteer deze optie als de persoon geen toegang moet krijgen tot het verzoek. Het verzoek wordt weergegeven in SuperOffice Customer Centre, maar de persoon kan de verzoekgegevens of -berichten niet weergeven.

    * Selecteer in de keuzelijst **Labels** de [relevante labels][4] voor dit verzoek.

    ![Request properties sidebar -screenshot][img7]

1. Ga naar het tabblad **Berichten** en voer de [tekst van het bericht](#message) in dat u aan het verzoek wilt toevoegen.

1. Klik op **Verzenden** om de aanvraag te verzenden en op te slaan.

## <a id="message"></a>Bericht

> [!NOTE]
> om het bericht naar iemand wilt verzenden, moet u ontvangers toevoegen in het veld **Aan** onder de tabbladen. Om het bericht beschikbaar te maken voor de persoon via SuperOffice Customer Centre, moet u het toegangsniveau (voor het bericht) instellen op **Extern**.

Hier typt u de tekst van het bericht dat u aan het verzoek wilt toevoegen. Dit werkt op dezelfde manier als het invoeren van tekst in een tekstverwerker. U kunt ook bijlagen, [antwoordsjablonen][2] en veelgestelde vragen aan het bericht toevoegen.

Onderin staan de volgende opties:

* ![pictogram][img1] – Klik hier om de werkbalk in de berichteditor weer te geven of te verbergen
* ![pictogram][img2] – Klik hier om de opties voor de bijlagen weer te geven. Hier kunt u relevante documenten aan het verzoek toevoegen als bijlagen.
  * Klik op **Bestand uploaden (of hierheen slepen)** om naar een bestand op een schijf of server te bladeren en het toe te voegen.
  * Sleep een bestand vanuit Windows Explorer naar het veld voor de bijlagen.
  * Klik op **Een CRM-document kiezen** om een document te selecteren in SuperOffice CRM.
* **Invoegen**: klik op de lijstknop ![pictogram][img3] en selecteer wat er moet worden ingevoegd in het bericht. U kunt een antwoordsjabloon, een item uit Veelgestelde vragen, een vorig bericht of een bijlage toevoegen. Optioneel: U kunt ook [antwoordsjablonen in andere talen toevoegen][7]. Selecteer een taal in de taallijst. Indien beschikbaar wordt de tekst ingevoegd in de geselecteerde taal. Anders wordt de standaardnaam gebruikt.
* **Intern/Extern**: hier kunt u **Extern** selecteren als de persoon toegang moet hebben tot het bericht via een SuperOffice Customer Centre; selecteer **Intern** als de persoon geen toegang moet hebben tot het bericht.
* **Gebruikte tijd**: hier kunt u de hoeveelheid tijd invoeren die is besteed aan het bericht. De klok wordt automatisch gestart wanneer u het verzoek maakt. U kunt de klok stoppen door te klikken op de stop knop ![pictogram][img4] en de klok opnieuw opstarten door te klikken op de startknop ![pictogram][img5]. Klik op de ![pictogram][img6] (**Tijdsperiode selecteren**) knop om de bestede tijd te registreren.

> [!NOTE]
> De standaardhandtekening van het verzoek wordt aan het bericht toegevoegd. U kunt de handtekening rechtstreeks in het bericht bewerken of uw standaard [e-mailhandtekening][1] bewerken.

## <a id="details"></a>Details

Het tabblad **Details** bevat meer details over het verzoek. Hier vindt u informatie zoals wanneer het verzoek is gemaakt, wanneer het voor het laatst is gewijzigd, gesloten of beantwoord, wanneer het is gelezen door de eigenaar of contactpersoon en extra velden. Deze informatie wordt automatisch bijgewerkt tijdens de levensduur van het verzoek, maar er zijn enkele velden die kunnen worden bewerkt wanneer het verzoek wordt gemaakt:

* **Relatie**: Hier kunt u ervoor kiezen om het verzoek te koppelen aan een ander verzoek, als het nieuwe verzoek gerelateerd is aan een ander bestaand verzoek.
* **Toegangsniveau**: Dit is een andere manier om het toegangsniveau voor het verzoek in te stellen. Dit kan ook worden gedaan in het **Eigenschappenvenster**. Als u het toegangsniveau hier wijzigt, wordt dit ook automatisch gewijzigd in het **Eigenschappenvenster**.
* **Verkoop**: Hier kunt u het verzoek koppelen aan een bestaande verkoop door te zoeken naar de gewenste verkoop of deze in de lijst te selecteren.
* **Project**: Hier kunt u het verzoek koppelen aan een bestaand project door te zoeken naar het gewenste project of deze in de lijst te selecteren.

## Automatisch opslaan

Wanneer u aan een verzoek werkt en plotseling een dringender verzoek ontvangt, moet u het verzoek waar u aan werkt verlaten om het geprioriteerde verzoek op te lossen.

De functie Automatisch opslaan slaat uw wijzigingen automatisch op totdat u op **Opslaan** klikt om de wijzigingen in uw verzoek te verzenden of te annuleren.
Automatisch opgeslagen informatie wordt in de lokale opslag van uw browser geplaatst, zodat uw gegevens zelfs een crash van uw browser, herstart, afmelding en aanmelding overleven.

De functie Automatisch opslaan is standaard geactiveerd wanneer u verzoeken bekijkt en bewerkt en bij beantwoorden/allen beantwoorden.

### Beperkingen

* Automatisch opgeslagen gegevens worden niet van de ene computer naar de andere overgedragen. Dit betekent dat u niet kunt beginnen met het beantwoorden van een verzoek op het werk en thuis verder kunt gaan.
* Automatisch opgeslagen gegevens worden niet gedeeld tussen twee verschillende browsers.
* De functie Automatisch opslaan is een handige functie, maar is geen vervanging van een normale, correcte opslag van uw werk.

## Details

Dit tabblad bevat eventuele extra velden die zijn gedefinieerd voor verzoeken. Deze verschillen per bedrijf.

## Wat wilt u nu doen?

* [Bericht bewerken][5]
* [Verzoeken verwerken][8]
* [E-mail-handtekening bewerken][1]
* [Escalatieniveaus][3]
* [Codes gebruiken in verzoeken][4]
* [Antwoordsjablonen toevoegen aan berichten][2]
* [Sjabloonvariabelen][11]
* [Antwoordsjabloon maken][9]
* [Antwoordsjabloon in een nieuwe taal maken][7]

<!-- Referenced links -->
[1]: ../../../learn/getting-started/edit-email-signature.md
[2]: reply.md#reply-templ
[3]: ../priority/escalation-levels.md
[4]: ../tags.md
[5]: edit-message.md
[7]: ../../reply-templates/learn/new-language.md
[8]: ../index.md
[9]: ../../reply-templates/learn/index.md
[11]: ../../reply-templates/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/format-font.png
[img2]: ../../../../../common/icons/attachments-theme.png
[img3]: ../../../../../common/icons/copy-paste-icon.png
[img4]: ../../../../../common/icons/stop.png
[img5]: ../../../../../common/icons/play.png
[img6]: ../../../../../common/icons/timespan.png
[img7]: ../../../../media/loc/en/request/requests-select-request-types.png
