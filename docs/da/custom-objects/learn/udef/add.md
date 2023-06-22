---
uid: help-da-udef-add
title: Tilføjelse af felter
description: Tilføjelse af felter
author: SuperOffice RnD
so.date: 02.23.2023
keywords: udef, brugerdefineret, tilpasset felt
so.topic: howto
so.user: admin
so.user.tooltip: Settings and maintenance
language: da
---

# Tilføj brugerdefinerede felter

Se denne video for at finde ud af, hvordan du kan oprette dine egne ekstrafelter i SuperOffice CRM (videolængde - 2:51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Trin

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Klik på knappen **Tilføj** under listen **Felter**.

1. Skriv det ønskede navn i feltet **Navn**.

1. På rullelisten **Type** vælger du den [felttype][6], du gerne vil tilføje (f.eks. tal, tekst eller dato).

1. Angiv den værdi, der som standard skal indsættes i dette felt, i feltet  **Standardværdi**.

1. I feltet **Værktøjstip** skal du skrive en kort beskrivelse, der skal vises, når musemarkøren holdes over feltet. Dette kan være en beskrivelse med oplysninger til de brugere, der skal bruge dette felt.

1. Feltet **Prog-id** indeholder et standard-id for dette felt. Prog-id'et kan tilsidesættes af vores partnere for bedre forbindelse med partnerapplikationer. I stedet for at ændre deres kode kan de skrive et mere logisk navn eller et specifikt id til et brugerdefineret felt (UDEF).

1. Markér **Obligatorisk,** hvis det skal være obligatorisk at udfylde dette felt.

    > [!NOTE]
    > Dette gælder ikke for felttypen **Afkrydsningsfelt.**

1. Markér **Skjul etiket**, hvis navnet på feltet ikke skal vises.

1. Markér **Skrivebeskyttet**, hvis du ikke ønsker, at det skal være muligt at ændre feltet.

    > [!NOTE]
    > Du kan ikke markere **Skrivebeskyttet**, hvis du har markeret **Obligatorisk**. Disse muligheder udelukker hinanden.

1. Markér **Indekseret**, hvis du ønsker, at det skal være muligt at søge efter dette felt.

1. Når du har angivet de nødvendige indstillinger, skal du klikke på **Gem**. Dialogboksen lukkes, og det nye felt vises på listen **Felter** og i gitteret.

    > [!TIP]
    > Nederst til højre i dialogboksen **Felter** er **navnet på skabelonvariablen** efterfulgt af en kode (ID), som kan bruges til at genbruge de oplysninger, du indtaster i dette felt, f.eks. som [skabelonvariabler][2] i dokumenter og mails.

1. [Juster feltets placering][3].

1. Klik på **Udgiv**, hvis feltet skal være tilgængeligt for SuperOffice CRM-brugere. Ikonet ![Ikke-publicerede][img1] felter og felter med ikonet ![for ikke-publicerede ændringer ][img2]vises med fed tekst på listen **Felter** .

## Hvorfor er det en god ide at indeksere?

Hvis du vælger **Indekseret,** bliver det hurtigere at søge på disse felter ved hjælp af **Søg**. Der kan også søges i ikke-indekserede felter, men søgningen tager længere tid. Du bør kun indeksere felter, der ofte søges i, og som indeholder ofte anvendte data.

## Fejlfinding

### Jeg kan ikke oprette et nyt felt

Hvis du finder ud af, at du ikke har tilladelse til at oprette et nyt felt, kan det skyldes, at du allerede har nået det [maksimale antal tilladte felter][1] af denne type. Du skal derefter slette et eksisterende felt, før du kan indsætte et nyt.

Fire af hver felttype (kort tekst, lang tekst, tal, decimal) er søgbare. Hvis du f.eks. ikke markerer nogen felter, der kan søges i, kan du kun angive seks decimalfelter.

## Relaterede emner

* [Placering af felter][3]
* [Redigering af felter][4]
* [Redigering af TAB-rækkefølgen på felter][5]
* [Maksimalt antal felter][1]
* [Skærmdesigner][7]

<!-- Referenced links -->
[1]: limitations.md
[2]: ../../../document/learn/template-variables.md
[3]: move.md
[4]: edit.md
[5]: change-tab-order.md
[6]: index.md#field-types
[7]: ../../../ui/screen-designer/learn/index.md

<!-- Referenced links -->
[img1]: ../../../../media/icons/admin/fields-unpublish-new.png
[img2]: ../../../../media/icons/admin/fields-unpublish-changed.png
