---
uid: help-no-importing-files
title: Importere filer
description: Importere filer
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger for Windows-klient
topic: help
language: no
client: win
envir: onsite
---

# Importere en datafil til SuperOffice-databasen

Når du har tatt sikkerhetskopi av databasefilen, funnet riktig datafil og plassert den i en mappe der du lett finner den igjen (se [Importrutiner][1]), kan du sette i gang selve importen.

> [!NOTE]
> Enkelte programmer "låser" åpne filer, slik at andre programmer ikke kan bruke dem. Før du starter importen, må du passe på at verken importbeskrivelsesfilen eller datafilen er åpen i et annet program (for eksempel Excel).

**Trinn:**

<!-- markdownlint-disable-file MD029 -->

1. [!include[How to open import](includes/open-import.md)]

[!include[Import description](includes/step-import-description.md)]
<!-- Include covers steps 2-3. Next line MUST be 4. -->

4. Når du har valgt importbeskrivelse, og importfilen er funnet, fylles de andre feltene automatisk ut. Du kan eventuelt [redigere detaljene i importbeskrivelsen][3].

5. Det kan være lurt å sjekke at innholdet i feltene kommer riktig i forhold til feltene du har valgt. Kolonnen **Felt i fil** under **Felttilordning** viser innholdet i den første posten i datafilen du importerer, mens kolonnen **Felt i SuperOffice CRM** viser hvilke felt i SuperOffice-databasen disse opplysningene importeres til. Klikk gjerne på **Neste**-knappen noen ganger for å kontrollere innholdet i noen av de neste postene også.

    > [!NOTE]
    >Hvis feltene ikke vises slik du ønsker, må du enten endre [felttilordningen][4] eller gjøre nødvendige endringer i importfilen.

6. Klikk på **Start** for å sette i gang importen. Det vises en statusindikator nederst i bildet.

> [!NOTE]
> Hvor lang tid det tar å importere dataene fra importfilen til SuperOffice-databasen, er avhengig av størrelsen på databasen og dataforbindelsen (treg eller rask forbindelse til databaseserveren). Du kan imidlertid når som helst avbryte importen ved å klikke på **Stopp**-knappen til høyre for statusindikatoren.

<!-- Referenced links -->
[1]: import-routines.md
[3]: editing-import-descriptions.md
[4]: field-mapping.md

<!-- Referenced images -->
