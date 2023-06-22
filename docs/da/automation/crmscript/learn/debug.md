---
uid: help-da-automation-script-debug
title:  Fejlfindingssessioner
description: Fejlfindingssessioner
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRMScript
so.topic: howto
so.user: admin
language: da
---

# Fejlfindingssessioner

[!include[Requirement](../../../learn/includes/req-expander-services.md)]

Fanen **Fejlfindingssessioner** over alle aktive fejlfindingssessioner i systemet. Klik på en session på listen for at åbne den i **Fejlfinding**.

## Gå til fanen Fejlfindingssessioner

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klik på **CRMScript**, og vælg fanen **Fejlfindingssessioner** .

## Start fejlfindingssession

Du kan starte en sådan session ved at køre et script i fejlfindingstilstand i skærmbilledet **Script** eller ved at køre funktionen "Void enableDebug(String key)" i et CRMScript.

Du kan også klikke på ![ikon][img1]**Start sporing af scripts** for at starte [sporing][2] af scripts på listen.

## Fejlfinding

Fejlfindingsværktøjet gør det nemt at finde og rette fejl inde i dine scripts og makroer. Du kan udføre fejlfinding på dine scripts og makroer i et produktionsmiljø uden at forstyrre de andre SuperOffice-brugere. Det giver dig mulighed for at undersøge scripts og makroer i realtid, mens de udføres. Du kan gå gennem udførelsen af scriptet trin for trin, bruge pausepunkter og vise variabelværdierne.

Du kan udføre fejlfinding på et script eller en makro ved at åbne scriptet eller makroen i fanen **Makroer og script** og klikke på ![ikon][img4] **Fejlfind script**.

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klik på **CRMScript**, og vælg fanen **Makroer og scripts**.

Du kan også klikke på ![ikon][img3] **Spor script** for at starte [sporing af et script][2].

<!-- Referenced links -->
[2]: tracing.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/run-script.png
[img3]: ../../../../media/icons/btn-script-trace-small.png
[img4]: ../../../../../common/icons/bug.png
