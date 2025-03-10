---
uid: help-da-bulk-update
title: Masseopdatering
description: Opdater flere poster samtidigt i SuperOffice CRM.
keywords: masseopdatering, masseredigering, bulk update
author: SuperOffice RnD
date: 03.07.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Opdater flere poster (masseopdatering)

Masseopdatering giver dig mulighed for at ændre værdier på tværs af flere poster af samme type. Du kan bruge masseopdatering på alle eller udvalgte poster i detaljekort, udvalg og skærmbilledet **Søg**. Denne funktion kan også bruges til at slette flere poster på én gang.

## Trin

1. Åbn udvalget, detaljekortet (arkiv) eller søgeresultaterne (skærmbilledet **Søg**), der indeholder poster, som du vil opdatere.

2. Klik på **Opgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) og vælg **Masseopdatering**.
    Eller, marker de poster, du vil opdatere, højreklik på dem, og vælg **Masseredigering ...**

    Dialogboksen **Masseredigering** åbnes. Nederst i denne dialogboks kan du se typen post og hvor mange poster, der skal opdateres. Eksempel: Antal personer i kø til masseredigering: 7.

    > [!NOTE]
    > Hvis udvalget indeholder både firmaer og personer, vil der være to faner: **Firma** og **Person**.

3. Vælg et felt, der skal ændres, i kolonnen **Felt**. Du kan også indtaste navnet i feltet. Når du skriver hvert bogstav, viser listen nedenfor alle forekomster, der er relevante for de valgte poster.

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

6. Marker (<i class="ph ph-check" aria-hidden="true"></i>) de felter, du vil opdatere, og fjern markeringen for de felter, der ikke skal opdateres.

7. Klik på **Opdater**. Dialogboksen **Bekræft** åbnes, og der vises en liste over opdateringerne.

8. Klik på **Ja** at implementere ændringerne i de valgte poster.

   > [!CAUTION]
   > Når en opdatering er gennemført, kan den ikke fortrydes. Du kan dog stoppe opdateringen, mens den er i gang. Eventuelle resterende poster vil ikke blive opdateret.

9. Klik på **LOG** for at vise ændringsloggen. Hvis nogle poster ikke blev opdateret, er årsagen angivet i kolonnen **Årsag**.

10. Klik på **Luk**.

## <a id="search-and-replace"></a>Søg og erstat

Du kan bruge handlingen **Søg og erstat** til at finde en bestemt tekst i et felt og erstatte den.

1. Vælg **Søg og erstat** i kolonne **Handling**.
2. Indtast den tekst, der skal erstattes, i feltet **Søg**.
3. Indtast erstatningsteksten i feltet **Erstat med**.
4. Valgfrit: Klik på **Alternativer**, og vælg indstillinger for, om du vil skelne mellem store og små bogstaver og søge efter hele ord eller dele af ord.

## <a id="regex"></a>Regulære udtryk

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
