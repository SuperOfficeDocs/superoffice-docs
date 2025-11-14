---
uid: help-no-add-company-category
title: Firma kategori og kategorigruppe
description: Opprett eller oppdater firmakategorier, tilordne kategorigrupper, og aktiver sporing av leadstatus.
keywords: firmakategori, kategorigruppe, leadstatus, potensiell kunde, lister
author: digitaldiina
date: 12.11.2025
version: 11.6
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
index: true
language: no
---

# Firma kategori og kategorigruppe

[!include[Må være administrator](../../learn/includes/req-admin.md)]

Listen **Firma – Kategori** definerer typene av firmaer i databasen, slik som *Kunde*, *Partner* eller *Lead*.
Hver kategori kan tilhøre en **Kategorigruppe** som bestemmer hvordan den oppfører seg i søk, automatiseringer og lead-håndtering.

Du administrerer firmakategorier under **Innstillinger og vedlikehold** under **Lister** > **Firma – Kategori**.

## Om kategorigrupper

Kategorigrupper gir en måte å klassifisere kategorier etter formål og forhindre uønskede automatiseringsendringer. For eksempel skal et firma merket som *Kunde* aldri automatisk gå tilbake til en *Lead* på grunn av en innsending fra et skjema.

| Kategorigruppe | Beskrivelse |
|---|---|
| Kunde | Brukes for eksisterende kunder, som *Kunde A*, *Kunde B* eller *VIP-kunde*. |
| Tapt | Brukes for tidligere kunder eller tapte muligheter. |
| Partner | Brukes for forhandlere, integratorer eller forretningspartnere. |
| Potensiell kunde | Brukes for leads eller potensielle som ennå ikke har blitt kunder. Kun denne gruppen kan ha **Lead-status** aktivert. |
| Annet | Brukes for hvilken som helst annen type firma. |

## Legg til firmakategori

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i Navigatoren.

1. Fra rullegardinmenyen velger du **Firma – Kategori**. Fanen **Elementer** viser alle eksisterende kategorier.

1. Klikk **Legg til** for å åpne dialogen **Rediger listeelement**.

1. Skriv inn et navn for kategorien i feltet **Navn**. *(Obligatorisk)*

    Dette navnet vises i feltet **Kategori** på firmasiden.

1. Fra rullegardinmenyen **Kategorigruppe** velger du passende gruppe.

    Gruppen bestemmer hvordan kategorien oppfører seg i søk og automatiseringer, men er ikke synlig for sluttbrukere.

    * For å aktivere leadstatus senere, velger du **Potensiell kunde**.

1. *(Valgfritt)* Skriv inn en beskrivelse for å klargjøre hvordan kategorien skal brukes.

1. *(Valgfritt)* Velg **Aktiver lead-status for denne kategorien** hvis aktuelt.

1. Klikk **OK** for å lagre den nye kategorien eller **Avbryt** for å forkaste endringene.

![Redigering av en firmakategori i listen Firma – Kategori, som viser at gruppen Potensiell kunde er valgt og muligheten for å aktivere leadstatus for kategorien. -screenshot][img1]

## Rediger eller slett firmakategorier

> [!NOTE]
> Redigering eller sletting av kategorier som er i bruk kan føre til inkonsistente data.
> Endring av kategorigruppe eller deaktivering av lead-status kan etterlate firmaer og kontakter med leadinformasjon som ikke lenger kan oppdateres.
> Gå nøye gjennom kategoriens bruk før du gjør endringer.

1. Åpne listen **Firma – Kategori**.

1. For å redigere:

    1. Dobbeltklikk en kategori for å åpne den.
    1. Oppdater **Navn**, **Kategorigruppe** eller alternativen **Lead-status**.
    1. Klikk **OK** for å lagre.

1. For å slette:

    1. Velg kategorien i listen.
    1. Klikk **Slett**.

## Gjenopprett slettede firmakategorier

1. Åpne listen **Firma – Kategori**.

1. Velg **Vis slettede elementer og overskrifter**.

1. Finn den slettede kategorien, dobbeltklikk den, og klikk **Gjenopprett**.

1. Klikk **OK**.

## Relatert innhold

* [Potensielle kundekategorier][2]
* [Aktiver lead-status for firmakategorier][1]
* [Administrer lead-statuser][3]
* [Brukergruppefiltrering][4]

<!-- Referenced links -->
[1]: index.md
[2]: ../learn/index.md
[3]: add-lead-status.md
[4]: ../../admin/lists/user-group-filtering.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/add-company-category.png
