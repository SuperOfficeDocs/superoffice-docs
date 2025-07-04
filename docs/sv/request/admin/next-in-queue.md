---
uid: help-sv-request-next-in-queue
title: Hämta nästa ärende i kön
description: Hämta nästa ärende i kön
keywords: hämta nästa ärende i kön, ärende, kösystem, tilldelningsmetod, tilldela inte, otilldelad, köstatus
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice Service
language: sv
redirect_from: /sv/request/learn/next-in-queue
index: true
---

# Så här konfigurerar du Hämta nästa ärende i kön

I SuperOffice tilldelas ärenden normalt till användare enligt en tilldelningsmetod. En annan metod för att tilldela ärenden till ärendehandläggare är att placera nya ärenden i **Ärenden** > **Otilldelade ärenden**, där ärendehandläggarna manuellt accepterar ärendena.

Det är också möjligt att skapa ett intelligent kösystem för att hantera nya ärenden. Ärendehandläggare kan då klicka på **Hämta nästa ärende i kön** under **Ärenden** för att acceptera nästa ärende i kön. Ärendena i kön filtreras efter [kategori][2], så att användare endast tilldelas ärenden inom de kategorier de är medlemmar i.

## Hur prioriteras ärendena i kön?

Sekvensen för ärendena i kön bestäms av tidsfristen för varje individuellt ärende. Ärenden med den närmaste tidsfristen kommer först i kön. Tidsfristen beräknas utifrån definierade prioriteter för kontakt, företag, e-postlåda, e-postfilter och standardprioritet.

Detta säkerställer att ärenden prioriteras i en logisk och rättvis ordning.

> [!NOTE]
> Det går också att använda en kombination av kösystem och tilldelningsmetod. Ärenden kan t.ex. placeras i kön eller tilldelas till användare baserat på vilken kategori ärendena tillhör.

## Vilka ärenden kan hämtas från kön?

Följande faktorer avgör vilka ärenden en ärendehandläggare kan få från kön:

* Ärendena måste ha en ärendestatus med **Köstatus** aktiverad.
* Ärendena måste ha en kategori som ärendehandläggaren är medlem i.
* Ärendets ägare måste vara **Otilldelad**.

## Skapa en ny ärendestatus, "I kö"

Först skapar vi en ny ärendestatus: **I kö**. Nya ärenden ska automatiskt tilldelas denna ärendestatus.

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Välj **Ärenden** > **Ärendestatus**.

1. Klicka på **Lägg till**.

1. I fältet **Namn** anger du ett beskrivande namn för ärendestatusen, till exempel "I kö".

1. I listrutan **Intern status**, välj **Aktivt**.

1. Markera **Standard**, så att alla nya ärenden (aktiva ärenden) som standard tilldelas denna status.

1. Markera **Köstatus**. Användarna kan nu hämta ärenden med denna status från kön.

    > [!NOTE]
    > Detta innebär inte att dessa ärenden MÅSTE hämtas från kön. Vi använder kategorier för att avgöra vilka ärenden som ska placeras i kön och vilka som ska distribueras enligt tilldelningsmetoden för kategorin.

1. Du behöver inte markera **Skapa nytt ärende vid kundsvar**.

1. I listan **Spåra tid som**, välj **I kö**.

1. Klicka på **Spara**.

Den nya ärendestatusen visas nu i listan och en kryssmarkering finns i kolumnerna **Standard** och **Köstatus**.

## Använd kategorier för att placera ärenden i kön

Nu måste du säkerställa att du är medlem i den kategori eller de kategorier du ska hantera. Vi måste även specificera att ärenden som tillhör dessa kategorier inte ska tilldelas enligt tilldelningsmetoden.

> [!NOTE]
> Medlemskap i kategorier kan också definieras på gruppnivå. I Inställningar och underhåll (**Användare** > **Användargrupper**) kan du ange kategorier för de olika användargrupperna.

**Steg:**

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Välj **Ärenden** > **Kategorier**.

1. Klicka på önskat kategorinamn. Du kommer nu till skärmen **Egenskaper för kategori**.

1. Välj fliken **Medlemmar**.

1. Välj dig själv i listan **Användare** och klicka på **+** för att lägga till dig själv som medlem i kategorin.

1. Lägg till eventuella andra användare som medlemmar i denna kategori.

1. Välj fliken **Tilldelningsmetod** och välj **Tilldela inte**. Nu kommer ärenden i denna kategori inte att tilldelas till användare enligt tilldelningsmetoden.

1. Klicka på **Spara**.

Upprepa vid behov denna procedur för andra kategorier som ska kunna hämtas från kön. Kategorier som följer en tilldelningsmetod tilldelas en användare och kommer därför inte att hamna i kön.

## Definiera ny status för ärenden som hämtas från kön

När du har hämtat ett ärende från kön måste statusen ändras från **I kö** till **Aktivt** (eller någon annan aktiv status som visar att ärendet håller på att behandlas). Detta hanteras normalt automatiskt.

## Kontrollera att kön fungerar

Skapa ett nytt ärende, sätt **Ägare** till **Otilldelad**, välj en kategori som du är medlem i och sätt **Status** till **I kö**. Testa sedan att klicka på **Ärenden** > **Hämta nästa ärende i kön**.

<!-- Referenced links -->
[2]: category/index.md
