---
uid: help-da-screen-designer-fields
title: Arbejde med felter
description: Sådan tilføjer, flytter og sletter du felter i et layout ved hjælp af Skærmdesigneren i Indstillinger og vedligeholdelse.
keywords: Skærmdesigner, layout, felt, feltindstilling
author: Bergfrid Dias
date: 10.07.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Arbejde med felter

[!include[Krav](../../../../../common/includes/req-dev-tools.md)]

Etiketter og felter repræsenterer de væsentlige indholdselementer på en skærm. Uanset om du opretter et nyt layout eller ændrer et eksisterende, skal du starte med at klikke på **Rediger layout**. [Vis mig de detaljerede trin.][1] Når du er færdig, skal du **gemme eller udgive** layoutet.

> [!TIP]
> Du vil måske [tilføje eller fjerne faner][2], før du finjusterer felterne.

![Skjermdesigner, firmakort, standard feltlayout -screenshot][img1]

Listen over felter på en hvilken som helst skærm indeholder alle standardfelter fra SuperOffice for det pågældende område samt alle brugerdefinerede felter (både brugerskabte og ekstra).

## <a id="add"></a>Tilføj felt

Ethvert felt kan vises flere steder, hvis det er relevant.

1. Vælg den fane, hvor du vil tilføje feltet.
2. Sørg for, at sektionen **Felter** er valgt.
3. Find det ønskede felt i listen.

    > [!TIP]
    > Brug filterfunktionen til at finde specifikke felter.

4. Træk feltet fra listen til et område med stiplede linjer i den valgte fane.

    ![Bokse med stiplede linjer -screenshot][img6]

    For at gøre et felt synligt på alle faner skal du placere feltet i headeren eller footeren af hovedkortet.

## <a id="settings"></a>Rediger feltindstillinger

Rediger feltformateringen (såsom skriftstørrelse) for at forbedre synligheden.

1. Vælg den fane, der indeholder feltet.
1. Klik på feltet i forhåndsvisningen.
1. Rediger feltformateringen i sektionen **Indstillinger**. De tilgængelige indstillinger afhænger af den valgte felttype.

    * Vælg **Fedt** eller *Kursiv* for at ændre skriftstil
    * Skift mellem venstre- og højrejusterede værdier
    * Vælg mellem lille, normal og stor skrift

For eksempel på formatering, se skærmbilledet i sektionen om [tilføjelse af overskrift eller skillelinje][3].

## <a id="move"></a>Flyt felt

Tilføj eller flyt vigtige brugerdefinerede felter til hovedfanen (den venstre fane) for nem adgang. Flyt mindre vigtige felter til sekundære faner som et alternativ til at fjerne dem.

**Trin:**

1. Vælg fanen, der indeholder feltet.
2. Klik på **=** til venstre for feltets etiket, og træk feltet til en ny position.

    > [!TIP]
    > For at flytte et felt til en anden fane skal du trække det til den nye fane, vente på at forhåndsvisningen opdateres, og derefter slippe feltet i et område med stiplede linjer på den nye fane.

## <a id="delete"></a>Fjern (skjul) felt

For at reducere rod skal du skjule felter, der aldrig bruges. Fjernede felter påvirker kun det, der vises i brugergrænsefladen, og ændrer ikke database- eller tabelværdier.

* For at fjerne et felt skal du holde markøren over feltet og klikke på den røde omkransede x-en.

* For at gendanne feltet skal du blot [tilføje feltet igen](#add).

> [!NOTE]
> Obligatoriske felter kan ikke slettes. Du kan dog flytte et obligatorisk felt til en anden fane.

## Relateret indhold

* [Rediger antallet af kolonner under en fane][4]
* [Tilføj etiketter og skilleelementer][3]
* [Tilføj links og knapper][5]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: working-with-tabs.md
[3]: working-with-tabs.md#label
[4]: working-with-tabs.md#columns
[5]: add-button.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/edit-card-layout-fields.png
[img6]: ../../../../media/loc/en/ui/screendesigner-field-place.png
