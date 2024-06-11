---
uid: help-nl-request-assign
title: Toewijzingsmethoden
description: Toewijzingsmethoden voor verzoeken
keywords: verzoek
author: Hanne Gunnarsson, Christian Mogensen, Bergfrid Dias
so.date: 06.11.2024
so.version: 10
language: nl
so.topic: concept
so.audience: person
so.audience.tooltip: SuperOffice Service
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

Laten we deze toewijzingsmethoden illustreren met drie gebruikers en drie inkomende verzoeken.

![Request assignment methods -screenshot][img1]

### Evenredige

Wijst verzoeken gelijkmatig toe aan de leden van de categorie in een rondraaiende volgorde.

![Request assignment methods, even -screenshot][img2]

### Gewogen

Wijst verzoeken toe op basis van gespecificeerde wegingen voor elk lid van de categorie. Als lid A bijvoorbeeld een weging van 1 heeft, lid B een weging van 2 en lid C een weging van 5, worden ze over 8 verzoeken proportioneel toegewezen.

Verzoeken worden probabilistisch toegewezen op basis van hun wegingen.

![Request assignment methods, weighted][img3]

| Verzoek | Willekeurige waarde | Toegewezen aan |
|---|:-:|---|
| Eerste verzoek | 7 | Lid C |
| Tweede verzoek | 2 | Lid B |
| Derde verzoek | 5 | Lid C |

![Request assignment methods, weighted -screenshot][img4]

### Aan gebruiker met minste aantal openstaande verzoeken

Wijst nieuwe verzoeken toe aan het lid met de minste actieve verzoeken.

| Verzoek | Voorwaarde | Toegewezen aan |
|---|---|---|
| Eerste verzoek | Leden B en C hebben de minste verzoeken | Lid C |
| Tweede verzoek | Lid B heeft de minste verzoeken | Lid B |
| Derde verzoek | Alle leden hebben hetzelfde aantal verzoeken | Lid B |

![Request assignment methods, user with fewest open requests -screenshot][img5]

### Niet toewijzen

Wijst geen verzoeken toe aan specifieke leden. Alle verzoeken worden standaard in een wachtrij geplaatst.

![Request assignment methods, do not assign -screenshot][img6]

[!include[Get next request in queue](includes/howto-get-next-request.md)]

## Toewijzingsmethode voor categorie opgeven

Een verzoekbehandelaar met rechten voor categoriebeheer kan de toewijzingsmethode voor categorieën opgeven:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Selecteer **Verzoeken** > **Categorieën**.
1. Selecteer de gewenste categorie.
1. Selecteer het tabblad **Toewijzingsmethode**.
1. Selecteer de gewenste opties.
1. Klik op **OK**.

## Voorbeeld

<!-- markdownlint-disable-next-line MD034 -->
Stel dat uw bedrijf een categorie heeft gemaakt voor elke afdeling binnen het bedrijf: Gebruikersondersteuning, Verkoop, Accounts en dergelijke. U hebt tevens aangegeven dat alle e-mailberichten die naar support@company.com worden verzonden, automatisch moeten worden toegewezen aan de categorie "Gebruikersondersteuning". Alle medewerkers van de afdeling Gebruikersondersteuning zijn leden van deze categorie. De methode **Evenredige toewijzing** is ingesteld voor deze categorie. Dit betekent dat aan alle leden van de categorie hetzelfde aantal verzoeken wordt toegewezen en dat elk lid continu nieuwe verzoeken zal ontvangen in het scherm **Eigen openstaande verzoeken**. Als men de methode **Niet toewijzen** had geselecteerd, zouden de leden zelf het scherm **Niet-toegewezen verzoeken** moeten openen om [eigenaar te worden van nieuwe verzoeken][4].

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
[img1]: ../../../../media/loc/en/request/assign-requests.png
[img2]: ../../../../media/loc/en/request/assign-requests-even.png
[img3]: ../../../../media/loc/en/request/assign-requests-weighted-diagram.png
[img4]: ../../../../media/loc/en/request/assign-requests-weighted.png
[img5]: ../../../../media/loc/en/request/assign-requests-fewest.png
[img6]: ../../../../media/loc/en/request/assign-requests-not.png
