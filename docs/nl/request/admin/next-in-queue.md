---
uid: help-nl-request-next-in-queue
title: Volgend verzoek in de wachtrij ophalen
description: Volgend verzoek in de wachtrij ophalen
keywords: verzoek, wachtrij, volgende verzoek
author: Hanne Gunnarsson
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice Service
language: nl
redirect_from: /nl/request/learn/next-in-queue
index: true
---

# Hoe 'Volgende verzoek in wachtrij ophalen' instellen

In SuperOffice Service worden verzoeken normaal gesproken toegewezen aan gebruikers volgens een toewijzingsmethode. Een andere methode is om nieuwe verzoeken te plaatsen in **Verzoeken** > **Niet-toegewezen verzoeken**. De verzoekbehandelaars moeten deze verzoeken dan handmatig accepteren.

Het is echter ook mogelijk om een intelligent wachtrijsysteem te maken voor de afhandeling van nieuwe verzoeken. Verzoekbehandelaars kunnen dan klikken op **Volgend verzoek in wachtrij ophalen** onder **Verzoeken** om het volgende verzoek in de wachtrij te accepteren. Verzoeken in de wachtrij worden gefilterd per [categorie][2], zodat gebruikers alleen verzoeken toegewezen krijgen die behoren tot de categorieën waarvan zij lid zijn.

## Hoe krijgen de verzoeken in de wachtrij prioriteit?

De volgorde van de verzoeken in de wachtrij wordt bepaald door de deadline voor elk verzoek. De verzoeken met de dichtstbijzijnde deadlines komen als eerste in de wachtrij. De deadline wordt berekend op basis van de prioriteiten die zijn gedefinieerd voor de persoon, het bedrijf, de postbus, het e-mailfilter en de standaardprioriteit.

Dit zorgt ervoor dat verzoeken op een logische en eerlijke manier worden geprioriteerd.

> [!NOTE]
> Het is ook mogelijk een combinatie van wachtrijsysteem en toewijzingsmethode te gebruiken. Verzoeken kunnen bijvoorbeeld in de wachtrij worden geplaatst of worden toegewezen aan gebruikers op basis van de categorie waartoe de verzoeken behoren.

## Welke verzoeken kunnen worden opgehaald uit de wachtrij?

De volgende factoren bepalen welke verzoeken een verzoekbehandelaar uit de wachtrij kan ophalen:

* De verzoeken moeten een verzoekstatus hebben met **Wachtrijstatus** ingeschakeld.
* De verzoeken moeten een categorie hebben waarvan de verzoekbehandelaar lid is.
* De verzoekeigenaar moet **Niet-toegewezen** zijn.

## Nieuwe verzoekstatus 'In wachtrij' aanmaken

Eerst maken we een nieuwe verzoekstatus: **In wachtrij**. Nieuwe verzoeken moeten automatisch deze verzoekstatus krijgen.

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Selecteer **Verzoeken** > **Verzoekstatus**.

1. Klik op de knop **Toevoegen**.

1. Voer in het veld **Naam** een herkenbare naam in voor de verzoekstatus. Bijvoorbeeld 'In wachtrij'.

1. Selecteer in de lijst **Interne status** de optie **Open**.

1. Selecteer **Standaard**, zodat alle nieuwe verzoeken (actieve verzoeken) standaard deze status krijgen.

1. Selecteer **Wachtrijstatus**. De gebruikers kunnen nu verzoeken met deze status van de wachtrij te krijgen.

    > [!NOTE]
    > Dit betekent niet dat deze verzoeken MOETEN worden opgehaald uit de wachtrij. We maken gebruik van categorieën om te beslissen welke verzoeken in de wachtrij worden geplaatst en welke verzoeken worden verdeeld volgens de toewijzingsmethode voor de categorie.

1. **Nieuw verzoek maken na antwoord klant** hoeft niet geselecteerd te worden.

1. Selecteer in de lijst **Tijd traceren als** de optie **In wachtrij**.

1. Klik op **Opslaan**.

De nieuwe verzoekstatus wordt weergegeven in de lijst en er staat een vinkje in de kolommen **Standaard** en **Wachtrijstatus**.

## Categorieën gebruiken om verzoeken in de wachtrij te plaatsen

Nu moet u ervoor zorgen dat u lid bent van de categorie of categorieën die u gaat beheren. Daarnaast moet worden ingesteld dat verzoeken in deze categorieën niet worden toegewezen volgens de toewijzingsmethode.

> [!NOTE]
> Lidmaatschap in categorieën kan ook worden ingesteld op groepsniveau. In **Instellingen en onderhoud** (**Gebruikers** > **Gebruikersgroepen**) kunt u categorieën koppelen aan verschillende gebruikersgroepen.

**Stappen:**

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Selecteer **Verzoeken** > **Categorieën**.

1. Klik op de naam van de gewenste categorie. Het scherm **Categorie-eigenschappen** wordt geopend.

1. Ga naar het tabblad **Leden**.

1. Selecteer uzelf in de lijst **Gebruiker** en klik op **+** om uzelf als lid van de categorie toe te voegen.

1. Voeg indien nodig andere gebruikers toe als leden van deze categorie.

1. Ga naar het tabblad **Toewijzingsmethode** en selecteer **Niet toewijzen**. Hierdoor worden verzoeken in deze categorie niet toegewezen via de toewijzingsmethode.

1. Klik op **Opslaan**.

Indien nodig herhaalt u deze procedure voor andere categorieën waarvan de verzoeken uit de wachtrij opgehaald moeten worden. Categorieën die een toewijzingsmethode volgen, krijgen automatisch een gebruiker toegewezen en komen dus niet in de wachtrij terecht.

## Nieuwe status instellen voor verzoeken die uit de wachtrij worden gehaald

Wanneer u een verzoek uit de wachtrij hebt gehaald, moet de status veranderd worden van **In wachtrij** naar **Open** (of een andere actieve status die aangeeft dat het verzoek wordt verwerkt). Dit wordt normaal gezien automatisch afgehandeld.

## Controleer of de wachtrij werkt

Maak een nieuw verzoek aan, stel de **Eigenaar** in op **Niet-toegewezen**, selecteer de categorie waarvan u lid bent en stel de **Status** in op **In wachtrij**. Probeer vervolgens te klikken op **Verzoeken** > **Volgend verzoek in wachtrij ophalen**.

<!-- Referenced links -->
[2]: category/index.md
