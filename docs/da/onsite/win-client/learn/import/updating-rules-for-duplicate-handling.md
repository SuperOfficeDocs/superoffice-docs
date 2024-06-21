---
uid: help-da-updating-rules-for-duplicate-handling
title: Opdatering af regler for dublethåndtering
description: Opdatering af regler for dublethåndtering
author: SuperOffice RnD
date: 06.29.2022
keywords: Indstillinger for Windows-klient
topic: help
language: da
client: win
envir: onsite
---

# Opdatering af regler for dublethåndtering

Du skal altid angive regler for håndtering af dubletter under import.

1. [!include[How to open import](includes/open-import.md)]

2. Gør ét af følgende:

    * Klik på ![ikonet][img1] ud for feltet **Importbeskrivelsesfil**, og vælg en importbeskrivelsesfil i den dialogboks, der åbnes. En importfil og tidligere valgte indstillinger indsættes automatisk.

    * [!include[Select file](includes/step-select-file.md)]

        Angiv derefter [felttilknytning][1].

3. Indholdet af kolonnen **Tabel** under **Dublethåndtering** er baseret på den angivne felttilknytning.

4. Under **Dublethåndtering** skal du vælge den række, der skal angives en regel for dublethåndtering for.

    > [!NOTE]
    > Hvilke rækker der vises under **Dublethåndtering**, afhænger af, hvilke felter du har valgt at importere til. Dette kan ikke ændres, og du skal angive regler for dublethåndtering for alle rækkerne.

5. Klik på knappen **Opdater**. Dialogboksen **Håndter dubletter** for den valgte datatype åbnes.

6. Alle tilgængelige felter af den påkrævede datatype, som du har defineret felttilknytning for, vises under **Når disse felter stemmer overens**. Kontrollér, hvilke felter der skal have identisk indhold, for at posten kan betragtes som en dublet. Dette kaldes en importnøgle.

7. Under **Gør følgende** skal du vælge, hvad du vil gøre, hvis der registreres dubletter under importen:

    * **Opdater eksisterende**: Værdierne i importfilen overskriver værdierne i databasen. Vælg denne indstilling, hvis du mener, at informationerne i importfilen er mere opdaterede end dem, der allerede findes i databasen.
    * **Opdater kun tomme**: Alle nye poster tilføjes, men for eksisterende poster opdateres kun de tomme felter. Vælg denne indstilling, hvis du mener, at informationerne i databasen er mere opdaterede end dem, der findes i importfilen.
    * **Udelad post**: Alle nye poster tilføjes, men de, der allerede findes i databasen, bevares uændret.

    > [!NOTE]
    > Dette er standardindstillingen for nulstilling af databasen, så uønskede poster ikke importeres med uheldige konsekvenser.

    * **Tilføj**: Alle felterne i importfilen importeres, og der udføres ingen kontrol for at se, om de allerede findes. Dette er især relevant, når du importerer til en tom database. Du behøver ikke at angive importnøgler for denne indstilling.

8. Klik på **OK**.

[!include[Save mapping](includes/tip-save-mapping.md)]

## Hvad vil du foretage dig nu?

* [Nulstilling af regler for dublethåndtering][3]

<!-- Referenced links -->
[1]: field-mapping.md
[3]: resetting-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/search-icon-black.png
