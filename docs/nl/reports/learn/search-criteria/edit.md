---
uid: help-nl-report-search-criteria-edit
title: Zoekcriteria bewerken in rapporten
description: Zoekcriteria bewerken in rapporten
author: SuperOffice RnD
so.date: 07.04.2022
keywords: rapport
so.topic: howto
language: nl
---

# Zoekcriteria bewerken in rapporten

U kunt de zoekcriteria in favoriete rapporten bewerken. Standaardrapporten kunnen niet worden bewerkt, u kunt de zoekcriteria echter wel aanpassen en een standaardrapport opslaan als uw eigen [favoriete rapporten][1].

1. [!include[How to-goto-reports](../includes/goto-reports.md)]

1. Selecteer een tabblad. De rapporten worden weergegeven in de rapportenlijst.

    > [!NOTE]
    > het is niet raadzaam rapporten uit te voeren zonder zoekcriteria op te geven, aangezien u dan erg grote rapporten krijgt en de verwerking zeer veel tijd in beslag neemt.

1. Selecteer in de lijst het gewenste rapport.

1. Dubbelklik in de criterialijst op het criterium dat u wilt bewerken.

1. Het dialoogvenster **Zoekcriteria toevoegen/bewerken** wordt weergegeven.

1. [Bewerk de betreffende gegevens in.][2]

    > [!NOTE]
    > De criteria waaruit u kunt kiezen, variëren afhankelijk van het tabblad en het rapport dat u hebt geselecteerd.

1. Klik op **OK** onder in het dialoogvenster **Zoekcriteria toevoegen/bewerken** wanneer u klaar bent.

## Voorbeeld

We gaan nu de criteria in een verkooprapport aanpassen:

1. Selecteer het tabblad **Verkoop**. In de rapportlijst wordt een lijst met standaardrapporten voor het geselecteerde tabblad weergegeven.
1. **Selecteer het standaardrapport**Omzetrapport – Werkelijke omzet. In het tekstveld wordt een beschrijving van het rapport weergegeven. De criterialijst eronder bevat de criteria voor het geselecteerde rapport.

Nu gaan we de criteria voor dit standaardrapport enigszins wijzigen, zodat u kunt zien hoe u criteria kunt aanpassen aan uw behoeften. We gaan het standaardrapport wijzigen, zodat alle werkelijke verkopen van de vorige maand worden weergegeven die *niet* de status **Open** hebben.

1. Dubbelklik de **Verkoop: Datum** in de criterialijst. Het dialoogvenster **Zoekcriteria toevoegen/bewerken** wordt weergegeven.

    ![Zoekcriteria toevoegen/bewerken -screenshot][img3]

1. Klik op de pijl naast het veld **Deze maand**, wijzig de periode in **Vorige maand** en klik op **OK**. Uw rapport bevat nu alleen verkopen van de vorige maand.

1. Select the **Sale: Eigenaar** in de criterialijst en klik op de knop **Verwijderen** onderaan op het sectietabblad. Het rapport bevat nu alle verkopen, dus niet alleen verkopen waarvoor de huidige gebruiker (uzelf) is geregistreerd als eigenaar.

1. Dubbelklik op **Verkoop: Status** in de criterialijst. Het dialoogvenster **Zoekcriteria toevoegen/bewerken** wordt weergegeven. Nu gaan we het criterium **Verkoop: Status** wijzigen, zodat het rapport alleen verkopen bevat die niet de status **Open** hebben.

    ![Zoekcriteria toevoegen/bewerken -screenshot][img4]

1. Klik op de pijl naast het veld **Is een van** en wijzig de waarde in **Is niet een van**.

1. Selecteer in de kolom **Geselecteerde waarden** de optie **Verkocht** en klik op ![het pictogram][img2]. Het criterium wordt verplaatst naar de uiterst linkerkolom.

1. Selecteer in de uiterst linkerkolom **Openen** en klik op ![het pictogram][img1]. Het criterium is verplaatst naar de kolom **Geselecteerde waarden**. Het rapport bevat nu verkopen die niet de status **Open** hebben.

1. Klik op **OK**.

<!-- Referenced links -->
[1]: ../favorites/add.md
[2]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/arrow-left.png
[img3]: ../../../../media/loc/en/reports/edit-criteria.bmp
[img4]: ../../../../media/loc/en/reports/edit-criteria-2.bmp
