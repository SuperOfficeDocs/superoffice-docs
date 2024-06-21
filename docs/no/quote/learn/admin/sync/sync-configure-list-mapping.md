---
uid: help-no-sync-configure-list-mapping
title: Konfigurere listetilordning
description: Konfigurere listetilordning
author: Bergfrid Dias
date: 03.29.2023
keywords: tilbud, sync, connector, ERP, kartlegging
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Konfigurere listetilordning

Når du skal synkronisere data mellom SuperOffice og ERP-systemer, må du angi hvilke SuperOffice-felt og ERP-felt som hører sammen.

> [!NOTE]
> Når du skal redigere en ERP-tilkobling, må du først deaktivere den.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Merk ERP-koblingen, og klikk på knappen **Listetilordninger** nederst.

1. Velg en liste. Hvilke feltelementer som er tilgjengelige, vises på høyre side i dialogboksen.

    Hvis det ikke vises noen lister, må du [konfigurere felttilordning][1].

1. Velg det tilsvarende CRM-elementet for hvert ERP-element.

    > [!NOTE]
    >Tilordning er "en til en". Du kan ikke tilordne til samme CRM-element to ganger. Dobbelt tilordnede listeelementer vises i RØDT. For å la et ERP-listeelement være utilordnet, velger du **(Ingen utvalg)**.

1. Gjenta trinn 4 til 5 hvis du vil tilordne listeelementer for den neste listen.

1. Merk av for **Aktiv** for ERP-koblingen du har redigert.

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md

<!-- Referenced images -->
