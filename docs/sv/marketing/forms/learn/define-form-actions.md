---
uid: help-sv-form-actions
title: Definer formuläråtgärder
description: Definer formuläråtgärder
keywords: formulär, automatisera, formuläråtgärd, formulärinlämning
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Definera formuläråtgärder

Att manuellt hantera 200 anmälningar till evenemanget tar tid och är onödigt. Automatiserade formuläråtgärder kan effektivisera denna process.

Automatisering sparar tid som annars skulle användas för att hantera svar. När en person skickar in formuläret utför systemet åtgärderna åt dig!

![Definera skjemahandlinger -screenshot][img17]

## Tilgjengelige åtgärder

### Meddela inlämningar genom att skapa ärenden

Välj detta alternativ om du vill [skapa ett ärende][8] för varje formulär som lämnas in. Ange en rubrik och välj kategori och prioritet för ärendet.

Inlämnade formulär är tillgängliga i fönstren **Ärenden** och i detaljkortet **Ärende** i fönstren Företag och Kontakt i SuperOffice CRM.

### Hur ska en formulärinlämning bearbetas?

Här kan du ange om det inlämnade formuläret ska behandlas automatiskt.

* **Bearbeta alla inlämningar automatiskt. Skapa en ny kontakt om ingen matchning hittas**: Alla formulärinlämningar bearbetas automatiskt. Det kommer inga meddelanden om inskickade formulär.

* **Manuellt om avsändaren är okänd. Automatiskt om avsändaren är känd**: Om e-postadressen som skickas i formuläret matchar en e-postadress i SuperOffice behandlas formulärinlämningen automatiskt. Annars måste den bearbetas manuellt. Du får ett meddelande.

* **Manuellt för alla inlämningar**: Du får ett meddelande för varje inskickat formulär. Om du vill bearbeta formulärinlämningar manuellt går du till.

![ikon][img11] [Bearbeta formulärinlämningar][6]

### What should happen when the form is processed?

Här kan du välja åtgärder som ska utföras när ett formulär bearbetas (automatiskt eller manuellt).

* **Lägg till kontakt i urval**: Om du valt automatisk behandling ovan lägger du till en markering här som håller koll på kontakter som lagts till via det här formuläret. Det gör det också lättare att ta bort irrelevanta kontakter (och företag).

* **Lägg till kontakt i projekt**: Välj ett projekt. Kontakter som lämnar in det här formuläret läggs till i projektet.

* **Lägg till intressen för kontakt**: Välj ett intresse. Intresset läggs till i kontakter som lämnar in det här formuläret.

* **E-postsvar**: Välj ett formulärsvar som du vill skicka till kontakter när deras formulär behandlas. [Så här skapar du ett formulärsvar][7].

* **Skapa ärende**: Om du lagt till ett ärendefält i kategorin **Fält** måste du också välja en standardkategori och prioritet för de ärenden som skapas från det här formuläret. Inlämnade formulär är tillgängliga under **Ärenden** i SuperOffice Service och i detaljkortet **Ärende** i fönstren Företag och Kontakt i SuperOffice CRM.

* **Kör CRMScript**: Välj ett [CRMScript][9] eller makro som ska köras när ett formulärsvar behandlas.

* **Standardkategori** / **Standardföretag**: Välj en standardkategori och ett företag för alla kontakter eller företag som har lagts till i SuperOffice baserat på inskickade formulär. Med det här alternativet kan du gruppera inskickade formulär och nya kontakter/företag till en specifik kategori och/eller företag.

    Om du till exempel har ett formulär för potentiella kunder, väljer du potentiella kunder som din kategori. Därefter kan du enkelt skapa urval baserat på denna kategori och/eller företag.

> [!NOTE]
> När du uppdaterar ett formulär, kom ihåg att det kan användas av flera kampanjer och/eller automatiserade flöden. Se till att det inte finns några duplicerade eller motstridiga åtgärder.

## Relaterat innehåll

* [Publicera formulär][2]

<!-- Referenced links -->
[2]: publish.md
[6]: process-submissions.md
[7]: ../../mailing/learn/create/tutorial-form-mailing.md
[8]: ../../../request/learn/create.md
[9]: ../../../../en/automation/crmscript/howto/marketing/forms.md

<!-- Referenced images -->
[img11]: ../../../../media/loc/en/marketing/form-notification.png
[img17]: ../../../../media/loc/en/marketing/contact-me-form-actions.png
