---
uid: help-no-erp-connect
title: Knytte til ERP
description: Knytte til ERP
author: SuperOffice RnD
date: 07.04.2022
keywords: ERP
topic: howto
language: no
---

# Knytte til ERP

[!include[Requirement](includes/req-integration-server.md)]

Du kan knytte et SuperOffice-firma til en kunde/leverandør i ERP-systemet. Personer som er registrert på SuperOffice-firmaet kan deretter knyttes til personer i ERP-systemet. Tilsvarende kan SuperOffice-prosjekter knyttes til prosjekter i ERP-systemet. Deretter synkroniseres data mellom SuperOffice og ERP-systemet.

1. Gå til skjermbildet Firma, Person eller Prosjekt, og deretter velg **ERP**-fanen.

    > [!NOTE]
    > Hvis **ERP**-fanen inneholder firma-, person- eller prosjektinformasjon, er det allerede opprettet en kobling mellom SuperOffice og ERP-systemet.

1. Klikk på **Rediger**. Valgene avhenger av om du redigerer et firma, en person eller et prosjekt.
1. Firma: Klikk på **Kunde** eller **Leverandør**, avhengig av hvilken ERP-aktør du vil knytte firmaet til. Du kan bare velge én aktør per selskap.
    *Eller* Prosjekt: Klikk på **Prosjekt**.
    *Eller* Person: Klikk på **Person**.
1. I dialogboksen **Koble til ERP** skriver du inn teksten du vil søke etter i søkefeltet, og deretter klikker du på **Søk**. Du kan også klikke på <i class="ph ph-magnifying-glass" aria-label="Søk"></i> for å starte et avansert søk (se [Bruke Finn-bildet][1]).

    > [!TIP]
    > Hvis du søker med et tomt søkefelt, vises alle oppføringer i ERP-systemet.

1. Velg et element i listen. Hvis du ikke får noen treff, kan [du opprette en ny aktør i ERP-systemet][2] basert på data fra SuperOffice CRM.
1. Klikk på **Tilknytt**. Det vises en dialogboks som viser dataene som blir synkronisert mellom SuperOffice CRM og ERP-systemet. Hvilke data som vises her, angir du i SuperOffice Innstillinger og vedlikehold.
1. Hvis dataene i de to systemene er forskjellige, merker du av for dataene som er riktige.
    For eksempel: Hvis gateadressene er ulike, velger du den som er riktig. De andre dataene blir overskrevet.
1. Klikk på **Tilknytt**. Dette tar deg tilbake til **ERP-fanen** der de synkroniserte dataene vises.
1. Klikk på **Lagre**.
1. Klikk eventuelt på **Synkroniser nå**.

## Hva vil du gjøre nå?

* [Opprette aktør i ERP-systemet][2]
* [Deaktiver synkronisering][3]

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[2]: erp-create-new-actor.md
[3]: erp-sync-disconnect.md

<!-- Referenced images -->
