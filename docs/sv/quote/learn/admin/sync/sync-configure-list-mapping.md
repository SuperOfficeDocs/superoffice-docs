---
uid: help-sv-sync-configure-list-mapping
title: Konfigurera listmappning
description: Konfigurera listmappning
author: Bergfrid Dias
so.date: 03.29.2023
keywords: offert, synk, referens, ERP, tilldelning
so.topic: howto
so.user: admin
language: sv
---

# Konfigurera listmappning

När du synkroniserar data mellan SuperOffice och ERP-system, måste du ange vilka SuperOffice-fält och ERP-fält som hör samman.

> [!NOTE]
> När du ska redigera en ERP-koppling, måste du inaktivera den först.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Markera ERP-kopplingen och klicka på knappen **Listmappning** nederst.

1. Välj en lista. De tillgängliga fältelementen visas till höger i dialogrutan.

    Om inga listor visas, måste du [konfigurera fälttilldelning][1].

1. Välj motsvarande CRM-objekt för varje ERP-objekt.

    > [!NOTE]
    > Kopplingen är en till en. Du kan inte koppla till samma CRM-objekt två gånger. Dubblett-kopplade listobjekt visas i RÖTT. Om du vill lämna ett ERP-listobjekt okopplat väljer **du**(Inget val).

1. Upprepa steg 4 till 5 för att koppla listobjekt för nästa lista.

1. Markera **Aktiv** för ERP-kopplingen du redigerade.

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md

<!-- Referenced images -->
