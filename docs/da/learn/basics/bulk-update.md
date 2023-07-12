---
uid: help-da-bulk-update
title: Masseredigering
description: Masseredigering
author: SuperOffice RnD
so.date: 06.29.2022
keywords: masseredigering
so.topic: howto
language: da
---

# Sådan opdaterer du flere poster (masseopdatering)

Masseredigering giver dig mulighed for at ændre værdier på tværs af flere poster af samme type. Du kan udføre masseredigeringen på alle eller udvalgte poster i detaljekort (arkiver), udvalg og skærmbilledet **Søg**. Denne opgave kan også bruges til at slette flere poster.

1. Åbn udvalget, detaljekortet (arkiv) eller søgeresultaterne (skærmbilledet **Søg**), der indeholder poster, som du vil opdatere.

2. Udvalg: Klik på knappen **Opgave**, og vælg **Masseopdatering**.
    eller
    Marker de poster, du vil opdatere, højreklik på dem, og vælg **Masseredigering ...**
    Dialogboksen **Masseredigering** åbnes. Nederst i denne dialogboks kan du se typen post og hvor mange poster, der skal opdateres. Eksempel: Antal personer i kø til masseredigering: 7.

    > [!NOTE]
    > Hvis udvalget indeholder både firmaer og personer, vil der være to faner: **Firma** og **Person**.

3. Vælg et felt, der skal ændres, i kolonnen **Felt**. Du kan også [indtaste navnet i feltet][1]. Når du skriver hvert bogstav, viser listen nedenfor alle forekomster, der er relevante for de valgte poster.

4. Vælg en handling i kolonnen **Handling**. Hvilke handlinger, der er tilgængelige, afhænger af, hvilken type felt, du valgte i det forrige trin. Eksempler:

    * **Marker**: Marker eller fjern markering i afkrydsningsfelt.
    * **Skift**: Fjern markering i et markeret afkrydsningsfelt og omvendt.
    * **Søg og erstat**: [Find tekst, og erstat den](#search-and-replace).
    * **Regex**: Opdater et felt med [regulære udtryk](#regex).
    * **Angiv**: Brug en ny værdi i feltet.
    * **Ryd**: Fjern alle værdier fra feltet.
    * Handlinger for lister: Vælg eller fjern enkelte eller flere værdier for listefelter.
    * Handling for aktivitetslinks: Tilføj, slet eller erstat aktivitetslinks, eller fjern alle aktivitetslinks.

5. Hvis du vil tilføje flere felter, der skal opdateres, skal du klikke på **Tilføj** og gentage trin 3 og 4.

6. Sørg for at markere (![ikon][img1]) de felter, du vil opdatere, og fjern markeringen (![ikon][img2]) af felter, som du IKKE VIL opdatere.

7. Klik på **Opdater**. Dialogboksen **Bekræft** åbnes, og der vises en liste over opdateringerne.

    > [!NOTE]
    > Når en opdatering er installeret, kan den ikke fortrydes.

8. Klik på **Ja** at implementere ændringerne i de valgte poster.

    > [!NOTE]
    > Det er muligt at stoppe opdateringen, så snart du har startet det. Elementer, som endnu ikke er blevet opdateret, bliver ikke opdateret.

9. Klik på **LOG** for at vise ændringsloggen. Hvis nogle poster ikke blev opdateret, er årsagen angivet i kolonnen **Årsag**.

10. Klik på **Luk**.

## <a id="search-and-replace" />Søg og erstat

Du kan bruge handlingen **Søg og erstat** til at finde en bestemt tekst i et felt og erstatte den.

1. Vælg **Søg og erstat** i kolonne **Handling**.
2. Indtast den tekst, der skal erstattes, i feltet **Søg**.
3. Indtast erstatningsteksten i feltet **Erstat med**.
4. Valgfrit: Klik på **Alternativer**, og vælg indstillinger for, om du vil skelne mellem store og små bogstaver og søge efter hele ord eller dele af ord.

## <a id="regex" />Regulære udtryk

Du kan bruge handlingen **Regex** til at anvende regulære udtryk til at opdatere et felt.

1. Vælg **Regex** i kolonnen **Handling**.
2. Indtast udtrykket i feltet **Udtryk**.
3. Indtast erstatningsteksten i feltet **Erstat med**.
4. Valgfrit: Klik på **Alternativer**, og vælg indstillinger for det regulære udtryk.

## Eksempler

## Opdatering af firmakategorier

Du vil kategorisere kunderne efter salgsbeløb. Opret firmakategorier med betegnelserne "Kunde A", "Kunde B" og "Kunde C" i SuperOffice CRM. For "Kunde A" kan du oprette et udvalg af firmaer, som havde et salgsbeløb på over EUR 50.000 sidste år. Brug **Masseredigering** til at opdatere kategorien for disse kunder til "Kunde A". Gentag denne proces for de andre firmaer.

## Opdatering af postnummer og by for firmaer

Postnumre og postbyer i Norge er ændret. Brug **Masseredigering** til at opdatere adresserne.

## Opdater person

Du har opdaget, at feltet **Stilling** for personer sjældent anvendes. For at komme i gang med at udfylde dette felt for alle personer, vil du gerne finde alle de personer, der har direktør i titlen. Opret et udvalg af alle personer, der indeholder ordet "direktør" i feltet **Titel**. Brug **Masseredigering** til at opdatere feltet **Stilling** med indholdet **Ledelse**.

## Opdatering af projekt

Du vil rydde op i alle de "gamle" projekter, som ikke er angivet som fuldførte. Opret et udvalg af alle de gamle projekter, for eksempel alle projekter, der går mere end 2 år tilbage i tiden, og som ikke er blevet opdateret gennem det sidste år. Brug **Masseredigering** til at opdatere status **Fuldført** for disse projekter med indholdet **Ja**.

<!-- Referenced links -->
[1]: ../../search-options/learn/using-fastsearcher.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-selected.png
[img2]: ../../../media/icons/btn-unselected.png
