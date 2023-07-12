---
uid: help-sv-role-set-data-rights
title: Ange databehörigheter för en roll
description: Ange databehörigheter för en roll
author: Bergfrid Dias
so.date: 03.15.2023
keywords: administrera användare, roll, åtkomst, behörigheter
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Ange behörighet för roll

[!include[Requirement](../includes/note-anon-req.md)]

Du kan ange behörigheter för [dataobjekt][2] baserat på vem som äger objekten. Alla användare som tillhör den här [rollen][2] tilldelas behörigheter baserat på inställningarna du gör här.

## Steg

1. [!include[Open Roles](includes/open-roles.md)]

2. Gå till fliken **Medarbetare** eller **Externa** (lokalt).

    [Så redigerar du rollen för anonyma användare.][1]

3. Markera önskad roll i listan **Roller**. Behörigheterna för den valda rollen visas på fliken **Databehörigheter**.

4. Klicka på ![ikon][img3] pilen bredvid den rättighet du vill ändra och välj önskad rättighet.

    | Namn | Behörighet | Inforuta |
    |---|---|---|
    | Ingen | Inga behörigheter | |
    | Läsa | Läsbehörigheter | L |
    | Skapa | Behörighet att läsa och skapa | SL |
    | Uppdatera | Behörighet att läsa, skapa och uppdatera | SLU |
    | Radera | Behörighet att läsa, skapa, uppdatera och ta bort | SLUT |

    **S** = skapa, **L** = läsa, **U** = uppdatera, **T** = ta bort

    Ändringarna sparas automatiskt.

## Vad betyder de olika kolumnerna under Data ägs av?

| Data ägs av | Förklaring|
|---|---|
| Min egen | Skapad av dig |
| Primärgrupp (M) | Skapad av din primärgrupp (avdelning) |
| Mitt företag (E) | Skapad av en extern användares företag |
| Andra grupper (M) | Skapad av en användargrupp som du tillhör |
| Samma projekt (E) | Skapad i ett projekt som en extern användare tillhör |
| Andra medarbetare | Skapad av andra medarbetare på företaget |
| Extern användare | Skapad av externa användare (Audience-användare) |
| Anonym | Skapad av anonyma användare |

* M = medarbetare
* E = externa

## Hur visar jag dataobjekt för externa användare?

Om dataobjekten (företag, projekt, dokument etc.) ska vara tillgängliga för externa användare (Audience-användare) räcker det inte att bara tilldela läsbehörighet (eller högre) till externa användare. Dataobjekten måste också publiceras i SuperOffice.

## Behörighet till rapporter

Alla SuperOffice CRM-användare har åtkomst till fönstret Rapporter, men vilka rapporter du kommer åt beror på vilka behörigheter du har (roll) med avseende på händelser, dokument, försäljning och aktivitetslistan. I praktiken innebär det att du inte kan skapa rapporter för innehåll som du inte har behörighet att se.

<!-- Referenced links -->
[1]: edit-rights-for-anonymous-users.md
[2]: index.md

<!-- Referenced images -->
[img3]: ../../../../../media/icons/arrow-down.png
