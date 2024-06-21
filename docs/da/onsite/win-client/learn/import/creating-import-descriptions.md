---
uid: help-da-creating-import-descriptions
title: Oprettelse af importbeskrivelser
description: Oprettelse af importbeskrivelser
author: SuperOffice RnD
date: 06.29.2022
keywords: Indstillinger for Windows-klient
topic: help
language: da
client: win
envir: onsite
---

# Oprettelse af importbeskrivelser

> [!NOTE]
> Hvis du allerede har uploadet importfilen og konfigureret alle felter og indstillinger, skal du klikke på **Gem**. Hvis du klikker på **Ny**, fjernes alle indstillinger, du har foretaget for importfilen.

1. [!include[How to open import](includes/open-import.md)]

2. Klik på knappen **Ny** øverst til højre i skærmbilledet. Skærmbilledet **Importér** åbnes.

3. Angiv en datafil i feltet **Importfil** .

4. Under **Felttilknytning** skal du angive, hvilket felt i importfilen der skal knyttes til hvilket felt i SuperOffice-databasen. (Se [Felttilknytning][1].)

5. Under **Importindstillinger** kan du vælge mellem følgende indstillinger:

    * **Filen har overskriftsrække**: Markér her, hvis filen begynder med en overskriftsrække (en række, der ikke indeholder data).
    * **Tilføj ukendte forekomster på liste**: Markér her, hvis du ønsker, at ukendte forekomster skal medtages i eksisterende lister i SuperOffice-databasen. Hvis denne indstilling ikke er markeret, importeres den ukendte forekomst ikke, og det relevante felt i SuperOffice-databasen efterlades tomt.
    * **Tilføj som medlemmer i nyt udvalg**: Markér her, hvis du importerer firma- eller persondatatypen og ønsker, at de firmaer/personer, du importerer, skal medtages i et separat udvalg. I dette tilfælde skal du også angive et navn til udvalget i feltet **Navn**.

    > [!NOTE]
    > Hvis du vælger **Tilføj som medlemmer i nyt udvalg**, føjes firmaer og personer, der er inkluderet i importen, til et nyt udvalg, med det navn, du har angivet. Firmaer og personer, der ikke medtages (hvis du har valgt **Udelad post** i dialogboksen **Håndter dubletter**), føjes ikke til udvalget, selvom de findes i importfilen.

6. Hvis du vil angive mere [avancerede indstillinger for importen][2], skal du klikke på knappen **Avanceret**.

7. Under **Dublethåndtering** angiver du regler for at tage højde for eksistensen af [dubletter][3]. Det vil sige, hvis den samme post findes i både den fil, du importerer, og den database, du importerer til.

8. Når du har angivet de nødvendige indstillinger, skal du klikke på **Gem**.

    > [!NOTE]
    > Du kan udføre en import uden at klikke på knappen **Gem** men dine ændringer gemmes derefter ikke til senere brug.

9. Skriv navnet på den nye fil i dialogboksen, vælg den mappe, du vil gemme den i, og klik på **Gem**.

> [!NOTE]
> Du kan også oprette en ny importbeskrivelse ved at [ændre en eksisterende beskrivelse][4] og gemme den med et nyt navn.

<!-- Referenced links -->
[1]: field-mapping.md
[2]: specifying-advanced-import-settings.md
[3]: duplicates-import.md
[4]: editing-import-descriptions.md

<!-- Referenced images -->
