---
uid: help-da-screen-designer-add-layout
title: Tilføj layout
description: Sådan tilføjes et nyt layout for en brugergruppe.
keywords: Skærmdesigner, layout, udseende, layout, skærmlayout, hovedkort
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføj layout

[!include[Krav](../../../../../common/includes/req-dev-tools.md)]

Uanset om du tilføjer en personlig visning for en valgt brugergruppe eller designer et layout optimeret til specifikke projekt-, salgs-, sag- og opfølgningstyper eller dokumentskabeloner, skal du starte med at tilføje et nyt layout til en skærm i Skærmdesigneren.

Med tilpassede skærmlayouts til hvert af dine teams vil det blive nemmere end nogensinde at finde kundedata. De mest relevante data vil altid være tilgængelige og synlige. Fjern, flyt eller skjul irrelevante eller mindre vigtige data for at rydde op på skærmene. Tilføj tilpassede arkiver med de mest relevante data for dine teams. Resultatet bliver en renere og mere ryddelig skærm for dine teams at arbejde i.

Se denne video og find ud af, hvordan du tilføjer et nyt layout, eller følg trin-for-trin-guiden nedenunder (videoen starter ved 5:37):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU?t=337]

## Opret nyt layout

1. Åbn Skærmdesigneren (i **Indstillinger og vedligeholdelse**).

1. Vælg en skærm eller dialog øverst for at tilpasse.

1. Vælg **Hovedkort**.

    For at oprette et layout til et arkiv, se [Arbejde med detaljekort][2].

1. [Vælg tildelingsmetode][6] (hvis ikke indstillet): klik på teksten ved siden af **Tildel layout til**, og vælg gruppe, type, eller skabelon.

1. Klik på **Tilføj** under **Layouts**.

    ![Klik på Tilføj for at oprette et nyt layout -screenshot][img1]

1. I dialogboksen **Tilføj nyt layout** skal du vælge et layout fra listen **Opret nyt baseret på**.

1. Indtast et navn og en beskrivelse for det nye layout.

    ![Angiv det korrekte navn og de brugergrupper, der skal bruge dette layout -screenshot][img2]

1. Klik på feltet **Tildel til**, og tildel det nye layout til en eller flere brugergrupper **eller** salgs-/projekt-/sags-/opfølgningstyper **eller** dokumentskabeloner.

    > [!NOTE]
    > Kun grupper/typer/skabeloner, der i øjeblikket bruger standardlayoutet, vises.

1. Klik på **OK**.

    Det nye layout føjes til listen **Layouts** med status Kladde, hvilket betyder, at det endnu ikke er synligt for brugerne. Forhåndsvisningen vises i højre side af skærmen.

## Tilpas det nye skærmlayout

1. Vælg det nye layout i listen **Layouts**, og klik på knappen **Rediger layout**.

2. Gå gennem fanerne i layoutet.

    * [Tilføj, rediger, flyt eller fjern et felt][1]
    * [Tilføj kobling eller knap][5]
    * [Tilføj, fjern eller gendan en fane][3]
    * [Tilføj eller fjern et detaljekort (arkiv)][2]

3. Når du er færdig, skal du gemme eller udgive layoutet.

## Relateret indhold

* [Hvordan konfigurerer jeg, hvilke oplysninger brugerne i vores firma kan få adgang til i SuperOffice CRM?][15]
* [Hvordan opretter jeg en ny brugergruppe i SuperOffice CRM?][16]
* [Slet layout][4]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: working-with-archives.md
[3]: working-with-tabs.md
[4]: edit-layout.md#delete
[5]: add-button.md
[6]: assign-layout.md
[15]: ../../../admin/user-management/learn/role/index.md
[16]: ../../../admin/user-management/learn/user-groups.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/add-button-for-new-screen-layout.png
[img2]: ../../../../media/loc/en/ui/add-new-screen-layout.png
