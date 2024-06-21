---
uid: help-da-resetting-rules-for-duplicate-handling
title: Nulstiller regler for dublethåndtering
description: Nulstiller regler for dublethåndtering
author: SuperOffice RnD
date: 06.29.2022
keywords: Indstillinger for Windows-klient
topic: help
language: da
client: win
envir: onsite
---

# Nulstil en eller alle regler for dublethåndtering

1. [!include[How to open import](includes/open-import.md)]

2. Gør ét af følgende:

    * Klik på ![ikonet][img1] ud for feltet **Importbeskrivelsesfil**, og vælg en importbeskrivelsesfil i den dialogboks, der åbnes. En importfil og tidligere valgte indstillinger indsættes automatisk.

    * [!include[Select file](includes/step-select-file.md)]

        Angiv derefter [felttilknytning][1]. Indholdet af kolonnen **Tabel** under **Dublethåndtering** er baseret på den angivne felttilknytning.

3. Vælg en af følgende:

    * Fjern en enkelt regel:

        1. Vælg den ønskede række under **Dublethåndtering**.
        2. Klik på knappen **Nulstil**. Den valgte række vil derefter ikke have noget i kolonnen **Nøgle**, og kolonnen **Handling** ændres til **Udelad post**.

    * Fjern alle regler:

        1. Klik på knappen **Nulstil alle** under **Dublethåndtering**. Alle rækker vil derefter ikke have noget i kolonnen **Nøgle**, og kolonnen **Handling** for hver række ændres til **Udelad post**.

> [!NOTE]
> Medmindre du vælger **Tilføj** under **Gør følgende** i dialogboksen **Håndter dubletter**, kan du ikke importere data uden at angive regler for håndtering af dubletter for alle datatyper. Det betyder, at hvis du har nulstillet regler, skal du angive nye, før du starter importen.

## Hvad vil du foretage dig nu?

* [Opdatering af regler for dublethåndtering][2]

<!-- Referenced links -->
[1]: field-mapping.md
[2]: updating-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/nav-admin-import-active.png
