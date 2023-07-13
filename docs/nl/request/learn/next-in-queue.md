---
uid: help-nl-request-next-in-queue
title: Volgend verzoek in de wachtrij ophalen
description: Volgend verzoek in de wachtrij ophalen
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: verzoek
so.topic: howto
so.audience: person
so.audience.tooltip: SuperOffice Service
language: nl
---

# Hoe 'Volgende verzoek in wachtrij ophalen' kunt instellen

In SuperOffice Service worden verzoeken normaal gesproken toegewezen aan gebruikers volgens een toewijzingsmethode. Een andere methode om verzoeken toe te wijzen aan verzoekbehandelaars, is de plaatsing van nieuwe verzoeken in **Verzoeken**> **Niet-toegewezen verzoeken**. De verzoekbehandelaars moeten de verzoeken vervolgens handmatig accepteren.

Het is echter ook mogelijk om een intelligent wachtrijsysteem te maken voor de afhandeling van nieuwe verzoeken. Verzoekbehandelaars kunnen vervolgens klikken op **Volgend verzoek in wachtrij ophalen** onder **Verzoeken** om het volgende verzoek in de wachtrij te accepteren. Verzoeken in de wachtrij worden gefilterd per [categorie][2], zodat gebruikers alleen verzoeken toegewezen krijgen die behoren tot de categorieën waar zij lid van zijn.

## Hoe krijgen de verzoeken in de wachtrij prioriteit?

De volgorde van de verzoeken in de wachtrij wordt bepaald door de deadline voor elk verzoek. De verzoeken met de dichtstbijzijnde deadlines komen eerst in de wachtrij. De deadline wordt berekend op basis van de prioriteiten die gedefinieerd waren voor persoon, bedrijf, postbus, e-mailfilter en de standaardprioriteit.

Dit zorgt ervoor dat de verzoeken op een logische en eerlijke manier een prioriteit krijgen.

> [!NOTE]
> Het is ook mogelijk een combinatie van wachtrijsysteem en toewijzingsmethode te gebruiken. Verzoeken kunnen bijvoorbeeld in de wachtrij worden geplaatst of worden toegewezen aan gebruikers op basis van de categorie waartoe de verzoeken behoren.

## Welke verzoeken kunnen worden opgehaald uit de wachtrij?

De volgende factoren bepalen welke verzoeken een verzoekbehandelaar uit de wachtrij krijgt:

* De verzoeken moeten een verzoekstatus **Wachtrijstatus** geactiveerd hebben.
* De verzoeken moeten een categorie hebben waarvan de verzoekbehandelaar lid is.
* De verzoekeigenaar moet **Niet-toegewezen** zijn.

## Maak een nieuwe verzoekstatus 'In wachtrij' aan

We maken eerst een nieuwe verzoekstatus: **In wachtrij**. Aan nieuwe verzoeken wordt automatisch deze verzoekstatus toegewezen.

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Selecteer **Verzoeken** > **Verzoekstatus**.

1. Klik op de knop **Toevoegen**.

1. Voer in het veld **Naam** een herkenbare naam in voor de verzoekstatus. Bijvoorbeeld 'In wachtrij'.

1. In het lijstvak **Interne status** selecteert u **Open**.

1. Selecteer **Standaard**, zodat alle nieuwe verzoeken (actieve verzoeken) standaard deze status krijgen.

1. Selecteer **Wachtrijstatus**. De gebruikers kunnen nu verzoeken met deze status van de wachtrij te krijgen.

    > [!NOTE]
    > Dit betekent niet dat deze verzoeken MOETEN worden opgehaald uit de wachtrij. We maken gebruik van categorieën om te beslissen welke verzoeken in de wachtrij worden geplaatst en welke verzoeken worden verdeeld volgens de toewijzingsmethode voor de categorie.

1. U hoeft **Nieuw verzoek maken na antwoord klant** niet te selecteren.

1. In de lijst **Tijd traceren als** selecteert u **In wachtrij**.

1. Klik op **Opslaan**.

De nieuwe verzoekstatus wordt weergegeven in de lijst en er staat een vinkje in de kolommen **Standaard** en **Wachtrijstatus**.

## Gebruik categorieën om verzoeken in de wachtrij te plaatsen

Nu moet u ervoor zorgen dat u een lid van de categorie of categorieën bent die u gaat beheren. Verzoeken die tot deze categorieën behoren, moeten niet worden toegewezen volgens de toewijzingsmethode.

> [!NOTE]
> Het lidmaatschap in categorieën kan ook worden gedefinieerd op groepsniveau. In Instellingen en onderhoud (**Gebruikers** > **Gebruikersgroepen** kunt u categorieën voor de verschillende gebruikersgroepen vermelden.

**Stappen:**

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Selecteer **Verzoeken** > **Categorieën**.

1. Klik op de gewenste categorienaam. Het scherm **Categorie-eigenschappen** wordt geopend.

1. Selecteer het tabblad **Leden**.

1. Selecteer uzelf in de lijst **Gebruiker** en klik op ![pictogram][img1] om uzelf als een lid van de categorie toe te voegen.

1. Voeg eventueel andere gebruikers als leden van deze categorie toe.

1. Selecteer het tabblad **Toewijzingsmethode** en selecteer **Niet toewijzen**. Nieuwe verzoeken in deze categorie worden niet aan de gebruikers toegewezen volgens de toewijzingsmethode.

1. Klik op **Opslaan**.

Indien nodig herhaalt u deze procedure voor andere categorieën die uit de wachtrij opgehaald moeten worden. Er wordt een gebruiker toegewezen aan categorieën die een toewijzingsmethode volgen en daarom komen deze niet in de wachtrij.

## Nieuwe status definiëren voor verzoeken die opgehaald worden uit de wachtrij

Wanneer u een verzoek uit de wachtrij hebt gehaald, moet de status veranderd worden van **In wachtrij** naar **Open** (of een andere actieve status die aangeeft dat het verzoek wordt verwerkt). Dit wordt normaal gezien automatisch afgehandeld.

## Controleer of de wachtrij werkt

Maak een nieuw verzoek, stel de **Eigenaar** in op **Niet-toegewezen**, selecteer de categorie waarvan u lid bent en stel **Status** in op **In wachtrij**. Probeer vervolgens te klikken op **Verzoeken** > **Volgend verzoek in wachtrij ophalen**.

<!-- Referenced links -->
[2]: category/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-add.png
