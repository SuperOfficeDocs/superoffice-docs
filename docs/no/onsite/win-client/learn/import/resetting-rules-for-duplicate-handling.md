---
uid: help-no-resetting-rules-for-duplicate-handling
title: Tilbakestille regler for duplikathåndtering
description: Tilbakestille regler for duplikathåndtering
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger for Windows-klient
topic: help
language: no
client: win
envir: onsite
---

# Tilbakestille én eller alle regler for duplikathåndtering

1. [!include[How to open import](includes/open-import.md)]

2. Gjør ett av følgende:

    * Klikk på ![ikon][img1] ved siden av feltet **Importbeskrivelsesfil** og velg en importbeskrivelsesfil i dialogboksen som vises. Importfil og tidligere valgte innstillinger settes inn automatisk.

    * [!include[Select file](includes/step-select-file.md)]
        Angi deretter [felttilordning][1]. Innholdet i kolonnen **Tabell** under **Duplikathåndtering** baseres på angitt felttilordning.

3. Velg ett av følgende:

    * Fjern én enkelt regel:

        1. Merk ønsket rad under **Duplikathåndtering**.
        2. Klikk på **Tilbakestill**-knappen. Den valgte raden har da ikke lenger innhold i kolonnen **Nøkkel**, og innholdet i kolonnen **Handling** endres til **Hopp over**.

    * Fjern alle reglene:

        1. Klikk på knappen **Tilbakestill alle** under **Duplikathåndtering**. Ingen av radene har da lenger noe innhold i kolonnen **Nøkkel**, og innholdet i kolonnen **Handling** endres til **Hopp over**.

> [!NOTE]
> Med mindre du velger **Tilføy** under **Gjør følgende** i dialogboksen **Duplikathåndtering**, får du ikke importere uten å ha angitt regler for duplikathåndtering for alle datatyper. Det betyr at hvis du har tilbakestilt regler, må du legge inn nye før du setter i gang importen.

## Hva vil du gjøre nå?

* [Oppdatere regler for duplikathåndtering][2]

<!-- Referenced links -->
[1]: field-mapping.md
[2]: updating-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/nav-admin-import-active.png
