---
uid: help-sv-reply-template-language
title: Skapa ny språkversion av svarsmall
description: Skapa ny språkversion av svarsmall
keywords: översätt svarsmall, ny språkversion, svarsmall
author: SuperOffice Product and Engineering
date: 02.25.2025
version: 10.5.2
content_type: howto
category: service
topic: knowledge base
license: serviceessentials
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: sv
redirect_from: /sv/request/reply-templates/learn/new-language
---

# Skapa ny språkversion av svarsmall

Det kan vara lämpligt att ha samma svarsmall tillgänglig på flera språk, t.ex. om du måste skicka samma svar till kunder i flera länder.

## Lägg till språk i svarsmall

1. Gå till <i class="ph ph-list" aria-label="Main menu"></i> i det övre fältet och välj **Kunskapsbas** > **Svarsmallar**.

2. Gå till mappen där svarsmallen ligger.

3. Klicka på svarsmallen. Du kommer då till skärmen **Visa svarsmallar**.

4. Klicka på **Redigera svarsmall**. Du kommer då till skärmen **Egenskaper för svarsmall**.

5. Klicka på knappen **Ny språkversion** längst ned på skärmen. En ny flik med namnet **(Ospecificerat språk)** läggs till.

6. **Språk**: I denna lista väljer du språk för den aktuella språkversionen av svarsmallen. Listrutan innehåller registrerade [kundspråk][2].

7. Skriv texterna på det aktuella språket på de andra flikarna och gör de ändringar som behövs i denna språkversion av svarsmallen. Du kan läsa mer om detta i [Skapa svarsmallar][1].

8. Klicka på **OK**. Ändringarna sparas. Fliken **(Ospecificerat språk)** ändras till det valda språket.

> [!TIP]
> Klicka på **Ta bort vald språkversion** om du vill ta bort den aktiva språkversionen (den valda språkfliken).

## Felsökning

### Varför syns inte knappen "Ny språkversion" i sidfoten?

Om knappen **Ny språkversion** inte är synlig betyder det att inga kundspråk för närvarande är definierade i systemet. För att lösa detta behöver en administratör [lägga till kundspråk][3] i **Inställningar och underhåll** under **Alternativ** > **Kundspråk**.

### Varför är ett specifikt språk inte tillgängligt i listan?

Om ett specifikt språk saknas i rullgardinsmenyn **Språk** har det inte lagts till i listan över kundspråk. Be din administratör att lägga till det saknade språket i **Inställningar och underhåll**.

<!-- Referenced links -->
[1]: create.md
[2]: ../../../localization/learn/customer-languages.md
[3]: ../../../localization/admin/add-customer-language.md
