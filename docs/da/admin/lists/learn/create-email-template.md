---
uid: help-da-mail-link-create-template
title: Oprettelse af e-mailskabeloner
description: Oprettelse af e-mailskabeloner
author: SuperOffice RnD
so.date: 06.29.2022
keywords: E-mail-link
so.topic: howto
so.user: admin
language: da
---

# Oprettelse af e-mailskabeloner

Du kan oprette dine egne skabeloner til oprettelse af e-mails i SuperOffice CRM. Følg disse trin:

1. Opret en ny mail ved hjælp af f.eks. Outlook Express. Hvis du bruger standarddokumentskabelonvariabler, skal du omslutte dem med parenteser som disse: `{name}`.

2. Gem filen i formatet *.oft*, men indstil filtypenavnet til at være *.somail*. For eksempel *my-mail.somail*.

3. Flyt filen til mappen *\\so_arc\\template*.

4. Åbn Indstillinger og vedligeholdelse.

5. Åbn skærmbilledet **Lister**.

6. Vælg fanen **Forekomster**.

7. [!include[Click arrow and select](includes/expand-list.md)] **Dokumentskabelon** fra rullemenuen **Liste**.

8. Klik på knappen **Tilføj** ![icon][img2] under listen **Forekomster**.

9. Indtast i dialogboksen navnet på skabelonen i det påkrævede felt **Navn**.

10. I feltet **Filnavn** klikker du på pilen ![icon][img1] og vælger den *.somail*-fil, som du lige har oprettet.

11. I feltet **Retning** klikker du på pilen ![icon][img1] og vælger **Udgående** på rullelisten.

12. I feltet **Posttype** klikker du på pilen ![icon][img1] og vælger **E-mail**.

13. I feltet **Dokument-plug-in** vælger du det program, der skal anvendes til at vise dokumentet, ved at klikke på pilen ![icon][img1] og vælge på rullelisten.

14. I feltet **Hensigt** klikker du på pilen ![icon][img1], hvorefter du vælger en af de foruddefinerede indstillinger på rullelisten. Disse forekomster bruges i forbindelse med statusovervågning i SuperOffice CRM (kræver SAINT-licens).

15. Marker feltet **Udgiv** for i skærmbilledet Dokument at lade en bruger vælge, at den aktuelle dokumentskabelon skal være tilgængelig for eksterne brugere.

16. Angiv standardindstillingen for feltet **Vores reference (standard)** ved at anvende skabelonvariabler, eksempelvis {auth}{auth} for afsenderens for- og efternavne.

17. I feltet **Gem i database** vælger du **Nej**.

18. I feltet **Nøgle til åbning af registreringsdatabase** indtaster du *SoMailParser.exe*.

19. Som alternativ kan du indtaste en beskrivelse af e-mailskabelonen i feltet **Beskrivelse**.

20. Klik på **OK**. Skabelonen bliver nu tilføjet som en særlig forekomst på listen **Forekomster**.

21. Klik på **Gem**.

Du kan nu oprette nye e-mails i SuperOffice CRM med denne skabelon.

<!-- Referenced images -->
[img1]: ../../../../../common/icons/dropdown-arrow.png
[img2]: ../../../../media/icons/btn-add.png
