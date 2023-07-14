---
uid: help-sv-request-next-in-queue
title: Hämta nästa ärende i kön
description: Hämta nästa ärende i kön
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: ärende
so.topic: howto
so.audience: person
so.audience.tooltip: SuperOffice Service
language: sv
---

# Så här konfigurerar du Hämta nästa ärende i kön

I SuperOffice tilldelas ärenden normalt till användare enligt en tilldelningsmetod. En annan metod att tilldela ärenden till ärendehandläggare är att placera nya ärenden i **Ärendehantering** > **Otilldelade ärenden**. Då måste ärendehanterarna acceptera ärendena manuellt.

Men det går också att skapa ett intelligent kösystem för hantering av nya ärenden. Ärendehandläggare kan då klicka på **Hämta nästa ärende i kön** under **Ärendehantering** för att acceptera nästa ärende i kön. Ärendena i kön filtreras efter [kategori][2], så att användare endast tilldelas ärenden i de kategorier som de är medlemmar i.

## Hur prioriteras ärendena i kön?

Sekvensen för ärendena i kön bestäms av tidsfristen för varje individuellt ärende. Ärenden med den närmaste tidsfristen kommer först i kön. Tidsfristen beräknas utifrån definierade prioriteter för kontakt, företag, postlåda, e-postfilter och standardprioritet.

Detta säkerställer att ärenden prioriteras i en logisk och rättvis ordning.

> [!NOTE]
> Det går också att använda en kombination av kösystem och tilldelningsmetod. Ärenden kan t.ex. placeras i kön eller tilldelas till användare baserat på vilken kategori ärendena tillhör.

## Vilka ärenden kan hämtas från kön?

Följande faktorer avgör vilka ärenden en ärendehandläggare kan få från kön:

* Ärendena måste ha en ärendestatus med **Köstatus** aktiverad.
* Ärendena måste ha en kategori som ärendehandläggare§n är medlem i.
* Ärendets ägare måste vara **Otilldelad**.

## Skapa en ny ärendestatus, "I kö"

Först skapar vi en ny ärendestatus: **I kö**. Nya ärenden ska tilldelas denna ärendestatus automatiskt.

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Välj **Ärendehantering** > **Ärendestatus**.

1. Klicka på knappen **Lägg till**.

1. I fältet **Namn** anger du ett beskrivande namn på ärendestatusen. T.ex. "I kö".

1. I listrutan **Intern status**, välj **Aktivt**.

1. Markera **Standard** så att alla nya ärenden (aktiva ärenden) tilldelas denna status som standard.

1. Markera **Köstatus**. Användarna kan nu hämta ärenden med denna status från kön.

    > [!NOTE]
    > Det betyder inte att dessa ärenden MÅSTE hämtas från kön. Vi använder kategorier för att avgöra vilka ärenden som ska placeras i kön och vilka ärenden som ska distribueras enligt tilldelningsmetoden för kategorin.

1. Du behöver inte markera **Skapa nytt ärende vid kundsvar**.

1. I listan **Spåra tid som**, välj **I kö**.

1. Klicka på **Spara**.

Den nya ärendestatusen visas i listan och en kryssmarkering finns i kolumnerna **Standard** och **Köstatus**.

## Använda kategorier för att placera ärenden i kön

Du måste nu säkerställa att du är medlem i den kategori eller de kategorier som du ska hantera. Vi måste också specificera att ärenden som tillhör dessa kategorier inte ska tilldelas enligt tilldelningsmetoden.

> [!NOTE]
> Medlemskap i kategorier kan också definieras på gruppnivå. I Inställningar och underhåll (**Användare** > **Användargrupper**) kan du ange kategorier för de olika användargrupperna.

**Steg:**

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Välj **Ärenden** > **Kategorier**.

1. Klicka på önskat kategorinamn. Du kommer då till skärmen **Egenskaper för kategori**.

1. Välj fliken **Medlemmar**.

1. Välj dig själv i listan **Användare** och klicka på ![ikon][img1] för att lägga till dig själ som en medlem i kategorin.

1. Du kan även lägga till andra användare som medlemmar i kategorin.

1. Välj fliken **Tilldelningsmetod** och välj **Tilldela inte**. Nu kommer ärenden i denna kategori inte att tilldelas till användare i enlighet med tilldelningsmetoden.

1. Klicka på **Spara**.

Upprepa vid behov denna procedur för andra kategorier som ska finnas tillgängliga för hämtning från kön. Kategorier som följer en tilldelningsmetod tilldelas en användare och kommer därför inte med i kön.

## Definiera ny status för ärenden som hämtas från kön

När du har hämtat ett ärende från kön måste statusen ändras från **I kö** till **Aktivt** (eller någon annan aktiv status som anger att ärendet håller på att handläggas). Detta sköts normalt automatiskt.

## Kontrollera att kön fungerar

Skapa ett nytt ärende, sätt **Ägare** på **Otilldelat**, välj den kategori som du är medlem i och sätt **Status** på **I kö**. Testa sedan att klicka på **Ärendehantering** > **Hämta nästa ärende i kön**.

<!-- Referenced links -->
[2]: category/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-add.png
