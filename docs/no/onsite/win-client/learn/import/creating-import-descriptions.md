---
uid: help-no-creating-import-descriptions
title: Opprette importbeskrivelser
description: Opprette importbeskrivelser
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger for Windows-klient
topic: help
language: no
client: win
envir: onsite
---

# Opprette importbeskrivelser

> [!NOTE]
> Hvis du allerede har lastet opp importfilen og konfigurert alle feltene og innstillingene, klikker du på **Lagre**. Hvis du klikker på **Ny**, FJERNES alle innstillingene du anga for importfilen.

1. [!include[How to open import](includes/open-import.md)]

2. Klikk på **Ny**-knappen øverst til høyre i bildet. **Importer**-bildet tømmes for informasjon.

3. Angi en datafil i feltet **Importfil**.

4. Under **Felttilordning** angir du hvilke felt i importfilen som skal tilordnes hvilket felt i SuperOffice-databasen. (Se [Felttilordning][1].)

5. Under **Importinnstillinger** har du følgende muligheter:

    * **Fil har overskriftsrad**: Merk av her hvis filen begynner med en overskriftsrad (en rad som ikke inneholder faktiske data).
    * **Legg til ukjente forekomster på lister**: Merk av her hvis du vil at eventuelle ukjente forekomster skal inkluderes på eksisterende lister i SuperOffice-databasen. Hvis du ikke merker av, importeres ikke den ukjente forekomsten, og det aktuelle feltet i SuperOffice-databasen blir stående tomt.
    * **Legg til som medlemmer i nytt utvalg**: Merk av her hvis du importerer datatypen firma eller person og vil at firmaene/personene du importerer, skal inkluderes i et eget utvalg. I så fall må du også angi et navn på utvalget i feltet **Navn**.

    > [!NOTE]
    >Hvis du velger **Legg til som medlemmer i nytt utvalg**, vil firmaer og eventuelle personer som berøres av importen, bli lagt til i et nytt utvalg, som har det navnet du har angitt. Firmaer og personer som ikke blir berørt (hvis du har valgt **Hopp over** i dialogboksen **Håndter duplikater**), blir ikke lagt til i utvalget selv om de finnes i importfilen.

6. Hvis du vil angi [mer avanserte innstillinger for importen][2], kan du klikke på **Avansert**-knappen.

7. Under **Duplikathåndtering** angir du regler for hva som skal skje hvis det oppdages [duplikater][3]. Det vil si at samme post forekommer både i filen du importerer, og i databasen du importerer til.

8. Når du har angitt de nødvendige systemvalgene, klikker du på **Lagre**.

    > [!NOTE]
    > Du kan utføre en import uten å klikke på **Lagre**-knappen, men da lagres ikke endringene dine til senere bruk.

9. I dialogboksen skriver du inn et navn for den nye filen, velger hvilken mappe du vil lagre den i, og klikker på **Lagre**.

> [!NOTE]
> Du kan også opprette en ny importbeskrivelse ved å [endre en eksisterende beskrivelse][4] og lagre den med et nytt navn.

<!-- Referenced links -->
[1]: field-mapping.md
[2]: specifying-advanced-import-settings.md
[3]: duplicates-import.md
[4]: editing-import-descriptions.md

<!-- Referenced images -->
