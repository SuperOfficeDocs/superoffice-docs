---
uid: help-nl-role-set-data-rights
title: Gegevensrechten voor rol instellen
description: Gegevensrechten voor rol instellen
keywords: gebruikersbeheer, rol, toegang, rechten
author: Bergfrid Dias
date: 12.10.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Gegevensrechten voor een rol instellen

[!include[Requirement](../includes/note-anon-req.md)]

U kunt rechten voor [gegevensobjecten][2] instellen op basis van wie de eigenaar van het object is. Aan alle gebruikers die tot deze [rol][2] behoren, worden rechten toegewezen op basis van de instellingen die u hier maakt.

## Stappen

1. [!include[Open Roles](includes/open-roles.md)]

2. Kies het tabblad **Medewerkers** of het tabblad **Extern** (lokaal).

    [De rol voor anonieme gebruikers bewerken.][1]

3. Selecteer de betreffende rol in de lijst **Rollen**. De rechten voor de geselecteerde rol worden weergegeven op het tabblad **Gegevensrechten**.

4. Klik op de ![pictogram][img3] pijl naast het recht dat u wilt wijzigen en selecteer het vereiste recht.

    | Naam | Rechten | Knopinfo |
    |---|---|---|
    | Geen | Geen rechten | |
    | Lezen | Leesrechten | R |
    | Maken | Lees- en maakrechten | ML |
    | Bijwerken | Lees-, maak- en bijwerkrechten | MLB |
    | Verwijderen | Lees-, maak-, bijwerk- en verwijderrechten | MLBV |

    **M** = Maken, **L** = Lezen, **B** = Bijwerken, **V** = Verwijderen

    De wijzigingen worden automatisch opgeslagen.

## Wat betekenen de verschillende kolommen onder Eigenaar van gegevens?

| Eigenaar van gegevens | Uitleg|
|---|---|
| Gebruiker zelf | Gemaakt door u zelf |
| Primaire groep (A) | Gemaakt door uw primaire groep (afdeling) |
| Mijn bedrijf (E) | Gemaakt door het bedrijf van een externe gebruiker |
| Andere groepen (A) | Gemaakt door een gebruikersgroep waartoe u behoort |
| Hetzelfde project (E) | Gemaakt binnen een project waartoe een externe gebruiker behoort |
| Andere medewerkers | Gemaakt door andere medewerkers binnen het bedrijf |
| Externe gebruiker | Gemaakt door externe gebruikers (Audience-gebruikers) |
| Anoniem | Gemaakt door anonieme gebruikers |

* A = Medewerkers
* E = Extern

## Hoe kan ik gegevensobjecten voor externe gebruikers weergeven?

Als de gegevensobjecten (bedrijven, projecten, documenten enzovoort) toegankelijk moeten zijn voor externe gebruikers (Audience-gebruikers), is het niet voldoende leesrechten toe te wijzen aan de externe gebruikers. De gegevensobjecten moeten ook worden gepubliceerd in SuperOffice.

## Aanvervandt

* [Gegevensrechten][3]

<!-- Referenced links -->
[1]: edit-rights-for-anonymous-users.md
[2]: index.md
[3]: functional-rights.md

<!-- Referenced images -->
[img3]: ../../../../../media/icons/arrow-down.png
