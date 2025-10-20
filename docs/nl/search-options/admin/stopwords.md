---
uid: help-nl-stopwords
title: Stopwoorden
description: Stopwoorden
keywords: vrije tekst, zoeken, stopwoord
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: nl
redirect_from: /nl/admin/options/learn/freetext-search/stopwords
---

# Stopwoorden

Een stopwoord is een woord dat niet is geïndexeerd (niet opgenomen in een vrije-tekstzoekbewerking). Dit kunnen woorden zijn als *en*, *of*, *als* en *voor*. Wanneer u stopwoorden definieert, kost het minder tijd om de vrije-tekstindex te doorzoeken, omdat overbodige woorden worden uitgesloten. Bovendien wordt door de definitie van stopwoorden minder ruimte in de database gebruikt.

De woorden die zijn gedefinieerd als stopwoorden voor vrije-tekstzoekbewerkingen, worden weergegeven in de tabel **Lijst met stopwoorden** op het tabblad **Vrije-tekstzoekbewerking** in het scherm Opties.

## Voordat u begint

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Zorg er bij on-premises installaties voor dat de optie **Freetekst zoeken inschakelen** is geselecteerd. In CRM Online is deze optie altijd ingeschakeld.

> [!TIP]
> Als u wilt dat de wijzigingen wel een terugwerkende kracht hebben, moet u [de vrije-tekstindex opnieuw genereren][3]. Doe dit nadat u stopwoorden hebt toegevoegd, nadat het systeem stopwoorden heeft voorgesteld of nadat u een grote hoeveelheid tekst hebt geïmporteerd.

## Stopwoord toevoegen

1. Klik op de knop **Toevoegen** onder de lijst met stopwoorden.

1. Voer in het dialoogvenster **Nieuwe stopwoorden** de woorden in die u als stopwoord wilt opnemen. U kunt alle tekens gebruiken als scheidingsteken, behalve een punt.

1. Klik op **Opslaan**.

1. Er wordt een bericht weergegeven waarin wordt vermeld dat wijzigingen in de lijst met stopwoorden geen terugwerkende kracht hebben. Nieuwe stopwoorden gelden dus niet voor velden die waren geregistreerd voordat de stopwoorden werden gedefinieerd. Klik op **OK**.

## Stopwoorden voorstellen

U kunt stopwoorden laten voorstellen door het systeem, in plaats van dat u de stopwoorden handmatig invoert.

1. Klik op de knop **Voorstellen** onder de lijst met stopwoorden.

1. Vervolgens wordt het bericht weergegeven dat het enige tijd kan duren om in de woordenlijst en de index te zoeken naar mogelijke stopwoorden. Klik op **OK**.

1. Wanneer mogelijke stopwoorden zijn aangetroffen, worden deze weergegeven in het dialoogvenster **Nieuwe stopwoorden**. De woorden die in de database het meest voorkomen, staan bovenaan. Schakel de woorden in die u als stopwoord wilt opnemen. Houd de **CTRL**-toets ingedrukt en klik op de relevante stopwoorden.

1. Klik op **Opslaan**.

1. Vervolgens wordt het bericht weergegeven dat wijzigingen in de lijst met stopwoorden geen terugwerkende kracht hebben. Dit betekent dat nieuwe stopwoorden niet gelden voor velden die waren gemaakt voordat de stopwoorden zijn gedefinieerd. Klik op **OK**.

## Stopwoorden verwijderen

U verwijdert stopwoorden als u ze bij nader inzien toch wilt gebruiken voor vrije-tekstzoekbewerkingen. U verwijdert als volgt een stopwoord uit de lijst:

1. Selecteer het gewenste stopwoord.

1. Klik op de knop **Verwijderen** onder de lijst met stopwoorden.

<!-- Referenced links -->
[3]: regenerate-index.md

<!-- Referenced images -->
