---
uid: help-no-add-company-category
title: Firma kategori og kategorigruppe
description: Opprett eller oppdater firmakategorier, tilordne kategorigrupper, og aktiver sporing av leadstatus.
keywords: firmakategori, kategorigruppe, leadstatus, potensiell kunde, lister
author: digitaldiina
date: 11.12.2025
version: 10.6
topic: howto
license: salesessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
index: true
language: no
---

# Firma kategori og kategorigruppe

[!include[Må være administrator](../../learn/includes/req-admin.md)]

Listen **Firma – Kategori** definerte typene av firmaer i databasen, slik som *Kunde*, *Partner* eller *Lead*.
Hver kategori hadde en **Kategorigruppe** som bestemte hvordan den oppførte seg i søk, automatiseringer og lead-håndtering.

Du administrerte firmakategorier under **Innstillinger og vedlikehold** under **Lister** > **Firma – Kategori**.

## Om kategorigrupper

Kategorigrupper gav en måte å klassifisere kategorier etter formål og forhindre uønskede automatiseringsendringer. For eksempel skulle et firma merket som *Kunde* aldri automatisk gå tilbake til en *Lead* på grunn av en innsending fra et skjema.

| Kategorigruppe | Beskrivelse |
|---|---|
| Kunde | Brukes for eksisterende kunder, som *Kunde A*, *Kunde B* eller *VIP-kunde*. |
| Tapt | Brukes for tidligere kunder eller tapte muligheter. |
| Annet | Brukes for hvilken som helst annen type firma. |
| Partner | Brukes for forhandlere, integratorer eller forretningspartnere. |
| Potensiell kunde | Brukes for leads eller potensielle som ennå ikke har blitt kunder. Kun denne gruppen kan ha **Lead-status** aktivert. |

## Legg til firmakategori

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i Navigatoren.
1. Fra rullegardinmenyen valgte du **Firma – Kategori**. Fanen **Elementer** viste alle eksisterende kategorier.
1. Klikk **Legg til** for å åpne dialogen **Rediger listeelement**.
1. Skriv inn et navn for kategorien i feltet **Navn**. *(Obligatorisk)*
    Dette navnet vises i feltet **Kategori** på firmasiden.
1. Fra rullegardinmenyen **Kategorigruppe** valgte du passende gruppe.
    Gruppen bestemmer hvordan kategorien oppfører seg i søk og automatiseringer, men er ikke synlig for sluttbrukere.
    * For å aktivere leadstatus senere, valgte du **Potensiell kunde**.
1. *(Valgfritt)* Skriv inn en beskrivelse for å klargjøre hvordan kategorien skal brukes.
1. *(Valgfritt)* Velg **Aktiver lead-status for denne kategorien** hvis aktuelt.
1. Klikk **OK** for å lagre den nye kategorien eller **Avbryt** for å forkaste endringene.

## Rediger eller slett firmakategorier

> [!CAUTION]
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

[1]: index.md
[2]: ../learn/index.md
[3]: add-lead-status.md
[4]: ../../admin/lists/user-group-filtering.md
