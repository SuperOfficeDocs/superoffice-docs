---
uid: help-da-dashboard-tile-sales-targets
title: Brug af salgsmål i ruder
description: Brug dashboards og ruder til at sammenligne dine salgsmål med dit faktiske salg.
keywords: dashboard, salgsmål, diagram
author: SuperOffice Product and Engineering
date: 11.21.2025
version: 11.6
content_type: howto
license: salespremium
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Brug af mål i ruder

Når [salgsmål][4] er opsat for dit firma, teams eller individuelle brugere, kan du tilføje disse mål til dashboard-ruder. Dette giver dig mulighed for at sammenligne faktisk salg med mål direkte i visuelle diagrammer som målere, søjlediagrammer og store tal.

For at lære hvordan dashboards og udvalg kan hjælpe dig med at overvåge og forudsige salg, se [Forudsig dit salg][8].

![Vælg fanen Layout, og vælg Sammenlign med mål i sektionen Gruppering -screenshot][img1]

## Tilføj rude med salgsmål til et dashboard

1. Åbn skærmbilledet **Dashboard**.

2. Vælg det dashboard, du vil redigere.

3. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> og vælg **Rediger dashboardfelter**. I højre side af det valgte dashboard vises sektionen **Rediger dashboardfelter** .

4. Vælg **Salg** på listen**Vis ruder for**.

5. Vælg et af følgende diagrammer på fanen **Bibliotek** :

    * <i class="ph ph-number-square-three" aria-hidden="true"></i> - Stort nummer
    * <i class="ph ph-chart-bar-horizontal" aria-hidden="true"></i> - Søjlediagram
    * <i class="ph ph-chart-bar" aria-hidden="true"></i> - Kolonnediagram
    * <i class="ph ph-gauge" aria-hidden="true"></i> - Målediagram
    * Tom salgsrude

    > [!TIP]
    > Du kan også vælge en tom rude for at [oprette en rude fra bunden][6], men diagramtypen skal være en af dem, der er anført ovenfor.

6. Hvis du vil føje en rude til dashboardet, skal du trække og slippe den på den ønskede position på dashboardet. Du kan også klikke på **Tilføj** for at føje en rude til næste tilgængelige position. Ruden tilpasses automatisk efter den tilgængelige plads og justeres med gitter- og kolonneopsætningen.

7. Juster ruderne på dashboardet:

    * Hold musemarkøren over en rude, og klik og træk rammen for at justere rudens størrelse. Tilgængelige slots/mellemrum på dashboardet vil blive fremhævet med gult, når ruden kan passe ind i placeringen.

    * Klik på overskriften i en rude, og træk den til en anden position.

8. Klik på ikonet **Rediger rude** (<i class="ph ph-pencil" aria-hidden="true"></i>) på den nye rude.

9. På fanen **Datasæt** skal du indstille **Salgsdato** til dette år, kvartal eller måned. Rediger de andre [kriterier][2] efter behov. Husk at opdatere rudens navn for at afspejle eventuelle ændringer, der er foretaget her.

10. Rediger layoutet under fanen **Layout**:

    * **Diagramtype**: Du kan ændre dette til en hvilken som helst diagramtype, der er anført i trin 5.
    * **Mål**: Vælg **Total** eller **Antal.** Dette kan f.eks. være summen af alle salg eller det samlede antal (tal) af alle salg.
    * **Af**: Hvis du valgte **Antal**, skal du vælge **Salgs-id** på denne liste. Hvis du valgte **Total**, skal du vælge**Beløb** eller **Vægtet beløb**.
    * **Efter**: Vælg **Salg &gt; Ejer** (ejer, fuldt navn eller gruppe) eller **Salg &gt; Salgsdato** . Denne indstilling er kun relevant for søjlediagrammer og kolonnediagrammer.
    * **Gruppering**eller **Sidefod**: Vælg **Sammenlign med mål**.
      * Hvis denne indstilling ikke er synlig eller er inaktiv, skal du dobbelttjekke, om du har udført ovenstående trin. Hvis du ikke kan se indstillingen **Sammenlign med mål** (den er deaktiveret), kan du holde musemarkøren over teksten. Dette viser et værktøjstip, der forklarer, hvad du skal ændre for at aktivere og vælge indstillingen.
    * **Destination**: Vælg det mål, du vil føje til ruden. (Ikke relevant for søjlediagrammer).
    * **Vis som %**: Vælg denne indstilling for at få vist målprocentdelen i stedet for totaler eller antal. (Denne indstilling er ikke relevant for kolonnediagrammer og store tal).

11. Rediger formateringen. Afhængigt af hvilken diagramtype du har valgt, har du yderligere muligheder under **Formatering**:

    * Stort antal: Du kan redigere de farver, der bruges til at vise mål.
    * Målediagram: Brug indstillingen **Markér mål på** for at indstille målet på målediagrammet.

12. Klik på <i class="ph ph-translate" aria-label="Translate"></i> to [for at tilføje][3] en oversættelse til rudens navn, titler og etiketter.

13. Klik på **Gem**. Klik derefter på **Udført**.

## Hvorfor kan jeg ikke vælge Sammenlign med mål?

Hvis du ser feltet Sammenlign med mål, men det er deaktiveret, kan du holde musen over feltet for at se et værktøjstip, der forklarer, hvad du skal ændre for at aktivere og vælge feltet.

Er Sammenlign med mål slet ikke synlig, skal du kontrollere, at du har valgt den korrekte diagramtype, og at du har brugt salgsdatoen som kriterier under fanen Datasæt.

## Relateret indhold

* [Tilføj et nyt dashboard][5]
* [Rediger eller opret felter][6]
* [Ruder med leads og UTM-data][9]
* [Opsæt salgsmål][7]
* [Forudsig dit salg][8]

<!-- Referenced links -->
[2]: ../../search-options/learn/search-criteria.md
[3]: ../../localization/learn/translate-fields.md
[4]: ../../sale/learn/sales-targets/index.md
[5]: create.md
[6]: working-with-tiles.md
[7]: ../../sale/learn/sales-targets/create.md
[8]: ../../sale/learn/forecasting.md
[9]: show-leads.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/team-forecast-vs-target.png
