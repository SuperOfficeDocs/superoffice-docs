---
uid: help-da-add-company-category
title: Firma kategori og kategorigruppe
description: Opret eller opdater firmakategorier, tildel kategorigrupper, og aktivér sporing af leadstatus.
keywords: firmakategori, kategorigruppe, leadstatus, potentiel kunde, lister
author: digitaldiina
date: 12.11.2025
version: 11.6
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
index: true
language: da
---

# Firma kategori og kategorigruppe

[!include[Skal være administrator](../../learn/includes/req-admin.md)]

Listen **Firma – Kategori** definerer typerne af firmaer i databasen, såsom *Kunde*, *Partner* eller *Lead*.
Hver kategori kan tilhøre en **Kategorigruppe**, som bestemmer hvordan den opfører sig i søgninger, automatiseringer og lead-håndtering.

Du administrerer firmakategorier under **Indstillinger og vedligeholdelse** under **Lister** > **Firma – Kategori**.

## Om kategorigrupper

Kategorigrupper giver en måde at klassificere kategorier efter formål og forhindre uønskede automatiseringsændringer. For eksempel skal et firma markeret som *Kunde* aldrig automatisk gå tilbage til en *Lead* på grund af en formular­indsendelse.

| Kategorigruppe | Beskrivelse |
|---|---|
| Kunde | Bruges for eksisterende kunder, som *Kunde A*, *Kunde B* eller *VIP-kunde*. |
| Tabt | Bruges for tidligere kunder eller tabte muligheder. |
| Partner | Bruges for forhandlere, integratorer eller forretningspartnere. |
| Potentiel kunde | Bruges for leads eller potentielle som endnu ikke er kunder. Kun denne gruppe kan have **Lead-status** aktiveret. |
| Andet | Bruges for enhver anden type firma. |

## Tilføj en firmakategori

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i Navigatoren.

1. Fra dropdown-menuen vælger du **Firma – Kategori**. Fanen **Elementer** viser alle eksisterende kategorier.

1. Klik **Tilføj** for at åbne dialogen **Rediger listeelement**.

1. Indtast et navn for kategorien i feltet **Navn**. *(Obligatorisk)*

    Dette navn vises i feltet **Kategori** på firmasiden.

1. Fra dropdown-menuen **Kategorigruppe** vælger du den passende gruppe.

    Gruppen bestemmer, hvordan kategorien opfører sig i søgninger og automatiseringer, men er ikke synlig for slutbrugere.

    * For at aktivere leadstatus senere vælger du **Potentiel kunde**.

1. *(Valgfrit)* Indtast en beskrivelse for at præcisere, hvordan kategorien skal anvendes.

1. *(Valgfrit)* Vælg **Aktivér lead-status for denne kategori**, hvis relevant.

1. Klik **OK** for at gemme den nye kategori eller **Annullér** for at kassere ændringerne.

![Redigering af en firmakategori i listen Firma – Kategori, der viser gruppen Potentiel kunde valgt og muligheden for at aktivere leadstatus for kategorien. -screenshot][img1]

## Rediger eller slet firmakategorier

> [!NOTE]
> Redigering eller sletning af kategorier, der er i brug, kan føre til inkonistente data.
> Ændring af kategorigruppe eller deaktivering af lead-status kan efterlade firmaer og kontakter med leadinformation, som ikke længere kan opdateres.
> Gennemgå brugen af kategorien grundigt, før du foretager ændringer.

1. Åbn listen **Firma – Kategori**.

1. For at redigere:

    1. Dobbeltklik en kategori for at åbne den.
    1. Opdater **Navn**, **Kategorigruppe** eller indstillingen **Lead-status**.
    1. Klik **OK** for at gemme.

1. For at slette:

    1. Vælg kategorien i listen.
    1. Klik **Slet**.

## Gendan slettede firmakategorier

1. Åbn listen **Firma – Kategori**.

1. Vælg **Vis slettede elementer og overskrifter**.

1. Find den slettede kategori, dobbeltklik den, og klik **Gendan**.

1. Klik **OK**.

## Relateret indhold

* [Potentielle kundekategorier][2]
* [Aktivér lead-status for firmakategorier][1]
* [Administrér lead-statuser][3]
* [Brugergruppefiltrering][4]

<!-- Referenced links -->
[1]: index.md
[2]: ../learn/index.md
[3]: add-lead-status.md
[4]: ../../admin/lists/user-group-filtering.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/add-company-category.png
