---
uid: help-nl-saint-admin
title: Instellen SAINT
description: In deze gids staat hoe u SuperOffice SAINT instelt.
keywords: SAINT, statuscontroles
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Instellen SAINT

U kunt uw klanten proactief opvolgen door gebruik te maken van SAINT, wat staat voor Sales Intelligence. SuperOffice SAINT kan op vele manieren en voor veel verschillende processen worden gebruikt. Voor een succesvolle implementatie van de SAINT-functie is het belangrijk om te weten wat u wilt verbeteren en hoe u dit kunt analyseren.

Nadat u hebt bepaald wat u wilt verbeteren, is de volgende stap na te gaan welke actie uw bedrijf zou kunnen ondernemen om de bestaande situatie te verbeteren. Welke actie wilt u ondernemen?

* Een groepsmailing verzenden met SuperOffice Mailings
* Bell alle klanten in de SAINT selectie
* Vervolgactiviteit van alle verzoeken

[!include[Requirement](../includes/note-saint-req.md)]

Via het tabblad **Statuscontroles/SAINT** in het scherm kunt u statussen voor bedrijven, personen en projecten maken. Statuscontroles vertegenwoordigen de functionaliteit van het Sales Intelligence-concept (SAINT). Dit maakt het mogelijk om bedrijven, personen en projecten op te volgen en biedt geavanceerde zoekopties in SuperOffice CRM.

## Statusafbeeldingen

Statussen kunnen worden weergegeven als afbeeldingen op de kaarten van projecten, personen of bedrijven die voldoen aan de uw criteria. De statusafbeelding voor een klant waarmee u enige tijd geen contact hebt gehad, zou bijvoorbeeld een spinnenweb kunnen zijn. Zo beschikt u over een visuele en directe aanduiding van de status van uw relatie met de klant of van de voortgang van een project. Wanneer de gebruiker op een statusafbeelding in SuperOffice CRM klikt of de muisaanwijzer boven een statusafbeelding houdt, verschijnt er een tekst. Bijvoorbeeld om aan te geven welke acties ondernomen moeten worden (u voert deze tekst zelf in bij het maken van de status).

## Standaardvervolgactiviteit voor een status

Wanneer de gebruiker het dialoogvenster status in SuperOffice CRM opent,kan deze ook een vervolgactiviteit voor de betreffende status maken. Het type vervolgactiviteit en de tekst kunnen vooraf worden gedefinieerd.

### Voorbeeld

Een status zou bijvoorbeeld van toepassing kunnen zijn op bedrijven die aan de volgende criteria voldoen:

* Categorie = Klant
* Laatste verkoop meer dan 2 maanden geleden
* Aantal verkopen groter dan 50

De tekst in het veld **Beschrijving** zou dan als volgt kunnen luiden:

"&lt;name&gt; was voorheen een goede klant, maar we hebben al 2 maanden niets aan hen verkocht. &lt;cont&gt; is de hoofdcontactpersoon voor deze klant en moet snel telefonisch (&lt;cpho&gt;) of per e-mail (&lt;mail&gt;) contact opnemen met de klant om de reden te achterhalen."

In dit voorbeeld worden de volgende sjabloonvariabelen gebruikt om de tekst aan het specifieke bedrijf aan te passen:

| Variabele | Beschrijving |
|---|---|
| naam | De naam van het bedrijf |
| cont | De naam van onze contactpersoon voor het bedrijf |
| cpho | Telefoonnummer van bedrijf |
| mail | E-mailadres van het bedrijf |

## Zoekbewerkingen en selecties

Statussen en tellers kunnen worden gebruikt in zoekbewerkingen en voor het maken van dynamische selecties. Zo kunt u bijvoorbeeld zoeken naar bedrijven, personen of projecten die voldoen aan criteria voor een status of teller.[!include[Define counter](../includes/def-counter.md)]

U kunt 3 verschillende tellers/periodes instellen, deze tellers zijn het aantal dagen dat u wilt tellen wat betreft activiteiten, verkopen en verzoeken. De verschillende periodes zijn ingesteld op wat voor u belangrijk is. U wilt bijvoorbeeld een melding ontvangen als een aantal van uw klanten de afgelopen maand (30 dagen) geen activiteiten hebben gehad of als er onopgeloste klantverzoeken zijn die ouder zijn dan 30 dagen.

## Perioden

U kunt maximaal drie verschillende perioden voor tellers opgeven zodat de SAINT-criteria kortere of langere perioden kunnen bestrijken. Als u drie perioden specificeert, van 30, 60 en 90 dagen, kunt u SAINT-criteria selecteren voor elk van deze perioden.

## Nieuwe statussen maken

Log eerst in op SuperOffice CRM, ga naar het hoofdmenu in de rechterbovenhoek en open Instellingen en onderhoud, klik op SAINT in de navigator. Daar kunt u uw Sales Intelligence en statuscontroles instellen.

Het maken van een status:

1. [Een nieuwe status maken][1]
1. [Een afbeelding selecteren voor een status][2]
1. [Een standaardtype vervolgactiviteit selecteren voor een status][3]
1. [Statuscriteria opgeven][4]
1. [Een periodeduur opgeven][5]

U kunt nu teruggaan naar SuperOffice CRM en een nieuwe dynamische selectie openen om alle personen te zien die u moet opvolgen.

Zorg ervoor dat u uw SAINT-criteria toevoegt. Klik op Toevoegen, klik vervolgens op naast het veld en kies Bedrijf – Tellers (SAINT). Zoek uw SAINT-statusmonitor. In ons voorbeeld kiezen we Verwaarloosde klanten en klikken we op OK. Ververs uw selectie en u weet precies welke klanten moeten worden opgevolgd.

## Statussen herstellen en bewerken

* [Een verwijderde status herstellen][6]
* [Een statusbeschrijving bewerken][7]

## Statuscontroles beheren en onderhouden

* [Statuscontroles beheren][8]

<!-- Referenced links -->
[1]: create-status.md
[2]: select-image-for-status.md
[3]: select-default-follow-up-type-for-status.md
[4]: select-status-criteria.md
[5]: select-period-length.md
[6]: restore-status.md
[7]: edit-status.md
[8]: manage-status-monitors.md

<!-- Referenced images -->
