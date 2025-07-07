---
uid: help-da-erp-connect-actor
title: Knyt til ERP
description: Knyt til ERP
keywords: knyt til ERP, knyt firma til ERP, knyt person til ERP, knyt projekt til ERP, ingen hits i ERP, opret i ERP, opret aktør, ERP-aktør, ERP
author: SuperOffice RnD
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from:
  - /da/admin/erp/learn/erp-connect
  - /da/admin/erp/learn/erp-create-new-actor
---

# Knyt til ERP

[!include[Requirement](../../includes/req-dev-tools.md)]

Du kan knytte et SuperOffice-firma til en kunde eller leverandør i ERP-systemet. Personer, som er registreret på SuperOffice-firmaet, kan derefter knyttes til personer i ERP-systemet. På samme måde kan SuperOffice-projekter knyttes til projekter i ERP-systemet. Data synkroniseres derefter mellem SuperOffice og ERP-systemet.

1. Gå til skærmbilledet Firma, Person eller Projekt, og vælg fanen **ERP**.

    Hvis fanen **ERP** indeholder firma-, person- eller projektinformation, er der allerede oprettet en tilknytning mellem SuperOffice og ERP-systemet.

1. Klik på **Rediger**. Indstillingerne afhænger af, om du redigerer en virksomhed, en person eller et projekt.
1. Firma: Klik på **Kunde** eller **Leverandør**, afhængigt af hvilken ERP-aktør du vil knytte firmaet til. Du kan kun vælge én aktør pr. firma.
    *Eller* Projekt: Klik på **Projekt**.
    *Eller* Person: Klik på **Person**.
1. I dialogboksen **Tilknyt til ERP** skal du indtaste tekst i søgefeltet og klikke på **Søg**. Du kan også klikke på søgeikonet (<i class="ph ph-magnifying-glass" aria-label="Search"></i>) for at starte en [avanceret søgning][1].

    Hvis du søger med tomt søgefelt, vises alle poster i ERP-systemet.

1. Vælg en post i resultatlisten. Hvis du ikke får nogen resultater, kan du [oprette en ny aktør i ERP-systemet](#create-actor) baseret på data fra SuperOffice CRM.
1. Klik på **Tilknyt**. En dialogboks vises med de data, der vil blive synkroniseret mellem SuperOffice CRM og ERP-systemet. Hvilke data der vises her, defineres i SuperOffice Indstillinger og vedligeholdelse.
1. Hvis dataene i de to systemer er forskellige, skal du vælge de korrekte data.
    For eksempel: Hvis gadeadresserne er forskellige, vælg den korrekte. De øvrige data overskrives.
1. Klik på **Tilknyt**. Du kommer tilbage til fanen **ERP**, hvor de synkroniserede data nu vises.
1. Klik på **Gem**.

## <a id="create-actor"></a>Opret en aktør i ERP-systemet

Hvis eksempelvis en kunde ikke findes i ERP-systemet, kan du oprette kunden i ERP-systemet baseret på dataene fra SuperOffice.

> [!NOTE]
> Knappen **Opret** er deaktiveret, hvis SuperOffice ikke har tilladelse til at oprette aktører i ERP-systemet.

1. I dialogboksen **Tilknyt til ERP** skal du vælge **Ingen hits i ERP** nederst og klikke på **Opret**. Dialogboksen **Opret i ERP** vises.
1. Indtast de ønskede værdier.
1. Klik på **Opret**. Du kommer tilbage til fanen **ERP**, hvor de synkroniserede data nu vises.
1. Klik på **Gem**.

## Relateret indhold

* [Deaktivering af synkronisering][3]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[3]: disconnect.md

<!-- Referenced images -->
