---
uid: help-no-add-lead-status
title: Administrer leadstatuser
description: Legg til, rediger eller fjern leadstatuser for å spore leadkvalifiseringsprosessen.
keywords: leadstatus, leadkvalifisering, diskvalifisert, kvalifisert, potensiell kunde, liste
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

# Administrer leadstatuser

[!include[Må være administrator](../../learn/includes/req-admin.md)]

Listen **Person – Leadstatus** definerer kvalifiseringsstadiene som er tilgjengelige for salgs- og markedsføringsteam når de arbeider med leads. Hver status representerer et spesifikt trinn i leadprosessen og vises i feltet **Leadstatus** på personkortet når firmaets kategori tilhører gruppen *Potensiell kunde* med **Aktiver leadstatus** valgt.

Gruppering og filtrering etter brukergruppe er ikke tilgjengelig for denne listen.

## Legg til en leadstatus

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i Navigatoren.

1. Fra rullegardinmenyen velger du **Person – Leadstatus**. Fanen **Elementer** viser alle eksisterende statuser.

1. Klikk **Legg til** for å åpne dialogen **Rediger listeelement**.

1. I feltet **Navn** skriver du inn navnet på den nye statusen. *(Obligatorisk)*

1. *(Valgfritt)* Skriv inn en kort beskrivelse for å forklare hvordan statusen skal brukes.

    Beskrivelsen vises som et verktøytips når brukeren holder markøren over et statusnavn.

1. Klikk **OK** for å lagre eller **Avbryt** for å forkaste endringene.

![Dialogboksen Rediger listeelement i listen Person – Leadstatus -screenshot][img1]

## Rediger eller slett leadstatuser

> [!NOTE]
> Gå nøye gjennom bruken av statusene før du gjør endringer.
> Sletting eller endring av statuser som er i bruk kan føre til inkonsistente data.
> Statusen **Åpen** er standard for nye leads og bør ikke slettes.

1. Åpne listen **Person – Leadstatus**.

1. For å redigere:

    1. Dobbeltklikk en status for å åpne den.
    1. Oppdater feltene **Navn** eller **Beskrivelse**.
    1. Klikk **OK** for å lagre.

1. For å slette:

    1. Velg statusen i listen.
    1. Klikk **Slett**.

## Gjenopprett slettede leadstatuser

1. Åpne listen **Person – Leadstatus**.

1. Velg **Vis slettede elementer og overskrifter**.

1. Finn den slettede statusen, dobbeltklikk den og klikk **Gjenopprett**.

1. Klikk **OK**.

## Relatert innhold

* [Aktiver leadstatus for firmakategorier][1]
* [Firmakategori og kategorigruppe][2]
* [Oversikt over leadhåndtering][3]

<!-- Referenced links -->
[1]: index.md
[2]: add-company-category.md
[3]: ../learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/add-lead-status.png
