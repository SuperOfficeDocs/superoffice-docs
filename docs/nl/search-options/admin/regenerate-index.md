---
uid: help-nl-free-text-index-regen
title: Een vrije-tekstindex genereren
description: Een vrije-tekstindex opnieuw genereren
keywords: vrije tekst, zoekindex
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: nl
deployment: onsite
redirect_from: /nl/admin/options/learn/freetext-search/regenerate-index
---

# Een vrije-tekstindex genereren (lokaal)

> [!NOTE]
> Dit tabblad is alleen beschikbaar als uw SuperOffice-installatie op locatie is. Als u de online-oplossing gebruikt, kunt u deze instellingen niet wijzigen. Voor SuperOffice Online wordt de vrije-tekstindex standaard elke 7 dagen opnieuw gegenereerd.
>
> Als u een vrije-tekstindex opnieuw wilt kunnen genereren, moet u een rol op **gebruikersniveau 0** hebben (of equivalent). In Oracle-databases kan alleen de eigenaar van de database een vrije-tekstindex opnieuw genereren.

Wanneer u [nieuwe stopwoorden toevoegt of verwijdert][1], hebben uw wijzigingen geen terugwerkende kracht. Dat betekent bijvoorbeeld dat als u *en* hebt geregistreerd als een stopwoord terwijl *en* al op meerdere posities voorkomt in de database, deze posities niet automatisch worden verwijderd uit de vrije-tekstindex. De wijziging geldt alleen voor de treffers met *en* die u vanaf dat moment toevoegt. In sommige gevallen kan het dan ook beter zijn de vrije-tekstindex bij te werken zodat alle stopwoorden eruit worden verwijderd.

## Het opnieuw genereren van een vrije-tekstindex

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Zorg ervoor dat de optie **Zoeken op vrije tekst inschakelen** is geselecteerd.

1. Klik op de knop **Index opnieuw genereren**.

1. Vervolgens wordt het bericht weergegeven dat het enige tijd kan duren om de index opnieuw te genereren en dat gebruikers in die tijd geen toegang hebben tot de functie voor zoeken aan de hand van vrije tekst. Klik op **OK**. Er wordt een venster geopend waarin wordt aangegeven hoever het regenereerproces gevorderd is. Wanneer dit venster weer wordt gesloten, is de nieuwe vrije-tekstindex klaar.

<!-- Referenced links -->
[1]: stopwords.md

<!-- Referenced images -->
