---
uid: help-da-screen-designer-tabs
title: Arbejde med faner
description: Sådan tilføjer, organiserer, sletter og gendanner du en fane i et layout, og hvordan du organiserer informationen i logiske grupper ved hjælp af Skærmdesigneren i Indstillinger og vedligeholdelse.
keywords: Skærmdesigner, layout, fane, fanelayout, overskrift, etiket, skillelinje, A-Z, kolonne
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.7
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Arbejde med faner

[!include[Krav](../../../../../common/includes/req-dev-tools.md)]

Denne guide går ud fra, at du allerede er i gang med at [redigere layoutet][2]. De følgende afsnit forklarer, hvordan du organiserer og tilpasser faner i SuperOffice CRM, så du kan skræddersy brugergrænsefladen til din organisations behov.

## Tilføj fane

Oprettelse af brugerdefinerede faner gør det muligt for dig at gruppere relaterede felter på en måde, der giver mening for din organisation. Du kan f.eks. oprette faner dedikeret til specifikke forretningsområder, så informationer bliver lettere at finde.

**Trin:**

1. Klik på **Tilføj**. Sektionen **Fanelayout** åbnes til venstre.

2. Under Fanetitel, erstat teksten "Ny fane" med det nye fanenavn.

    Du kan også klikke på <i class="ph ph-translate" aria-label="Translate"></i> for at tilføje titel på andre sprog.

3. Vælg det antal kolonner, du vil bruge i den nye fane.

## Omdøb fane

Hvis du senere har brug for at omdøbe fanen, skal du vælge fanen og gå til **Fanelayout**. Du **kan ikke omdøbe standardfaner**.

## Fjern fane

For at forenkle grænsefladen kan du fjerne faner, der ikke længere er nødvendige. Et layout skal dog have mindst én fane. Hvis der kun er én fane tilbage, kan den ikke fjernes.

> [!NOTE]
> Hvis fanen indeholder obligatoriske felter, skal du flytte disse felter til en anden fane, før du sletter den aktuelle fane.

**Trin:**

1. Vælg fanen.
1. Klik på **Opgave** og vælg **Fjern fane**.
1. Klik på **OK** for at bekræfte og lukke dialogboksen.

## Gendan fane

Hvis du fjerner en fane og senere beslutter, at du har brug for den, kan du nemt gendanne den.

1. Åbn layoutet i redigeringstilstand.
1. Klik på **Opgave** og vælg **Gendan faner**.

> [!NOTE]
> Denne handling gendanner **alle** tidligere fjernede faner.

## <a id="label"></a>Tilføj overskrift eller skillelinje

Etiketter og skillelinjer hjælper med at organisere felter inden for en fane, hvilket gør oplysningerne mere læsbare og tilgængelige. Brug etiketter til at oprette overskrifter og skillelinjer til at adskille sektioner inden for en kolonne.

1. Vælg fanen, hvor du vil tilføje elementet.

2. Klik på sektionen **Elementer**.

3. For at tilføje en overskrift skal du trække elementet **Etiket** ind i layoutet.

    * I sektionen **Indstillinger**, erstat "Ny etiket" med den nye etiketnavn. Du kan eventuelt klikke på <i class="ph ph-translate" aria-label="Translate"></i> ved siden af etiketten for at [tilføje etiketten på andre sprog][9].
    * Juster skriften efter behov.

4. For at tilføje en vandret skillelinje, træk elementet **Skillelinje** ind i layoutet. Ændr afstandsstykketypen, hvis det er nødvendigt.

![Skærmdesigner felter og elementer -screenshot][img2]

## <a id="columns"></a>Gruppér felter i kolonner

Som standard har faner to kolonner, men du kan justere dette efter behov. Hver fane kan have 1, 2, 3 eller 4 kolonner afhængigt af, hvor mange oplysninger du vil vise.

> [!NOTE]
> Faner med specifikke funktioner, såsom **ERP** og **Bemærkning**, understøtter ikke kolonnejustering. Gå til **Indstillinger og vedligeholdelse** > **ERP** for at konfigurere indholdet af ERP-fanen.

**Trin:**

1. Vælg fanen, hvor du vil justere kolonnerne.
1. Gå til sektionen **Fanelayout**.
1. Vælg en af de fire layoutmuligheder.

Når antallet af kolonner reduceres, flyttes felterne fra de fjernede kolonner til den sidste tilbageværende kolonne. Hvis du f.eks. reducerer fra tre kolonner til to, flyttes felterne i den tredje kolonne til bunden af den anden kolonne.

Kolonner vil blive stablet lodret, når skærmen er for lille til at vise dem vandret.

Hvis du har en bred skærm, kan du bruge flere kolonner for at se flere data samtidigt. Vær dog forsigtig: Brug af fire kolonner kan reducere synligheden af nogle felter. Skjulning af etiketterne kan hjælpe med at skabe mere plads.

> [!TIP]
> Hvis en fane bliver for overfyldt, bør du overveje at tilføje ekstra faner for at organisere oplysningerne bedre.

## <a id="more"></a>Mere-fanen

**Mere**-fanen indeholder automatisk alle [tilpassede felter][3], arrangeret efter rang. Du kan konfigurere disse felter inden for denne fane og eventuelt tilføje dem til andre skærme.

[Brugerdefinerede felter][5] (udef) og [ekstra felter][4] oprettes på samme måde som før.

## Relateret indhold

* [Arbejde med felter][1]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: edit-layout.md
[3]: ../../../custom-objects/learn/index.md
[4]: ../../../custom-objects/admin/create-extra-field.md
[5]: ../../../custom-objects/admin/add-udef.md
[9]: ../../../globalization-and-localization/learn/translate-fields.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/ui/field-settings.png
