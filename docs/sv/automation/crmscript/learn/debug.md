---
uid: help-sv-automation-script-debug
title:  Felsökningssessioner
description: Felsökningssessioner
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRMScript
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Felsökningssessioner

[!include[Requirement](../../../learn/includes/req-expander-services.md)]

På fliken **Felsökningssessioner** visas en lista över alla aktiva felsökningssessioner i systemet. Klikca på en session i listan om du vill öppna den i **Felsökning**.

## Gå till fliken Felsökningssessioner

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klicka på **CRMScript** och gå till fliken **Felsökningssessioner**.

## Starta felsökningssession

Du kan skapa en session genom att köra ett skript i felsökningsläge från fönstret **Skript** eller genom att köra funktionen "Void enableDebug(String key)" i ett CRMScript.

Du kan också klicka på ![ikon][img1] **Starta spårning av skript** för att starta en [spårning][2] av skripten i listan.

## Felsökare

Med felsökningsverktyget är det lätt att hitta och korrigera buggar i dina skript och makron. Du kan felsöka dina skript och makron i en produktmiljö utan att hindra andra SuperOffice-användare. Du kan undersöka dina skript och makron i realtid medan de körs. Du kan gå igenom skriptkörningen, använda brytpunkter och visa variabelvärdena.

Du kan felsöka ett skript eller makro genom att öppna det på fliken **Makron och skript** och klicka på ![ikon][img4] **Felsök skript**.

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klicka på **CRMScript** och gå till fliken **Makron och skript**.

Du kan också klicka på ![ikon][img3] **Spåra skript** för att börja [spåra ett skript][2].

<!-- Referenced links -->
[2]: tracing.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/run-script.png
[img3]: ../../../../media/icons/btn-script-trace-small.png
[img4]: ../../../../../common/icons/bug.png
