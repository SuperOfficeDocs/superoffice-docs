---
uid: help-sv-role-set-data-rights
title: Ange databehörigheter för en roll
description: Ange databehörigheter för en roll
keywords: administrera användare, roll, åtkomst, behörigheter
author: Bergfrid Dias
date: 03.27.2025
version: 10.5
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
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

4. Klicka på <i class="ph ph-caret-down" aria-label="Chevron"></i> bredvid den rättighet du vill ändra och välj önskad rättighet.

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
| Mitt företag (E)<br />Endast ONSITE | Skapad av en extern användares företag | Ägarfält används | Ansvarlig-fält används | "Vår kontakt" används |
| Andra grupper (M) | Skapad av en användargrupp som du tillhör | Ägarfält används | Ansvarlig-fält används | "Vår kontakt" är en medarbetare i en grupp du tillhör |
| Samma projekt (E)<br />Endast ONSITE | Skapad i ett projekt som en extern användare tillhör | Ägarfält används | Ansvarlig-fält används | "Vår kontakt" används |
| Andra medarbetare | Skapad av andra medarbetare i företaget | Ägarfält används | Ansvarlig-fält används | "Vår kontakt" är en medarbetare som inte tillhör samma grupp som du |
| Extern användare | Skapad av externa användare (Audience-användare) | Ägarfält används | Ansvarlig-fält används | "Vår kontakt" används |
| Anonym | Skapad av anonyma användare | Inte tillämpligt | Inte tillämpligt | Inte tillämpligt |

**M** = medarbetare, **E** = extern

I kontaktkortet hämtas fältet **Vår kontakt** alltid från företagskortet som kontakten tillhör.

## Hur visar jag dataobjekt för externa användare?

Om dataobjekten (företag, projekt, dokument etc.) ska vara tillgängliga för externa användare (Audience-användare) räcker det inte att bara tilldela läsbehörighet (eller högre) till externa användare. Dataobjekten måste också publiceras i SuperOffice.

## Relaterat

* [Databehörigheter][3]

<!-- Referenced links -->
[1]: edit-rights-for-anonymous-users.md
[2]: index.md
[3]: functional-rights.md
