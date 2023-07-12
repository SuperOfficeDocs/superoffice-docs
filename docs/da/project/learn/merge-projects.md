---
uid: help-da-project-merge
title: Flet projekter
description: Sådan sammenfletter du et projekt i SuperOffice
author: SuperOffice RnD
so.date: 07.04.2022
keywords: projekt
so.topic: howto
language: da
---

# Flet projekter

Hvis du har to projekter, som er næsten ens, er det nu muligt at lægge dem sammen, inklusive projektdeltagere og aktiviteter. Kildeprojektet vil blive slettet.

1. Gå til det projekt, som du vil flette ind i et andet projekt. Se [Brug skærmbilledet Søg][1].

2. Klik på ![ikon][img1] **Opgave** på kortet **Projekt**, og vælg **Slå projekter sammen**.

3. I dialogboksen **Sammenflet projekter** under **Til** vælger du det projekt, som du vil lægge sammen med det eksisterende projekt. Begynd at skrive i feltet for at søge efter et projekt.

    ![Dialogboksen Slå projekter sammen -screenshot][img2]

    > [!TIP]
    > Du kan bytte om på projekterne **Fra** og **Til** ved at klikke på ![ikon][img3].

4. Markér alternativet **Overskriv tomme felter i \[target project\] med data fra \[source project\]**, hvis du vil opdatere tomme felter i målprojektet med detaljer fra kildeprojektet.

    [!include[Preview results](../../learn/includes/note-preview-results.md)]

5. Klik på **Slå sammen**. Følgende sker:
    * Projekterne slås sammen.
    * Detaljer bliver lagt sammen (hvis angivet).
    * Projektdeltagere flyttes eller slås sammen.
    * Eventuelle tilknyttede salg flyttes.
    * Alle aktiviteter flyttes.
        Hvis du sammenlægger et projekt, som er tilknyttet en projektguide, med et projekt, som har en anden projektguide eller ikke har nogen projektguide, fjernes projektguiden fra kildeprojektet. Alle oprettede opfølgninger og dokumenter flyttes imidlertid over til det nye projekt og vises på detaljekortet **Aktiviteter**.
    * Eventuel tidligere udgivelse af kilde- og målprojektet deaktiveres.
    * Kildeprojektet slettes.

## Relaterede emner

* [Redigering af projekter][3]
* [Flet kontakter][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[2]: ../../company/learn/merge-companies.md
[3]: edit.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img3]: ../../../../common/icons/info-ball.png
[img2]: ../../../media/loc/en/project/merge-project.bmp
