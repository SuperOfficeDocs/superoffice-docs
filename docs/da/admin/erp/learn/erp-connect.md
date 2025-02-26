---
uid: help-da-erp-connect
title: Knytte til ERP
description: Knytte til ERP
author: SuperOffice RnD
date: 07.04.2022
keywords: ERP
topic: howto
language: da
---

# Knytte til ERP

[!include[Requirement](includes/req-integration-server.md)]

Du kan knytte et SuperOffice-firma til en kunde/leverandør i ERP-systemet. Personer, som er registreret på SuperOffice-firmaet, kan derefter knyttes til personer i ERP-systemet. På samme måde kan SuperOffice-projekter knyttes til projekter i ERP-systemet. Data synkroniseres derefter på tværs af SuperOffice og ERP-systemet.

1. Gå til skærmbilledet Firma, Person eller Projekt, og vælg fanen **ERP**.

    > [!NOTE]
    > Hvis fanen **ERP** indeholder firma-, person- eller projektinformation, er der allerede oprettet en tilknytning mellem SuperOffice og ERP-systemet.

1. Klik på **Rediger**. Indstillingerne afhænger af, om du redigerer en virksomhed, en person eller et projekt.
1. Firma: Klik på **Kunde** eller **Leverandør**, afhængig af hvilken ERP-aktør du vil knytte firmaet til. Du kan kun vælge én aktør pr. firma.
    *Eller* Projekt: Klik på **Projekt**.
    *Eller* Person: Klik på **Person**.
1. Indtast den ønskede tekst i søgefeltet i dialogboksen **Tilknyt ERP**, og klik på **Søg**. Du kan også klikke på <i class="ph ph-magnifying-glass" aria-label="Search"></i> for at starte en avanceret søgning (se [Brug skærmbilledet Søg][1]).

    > [!TIP]
    > Hvis du søger med tomt søgefelt, vises alle forekomster i ERP-systemet.

1. Markér et af resultaterne på listen. Hvis du ikke får nogen resultater, kan du [oprette en ny aktør i ERP-systemet][2] baseret på data fra SuperOffice CRM.
1. Klik på **Tilknyt**. Der vises en dialogboks med dataene, der bliver synkroniseret mellem SuperOffice CRM og ERP-systemet. De data, der vises her, angiver du i SuperOffice Indstillinger og vedligeholdelse.
1. Hvis dataene i de to systemer er forskellige, markerer du de data, der er rigtige.
    For eksempel: Hvis gadeadresserne er forskellige, vælger du den, der er rigtig. De andre data overskrives.
1. Klik på **Tilknyt**. Du kommer tilbage til fanen **ERP**, hvor de synkroniserede data vises.
1. Klik på **Gem**.
1. Klik eventuelt på **Synkroniser alt nu**.

## Relateret indhold

* [Oprettelse af aktør i ERP-systemet][2]
* [Deaktivering af synkronisering][3]

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[2]: erp-create-new-actor.md
[3]: erp-sync-disconnect.md
