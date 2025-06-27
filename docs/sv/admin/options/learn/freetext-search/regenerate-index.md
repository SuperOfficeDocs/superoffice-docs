---
uid: help-sv-freetext-index-regen
title: Återskapa ett fritextindex
description: Återskapa ett fritextindex
author: Bergfrid Dias
date: 03.24.2023
keywords: fritext, sökindex
content_type: howto
language: sv
envir: onsite
---

# Återskapa ett fritextindex (lokalt)

> [!NOTE]
> Den här fliken är endast tillgänglig om du har en lokal SuperOffice-installation. Om du använder onlinelösningen kan du inte göra några ändringar i dessa inställningar. För SuperOffice Online genereras fritextindexet som standard var sjunde dag.

När du [lägger till eller tar bort nya stoppord][1] gäller ändringarna inte retroaktivt. Det innebär att om du registrerar till exempel *och* som stoppord och redan har många förekomster av *och* i databasen, tas de förekomsterna inte automatiskt bort från fritextindexet. Ändringarna tillämpas bara på de förekomster av *och* som tillkommer efter att stoppordet har lagts till. Därför kan det vara aktuellt att uppdatera fritextindexet ibland, så att alla stoppord tas bort.

## Så här återskapar du fritextindexet

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Kontrollera att [fritextsökning är aktiverad][4].

1. Klicka på knappen **Återskapa fritextindex**.

1. Du får ett meddelande om att det kan ta lång tid att återskapa indexet och att användarna inte kommer åt fritextsökning under tiden. Klicka på **OK**. Nu visas ett fönster med förloppsstatus för genereringen. När fönstret försvinner är det nya fritextindexet klart.

> [!NOTE]
> För att kunna återskapa fritextindexet måste du ha en roll med **Behörighet 0** (eller motsvarande). I Oracle-databaser måste vara inloggad som databasägare.

<!-- Referenced links -->
[1]: stopwords.md
[4]: enable.md

<!-- Referenced images -->
