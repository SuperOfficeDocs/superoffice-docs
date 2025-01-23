---
uid: help-no-dashboard-tile-sales-targets
title: Bruke salgsmål i figurer
description: Bruke dashbord og figurer til å sammenligne salgsmålene med det faktiske salget.
author: SuperOffice RnD
date: 12.13.2022
keywords: dashbord, salg, mål, diagram
topic: howto
language: no
---

# Bruke mål i figurer

Hvis [salgsmål][4] er definert for firmaet, team/grupper og/eller selgere, kan du legge til disse målene i dashbordfigurene dine. Du vil da få en visuell presentasjon av dine salg og salgsmål.

For å kunne visualisere målene dine i et dashbord må du først legge til eller redigere figurene i dashbordet. Når du har valgt riktig figur, kan du redigere figurenes utseende og diagramtype.

![Velg Utseende-fanen, og velg deretter Sammenlign med mål i delen Gruppering -screenshot][img7]

## Legge til figur med salgsmål i dashbordet

1. Åpne skjermbildet **Dashbord**.

2. Velg dashbordet du vil redigere.

3. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> og velg **Legg til figurer / rediger layout**. Til høyre i det valgte dashbordet vises delen **Legg til figur / rediger layout**.

4. Velg **Salg**i listen **Vis figurer for**.

5. Velg ett av følgende diagrammer i fanen **Bibliotek**:

    * <i class="ph ph-number-square-three" aria-hidden="true"></i> – enkelt tall
    * <i class="ph ph-chart-bar" aria-hidden="true"></i> – stolpediagram
    * <i class="ph ph-chart-bar" aria-hidden="true"></i> – kolonnediagram
    * <i class="ph ph-gauge" aria-hidden="true"></i> – målerdiagram
    * Tom salgsfigur

    > [!TIP]
    > Du kan også [velge en tom figur][1] for å opprette en figur fra bunnen av, men diagramtypen må være en av dem som er oppført ovenfor.

6. Hvis du vil legge til en figur på dashbordet, drar og slipper du den på ønsket posisjon på dashbordet. Du kan også klikke på **Legg til** for å legge til en figur i neste tilgjengelige posisjon. Figuren justeres automatisk til tilgjengelig plass, og justeres etter rutenett- og kolonneoppsettet.

7. Juster figurene på dashbordet:

    * Hold musepekeren over en figur, og klikk og dra rammen for å justere figurstørrelsen. Tilgjengelige spor/plasser på dashbordet merkes i gult når figuren får plass i posisjonen.

    * Klikk på overskriften på en figur, og dra den til en annen plassering.

8. I dashbordet klikker du på **Rediger figur** (<i class="ph ph-note-pencil" aria-hidden="true"></i>) på den nye figuren.

9. I **Datasett**-fanen angir du **Salgsdato** til gjeldende år, kvartal eller måned. Rediger de andre [kriteriene][2] etter behov. Husk å oppdatere figurnavnet for å gjenspeile eventuelle endringer.

10. I fanen **Utseende** redigerer du utseendet:

    * **Diagramtype**: Endre dette til en hvilken som helst diagramtype som er oppført i trinn 5.
    * **Mål**: Velg **Sum** eller **Antall**. For eksempel summen av alle salg eller totalt antall (antall) av alle salg.
    * **Av**: Hvis du valgte **Antall** over, velger du **Salgs-ID** i denne listen. Hvis du valgte **Sum**, velger du **Beløp** eller **Vektet beløp**.
    * **Etter**: Velg **Salg > Eier** (eier, fullt navn eller gruppe) eller **Salg > Salgsdato**. Dette alternativet er bare relevant for stolpediagrammer og kolonnediagrammer.
    * **Gruppering** eller **bunntekst**: Velg **Sammenlign med mål**.
      * Hvis dette alternativet ikke er synlig eller er inaktivt, må du dobbeltsjekke at du har utført trinnene ovenfor. Hvis du ikke kan velge alternativet **Sammenlign med mål** (det er deaktivert), kan du holde musepekeren over teksten. Dette viser et verktøytips som forklarer hva du må endre for å aktivere og velge alternativet.
    * **Mål**: Velg målet du vil legge til i figuren. (Ikke relevant for stolpediagrammer.)
    * **Vis i %**: Velg dette alternativet hvis du vil vise prosentandelen av målet i stedet for summer eller antall. (Ikke relevant for kolonnediagrammer og enkle tall.)

11. Rediger formateringen. Du har flere valg under **Formatering**, basert på diagramtypen du valgte:

    * Stort tall: Du kan redigere fargene som brukes til å vise mål.
    * Målediagram: Bruk alternativet **Merk mål ved** for å angi målet i målediagrammet.

12. Klikk på <i class="ph ph-translate" aria-label="Translate"></i> for å [legge til en oversettelse][3] til figurnavnet, titlene og etikettene.

13. Klikk på **Lagre**. Klikk deretter på **Ferdig**.

## Hvorfor kan jeg ikke velge Sammenlign med mål?

Hvis du ser feltet Sammenlign med mål, men det er deaktivert, kan du holde musen over feltet for å se et verktøytips som forklarer hva du må endre for å aktivere og velge feltet.

![Hold pekeren over feltet Sammenlign med mål for å vise et verktøytips -screenshot][img8]

Hvis Sammenlign med mål ikke er synlig, må du kontrollere at du har valgt riktig diagramtype, og at du har brukt Salgsdato som kriterium i fanen Datasett.

## Relatert

* [Legge til nytt dashbord][5]
* [Redigere eller opprette figurer][2]
* [Definere salgsmål][7]
* [Dashborddata][6]

<!-- Referenced links -->
[1]: edit-tile.md
[2]: ../../search-options/learn/search-criteria.md
[3]: ../../globalization-and-localization/learn/translate-fields.md
[4]: ../../sale/learn/sales-targets/index.md
[5]: create.md
[6]: working-with-tiles.md
[7]: ../../sale/learn/sales-targets/create.md

<!-- Referenced images -->
[img7]: ../../../media/loc/en/dashboard/user-dashboard-tile-comparetotarget.png
[img8]: ../../../media/loc/en/dashboard/user-dashboard-tile-disabled-comparetotarget.png
