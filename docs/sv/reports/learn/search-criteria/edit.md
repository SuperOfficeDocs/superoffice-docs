---
uid: help-sv-report-search-criteria-edit
title: Redigera sökkriterier i rapporter
description: Redigera sökkriterier i rapporter
author: SuperOffice RnD
so.date: 07.04.2022
keywords: rapport
so.topic: howto
language: sv
---

# Redigera sökkriterier i rapporter

Du kan redigera sökkriterier i favoritrapporter. Standardrapporter kan inte redigeras, men du kan anpassa sökkriterierna i dem och spara dem som dina egna [favoritrapporter][1].

1. [!include[How to-goto-reports](../includes/goto-reports.md)]

1. Välj en flik. Rapporterna visas i rapportlistan.

    > [!NOTE]
    > Det rekommenderas inte att du kör rapporter utan att ange sökkriterier, eftersom det kan generera extremt stora rapporter och resultera i tidskrävande bearbetning.

1. Välj önskad rapport i listan.

1. Dubbelklicka på det kriterium som du vill redigera i kriterielistan.

1. Dialogrutan **Lägg till/redigera kriterier** öppnas.

1. [Redigera önskad information][2].

    > [!NOTE]
    > Vilka kriterier du kan välja mellan varierar beroende på vilken flik och rapport du har valt.

1. Klicka på **OK** längst ned i dialogrutan **Lägg till/redigera sökkriterier** när du är klar.

## Exempel

Vi ska nu se hur du justerar kriterierna i en försäljningsrapport:

1. Klicka på fliken **Försäljning**. I rapportlistan visas en lista med standardrapporter för den flik du valde.
1. Välj standardrapporten **Försäljningsrapport – Faktisk försäljning**. Textfältet visar en beskrivning av rapporten och kriterielistan under visar kriterierna för den standardrapport som du har valt.

Nu ska vi ändra standardrapportkriterierna något, så att du kan se hur du ändrar dem för att de ska matcha dina behov. Vi ska ändra standardrapporten så att den visar all faktisk försäljning från föregående månad som *inte* har statusen **Öppen**.

1. Dubbelklicka på **Försäljning: Datumkriterium** i kriterielistan. Dialogrutan **Lägg till/redigera kriterier** öppnas.

    ![Lägg till/redigera kriterier -screenshot][img3]

1. Klicka på pilen bredvid fältet **Innevarande månad**, ändra perioden till **Föregående månad** och klicka på **OK**. Din rapport innehåller nu bara försäljning från föregående månad.

1. Välj **Försäljning: Ägarkriterium** i kriterielistan och klicka på knappen **Ta bort** längst ned. Din rapport kommer nu att innehålla all försäljning, och inte bara försäljning där användaren i fråga (du) är registrerad som ägare.

1. Dubbelklicka **Försäljning: Status** i kriterielistan. Dialogrutan **Lägg till/redigera kriterier** öppnas. Nu ska vi ändra **Försäljning: Statuskriterium** så att rapporten endast innehåller försäljning som inte har statusen **Öppen**.

    ![Lägg till/redigera kriterier -screenshot][img4]

1. Klicka på pilen bredvid **Är en av** och ändra värdet till **Är inte en av**.

1. I kolumnen **Valda värden**, välj **Sålt** och klicka på ![ikon][img2]. Kriteriet flyttas till kolumnen längst till vänster.

1. Välj **Öppen** och klicka på ![ikon][img1] i kolumnen längst till vänster. Kriteriet flyttas till kolumnen **Valda värden**. Rapporten kommer nu att innehålla försäljning som inte har statusen **Öppen**.

1. Klicka på **OK**.

<!-- Referenced links -->
[1]: ../favorites/add.md
[2]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/arrow-left.png
[img3]: ../../../../media/loc/en/reports/edit-criteria.png
[img4]: ../../../../media/loc/en/reports/edit-criteria-2.png
