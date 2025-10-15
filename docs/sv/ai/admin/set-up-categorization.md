---
uid: help-sv-ai-categorization-setup
title: Konfigurera AI-baserad kategorisering
description: Hur du tränar och konfigurerar kategorisering i SuperOffice AI
keywords: AI, kategorisering, maskininlärning, träning
author: digitaldiina
date: 10.15.2025
version: 11.5
content_type: howto
license: aiplatform, categorization
category: automation
topic: ai
deployment: online
platform: web
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
index: true
redirect_from: /sv/ai/admin/index
---

# Konfigurera AI-baserad kategorisering

Kategorisering använder maskininlärning för att föreslå kategorier för inkommande ärenden baserat på deras innehåll. Innan denna funktion kan användas måste AI tränas med ett urval av befintliga ärenden.

> [!NOTE]
> Kategorisering kräver SuperOffice AI Platform och en **Categorization-licens**. SuperOffice AI är endast tillgängligt för CRM Online.

## 1. Skapa ett urval av ärenden

Du måste först skapa ett urval av ärenden i SuperOffice för att träna AI-modellen.

1. Klicka på <i class="ph ph-list-magnifying-glass" aria-label="Sök ikon"></i> **Sök** eller gå till **Ny** > **Urval**.

    ![Nya urvalsalternativ i Sales-klienten -screenshot][img1]

1. Välj **Ärende** som urvalstyp. Använd **Sök ärende** eller välj från **Typiska sökningar**.

    ![Typiska sökningar för ärendeurval -screenshot][img2]

1. Definiera sökkriterier:
    1. Lägg till filter för att matcha de ärenden du vill använda för träning.
    2. Klicka på **Sök**.

    ![Kriterier för ärendeurval -screenshot][img3]

1. Spara urvalet:
    1. Klicka på **Spara som urval**.
    2. Välj statiskt eller dynamiskt.
    3. Ange ett namn och klicka på **Spara**.

    ![Välj urvalstyp -screenshot][img4]
    ![Ange urvalsnamn -screenshot][img5]

> [!NOTE]
> Endast de första 5000 ärendena i urvalet kommer att analyseras.

## 2. Välj urvalet i Inställningar och underhåll

1. Öppna **Inställningar och underhåll**.
1. Välj **AI-tjänster** från navigatorn.
1. Under **Kategorisering** öppnar du rullgardinsmenyn och söker efter urvalsnamnet.
1. Välj korrekt ärendeurval.

    ![Välj ärendeurval i AI-tjänster -screenshot][img6]

## 3. Analysera ärendeurvalet

När ett giltigt urval har valts blir knappen **Analysera ärenden** aktiv.

> [!NOTE]
> Stora datamängder kan ta timmar eller till och med dagar att analysera.

1. Klicka på **Analysera ärenden** för att starta träningsprocessen.
1. När träningen är klar visar statusen **Senaste träning** *modell tränad framgångsrikt*.
1. Om fel uppstår, granska meddelandet och skapa ett nytt urval vid behov.

    ![Träningsresultat och återkoppling -screenshot][img7]
    ![Exempel på träningssammanfattning -screenshot][img8]

## 4. Aktivera förslag

Efter framgångsrik träning:

1. Markera kryssrutan **Använd AI för att föreslå kategorier** för att aktivera funktionen.

    ![Kryssruta för att aktivera AI-förslag -screenshot][img9]

## 5. Resultat: kategoriförslag i ärenden

När aktiverat kommer användare att se en föreslagen kategori i ärendefoten. Genom att klicka på länken tillämpas kategorin på ärendet och förslaget tas bort.

Om det inte finns någon träff visas inget förslag.

## Träna om eller ändra urval

Du kan analysera ett nytt eller uppdaterat urval när som helst:

1. Gå till **Inställningar och underhåll** > **AI-tjänster**.
1. Under **Kategorisering** väljer du ett nytt urval.
1. Klicka på **Analysera ärenden** för att träna igen.

## Relaterat innehåll

* [Hur du skapar ett urval][1]
* [Ärendekategorisering][2]
* [Andra AI-tjänster][3]

<!-- Referenced links -->
[1]: ../../search-options/selection/learn/create.md
[2]: ../learn/categorization.md
[3]: ../learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/choose-new-selection.png
[img2]: ../../../media/loc/en/search-options/typical-request-searches.png
[img3]: ../../../media/loc/en/ai/find-request-search-criteria.png
[img4]: ../../../media/loc/en/ai/select-selection-type-dialog.png
[img5]: ../../../media/loc/en/ai/name-selection-input.png
[img6]: ../../../media/loc/en/ai/select-category-menu.png
[img7]: ../../../media/loc/en/ai/categorization-analysis.png
[img8]: ../../../media/loc/en/ai/categorization-summary.png
[img9]: ../../../media/loc/en/ai/use-ai-suggested-categories-checkbox.png
