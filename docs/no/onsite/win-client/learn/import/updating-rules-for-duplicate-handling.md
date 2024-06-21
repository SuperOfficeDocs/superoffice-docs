---
uid: help-no-updating-rules-for-duplicate-handling
title: Oppdatere regler for duplikathåndtering
description: Oppdatere regler for duplikathåndtering
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger for Windows-klient
topic: help
language: no
client: win
envir: onsite
---

# Oppdatere regler for duplikathåndtering

Du må alltid angi regler for hvordan duplikater skal håndteres ved import.

1. [!include[How to open import](includes/open-import.md)]

2. Gjør ett av følgende:

    * Klikk på ![ikon][img1] ved siden av feltet **Importbeskrivelsesfil** og velg en importbeskrivelsesfil i dialogboksen som vises. Importfil og tidligere valgte innstillinger settes inn automatisk.

    * [!include[Select file](includes/step-select-file.md)]

        Angi deretter [felttilordning][1].

3. Innholdet i kolonnen **Tabell** under **Duplikathåndtering** baseres på angitt felttilordning.

4. Merk raden du vil angi duplikathåndteringsregel for, under **Duplikathåndtering**.

    > [!NOTE]
    > Hvilke rader som kommer opp under **Duplikathåndtering**, avhenger av hvilke felt du har valgt å importere til. Det er ikke mulig å endre dette, og du må angi duplikathåndteringsregler for samtlige rader.

5. Klikk på **Oppdater**-knappen. Dialogboksen **Håndter duplikater** vises for den valgte datatypen.

6. Under **Når disse feltene samsvarer** vises alle tilgjengelige felt av ønsket datatype som du har definert felttilordning for. Her merker du av for hvilke(t) felt som må ha identisk innhold for at posten skal oppfattes som et duplikat. Det er dette som kalles en importnøkkel.

7. Under **Gjør følgende** velger du hva som skal skje hvis det oppdages duplikater under importen:

    * **Oppdater**: Verdiene i importfilen overskriver verdiene i databasen. Du velger dette hvis du mener at informasjonen i importfilen er mer oppdatert enn den som allerede er i databasen.
    * **Flett**: Alle nye poster legges til, og for eksisterende poster oppdateres bare de feltene som er tomme. Du velger dette hvis du mener at informasjonen i databasen er mer oppdatert enn den som er i importfilen.
    * **Hopp over**: Alle nye poster legges til, men de som ligger i databasen fra før, beholdes slik de er.

    > [!NOTE]
    > Dette alternativet er standardvalget ved tilbakestilling av databasen, slik at uønskede poster ikke importeres med uheldige konsekvenser.

    * **Tilføy**: Alle feltene i importfilen importeres, og det sjekkes ikke om de finnes fra før. Dette er spesielt aktuelt når du importerer til en tom database. Du behøver ikke angi importnøkler for å velge dette alternativet.

8. Klikk på **OK**.

[!include[Save mapping](includes/tip-save-mapping.md)]

## Hva vil du gjøre nå?

* [Tilbakestille regler for duplikathåndtering][3]

<!-- Referenced links -->
[1]: field-mapping.md
[3]: resetting-rules-for-duplicate-handling.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/search-icon-black.png
