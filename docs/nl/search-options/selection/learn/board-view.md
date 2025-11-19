---
uid: help-nl-selection-board-view
title: Boardweergave gebruiken in selecties
description: Visualiseer selecties met de boardweergave met groepering, filters en drag-and-drop-kaarten
keywords: boardweergave, board-weergave, selectieoverzicht, selectie, verkoopboard, projectboard, verzoekboard, kanban, groeperen op, filterwerkbalk, verkoopdatum badge, dagen in fase, dagen sinds registratie
author: digitaldiina
date: 12.02.2025
version: 11.7
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Boardweergave gebruiken in selecties <i class="ph ph-kanban" aria-hidden="true"></i>

De boardweergave toont je [selectie][2] in een kolomindeling met kaarten. Je kunt de selectieleden (records op het board) groeperen en filteren en kaarten verplaatsen tussen groepen via drag-and-drop.

De functionaliteit is identiek voor alle ondersteunde entiteiten: je kunt kaarten slepen, taakmenu's openen en boardinstellingen aanpassen. De beschikbare velden voor groepering en filtering verschillen afhankelijk van of je werkt met bedrijven, personen, verkopen, projecten of verzoeken.

![Boardweergave van verkopen gegroepeerd op fase -screenshot][img2]

## Boardweergave openen

1. Ga naar een selectie.

1. Klik rechtsboven op het pictogram voor **boardweergave** (<i class="ph ph-kanban" aria-label="Kanban board"></i>).

    ![Pictogram voor boardweergave rechtsboven in een selectie][img1]

1. Als uw selectie bedrijven en personen bevat, toont de bordweergave slechts één entiteitstype tegelijk. Om te wisselen klikt u op <i class="ph ph-gear-six" aria-label="Settings"></i> en gebruikt u vervolgens de vervolgkeuzelijst **Entiteit weergeven** om *Bedrijf* of *Persoon* te kiezen.

## Werken met kaarten

* Klik op de titel van een kaart om het volledige record te openen (bijvoorbeeld een verkoopkaart).

* Beweeg de muis over een naam of bedrijf om contactgegevens te bekijken.

    ![Voorbeeldweergave van contactgegevens bij hover op een kaart -screenshot][img3]

* Versleep kaarten tussen kolommen om het groeperingsveld bij te werken (zoals fase of eigenaar).
  * Als subgroepen zijn ingeschakeld, kun je kaarten ook tussen rijen binnen elke kolom slepen.

* Klik op een kaart om de details in het [zijpaneel][11] te bekijken. (Schakel de voorbeeldweergave in door deze te selecteren in het vervolgkeuzemenu bovenaan het zijpaneel).

    ![Zijpaneel met projectdetails -screenshot][img12]

* Om een kaart te bewerken, wijs deze aan en klik op **Bewerken** (<i class="ph ph-pencil" aria-hidden="true"></i>). Dezelfde bewerkdialoog wordt gebruikt als elders in SuperOffice CRM – zonder de boardweergave te verlaten.

  ![Cursor wijst naar de knop Bewerken op een verkoopkaart -screenshot][img4]

* Voor meer opties: wijs naar de kaart om het **Taak**-menu te tonen <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>, klik erop en kies een actie.

  * **Verkopen:** Bewerken, Vervolgactiviteit maken, Markeren als gewonnen/verloren, Verwijderen
  * **Projecten:** Bewerken, Vervolgactiviteit maken, Document aanmaken, Markeren als voltooid, Verwijderen
  * **Verzoeken:** Bewerken, Verzoek sluiten, Verwijderen
  * **Bedrijf:** Bewerken, Vervolgactiviteit maken, Verkoop maken, Naar de volgende categorie, Verwijderen
  * **Persoon:** Bewerken, Vervolgactiviteit maken, Verkoop maken, Verwijderen

  ![Geopend taakmenu op een verkoop in boardweergave met beschikbare acties -screenshot][img5]

<!-- markdownlint-disable-next-line MD013 -->
## Boardindeling aanpassen <i class="ph ph-gear-six" aria-hidden="true"></i> <i class="ph ph-sliders-horizontal" aria-hidden="true"></i>

### Groeperen en subgroeperen

Zo kies je welke kolommen worden weergegeven:

1. Klik op het pictogram **instellingen** (<i class="ph ph-gear-six" aria-hidden="true"></i>).

1. Kies **Groeperen op**.

    ![Instellingenpaneel van boardweergave voor verkoopselecties met groeperingsopties -screenshot][img6]

1. Selecteer een veld om de kolomindeling te bepalen.

    ![Groeperen-op-menu met beschikbare verkoopvelden zoals Fase en Eigenaar -screenshot][img7]

1. Klik op de pijl naar links (<i class="ph ph-caret-left" aria-hidden="true"></i>) om terug te gaan naar het instellingenoverzicht.

1. Kies optioneel een waarde voor **Subgroeperen op** om kaarten op te splitsen in aparte rijen binnen elke kolom.

1. Kies eventueel **Instellingen alleen voor deze selectie opslaan** om wijzigingen alleen op dit board toe te passen.

1. Klik op **Voltooid** om je instellingen toe te passen.

Voorbeelden van groeperingsvelden:

* **Verkopen:** Fase, Verkooptype, Eigenaar
* **Projecten:** Status, Verantwoordelijke, Type
* **Verzoeken:** Status, Verzoektype, Prioriteit, Eigenaar
* **Bedrijf:** Categorie, Onze kontaktpersoon
* **Persoon:** Categorie, Onze kontaktpersoon, Leadstatus

### Kaarten sorteren in kolommen

Gebruik het instellingenpaneel (<i class="ph ph-gear-six" aria-hidden="true"></i>) om **Sorteren op** en **Sorteervolgorde** in te stellen, bijvoorbeeld op verkoopdatum.

### Filters instellen

1. Klik op <i class="ph ph-sliders-horizontal" aria-label="Toggle filter toolbar"></i> om de filterwerkbalk te tonen.

    ![Filterwerkbalk in boardweergave van verkoopselectie -screenshot][img9]

1. Zo kies je welke filters beschikbaar zijn:

    1. Klik op <i class="ph ph-gear-six" aria-hidden="true"></i> om de instellingen te openen.
    1. Kies **Filterwerkbalk** en schakel filters in met de selectievakjes.
    1. Klik op de pijl naar links (<i class="ph ph-caret-left" aria-hidden="true"></i>) om terug te keren en klik dan op **Voltooid**.

    ![Filterinstellingen met beschikbare verkoopvelden zoals Fase en Eigenaar -screenshot][img8]

1. Vouw in de werkbalk een filter uit (bijvoorbeeld **Eigenaar**) om een lijst te tonen.

    * Selecteer of deselecteer items om ze toe te voegen of te verwijderen.
    * Klik op **Wissen** onderaan het keuzemenu om dat filter te resetten.
    * Klik op **X** aan de rechterkant van de werkbalk om **alle** filters tegelijk te resetten.

    ![Filterwerkbalk, verkooptype uitgeklapt -screenshot][img10]

Voorbeelden van filters:

* **Verkoop:** Verkooptype, Eigenaar, Fase, Volgende activiteit, Verkoopdatum
* **Projecten:** Type, Verantwoordelijke, Status, Volgende mijlpaal, Einddatum
* **Verzoeken:** Verzoekcategorie, Eigenaar, Status, Gemaakt, Deadline, Prioriteit
* **Bedrijf:** Onze kontaktpersoon, Geregistreede datum, Volgende activiteit, Categorie, Land
* **Persoon:** Onze kontaktpersoon, Eigenaar groep, Geregistreede datum, Volgende activiteit, Leadstatus, Categorie, Land

### Samenvatten (alleen verkopen)

Je kunt totalen van numerieke velden tonen in de boardweergave voor verkopen.

1. Klik op <i class="ph ph-gear-six" aria-hidden="true"></i> om het instellingenpaneel te openen.
2. Kies **Samenvatten op**.
3. Selecteer een numeriek veld, zoals **Bedrag** of **Gewogen bedrag**.

De totale waarde wordt **naast elke kolomtitel** weergegeven, zodat je eenvoudig de waarde per fase, eigenaar of ander groeperingsveld kunt volgen.

![Verkoopboard met samengevatte waarden per kolomnaam -screenshot][img11]

### Verkoopdatum badge (alleen verkopen)

Je kunt bepalen wat de **grijze badge** op elke verkoopkaart toont in de boardweergave. Dit helpt je om de leeftijd in één oogopslag te begrijpen – of hoe lang een verkoop open staat of hoe lang deze in de huidige fase zit.

1. Klik op <i class="ph ph-gear-six" aria-hidden="true"></i> om het **Instellingen**-paneel te openen.

    ![Instellingenpaneel voor verkoopboard met opties voor groepering, sortering, samenvatting, filters, verkoopdatum badge en verberg gesloten verkopen. -screenshot][img13]

1. Selecteer **Verkoopdatum badge**.

1. Kies een van de volgende opties:

    * **Dagen in fase:** Toont hoeveel dagen de verkoop in de huidige fase heeft gezeten.
    * **Dagen sinds registratie:** Toont hoe lang geleden de verkoop is aangemaakt.

    ![Verkoopdatum badge instellingendialoog met de opties Dagen in fase en Dagen sinds registratie. -screenshot][img14]

De geselecteerde metriek verschijnt als een **grijze badge** op elke verkoop in de boardweergave. Een **rode badge** wordt nog steeds gebruikt om achterstallige verkopen te markeren.

## Gebruiksscenario's

De boardweergave ondersteunt verschillende rollen en werkwijzen. Hier zijn voorbeelden voor verkopers, projectleden, supportmedewerkers en managers:

### Verkopers

* **Visualiseer je openstaande verkopen** en zie in welk stadium elke kans zich bevindt.
* **Sleep een kaart naar een andere kolom** om de verkoopfase aan te passen.
* **Filter op verkoopdatum** om te focussen op wat nu belangrijk is.
* **Open het taakmenu** om een vervolgactiviteit aan te maken of een verkoop als gewonnen/verkocht te markeren.
* **Bewerk een kaart snel** om details zoals een nieuwe contactpersoon bij te werken.

### Verkoopmanagers

* **Visualiseer de volledige pipeline** en begrijp de verdeling van verkopen over fases.
* **Vat samen op bedrag** voor ondersteuning bij forecasting.
* **Filter op verkooptype** om te focussen op new business of specifieke campagnes.
* **Groepeer op eigenaar** om de werklast per verkoper te controleren en te herverdelen met drag-and-drop.
* **Gebruik fase als groep en verkooptype als subgroep** voor strategisch overzicht per categorie en fase.

### Projectleden

* **Visualiseer je actieve projecten** en volg de voortgang via verschillende statussen.
* **Sleep een kaart naar een andere kolom** om de projectstatus bij te werken.
* **Filter op volgende mijlpaal of einddatum** om te focussen op dringende opleveringen.
* **Groepeer op verantwoordelijke** om eigenaarschap binnen het team te zien.
* **Open het taakmenu** om een vervolgactiviteit of document aan te maken, of om het project als voltooid te markeren.

### Projectmanagers

* **Krijg een volledig overzicht van alle projecten** om status te monitoren en vertragingen te herkennen.
* **Vat samen op type** om klantprojecten, interne initiatieven of ontwikkelwerk te vergelijken.
* **Filter op verantwoordelijke** om de werklast binnen het team in balans te brengen.
* **Groepeer op status** om te zien hoe projecten door fasen bewegen, of op type om aan te sluiten bij bedrijfsprioriteiten.

### Supportmedewerkers

* **Visualiseer je toegewezen verzoeken** en volg ze via statussen zoals nieuw, in behandeling en gesloten.
* **Sleep een kaart naar een andere kolom** om de verzoekstatus bij te werken.
* **Filter op deadline of prioriteit** om eerst urgente zaken af te handelen.
* **Groepeer op status** om voortgang te volgen, of op verzoektype om te focussen op specifieke categorieën.
* **Open het taakmenu** om het verzoek te sluiten.

### Supportmanagers

* **Krijg een volledig overzicht van inkomende verzoeken** en bekijk de verdeling per status.
* **Vat samen op prioriteit** om te zorgen dat belangrijke verzoeken snel worden afgehandeld.
* **Filter op categorie of aanmaakdatum** om trends in klantproblemen te analyseren.
* **Groepeer op eigenaar** om de werklast tussen medewerkers te monitoren en verzoeken indien nodig te herverdelen.
* **Gebruik status als groep en prioriteit als subgroep** om een gestructureerd overzicht te krijgen voor analyse en rapportage.

Gebruik groepering creatief om efficiënt met gegevens te werken.

## Problemen oplossen en tips

* **Nieuwe verkopen ontbreken:** Klik op <i class="ph ph-arrow-clockwise" aria-label="Refresh icon"></i> om de boardweergave te vernieuwen en de laatste gegevens op te halen.

* **Filterwerkbalk niet zichtbaar:** Schakel deze in of uit met het pictogram <i class="ph ph-sliders-horizontal" aria-hidden="true"></i>.

* **Een kolom is leeg:** Mogelijk is de inhoud eruit gefilterd. Controleer actieve filters in de werkbalk.

* **Kan een filterveld niet vinden:** Ga naar **Instellingen** (<i class="ph ph-gear-six" aria-hidden="true"></i>) > **Filterwerkbalk** en activeer het gewenste veld.

* **Selectie zelf bewerken (niet leden)?** Klik op <i class="ph ph-subtract-square" aria-label="Selection icon"></i> om terug te gaan naar de selectieoverzicht. Bewerken- en taakknoppen voor de selectie zijn niet beschikbaar in boardweergave.

* **Zoek kaarten op naam:** Gebruik het veld **Filter op titel** bovenaan om kaarten op naam te filteren.

* **Layout per toepassing opslaan:** Kies **Instellingen alleen voor deze selectie opslaan** als je een specifieke boardindeling, filters of groepering wilt bewaren voor één selectie.

## Gerelateerde inhoud

* [Een selectie aanmaken][1]
* [Een verkoop aanmaken / velden in de verkoopkaart][12]
* [Verkoopfasen configureren][13]
* [Een verzoek aanmaken / verzoekeigenschappen][14]
* [Verzoekstatus aanmaken][15]
* [Verzoekcategorie aanmaken][16]
* [Een project aanmaken / velden in de projectkaart][17]
* [Projectstatus configureren][18]
* [Projecttypen configureren][19]

<!-- Verwijzingen -->
[1]: create.md
[2]: index.md
[11]: ../../../learn/getting-started/main-screen/side-panel.md
[12]: ../../../sale/learn/create.md
[13]: ../../../sale/admin/sale-stage.md
[14]: ../../../request/learn/create.md
[15]: ../../../request/admin/status/create.md
[16]: ../../../request/admin/category/create.md
[17]: ../../../project/learn/create.md
[18]: ../../../project/admin/project-status.md
[19]: ../../../project/admin/project-type.md

<!-- Afbeeldingen -->
[img1]: ../../../../media/loc/en/search-options/board-view-toggle.png
[img2]: ../../../../media/loc/en/search-options/board-view.png
[img3]: ../../../../media/loc/en/search-options/board-view-preview-contact-on-hover.png
[img4]: ../../../../media/loc/en/search-options/board-view-card-edit-icon.png
[img5]: ../../../../media/loc/en/search-options/board-view-card-task-menu.png
[img6]: ../../../../media/loc/en/search-options/board-view-settings.png
[img7]: ../../../../media/loc/en/search-options/board-view-settings-group-by.png
[img8]: ../../../../media/loc/en/search-options/board-view-settings-filter.png
[img9]: ../../../../media/loc/en/search-options/board-view-filter-toolbar.png
[img10]: ../../../../media/loc/en/search-options/board-view-filter-on-sale-type.png
[img11]: ../../../../media/loc/en/search-options/board-view-summarized-sale-amount-per-column.png
[img12]: ../../../../media/loc/en/search-options/selection-board-view-project-preview.png
[img13]: ../../../../media/loc/en/search-options/board-view-settings-for-sales.png
[img14]: ../../../../media/loc/en/search-options/sale-date-badge-setting.png
