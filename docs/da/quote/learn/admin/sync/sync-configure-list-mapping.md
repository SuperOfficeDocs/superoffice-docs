---
uid: help-da-sync-configure-list-mapping
title: Konfigurere listetilknytning
description: Konfigurere listetilknytning
author: Bergfrid Dias
date: 03.29.2023
keywords: tilbud, sync, henvisning, ERP, felttildeling
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Konfigurere listetilknytning

Når du skal synkronisere data mellem SuperOffice og ERP-systemer, skal du angive, hvilke SuperOffice-felter og ERP-felter, som hører sammen.

> [!NOTE]
> Når du skal redigere et ERP-link, skal du deaktivere den først.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Marker ERP-linket, og klik på knappen **Listetilknytninger** nederst.

1. Vælg en liste. De tilgængelige feltelementer vises i højre side af dialogboksen.

    Hvis der ikke vises nogen lister, skal du [konfigurere felttilknytning][1].

1. Vælg det tilsvarende CRM-element for hvert ERP-element.

    > [!NOTE]
    > Mapping er "en til en". Du kan ikke tilknytte samme CRM-element to gange. Dobbelt tilknyttede listeelementer vises i RØD. Hvis du vil udelade et ERP-listeelement **, skal du vælge**(Ingen markering).

1. Gentag trin 4 til 5 for at tilknytte listeelementer for den næste liste.

1. Marker **Aktiv** for det ERP-link, du har redigeret.

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md

<!-- Referenced images -->
