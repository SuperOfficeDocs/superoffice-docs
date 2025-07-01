---
uid: help-sv-specifying-advanced-import-settings
title: Ange avancerade importinställningar
description: Ange avancerade importinställningar
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar för Windows-klient
content_type: howto
language: sv
platform: win
deployment: onsite
---

# Ange avancerade importinställningar

Avancerade importinställningar inkluderar inställningar för datumformatering och avgränsningstecken. De syftar till att säkerställa att SuperOffice tolkar importfilen på rätt sätt.

> [!NOTE]
> Om du vill tilldela fälten på importfilen på rätt sätt, kan du behöva redigera inställningarna för textavgränsare, fältavgränsare och radavgränsare.

1. [!include[How to open import](includes/open-import.md)]

1. [!include[Select file](includes/step-select-file.md)]

1. Klicka på knappen **Avancerat**.

1. I dialogrutan **Avancerat** väljer du ett fördefinierat format i listrutan **Datumformatering**. Du kan inte använda månadsnamn, utan bara siffror.

    > [!NOTE]
    > **Native ID** avser ett SuperOffice-datum. SuperOffice räknar sekunderna sedan 01/01/1970, och det är detta nummer som motsvarar **Native ID**.

1. I listrutan **Sifferformat** kan du välja bland de fördefinierade alternativen för decimalavgränsare.

1. I fältet **Format för kryssruta** skriver du in det eller de tecken som används i importfilen för att ange att en checkruta är markerad.

1. I fältet **Textavgränsare** skriver du in tecknet som används i importfilen för att omge oformaterad text.

    > [!NOTE]
    > Textavgränsare åsidosätter alla fält- och radavgränsare (se nedan). Om det till exempel finns en fältavgränsare mellan två textavgränsare, tolkas den som oformaterad text. Du behöver dock inte använda textavgränsare om importfilerna innehåller fält- eller radavgränsare.

1. I listrutan **Fältavgränsare** kan du välja bland de fördefinierade alternativen som anger vilka tecken som skiljer fälten från varandra.

1. I listrutan **Radavgränsare** kan du välja bland de fördefinierade alternativen som anger vilka tecken som skiljer raderna från varandra.

1. I listrutan **Format för medarbetare** kan du välja bland fördefinierade format som anger hur namn i importfilen ska tolkas, exempelvis om förnamn kommer före efternamn.

    > [!NOTE]
    > **Native ID** avser medarbetarens **medarbetar-id**, som det har registrerats i databasen. Om inget sådant ID hittas, används innehållet i fältet **Medarbetare (standard)**.

1. I listrutan **Medarbetare (standard)** kan man välja vilket namn som ska anges som standard om SuperOffice-databasen inte kan tolka formatet för medarbetare i importfilen.

1. I listrutan **Landsformat** kan man välja bland de fördefinierade format som anger hur länder ska tolkas, exempelvis om landsnamnet är lokalt eller på engelska.

    > [!NOTE]
    > **Native ID** avser **lands-id**, som det har registrerats i databasen.

1. I listrutan **Standardland** kan man välja vilket land som ska anges om SuperOffice-databasen inte kan tolka landsformatet i importfilen.

1. I listrutan **Valuta** kan man välja vilken valuta som ska anges om SuperOffice-databasen inte kan tolka valutaformatet i importfilen.

1. Markera **Uppdatera fritextindex** om du vill uppdatera fritextindexet kontinuerligt under importen, så att det är helt uppdaterat när importen är klar.

    > [!NOTE]
    > Importhastigheten minskar om du markerar **Uppdatera fritextindex**. För att importera stora mängder data är ett alternativ att köra importen utan att markera det här alternativet och sedan [generera ett nytt fritextindex][2] från fönstret **Alternativ** .

1. När du har angett de önskade inställningarna, klickar du på **OK**.

    [!include[Save mapping](includes/tip-save-mapping.md)]

> [!NOTE]
> Om du har angett en importbeskrivningsfil i fältet **Importera beskrivningsfil**, kommer informationen redan finnas i dialogrutan **Avancerat**. Du kan dock ändra den här informationen enligt beskrivningen ovan. Kom ihåg att importbeskrivningsfilen måste sparas innan den uppdateras med några nya alternativ.

<!-- Referenced links -->
[2]: ../../../../admin/options/learn/freetext-search/regenerate-index.md

<!-- Referenced images -->
