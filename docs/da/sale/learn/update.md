---
uid: help-da-sale-update
title: Opdater et salg
description: Sådan opdaterer du et salg i SuperOffice CRM. Lær, hvordan du redigerer et salg, ændrer fase (herunder markering som udsat, solgt eller tabt) eller sletter et salg, der ikke længere er relevant.
keywords: opdater salg, rediger salg, slet salg, udsat, tabt, solgt, salg
author: SuperOffice RnD
date: 03.07.2025
version: 10.5.2
topic: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Opdater et salg

Du kan opdatere oplysninger om et eksisterende salg, ændre fasen (herunder markering som udsat, solgt eller tabt) eller slette et salg, der ikke længere er relevant.

## Rediger salg

1. Åbn skærmbilledet **Salg** for det salg, du vil opdatere. Se [Brug skærmbilledet Find][5].

1. Klik på <i class="ph ph-pencil-simple" aria-hidden="true"></i> øverst til højre på salgskortet for at aktivere redigeringstilstand.

1. Foretag de nødvendige ændringer. Du kan skifte mellem faner, mens du er i redigeringstilstand.

    * **Felterne Samlet kostpris, Fortjeneste og Procent:** Hvis du ændrer én værdi, opdateres de andre automatisk for at sikre konsistens.

    * **Ændring af fase:** Opdatering af fasen justerer automatisk feltet **Sandsynlighed**. Du kan stadig ændre denne værdi manuelt, hvis nødvendigt. Hvis salgstypen er tilknyttet en [salgsguide][1], markeres tidligere faser som fuldførte med et flueben.

    > [!CAUTION]
    > Hvis du skifter **salgstype**, der er tilknyttet en salgsguide, fjernes guiden. Aktiviteter og dokumenter forbliver i detaljekortet **Aktiviteter** og vil blive tilknyttet igen, hvis du vender tilbage til den oprindelige salgstype.

1. Klik på **Gem** for at gemme ændringerne, eller klik på **Afbryd** for at fortryde dem. Begge handlinger afslutter redigeringstilstand.

    > [!NOTE]
    > Hvis knappen **Gem** er nedtonet, skal du sikre dig, at alle obligatoriske felter er udfyldt.

## <a id="stalled"></a>Markér et salg som udsat

Brug denne status, når f.eks. en kunde udskyder købsbeslutningen til en senere dato, f.eks. næste år.

1. Markér afkrydsningsfeltet **Udsat** i skærmbilledet **Salg**.

1. Udfyld følgende felter:
    * **Genåbningsdato:** Datoen for, hvornår salget bør tages op igen.
    * **Årsag (udsat):** En forklaring på, hvorfor salget ikke kan fortsætte lige nu.

    ![Udsat salg -screenshot][img1]

1. Klik på **Gem**. Dialogboksen **Opfølging** åbnes, så du kan planlægge et fremtidigt møde eller opkald for at følge op på salget.

> [!NOTE]
> Felterne **Genåbningsdato** og **Årsag (udsat)** erstatter feltet **Næste aktivitet**.

## Markér et salg som solgt

1. I rullemenuen **Fase** skal du vælge **Solgt**.

1. Opdater feltet **Dato** (standard er dags dato) til den faktiske lukkedato, hvis den er anderledes.

1. Vælg **Årsag** til, hvorfor salget blev gennemført.

    ![Solgt salg -screenshot][img2]

1. Justér salgets **Beløb**, og opdater eventuelt de økonomiske detaljer i fanen **Detaljer**.

1. Klik på **Gem**.

## Markér et salg som tabt

1. I rullemenuen **Fase** skal du vælge **Tabt**.

1. Vælg **Årsag** til, hvorfor salget gik tabt.

    ![Tabt salg -screenshot][img3]

1. Opdater andre relevante felter, hvis nødvendigt.

1. Klik på **Gem**.

Hvis salget er markeret som **Solgt** eller **Tabt**, kan du markere afkrydsningsfeltet **Fuldført**.

## <a id="delete"></a>Slet et salg

1. Åbn skærmbilledet **Salg** for det salg, du vil slette.

1. Klik på **Opgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) øverst til højre på salgskortet, og vælg **Slet**.

1. I dialogboksen **Slet salg** skal du gennemgå salgsoplysningerne for at sikre, at du sletter det korrekte salg. **Dette kan ikke fortrydes.**

    > [!NOTE]
    > Hvis muligheden **Slet** ikke er tilgængelig, har du muligvis ikke de nødvendige rettigheder til at slette salget. Du kan ikke slette salg, der tilhører andre, medmindre du har de relevante tilladelser.

1. Klik på **Ja** for at bekræfte sletningen.

## Relateret indhold

* [Opret et salg][2]
* [Salgsguider][1]
* [Forklaring af felterne][3]

<!-- Referenced links -->
[1]: sales-guides.md
[2]: create.md
[3]: create.md#fields
[5]: ../../search-options/learn/find-screen.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/stalled-sale.png
[img2]: ../../../media/loc/en/sale/won-sale.png
[img3]: ../../../media/loc/en/sale/lost-sale.png
