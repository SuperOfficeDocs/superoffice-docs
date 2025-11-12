---
uid: help-da-add-company-category
title: Firma kategori og kategorigruppe
description: Opret eller opdater firmakategorier, tildel kategorigrupper, og aktivér sporing af leadstatus.
keywords: firmakategori, kategorigruppe, leadstatus, potentiel kunde, lister
author: digitaldiina
date: 11.12.2025
version: 10.6
topic: howto
license: salesessentials
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
index: true
language: da
---

# Firma kategori og kategorigruppe

[!include[Skal være administrator](../../learn/includes/req-admin.md)]

Listen **Firma – Kategori** definerede typerne af firmaer i databasen, såsom *Kunde*, *Partner* eller *Lead*.
Hver kategori havde en **Kategorigruppe**, som bestemte hvordan den opførte sig i søgninger, automatiseringer og lead-håndtering.

Du administrerede firmakategorier under **Indstillinger og vedligeholdelse** under **Lister** > **Firma – Kategori**.

## Om kategorigrupper

Kategorigrupper gav en måde at klassificere kategorier efter formål og forhindre uønskede automatiseringsændringer. For eksempel skulle et firma markeret som *Kunde* aldrig automatisk gå tilbage til en *Lead* på grund af en formular­indsendelse.

| Kategorigruppe | Beskrivelse |
|---|---|
| Kunde | Bruges for eksisterende kunder, som *Kunde A*, *Kunde B* eller *VIP-kunde*. |
| Tabt | Bruges for tidligere kunder eller tabte muligheder. |
| Andet | Bruges for enhver anden type firma. |
| Partner | Bruges for forhandlere, integratorer eller forretningspartnere. |
| Potentiel kunde | Bruges for leads eller potentielle som endnu ikke er kunder. Kun denne gruppe kan have **Lead-status** aktiveret. |

## Tilføj en firmakategori

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i Navigatoren.
1. Fra dropdown-menuen valgte du **Firma – Kategori**. Fanen **Elementer** viste alle eksisterende kategorier.
1. Klik **Tilføj** for at åbne dialogen **Rediger listeelement**.
1. Indtast et navn for kategorien i feltet **Navn**. *(Obligatorisk)*
    Dette navn vises i feltet **Kategori** på firmasiden.
1. Fra dropdown-menuen **Kategorigruppe** valgte du den passende gruppe.
    Gruppen bestemmer, hvordan kategorien opfører sig i søgninger og automatiseringer, men er ikke synlig for slutbrugere.
    * For at aktivere leadstatus senere valgte du **Potentiel kunde**.
1. *(Valgfrit)* Indtast en beskrivelse for at præcisere, hvordan kategorien skal anvendes.
1. *(Valgfrit)* Vælg **Aktivér lead-status for denne kategori**, hvis relevant.
1. Klik **OK** for at gemme den nye kategori eller **Annullér** for at kassere ændringerne.

## Rediger eller slet firmakategorier

> [!CAUTION]
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

[1]: set-up.md
[2]: ../learn/index.md
[3]: add-lead-status.md
[4]: ../../admin/lists/user-group-filtering.md
