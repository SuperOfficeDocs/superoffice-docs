---
uid: help-sv-role-set-data-rights
title: Ange databehörigheter för en roll
description: Ange databehörigheter för en roll
keywords: administrera användare, roll, åtkomst, behörigheter
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /sv/admin/user-management/learn/role/set-data-rights-for-role
tier: starter
language: sv
---

# Ange behörighet för roll

Du kan ange behörigheter för dataobjekt baserat på vem som äger objekten. Alla användare som tillhör den här [rollen][2] tilldelas behörigheter baserat på inställningarna du gör här.

## Steg

1. [!include[Open Roles](../includes/open-roles.md)]

1. Gå till fliken **Medarbetare**.

1. Markera önskad roll i listan **Roller**. Behörigheterna för den valda rollen visas på fliken **Databehörigheter**.

1. Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> bredvid den rättighet du vill ändra och välj önskad rättighet.

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

| **Data ägs av** | **Dashboard och dokument** | **Försäljning och aktiviteter** | **Projekt** | **Företag och kontakt** |
|---|---|---|---|---|
| Min egen | Skapad av dig | Ägarfält används | Ansvarlig-fält används | Du är "Vår kontakt" |
| Primärgrupp (M) | Skapad av din primärgrupp (avdelning) | Ägarfält används | Ansvarlig-fält används | "Vår kontakt" är en medarbetare i din primärgrupp |
| Andra grupper (M) | Skapad av en användargrupp som du tillhör | Ägarfält används | Ansvarlig-fält används | "Vår kontakt" är en medarbetare i en grupp du tillhör |
| Andra medarbetare | Skapad av andra medarbetare i företaget | Ägarfält används | Ansvarlig-fält används | "Vår kontakt" är en medarbetare som inte tillhör samma grupp som du |
| Anonym | Skapad av anonyma användare | Inte tillämpligt | Inte tillämpligt | Inte tillämpligt |

**M** = medarbetare

I kontaktkortet hämtas fältet **Vår kontakt** alltid från företagskortet som kontakten tillhör.

## Relaterat innhåll

* [Databehörigheter][3]
* [Onsite-databehörigheter][4]

<!-- Referenced links -->

[2]: index.md
[3]: functional-rights.md
[4]: https://help.superoffice.com/docs/11/sv/admin/user-management/role/set-data-rights-for-role.html
