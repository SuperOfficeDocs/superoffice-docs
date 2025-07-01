---
uid: help-sv-resetting-rules-for-duplicate-handling
title: Återställa regler för hantering av dubbletter
description: Återställa regler för hantering av dubbletter
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar för Windows-klient
content_type: howto
language: sv
platform: win
deployment: onsite
---

# Återställ en eller alla regler för hantering av dubbletter

1. [!include[How to open import](includes/open-import.md)]

2. Gör något av följande:

    * Klicka på ![ikonen][img1] bredvid fältet **Importbeskrivningsfil** och välj en importbeskrivningsfil i den dialogruta som öppnas. En importfil och tidigare valda inställningar infogas automatiskt.

    * [!include[Select file](includes/step-select-file.md)]

        Ange sedan [fälttilldelningen][1]. Innehållet i kolumnen **Tabell** under **Hantering av dubbletter** baseras på den angivna fälttilldelningen.

3. Välj något av följande alternativ:

    * Ta bort en enskild regel:

        1. Välj önskad rad under **Hantering av dubbletter**.
        2. Klicka på knappen **Återställ**. Den valda raden har då ingenting i kolumnen **Nyckel** och kolumnen **Åtgärd** ändras till **Hoppa över**.

    * Ta bort alla regler:

        1. Klicka på knappen **Återställ alla** under **Hantering av dubbletter**. Alla rader kommer då inte att ha något i kolumnen **Nyckel** och kolumnen **Åtgärd** för varje rad kommer ändras till **Hoppa över**.

> [!NOTE]
> Om du inte väljer **Infoga** under **Gör följande** i dialogrutan **Hantera dubbletter**, kan du inte importera data utan att ange regler för dubbletthantering för alla datatyper. Det innebär att om du har återställningsregler, måste du ange nya innan du startar importen.

## Vad vill du göra nu?

* [Uppdateringsregler för hantering av dubbletter][2]

<!-- Referenced links -->
[1]: field-mapping.md
[2]: updating-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/nav-admin-import-active.png
