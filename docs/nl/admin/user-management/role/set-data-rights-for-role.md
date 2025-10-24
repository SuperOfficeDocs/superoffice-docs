---
uid: help-nl-role-set-data-rights
title: Gegevensrechten voor rol instellen
description: Gegevensrechten voor rol instellen
keywords: gebruikersbeheer, rol, toegang, rechten
author: digitaldiina
date: 03.27.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /nl/admin/user-management/learn/role/set-data-rights-for-role
language: nl
---

# Gegevensrechten voor een rol instellen

[!include[Requirement](../includes/note-anon-req.md)]

U kunt rechten voor gegevensobjecten instellen op basis van wie de eigenaar van het object is. Aan alle gebruikers die tot deze [rol][2] behoren, worden rechten toegewezen op basis van de instellingen die u hier maakt.

## Stappen

1. [!include[Open Roles](../includes/open-roles.md)]

1. Kies het tabblad **Medewerkers** of het tabblad **Extern** (lokaal).

    [De rol voor anonieme gebruikers bewerken.][1]

1. Selecteer de betreffende rol in de lijst **Rollen**. De rechten voor de geselecteerde rol worden weergegeven op het tabblad **Gegevensrechten**.

1. Klik op <i class="ph ph-caret-down" aria-label="Chevron"></i> naast het recht dat u wilt wijzigen en selecteer het vereiste recht.

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

| **Eigenaar van gegevens** | **Dashboards en documenten** | **Verkoop en vervolgactiviteiten** | **Projecten** | **Bedrijf en persoon** |
|---|---|---|---|---|
| Gebruiker zelf | Gemaakt door uzelf | Veld *Eigenaar* is van toepassing | Veld *Verantwoordelijke* is van toepassing | U bent "Onze contactpersoon" |
| Primaire groep (A) | Gemaakt door uw primaire groep (afdeling) | Veld *Eigenaar* is van toepassing | Veld *Verantwoordelijke* is van toepassing | "Onze contactpersoon" is een medewerker van uw primaire groep |
| Mijn bedrijf (E)<br />alleen ONSITE | Gemaakt door het bedrijf van een externe gebruiker | Veld *Eigenaar* is van toepassing | Veld *Verantwoordelijke* is van toepassing | "Onze contactpersoon" is van toepassing |
| Andere groepen (A) | Gemaakt door een gebruikersgroep waartoe u behoort | Veld *Eigenaar* is van toepassing | Veld *Verantwoordelijke* is van toepassing | "Onze contactpersoon" is een medewerker in een groep waartoe u behoort |
| Hetzelfde project (E)<br />alleen ONSITE | Gemaakt binnen een project waar een externe gebruiker deel van uitmaakt | Veld *Eigenaar* is van toepassing | Veld *Verantwoordelijke* is van toepassing | "Onze contactpersoon" is van toepassing |
| Andere medewerkers | Gemaakt door andere medewerkers in het bedrijf | Veld *Eigenaar* is van toepassing | Veld *Verantwoordelijke* is van toepassing | "Onze contactpersoon" is een medewerker waarmee u geen groep deelt |
| Externe gebruiker | Gemaakt door externe gebruikers (Audience-gebruikers) | Veld *Eigenaar* is van toepassing | Veld *Verantwoordelijke* is van toepassing | "Onze contactpersoon" is van toepassing |
| Anoniem | Gemaakt door anonieme gebruikers | Niet van toepassing | Niet van toepassing | Niet van toepassing |

**A** = medewerkers, **E** = extern

Op de **contactkaart** wordt het veld **Onze contactpersoon** altijd opgehaald van de **bedrijfkaart** waartoe de contactpersoon behoort.

## Hoe kan ik gegevensobjecten voor externe gebruikers weergeven?

Als de gegevensobjecten (bedrijven, projecten, documenten enzovoort) toegankelijk moeten zijn voor externe gebruikers (Audience-gebruikers), is het niet voldoende leesrechten toe te wijzen aan de externe gebruikers. De gegevensobjecten moeten ook worden gepubliceerd in SuperOffice.

## Gerelateerde inhoud

* [Gegevensrechten][3]

<!-- Referenced links -->
[1]: ../onsite/other-users.md#rights
[2]: index.md
[3]: functional-rights.md
