---
uid: help-no-erp-connect-actor
title: Knytte til ERP
description: Knytte til ERP
keywords: knytte til ERP, knytte firma til ERP, knytte person til ERP, knytte prosjekt til ERP, ingen treff i ERP, opprett i ERP, opprette aktør, ERP-aktør, ERP
author: SuperOffice RnD
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from:
  - /no/admin/erp/learn/erp-connect
  - /no/admin/erp/learn/erp-create-new-actor
---

# Knytte til ERP

[!include[Requirement](../../includes/req-dev-tools.md)]

Du kan knytte et SuperOffice-firma til en kunde eller leverandør i ERP-systemet. Personer som er registrert på SuperOffice-firmaet, kan deretter knyttes til personer i ERP-systemet. Tilsvarende kan SuperOffice-prosjekter knyttes til prosjekter i ERP-systemet. Deretter synkroniseres data mellom SuperOffice og ERP-systemet.

1. Gå til skjermbildet **Firma**, **Person** eller **Prosjekt**, og velg **ERP**-fanen.

    Hvis **ERP**-fanen allerede inneholder firma-, person- eller prosjektinformasjon, er det allerede opprettet en kobling mellom SuperOffice og ERP-systemet.

1. Klikk på **Rediger**. Valgene avhenger av om du redigerer et firma, en person eller et prosjekt.
1. Firma: Klikk på **Kunde** eller **Leverandør**, avhengig av hvilken ERP-aktør du vil knytte firmaet til. Du kan bare velge én aktør per firma.
    *Eller* Prosjekt: Klikk på **Prosjekt**.
    *Eller* Person: Klikk på **Person**.
1. I dialogboksen **Knytte til ERP** skriver du inn teksten du vil søke etter i søkefeltet, og klikker på **Søk**. Du kan også klikke på søkeikonet (<i class="ph ph-magnifying-glass" aria-label="Søk"></i>) for å starte et [avansert søk][1].

    Hvis du søker med et tomt søkefelt, vises alle oppføringer i ERP-systemet.

1. Velg et element i listen. Hvis du ikke får noen treff, kan du [opprette en ny aktør i ERP-systemet](#create-actor) basert på data fra SuperOffice CRM.
1. Klikk på **Tilknytt**. Det vises en dialogboks med dataene som blir synkronisert mellom SuperOffice CRM og ERP-systemet. Hvilke data som vises her, er definert i SuperOffice Innstillinger og vedlikehold.
1. Hvis dataene i de to systemene er forskjellige, velger du hvilke data som er riktige.
    For eksempel: Hvis gateadressene er forskjellige, velg den som er riktig. De andre dataene vil bli overskrevet.
1. Klikk på **Tilknytt**. Du kommer tilbake til **ERP**-fanen, hvor de synkroniserte dataene nå vises.
1. Klikk på **Lagre**.

## <a id="create-actor"></a>Opprette aktør i ERP-systemet

Hvis en kunde for eksempel ikke finnes i ERP-systemet, kan du opprette kunden i ERP-systemet basert på data fra SuperOffice.

> [!NOTE]
> **Opprett**-knappen er deaktivert hvis SuperOffice ikke har tillatelse til å opprette aktører i ERP-systemet.

1. I dialogboksen **Knytte til ERP**, merk av for **Ingen treff i ERP** nederst og klikk på **Opprett**. Dialogboksen **Opprett i ERP** vises.
1. Fyll inn relevante verdier.
1. Klikk på **Opprett**. Du kommer tilbake til **ERP**-fanen hvor de synkroniserte dataene nå vises.
1. Klikk på **Lagre**.

## Relatert innhold

* [Deaktiver synkronisering][3]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[3]: disconnect.md

<!-- Referenced images -->
