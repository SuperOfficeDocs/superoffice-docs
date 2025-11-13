---
uid: help-da-add-lead-status
title: Administrér leadstatusser
description: Tilføj, rediger eller fjern leadstatusser for at spore fremskridtet i kvalificeringsprocessen.
keywords: leadstatus, leadkvalificering, diskvalificeret, kvalificeret, potentiel kunde, liste
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

# Administrér leadstatusser

[!include[Skal være administrator](../../learn/includes/req-admin.md)]

Listen **Person – Leadstatus** definerer de kvalificeringsstadier, der er tilgængelige for salgs- og marketingteams, når de arbejder med leads. Hver status repræsenterer et specifikt punkt i leadprocessen og vises i feltet **Leadstatus** på personkortet, når firmaets kategori tilhører gruppen *Potentiel kunde* med **Aktivér leadstatus** valgt.

Gruppering og filtrering efter brugergruppe er ikke tilgængelig for denne liste.

## Tilføj en leadstatus

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i Navigatoren.

1. Fra rullemenuen vælger du **Person – Leadstatus**. Fanen **Elementer** viser alle eksisterende statusser.

1. Klik **Tilføj** for at åbne dialogen **Rediger listeelement**.

1. I feltet **Navn** indtaster du navnet på den nye status. *(Obligatorisk)*

1. *(Valgfrit)* Indtast en kort beskrivelse for at forklare, hvordan status skal bruges.

    Beskrivelsen vises som et værktøjstip, når brugeren holder markøren over et statusnavn.

1. Klik **OK** for at gemme eller **Annullér** for at kassere ændringerne.

![Dialogen Rediger listeelement i listen Person – Leadstatus -screenshot][img1]

## Redigér eller slet leadstatusser

> [!NOTE]
> Gennemgå brugen af statusser grundigt, før du foretager ændringer.
> Sletning eller ændring af statusser, der er i brug, kan føre til inkonsekvente data.
> Statussen **Åben** er standard for nye leads og bør ikke slettes.

1. Åbn listen **Person – Leadstatus**.

1. For at redigere:

    1. Dobbeltklik en status for at åbne den.
    1. Opdatér felterne **Navn** eller **Beskrivelse**.
    1. Klik **OK** for at gemme.

1. For at slette:

    1. Vælg status i listen.
    1. Klik **Slet**.

## Gendan slettede leadstatusser

1. Åbn listen **Person – Leadstatus**.

1. Vælg **Vis slettede elementer og overskrifter**.

1. Find den slettede status, dobbeltklik den og klik **Gendan**.

1. Klik **OK**.

## Relateret indhold

* [Aktivér leadstatus for firmakategorier][1]
* [Firmakategori og kategorigruppe][2]
* [Oversigt over leadhåndtering][3]

<!-- Referenced links -->
[1]: index.md
[2]: add-company-category.md
[3]: ../learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/add-lead-status.png
