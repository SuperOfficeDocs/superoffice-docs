---
uid: help-nl-request-assign
title: Toewijzingsmethoden
description: Toewijzingsmethoden voor verzoeken
author: Hanne Gunnarsson
so.date: 02.14.2023
keywords: verzoek
so.topic: concept
so.user: user
so.user.tooltip: SuperOffice Service
language: nl
---

# Automatische toewijzingsmethoden voor verzoeken

Een verzoek is uw verantwoordelijkheid zodra uw naam staat in het veld **Eigenaar** van het verzoek. Dit kan handmatig worden ingesteld, bijvoorbeeld wanneer het [verzoek wordt gemaakt][2]. Het kan ook het resultaat zijn van automatische toewijzing van verzoeken. Een dergelijke toewijzing hangt of van de categorie waartoe het verzoek behoort en de gespecificeerde toewijzingsmethode voor die categorie.

## Toewijzingsmethoden

| Methode | Beschrijving |
|---|---|
| Evenredige toewijzing | verzoeken worden evenredig verdeeld over alle leden van de categorie. |
| Gewogen toewijzing | verzoeken worden toegewezen op basis van het [gewicht][3] dat is toegekend aan leden van de categorie. |
| Aan gebruiker met minste aantal openstaande verzoeken | nieuwe verzoeken worden toegewezen aan het lid van de categorie met het minste aantal openstaande verzoeken. |
| Niet toewijzen | de verzoeken worden niet toegewezen aan specifieke verzoekbehandelaars, maar worden als **Niet-toegewezen** in een wachtrij geplaatst. |

[!include[Get next request in queue](includes/howto-get-next-request.md)]

### Toewijzingsmethode voor categorie opgeven

Een verzoekbehandelaar met rechten voor categoriebeheer kan de toewijzingsmethode voor categorieën opgeven:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Selecteer **Verzoeken** &gt; **Categorieën**.
1. Selecteer de gewenste categorie.
1. Selecteer het tabblad **Toewijzingsmethode**.
1. Selecteer de gewenste opties.
1. Klik op **OK**.

## Voorbeeld

Stel dat uw bedrijf een categorie heeft gemaakt voor elke afdeling binnen het bedrijf: Gebruikersondersteuning, Verkoop, Accounts en dergelijke. U hebt tevens aangegeven dat alle e-mailberichten die naar <support@company.com> worden verzonden, automatisch moeten worden toegewezen aan de categorie "Gebruikersondersteuning". Alle medewerkers van de afdeling Gebruikersondersteuning zijn leden van deze categorie. De methode **Evenredige toewijzing** is ingesteld voor deze categorie. Dit betekent dat aan alle leden van de categorie hetzelfde aantal verzoeken wordt toegewezen en dat elk lid continu nieuwe verzoeken zal ontvangen in het scherm **Eigen openstaande verzoeken**. Als men de methode **Niet toewijzen** had geselecteerd, zouden de leden zelf het scherm **Niet-toegewezen verzoeken** moeten openen om [eigenaar te worden van nieuwe verzoeken][4].

## Wat wilt u nu doen?

* [Een verzoek verwerken][1]
* [Een verzoek maken][2]
* [Een verzoek accepteren][4]
* [Andere verzoekbehandelaar om hulp vragen (overbrengen)][5]

<!-- Referenced links -->
[1]: ../index.md
[2]: create.md
[3]: ../category/create.md
[4]: accept.md
[5]: transfer.md

<!-- Referenced images -->
